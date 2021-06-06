using Bridge.Interfacex;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ILogging logging = new SimpleLogger(new ConsoleWrite());
            logging.LogError("Error #123");
            logging.LogWarning("Warning #221");
            logging.LogInfo("Some log info");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
            logging = new DetailedLogger(new ConsoleWrite());
            logging.LogError("Error #123");
            logging.LogWarning("Warning #221");
            logging.LogInfo("Some log info");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
            logging = new DetailedLogger(new FileWriter());
            logging.LogError("Error #123");
            logging.LogWarning("Warning #221");
            logging.LogInfo("Some log info");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
        }
    }
}
