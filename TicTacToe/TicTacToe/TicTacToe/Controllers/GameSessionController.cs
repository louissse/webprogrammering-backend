using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Services;
using Microsoft.Extensions.DependencyInjection;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TicTacToe.Controllers
{
    public class GameSessionController : Controller
    {
        private IGameSessionService _gameSessionService;
        public GameSessionController(IGameSessionService gameSessionService)
        {
            _gameSessionService = gameSessionService;
        }

        public async Task<IActionResult> Index(Guid id)
        {
            var session = await _gameSessionService.GetGameSession(id);
            if (session == null)
            {
                var gameInvitationService = Request.HttpContext.RequestServices.GetService<IGameInvitationService>();
                var invitation = await gameInvitationService.Get(id);
                session = await _gameSessionService.CreateGameSession(invitation.Id, invitation.InvitedBy, invitation.EmailTo);
            }
            return View(session);
        }
    }
}
