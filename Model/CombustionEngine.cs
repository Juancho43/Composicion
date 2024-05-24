using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion.Model
{
    public class CombustionEngine : IMove
    {
        public CombustionEngine() { }

        public string Move()
        {
            return "Brrrrrm";
        }
    }
}
