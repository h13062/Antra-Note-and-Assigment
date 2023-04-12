using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToWeb.Solid
{
    public class OCP
    {
        /*
         Open for extension closed for modification 
        can use upcasting to create an object of an interface that allow diffrent functionality.
        By doing so we are opening for extension by creating new child object that can be put inside a parent class

         */
        public OCP()
        {
            Car car = new V8Car();
        }
    }

    public class V8Car : Car
    {
    }

    public class Car
    {
        public virtual void Engine()
        {
            Console.Write("vrm");
        }
    }
    public class Sudan: Car
    {
        public override void Engine()
        {
            Console.Write("vrmmmmmmmmmm");
        }
    }
}
