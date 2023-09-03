using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using Sandbox.Common;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Common.ObjectBuilders.Definitions;
using Sandbox.Definitions;
using Sandbox.Game;
using Sandbox.Game.Entities;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Ingame;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.ModAPI;
using VRage.ModAPI;
using VRage.Utils;

namespace BetterWheels
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    class BetterWheels : MySessionComponentBase
    {
        public override void LoadData()
        {
            base.LoadData();
            var allDefs = MyDefinitionManager.Static.GetAllDefinitions();

            foreach (var componenet in allDefs.OfType<MyMotorSuspensionDefinition>())
            {
                if(componenet.BlockPairName.Contains("3x3"))
                {
                    componenet.PropulsionForce *= 3.0f;
                    componenet.AxleFriction += 2f;
                    MyLog.Default.WriteLine("Usefull Big Wheels - Improved " + componenet.BlockPairName);
                }
                else if (componenet.BlockPairName.Contains("5x5"))
                {
                    componenet.PropulsionForce *= 5.0f;
                    componenet.AxleFriction += 3f;
                    MyLog.Default.WriteLine("Usefull Big Wheels - Improved " + componenet.BlockPairName);
                }
                else if (componenet.BlockPairName.Contains("2x2"))
                {
                    componenet.PropulsionForce *= 2.0f;
                    componenet.AxleFriction += 1.75f;
                    MyLog.Default.WriteLine("Usefull Big Wheels - Improved " + componenet.BlockPairName);
                }
            }
        }
    }
}
