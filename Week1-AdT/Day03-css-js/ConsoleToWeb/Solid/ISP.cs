using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToWeb.Solid
{
    /*
     Interface Segregation principles:
    when there is an interface that has some properties that does not apply to some of the classes, use multiple interfaces
    to split up the interface into smaller ones, This allows for more flexibilty
     */
    public interface IAutomobile
    {

    }
    public interface IEngine
    {

    }
    public interface IWheel
    {

    }
    public interface IWindshield
    {

    }
    public class Motocycle: IEngine, IWindshield
    {

    }
    public  class ISP
    {
    }
}
