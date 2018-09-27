using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// RocketMod for Unturned 3.X.X.X
using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;

// Unturned + UnityEngine 5
using SDG.Unturned;
using UnityEngine;

namespace U3XTools
{
    class U3XCommandHome : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "home";

        public string Help => "Teleports you to your bed";

        public string Syntax => "/home";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            // display hello world in world chat after typing /home with the caller name
            ChatManager.sendChat(EChatMode.GLOBAL, caller.DisplayName + "has called /home");
        }
    }
}
