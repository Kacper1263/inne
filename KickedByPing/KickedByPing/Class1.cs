using System;
using UnityEngine;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Chat;
using System.Collections.Generic;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;

namespace KickedByPing
{
    
        public class Test : IRocketCommand
        {
            

            public AllowedCaller AllowedCaller => AllowedCaller.Both;

            public string Name => "hi";

            public string Help => "10s dealy hello";

            public string Syntax => "<player>";

            public List<string> Aliases => new List<string>();

            public List<string> Permissions => new List<string>() { "myplugin.permission" };

            public void Execute(IRocketPlayer caller, string[] command)
            {
                //float x = 4.613555F;
                //int y = (int)x;
                //Rocket.Core.Logging.Logger.Log("Ping: " + y.ToString() + "ms");


                MainClass.isWaiting = true;
                //MainClass.lastCalled = DateTime.Now;
            }
        }
    
}
