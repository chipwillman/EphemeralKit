using ek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ek.Extensions;

namespace ek.Commands
{
    public class Config : ICommand
    {
        public int Execute(string[] args)
        {
            var configOptions = new ConfigOptions();
            if (CommandLine.Parser.Default.ParseArgumentsStrict(args, configOptions))
            {
                var environment = EnvironmentManager.LoadEnvironment(configOptions.Environment);
                if (configOptions.Test)
                {
                    TestConfiguration(environment, configOptions);
                }
                else
                {
                    UpdateConfiguration(environment, configOptions);
                }
                return 0;
            }
            Console.WriteLine(HelpText());
            return 1;
        }

        public string HelpText()
        {
            return @"ek config <args>: Create a sample template for a requested environment
                        -test 
                              test environment setup
";
        }

        #region Implementation

        private void TestConfiguration(Ekenv environment, ConfigOptions configOptions)
        {
            if (environment.EnvironmentExists)
            {
                Console.WriteLine("Environment File Exists");
            }
            else
            {
                Console.WriteLine("Enironment File does not exist");
            }
        }


        private void UpdateConfiguration(Ekenv environment, ConfigOptions configOptions)
        {
            
        }

        #endregion
    }
}
