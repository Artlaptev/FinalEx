using FinalEx.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    public class AnimalMenu
    {
        private readonly IUserInterface _userInterface;
        public readonly Dictionary<string, ICommand> _commands;
        public bool ContinueWorking { get; set; } = true;
        public AnimalMenu(IUserInterface userInterface)
        {
            this._userInterface = userInterface;
            _commands = new Dictionary<string, ICommand>()
            {
                { "add",new AddAnimal(_userInterface)},
                { "lean",new LearnCommand(_userInterface)},
                { "get animals",new GetAnimalListCommand(_userInterface)},
                { "execute", new ExecuteCommand(_userInterface) },
                { "help", new HelpCommand(_userInterface,this)},
                { "exit", new ExitCommand(this)}
            };
        }
        public void Start()
        {
            _userInterface.WriteLine("Was started");


            while (ContinueWorking)
            {
                var input = _userInterface.Read("Enter the command");
                _userInterface.WriteLine($"entered command {input}");
                if (_commands.ContainsKey(input))
                    _commands[input].Execute(new string[2]);
                
            }


        }
    }
}
