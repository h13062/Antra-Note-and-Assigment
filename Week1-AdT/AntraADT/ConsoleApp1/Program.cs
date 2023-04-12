//DAPPER tutorial 
// add class library 
using ConsoleApp1.Menu;
using Infrastructure.Services;
using System;
using System.Linq;
using System.Text;
namespace ConsoleApp1;

public class Program
{
    public static void Main()
    {
        MenuSelection menu = new MenuSelection();
        menu.run();
    }
}
