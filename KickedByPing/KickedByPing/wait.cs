using System;
using UnityEngine;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Chat;
using System.Collections.Generic;
using Rocket.Core.Plugins;
using Rocket.Unturned.Plugins;
using Rocket.Core.Logging;
using System.Linq;
using System.Text;


using SDG.Unturned;

namespace KickedByPing
{
    public class MainClass : RocketPlugin
    {
        public static DateTime lastCalled;
        public static bool isWaiting = false;
        public static UnturnedPlayer Player;

        List<SteamPlayer> pList;

        void checkPing()
        {
            //if ((DateTime.Now - lastCalled).TotalSeconds >= 10)
            //{
                float ping;
                int intPing;

                SteamPlayer sPlayer = pList[0];
                ping = sPlayer.ping;
                intPing = (int)ping;

                UnturnedChat.Say(intPing.ToString());
                isWaiting = false;
            //}
        }

        public void FixedUpdate()
        {
            pList = Provider.clients;

            if (isWaiting == true)
            {
                checkPing();
            }
        }
    }
}
