namespace Computers.UI
{
    using System;
    using Logic.ComputerTypes;
    using Logic.Manufacturers;
    
    public static class Program
    {
        private const string ExitCommand = "Exit";
        private const string ChargeCommand = "Charge";
        private const string ProcessCommand = "Process";
        private const string PlayCommand = "Play";
        private const string InvalidCommandMessage = "Invalid command!";
        private const char Splitter = ' ';
        private static PersonalComputer pc;
        private static Laptop laptop;
        private static Server server;

        public static void Main()
        {
            CreateComputers();
            ProcessCommands();
        }

        private static void CreateComputers()
        {
            var manufacturerName = Console.ReadLine();
            var manufacturerFactory = new ManufacturerFactory();
            IComputersFactory computerFactory = manufacturerFactory.GetManufacturer(manufacturerName);

            pc = computerFactory.CreatePersonalComputer();
            laptop = computerFactory.CreateLaptop();
            server = computerFactory.CreateServer();
        }

        private static void ProcessCommands()
        {
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == null)
                {
                    break;
                }

                if (userInput.StartsWith(ExitCommand))
                {
                    break;
                }

                var commandParts = userInput.Split(new[] { Splitter }, StringSplitOptions.RemoveEmptyEntries);
                if (commandParts.Length != 2)
                {
                    throw new ArgumentException(InvalidCommandMessage);
                }

                var commandName = commandParts[0];
                var commandArgument = int.Parse(commandParts[1]);

                if (commandName == ChargeCommand)
                {
                    laptop.ChargeBattery(commandArgument);
                }
                else if (commandName == ProcessCommand)
                {
                    server.Process(commandArgument);
                }
                else if (commandName == PlayCommand)
                {
                    pc.Play(commandArgument);
                }
                else
                {
                    Console.WriteLine(InvalidCommandMessage);
                }
            }
        }
    }
}