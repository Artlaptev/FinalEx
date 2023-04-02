using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    public  interface IUserInterface
    {
        public void WriteLine(string message);
        public void Write(string message);

        public string Read(string message,bool promtNewLine=true);
    }
}
