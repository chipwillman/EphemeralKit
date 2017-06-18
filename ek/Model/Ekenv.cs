using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ek.Model
{
    public class Ekenv
    {
        public bool EnvironmentExists { get; internal set; }
        public string Name { get; internal set; }
        public string vpc { get; set; }
    }
}
