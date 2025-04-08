using System;
using System.IO;

namespace MindfulnessProgram
{
    public static class Logger
    {
        private static string _logFile = "MindfulnessLog.txt";

        public static void Log(string message)
        {
            string logEntry = $"{DateTime.Now}: {message}";
            File.AppendAllText(_logFile, logEntry + Environment.NewLine);
        }
    }
}
