using ek.Extensions;
using ek.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ek
{
    public class EnvironmentManager
    {
        public static Ekenv LoadEnvironment(string environmentName)
        {
            Ekenv result = null;
            if (File.Exists(environmentName + ".env"))
            {
                result = File.ReadAllText(environmentName + ".env").FromJson<Ekenv>();
                result.EnvironmentExists = true;
            }
            else
            {
                result = new Ekenv { Name = environmentName };
            }

            return result;
        }

    }
}
