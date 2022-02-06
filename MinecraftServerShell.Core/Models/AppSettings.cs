﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftServerShell.Core.Models
{
    public class AppSettings
    {
        public string ServerDirectory { get; set; }

        public string StartupCommand { get; set; }

        public string PluginDirectory { get; set; }

        public long MaxLogLength { get; set; } = 1000;
    }
}
