using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalEx.Commands
{
    public class AddAnimal : ICommand
    {
        private readonly IUserInterface _userInterface;
        public AddAnimal(IUserInterface userInterface) => _userInterface = userInterface;

        public string HelpString { get; set; } = "add animal in hte animal list";

        public bool Execute(string[] args)
        {
            try
            {
                string name = _userInterface.Read("Enter name");
                string type = _userInterface.Read("Enter animal type");
                DateOnly birthday = DateOnly.Parse(_userInterface.Read("Enter date format {yyyy.mm.dd}"));
                if (AnimalHandler.Animals == null)
                    AnimalHandler.Animals = new Hashtable();
                AnimalHandler.Animals.Add(name, new Animal(name, type, birthday));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
