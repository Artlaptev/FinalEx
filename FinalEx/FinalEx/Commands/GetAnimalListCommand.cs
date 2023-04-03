using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx.Commands
{
    public class GetAnimalListCommand : ICommand
    {
        private readonly IUserInterface _userInterface;
        public GetAnimalListCommand(IUserInterface userInterface) => _userInterface = userInterface;

        public string HelpString { get; set; } = "Get animal list";

        public bool Execute(string[] args)
        {
            if (AnimalHandler.Animals != null && AnimalHandler.Animals.Count > 0)
            {
                foreach (DictionaryEntry animal in AnimalHandler.Animals)
                {
                    _userInterface.WriteLine(animal.Value.ToString());
                }
                return true;
            }

            else
                return false;
        }
    }
}
