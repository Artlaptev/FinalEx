using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx.Commands
{
    public class LearnCommand : ICommand
    {
        private readonly IUserInterface _userInterface;
        public LearnCommand(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public string HelpString { get; set; } = "Teach the command to the selected animal";

        public bool Execute(string[] args)
        {
            string animalName = _userInterface.Read("Enter name");
            string commandDescription = _userInterface.Read("Enter command destription");
            string commandDoung = _userInterface.Read("Enter doing animal must execute");
            if (!AnimalHandler.Animals.ContainsKey(animalName))
                return false;
            Animal animal = AnimalHandler. Animals[animalName] as Animal;
            animal.LearnCommand(commandDescription, commandDoung);

            return true;
        }
    }
}
