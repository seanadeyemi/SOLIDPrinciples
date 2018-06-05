//using SRP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Persistence
    {
        public void SaveToFile(Object obj, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, obj.ToString());
            }
        }
    }
}
