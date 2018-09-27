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
using Steamworks;
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

        public List<string> Permissions => new List<string>() { "U3XTools.Home" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            // display hello world in world chat after typing /home with the caller name
            // ChatManager.sendChat(EChatMode.GLOBAL, caller.DisplayName + "has called /home");

            UnturnedChat.Say(caller.DisplayName + " has called /home");


            UnturnedPlayer player = (UnturnedPlayer) caller;
            Vector3 playerPosition;
            playerPosition.x = player.Position.x; //new Vector3();
            playerPosition.y = player.Position.y;
            playerPosition.z = player.Position.z;
            //UnturnedPlayer player = caller.to


            //BarricadeManager barricades;
            Vector3 bedPosition = new Vector3();
            byte bedAngle;
            bool hasBed;
            //byte newByte = 0;
            //byte bedRotation = 0;


            hasBed = BarricadeManager.tryGetBed(player.CSteamID, out bedPosition, out bedAngle);
            
            if(hasBed)
            {
                player.Teleport(bedPosition, bedAngle);

                UnturnedChat.Say(caller.DisplayName + " has called /home and attempted to teleport");
                UnturnedChat.Say(caller.DisplayName + " bed location:   x:" + bedPosition.x + " y:" + bedPosition.y + " z:" + bedPosition.z);
            }

            else
            {
                UnturnedChat.Say(caller.DisplayName + " has called /home with no bed");
                UnturnedChat.Say(caller.DisplayName + " current location:   x:" + playerPosition.x + " y:" + playerPosition.y + " z:" + playerPosition.z);
            }

            // This is intentionally Disatrous... will fix!
            // Get Bed Location

            // Get all Beds placed in the World?...
            //UnturnedNexus nexus = new UnturnedNexus();
            //nexus.initialize();
            //nexus.shutdown();
            // I have no clue what this is...

            //UnturnedNexus testEvent;
            //testEvent.
            


            /*
            UnturnedPlayerComponent playerC;
            UnturnedPlayer player;
            UnturnedPlayerFeatures playerF;
            UnturnedPlayerEvents playerE;
            UnturnedPlayerMovement playerM;
            */

            //player.transform.

            //if (playerM.)
            //Vector3 bedLoc = new Vector3();

        }
    }
}
