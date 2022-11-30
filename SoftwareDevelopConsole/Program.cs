using SBeregovoy.SoftDevelop.Domain;
using SBeregovoy.SoftDevelop.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SBeregovoy.SoftDevelop.SoftwareDevelopConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("test", new List<TimeRecord>()
            {
                new TimeRecord(DateTime.Now.AddDays(-3), "test", 8, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-2), "test", 9, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-1), "test", 7, "test message"),

                //ЗДЕСЬ ПОЛУЧАЕТСЯ ЗА ТРИ ДНЯ
                
            });
            Console.WriteLine(manager.TotalPay); //29750
            Console.ReadLine();
        }
    }
}
