using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx.Commands
{
    public class ExecuteCommand:ICommand
    {
        IUserInterface _userInterface;
        public ExecuteCommand(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public string HelpString { get; set; } = "animal axecute entered command";

        public bool Execute(string[] args)
        {
            string name = _userInterface.Read("Enter name");
            string command = _userInterface.Read("Enter command");
            Animal animal= AnimalHandler.Animals[name] as Animal;
            if (animal == null) return false;
            _userInterface.WriteLine(animal.DoCommand(command));
            return true;
        }
    }
}
