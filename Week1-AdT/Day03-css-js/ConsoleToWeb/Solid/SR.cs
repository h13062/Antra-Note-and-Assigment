using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToWeb.Solid
{
    public class SR
    {
        /*
         Single responsibilty Principle:
        States that a class should do one thing
        if it does more than one thing, consider seperating the functionality to another section of code
        seperation of concerns per file
         */
        public int Id { get; set; }
        public string Name { get; set; }
        //it either hold or conduct tasks
        public SR(int id, string name) // consider to move to repository
        {
            Id = id;
            Name = name;
        }
        public void Run() // consider to move to services
        {

        }
    }
    
}
