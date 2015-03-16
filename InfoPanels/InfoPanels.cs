using System;
using ColossalFramework.UI;
using UnityEngine;
using ICities;
using ViceMayor.DataModels;
using ViceMayor.Helpers;
using ViceMayor.Util;

namespace InfoPanels
{
    public class InfoPanel : IUserMod
    {
        public string Name
        {
            get { return "Infopanels"; }
        }
        public string Description
        {
            get { Log.Message("I dunno lol"); return "Toggleable information panels for your city!"; }
        }
    }

    public class LoadedDetector : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            if (mode == LoadMode.LoadMap)
            {
                Log.Message("It loaded!");

                InfopanelManager.Initialize(new MonitorElement
                {
                    Name = "Water",
                    Max = WaterProduction.Capacity,
                    Current = WaterProduction.Consumption
                },
                    new MonitorElement
                    {
                        Name = "Electricity",
                        Max = ElectricityProduction.Capacity,
                        Current = ElectricityProduction.Consumption
                    });
            }
        }
    }

}
