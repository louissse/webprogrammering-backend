﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public class EmailService : IEmailService
    {
        public Task SendEmail(string emailTo, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
