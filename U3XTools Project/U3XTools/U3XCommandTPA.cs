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
    class U3XCommandTPA : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "tpa";

        public string Help => "Teleports you to another player with their permission";

        public string Syntax => "/tpa <player>   /tpa [a]ccept [d]eny [b]lock [u]nblock [player]";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "U3XTools.TPA" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            // Casted /tpa
            UnturnedChat.Say(caller.DisplayName + " has called /tpa");
        }
    }
}
