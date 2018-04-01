using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Services
{
    public class GameSessionService : IGameSessionService
    {
        private IUserService _UserService;
        private static ConcurrentBag<GameSessionModel> _sessions;

        public GameSessionService(IUserService userService)
        {
            _UserService = userService;
        }

        static GameSessionService()
        {
            _sessions = new ConcurrentBag<GameSessionModel>();
        }

        public Task<GameSessionModel> GetGameSession(Guid gameSessionId)
        {
            return Task.Run(() => _sessions.FirstOrDefault(
            x => x.Id == gameSessionId));
        }

        public async Task<GameSessionModel> CreateGameSession(Guid invitationId, string invitedByEmail, string invitedPlayerEmail)
        {
            var invitedBy = await _UserService.GetUserByEmail(invitedByEmail);
            var invitedPlayer = await _UserService.GetUserByEmail(invitedPlayerEmail);
            GameSessionModel session = new GameSessionModel
            {
                User1 = invitedBy,
                User2 = invitedPlayer,
                Id = invitationId,
                ActiveUser = invitedBy
            };
            _sessions.Add(session);
            return session;
        }
    }
}
