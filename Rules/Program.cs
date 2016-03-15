using System;

namespace Rules
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer
            {
                Ghz = 4.0,
                Ram = 8,
                DiskSpace = 400,
                OperatingSystem = "Windows"
            };

            var checker = new SystemRequirementsChecker();
            checker.CheckSystem(computer);

            Console.ReadKey();
        }
    }
}
