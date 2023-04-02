using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEx
{
    public enum AnimalType 
    {
        cat,dog,camel,horse,unicorn

    }
    public class Animal
    {
        public string Name { get; private  set; }
        public string Type { get; private set; }
        public DateOnly Birthday { get; private set; }
        public Dictionary<string,string> Commands { get; private set; }
        
        public Animal (string name, string type, DateOnly birthday)
        {
            Name = name;
            Type = type;
            Birthday = birthday;
        }
        public string DoCommand(string command)
        {
            if (Commands == null) return "I can't do anithing";
            if (Commands.ContainsKey(command))
                return Commands[command];
            else return @"I don't know this command \,/(^_^)\,/";

        }
        public bool LearnCommand(string command, string doing)
        {
            if (Commands==null)
                Commands = new Dictionary<string,string>();
            if (Commands.ContainsKey(command))
                return false;
            Commands.Add(command, doing);
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();

            return sb.AppendFormat("{0} {1} {2}",new Object[] {Name,Type,Birthday}).ToString();
        }


    }
}
