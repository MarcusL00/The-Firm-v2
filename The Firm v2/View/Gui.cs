using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.View
{
    internal class Gui
    {
        public static void WriteEmployees(params Model.Employee[] employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.ReadKey();
        }
    }

}
