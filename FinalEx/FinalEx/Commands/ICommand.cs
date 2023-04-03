using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx.Commands
{
    public interface ICommand
    {
        public string HelpString { get; set; }
        public bool Execute(string[] args);
    }
}
