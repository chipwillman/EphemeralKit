using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine;

namespace ek
{
    class Program
    {
        public static void ShowHelpText()
        {
            Console.WriteLine("ek: Ephemeral Kits is a command line application that creates AWS environments for load testing production like ");
            Console.WriteLine("");
            Console.WriteLine(">ek <command> <args>");
            Console.WriteLine("");
            Console.WriteLine("Commands:");
            Console.WriteLine("        create           delete");
            Console.WriteLine("        samples          config");
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowHelpText();
            }
            else 
            {
                var command = CommandFactory.Get(args[1]);
                var commandArgs = new string[args.Length - 1];
                args.CopyTo(commandArgs, 1);
                command.Execute(commandArgs);
            }
        }
    }
}
