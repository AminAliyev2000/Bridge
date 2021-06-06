using Bridge.Interfacex;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ConsoleWrite : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
