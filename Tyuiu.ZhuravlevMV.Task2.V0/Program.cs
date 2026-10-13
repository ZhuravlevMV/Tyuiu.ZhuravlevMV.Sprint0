using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhuravlevMV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ZhuravlevMV.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и медота GetMassage
            //из библиотеки Tyuiu.ZhuravlevMV.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Михаил"));
            Console.ReadKey();
        }
    }
}
