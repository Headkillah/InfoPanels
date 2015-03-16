using System;
using ColossalFramework.Plugins;
using JetBrains.Annotations;

namespace ViceMayor.Util
{
    public static class Log
    {
        [StringFormatMethod("s")]
        public static void Message(string s, params object[] parameters)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, (parameters == null ? s : String.Format(s, parameters)));
        }

        [StringFormatMethod("s")]
        public static void Error(string s, params object[] parameters)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Error, (parameters == null ? s : String.Format(s, parameters)));
        }

        [StringFormatMethod("s")]
        public static void Warning(string s, params object[] parameters)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Warning, (parameters == null ? s : String.Format(s, parameters)));
        }
    }
}