using Bridge.Interfacex;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class DetailedLogger : ILogging
    {
        public DetailedLogger(IWriter writer)
        {
            Writer = writer;
        }
        public IWriter Writer { get; private set; }

        public void LogError(string text)
        {
            Writer.Write($"You have a log error as: {text} at this time:{DateTime.Now.ToShortTimeString()}");
        }

        public void LogInfo(string text)
        {
            Writer.Write($"You have logged in: {text} at this time:{DateTime.Now.ToShortTimeString()}");
        }

        public void LogWarning(string text)
        {
            Writer.Write($"You have a log warning as: {text} at this time:{DateTime.Now.ToShortTimeString()}");
        }
    }
}
