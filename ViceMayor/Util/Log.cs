using ColossalFramework.Plugins;

namespace ViceMayor.Util
{
    public static class Log
    {
        public static void Message(string s)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, s);
        }

        public static void Error(string s)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Error, s);
        }

        public static void Warning(string s)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Warning, s);
        }
    }
}