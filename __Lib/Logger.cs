//!CompilerOption:RegisterAssembly
using System.Windows.Media;
using ff14bot.Helpers;

namespace Lib
{
    public static class Logger
    {
        private static readonly string botName = "LibLogger";

        public static void PrintLine(string line)
        {
            Log(line);
        }
        
        private static void Log(string text)
        {
            var msg = string.Format("[" + botName + "] " + text);
            Logging.Write(Colors.Green, msg);
        }

        private static void Log(string text, params object[] args)
        {
            var msg = string.Format("[" + botName + "] " + text, args);
            Logging.Write(Colors.Green, msg);
        }

        private static void LogVerbose(string text, params object[] args)
        {
            var msg = string.Format("[" + botName + "] " + text, args);
            Logging.WriteVerbose(msg);
        }

    }
}