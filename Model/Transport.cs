using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion.Model
{
    public class Transport
    {
        private IMove Engine;
        private INavigate Driver;

        public Transport(IMove Engine, INavigate Driver)
        {
            this.Engine = Engine;
            this.Driver = Driver;
        }

        public IMove ENGINE
        {
            get { return this.Engine; }
            set { this.Engine = value; }
        }

        public INavigate DRIVER 
        { 
            get { return this.Driver; }
            set { this.Driver = value; }
        }

        public String Deliver(String destination, String cargo)
        {
            return $"We are moving to {destination} with {cargo} \n Engine: {ENGINE.Move()} \n Driver: {DRIVER.Navigate()} \n";
        }
    }
}
