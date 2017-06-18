using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ek.Model
{
    public class Options
    {
        [Option(HelpText = "Command argument")]
        public string Command { get; set; }
    }
}
