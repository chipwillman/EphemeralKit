using ek.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ek
{
    public class CommandFactory
    {
        public static ICommand Get(string commandName)
        {
            switch (commandName)
            {
                case "sample": return new Samples();
                case "config": return new Config();
                default:
                    break;
            }

            return new Usage();
        }
    }
}
