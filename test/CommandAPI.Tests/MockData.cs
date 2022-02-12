using System;
using System.Collections.Generic;
using System.Linq;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class MockData :IDisposable
    {
        List<Command> commands;
        public MockData()
        {
            commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Mock0", Platform = "Mock0",CommandLine = "Mock0"},
                new Command{Id = 1, HowTo = "Mock1", Platform = "Mock1",CommandLine = "Mock1"},
                new Command{Id = 2, HowTo = "Mock2", Platform = "Mock2",CommandLine = "Mock2"},
                new Command{Id = 3, HowTo = "Mock3", Platform = "Mock3",CommandLine = "Mock3"}
            };   
        }

        public void Dispose()
        {
            commands = null;
        }

        public Command GetCommandByID(int Id)
        {  

         Command command;

         switch(Id)
         {
             case 0:
             command = new Command{Id = 0, HowTo = "Mock0", Platform = "Mock0",CommandLine = "Mock0"};
             break;
             case 1:
             command = new Command{Id = 1, HowTo = "Mock1", Platform = "Mock1",CommandLine = "Mock1"};
             break;
             case 2:
             command = new Command{Id = 2, HowTo = "Mock2", Platform = "Mock2",CommandLine = "Mock2"};
             break;
             case 3:
             command = new Command{Id = 3, HowTo = "Mock3", Platform = "Mock3",CommandLine = "Mock3"};
             break;
             default:
             command = null;
             break;             
         } 
         return command;
        }

        public List<Command> GetCommands(int num)
        {
            var commands = new List<Command>();
            if (num > 0)
            {
                commands.Add(new Command
                {
                    Id = 0,
                    HowTo = "How to genrate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform = ".Net Core EF"
                });
            }
            return commands;
        }
    }
}