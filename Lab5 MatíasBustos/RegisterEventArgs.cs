﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_MatíasBustos
{
    class RegisterEventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerificationLink { get; set; }
    }
}
