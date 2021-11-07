using System.Collections.Generic;
using CommandAPI.Models;
namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{
                    Id=0, HowTo="How to genrate a migration", 
                    CommandLine="dotnet ef migrations add <Name of Migration>", 
                    Platform=".Net Core EF"},
                new Command{
                    Id=1, HowTo="Run Migrations", 
                    CommandLine="dotnet ef database update", 
                    Platform=".Net Core EF"},
                new Command{
                    Id=2, HowTo="AC List active migrations", 
                    CommandLine="dotnet ef migrations list", 
                    Platform=".Net Core EF"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            Command cmd = new Command();
            if(id == 0)
            {
                cmd = new Command
                {
                    Id = 0,
                    HowTo = "How to genrate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform = ".Net Core EF"
                };
            }
            else if(id == 1)
            {
                cmd = new Command
                {
                    Id = 1,
                    HowTo = "Run Migrations",
                    CommandLine = "dotnet ef database update",
                    Platform = ".Net Core EF"
                };
            }
            else if (id == 2)
            {
                cmd = new Command
                {
                    Id = 2,
                    HowTo = "AC List active migrations",
                    CommandLine = "dotnet ef migrations list",
                    Platform = ".Net Core EF"
                };
            }
            else if (id == 3)
            {
                cmd = null;                
            }

            return cmd;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }    
}