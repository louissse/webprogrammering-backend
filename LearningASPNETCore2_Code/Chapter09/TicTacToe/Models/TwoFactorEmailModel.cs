﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class TwoFactorEmailModel
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string ActionUrl { get; set; }
    }
}
