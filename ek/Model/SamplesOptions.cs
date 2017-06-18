using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ek.Model
{
    public class SamplesOptions
    {
        [Option('v', "vpc", HelpText = "vpc name")]
        public string vpc { get; set; }

        [Option('e', "env", HelpText = "environment file")]
        public string env { get; set; }

        [Option('t', "type", HelpText = "Type of template to create")]
        public string type { get; set; }
    }
}
