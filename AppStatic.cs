using Composicion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    public static class AppStatic
    {
        public static List<IMove> Engines = new List<IMove>();
        public static List<INavigate> Drivers = new List<INavigate>();
        public static List<Transport> Transports = new List<Transport>();

        public static void InstanciarTodo()
        {
            InstanciarDrivers();
            InstanciarEngines();
            InstanciarTransports(); 
        }

        private static void InstanciarDrivers()
        {
            Drivers.Add(new Human());
            Drivers.Add(new Robot());
        }

        private static void InstanciarEngines()
        {
            Engines.Add(new CombustionEngine());
            Engines.Add(new CombustionEngine());
            Engines.Add(new ElectricEngine());
            Engines.Add(new ElectricEngine());
        }

        private static void InstanciarTransports()
        {
            Transports.Add(new Transport(Engines[0], Drivers[0]));
            Transports.Add(new Transport(Engines[2], Drivers[0]));
            Transports.Add(new Transport(Engines[1], Drivers[1]));
            Transports.Add(new Transport(Engines[3], Drivers[1]));
        }
    }
}
