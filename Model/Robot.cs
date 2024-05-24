using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion.Model
{
    public class Robot : INavigate
    {
        public Robot() { }

        public string Navigate()
        {
            return "bip bop, bip bop";
        }
    }
}
