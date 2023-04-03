using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx.Commands
{
    public class HelpCommand:ICommand
    {
        IUserInterface _userInterface;
        AnimalMenu _menu;
        public HelpCommand(IUserInterface userInterFace, AnimalMenu menu)
        {
            _userInterface = userInterFace;
            _menu = menu;
        }

        public string HelpString { get; set; } = "Get manual";

        public bool Execute(string[] args)
        {
            foreach (string item in _menu._commands.Keys)
            {
                StringBuilder sb =new StringBuilder();
                _userInterface.WriteLine(sb.AppendFormat("{0} - {1}",item, _menu._commands[item].HelpString).ToString());
            }
            return true;
        }
    }
}
