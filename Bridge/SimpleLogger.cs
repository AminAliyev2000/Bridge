using Bridge.Interfacex;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SimpleLogger : ILogging

    {
        public SimpleLogger(IWriter writer)
        {
            Writer = writer;
        }
        public IWriter Writer { get; private set; }

        public void LogError(string text)
        {
            Writer.Write($"You have a log error as: {text}");
        }

        public void LogInfo(string text)
        {
            Writer.Write($"You have logged in: {text}");
        }

        public void LogWarning(string text)
        {
            Writer.Write($"You have a log warning as: {text}");
        }
    }
}
