﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Models;
using TicTacToe.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;

namespace TicTacToe.Controllers
{
    public class GameInvitationController : Controller
    {
        private IStringLocalizer<GameInvitationController> _stringLocalizer;
        private IUserService _userService;

        public GameInvitationController(IUserService userService, IStringLocalizer<GameInvitationController> stringLocalizer)
        {
            _userService = userService;
            _stringLocalizer = stringLocalizer;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string email)
        {
            var gameInvitationModel = new GameInvitationModel
            {
                InvitedBy = email,
                Id = Guid.NewGuid()
            };
            Request.HttpContext.Session.SetString("email", email);
            var user = await _userService.GetUserByEmail(email);
            Request.HttpContext.Session.SetString("displayName", $"{user.FirstName} {user.LastName}");
            return View(gameInvitationModel);
        }
        [HttpPost]
        public IActionResult Index(GameInvitationModel gameInvitationModel, [FromServices]IEmailService emailService)
        {
            var gameInvitationService = Request.HttpContext.RequestServices.GetService<IGameInvitationService>();
            if (ModelState.IsValid)
            {
                emailService.SendEmail(gameInvitationModel.EmailTo, "Invitation for playing a Tic-Tac-Toe game",
                    string.Format($"Hello, you have been invited to play the Tic-Tac-Toe game by {0}. For joining the game, please click here {1}",
                    gameInvitationModel.InvitedBy, Url.Action("GameInvitationConfirmation", "GameInvitation",
                        new { gameInvitationModel.InvitedBy, gameInvitationModel.EmailTo }, Request.Scheme, Request.Host.ToString())));

                var invitation = gameInvitationService.Add(gameInvitationModel).Result;
                return RedirectToAction("GameInvitationConfirmation", new { id = invitation.Id });
            }
            return View(gameInvitationModel);
        }
        [HttpGet]
        public IActionResult GameInvitationConfirmation(Guid id, [FromServices]IGameInvitationService gameInvitationService)
        {
            var gameInvitation = gameInvitationService.Get(id).Result;
            return View(gameInvitation);
        }
        //    Example of localization in controller (not view) String Localizer 
        //    [HttpPost]
        //    public IActionResult Index(GameInvitationModel gameInvitationModel)
        //    {
        //        return Content(_stringLocalizer[
        //        "GameInvitationConfirmationMessage",
        //        gameInvitationModel.EmailTo]);
        //    }

        }
    }