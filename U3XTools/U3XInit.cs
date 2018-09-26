
// C# System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// RocketMod for Unturned 3.X.X.X
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
    public class U3XInit : RocketPlugin<U3XConfig>
    {
        protected override void Load()
        {

        }

        protected override void Unload()
        {

        }

        public static U3XInit instance;
    }
}
