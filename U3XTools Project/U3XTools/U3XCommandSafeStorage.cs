using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// RocketMod for Unturned 3.X.X.X
using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;

// Unturned + UnityEngine 5
using SDG.Unturned;
using UnityEngine;

namespace U3XTools
{
    class U3XCommandSafeStorage : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "safestorage";

        public string Help => "Safe Storage for gathered items";

        public string Syntax => "/safestorage   /ss";

        public List<string> Aliases => new List<string>() { "ss" };

        public List<string> Permissions => new List<string>() { "U3XTools.SafeStorage" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            //nteractableStorage testCoolStuff;
            //testCoolStuff.
        }
    }
}
