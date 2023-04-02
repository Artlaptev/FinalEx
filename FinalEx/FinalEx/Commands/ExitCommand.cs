using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx.Commands
{
    public class ExitCommand : ICommand
    {
        private AnimalMenu _animalmenu;
        public string HelpString { get; set; } = "Close application";
        public ExitCommand(AnimalMenu animalmenu)
        {
            _animalmenu = animalmenu;
        }

        public bool Execute(string[] args)
        {
            _animalmenu.ContinueWorking = false;
            return true;
        }
    }
}
