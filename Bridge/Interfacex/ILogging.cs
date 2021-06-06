using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Interfacex
{
    public interface ILogging
    {
        IWriter Writer { get; }
        void LogInfo(string text);
        void LogWarning(string text);
        void LogError(string text);

    }
}
