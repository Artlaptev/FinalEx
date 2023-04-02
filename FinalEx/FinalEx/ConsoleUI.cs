using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    public class ConsoleUI : IUserInterface
    {
        public string Read(string promt,bool promtNewLine)
        {
            if (promtNewLine)
                if (!string.IsNullOrEmpty(promt))
                    Console.WriteLine(promt);
                else
                    Console.WriteLine(promt);
            return Console.ReadLine();
        }

        public void WriteLine(string message)=>Console.WriteLine(message);
        public void Write(string message)=>Console.Write(message);
    }
}
