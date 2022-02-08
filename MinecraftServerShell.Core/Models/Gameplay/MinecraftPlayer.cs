﻿using MinecraftServerShell.Core.Managers;
using MinecraftServerShell.Core.Managers.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftServerShell.Core.Models.Gameplay
{
    public class MinecraftPlayer
    {
        public string Name { get; set; } = null!;

        public Location Location { get; set; } = null!;

        public async Task Renew()
        {
            var newData = await PlayerManager.GetPlayerAsync(Name);
            Location = newData.Location;
        }
    }
}
