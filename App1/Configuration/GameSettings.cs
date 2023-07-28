using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Configuration
{
    internal class GameSettings
    {
        public string Browser { get; set; }
        public string PlayerOne { get; internal set; }
        public string PlayerTwo { get; internal set; }
        public string Website { get; internal set; }
    }
}
