using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ek.Model
{
    public class ConfigOptions
    {
        [Option('t', "test", HelpText = "Test Configuration and required access levels")]
        public bool Test { get; set; }

        [Option('e', "environment", Required = true, HelpText = "Name of the environment", DefaultValue ="DEFAULT")]
        public string Environment { get; set; }
    }
}
