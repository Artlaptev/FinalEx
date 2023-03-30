using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    public  class AnimalHandler
    {
        public Hashtable Animals { get; private set; } 
        public void AddAnimal(string name, AnimalType type,DateOnly birhtday)
        {
            if (Animals==null)
                Animals= new Hashtable();
            Animals.Add(name,new Animal(name, type, birhtday));
        }
        public bool LearnTheCommand(string animalName, string commandDescription, string commandDoung)
        {
            if (!Animals.ContainsKey(animalName))
                return false;
            Animal animal = Animals[animalName] as Animal;
            animal.LearnCommand(commandDescription, commandDoung);
            
            return true;
        }  
    }
}
