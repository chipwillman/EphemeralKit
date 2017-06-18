using CommandLine;
using ek.Factory;
using ek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ek.Commands
{
    public class Samples : ICommand
    {
        public string HelpText()
        {
            return @"ek sample <args>: Create a sample template for a requested environment
                        -vpc <VpcId> 
                              VpcId used to find named subnets
                        -env <Environment>
                              Environment configuration file used to replace values in the configuration files
                        -type <type>
                              Type consists of the following environments:
                                  webapp: Creates a template that monitors a single web application
                                  service: creates a template that monitors a single windows server
                                  base: Create a template with the base environment with no additional computers
";
        }

        public int Execute(string[] args)
        {
            var options = new SamplesOptions();
            if (Parser.Default.ParseArguments(args, options))
            {
                var command = SamplesCommandFactory.Get(options.type);
                return command.Execute(options);
            }
            return 0;
        }

    }
}
