using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColossalFramework.UI;
using UnityEngine;
using ViceMayor.Util;

namespace InfoPanels
{
    public static class InfopanelManager
    {
        private static UIPanel MainPanel;
        private static Dictionary<MonitorElement, UILabel> PerElement = new Dictionary<MonitorElement, UILabel>();

        public static void Initialize(params MonitorElement[] newElements)
        {
            if (MainPanel == null)
            {
                var uiView = GameObject.FindObjectOfType<UIView>();
                if (uiView == null) return;

                MainPanel = uiView.AddUIComponent(typeof(UIPanel)).GetComponent<UIPanel>();
                MainPanel.transformPosition = new Vector3(0, 0);
                MainPanel.width = 300;
                MainPanel.height = 500;
                MainPanel.backgroundSprite = "GenericPanel";
                MainPanel.color = new Color32(255, 255, 255, 100);

                float labelY = 0.95f;

                foreach (var e in newElements)
                {
                    UILabel label = MainPanel.AddUIComponent<UILabel>();
                    label.color = new Color32(255, 255, 255, 255);
                    label.transformPosition = new Vector3(0, labelY);

                    label.text = String.Format("{0}: {1}/{2}", e.Name, e.Current, e.Max);
                    labelY += 0.05f;

                    Log.Message("Making: {0}: {1}/{2}", e.Name, e.Current, e.Max);
                    Log.Message("Position: {0}", labelY);

                    PerElement.Add(e, label);
                }

                Log.Message("Dictionary Count: {0}", PerElement.Count);
            }
        }
    }
}
