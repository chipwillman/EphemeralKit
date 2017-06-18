using ek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ek.Commands
{
    public interface ISamplesCommand
    {
        int Execute(SamplesOptions options);
    }
}
