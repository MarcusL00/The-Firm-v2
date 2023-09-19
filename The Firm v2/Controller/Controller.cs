using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Firm_v2.Model;

namespace The_Firm_v2.Controller
{
    internal class Controller
    {
        public void Ctrl()
        {
            Cleaner employee1 = new Cleaner("Marcus", "Johansen", "123456789", "14141414", true, "MarcusJohansen@gmail.com");

            Technician manager1 = new Technician("John", "Johansen", "123456789", "13313113", "JohnJohansen@gmail.com", true);

            ProjectManager projectManager1 = new ProjectManager("Emre", "larsen", "12345658", "88888888", "EmreLarsen@hotmail.com");

            TechnicianCheif technicianCheif1 = new TechnicianCheif("Magnus", "Lund", "123456", "24242424", "MagnusLund@gmail.com", true, true);


            View.Gui.WriteEmployees(employee1, manager1, projectManager1, technicianCheif1);

        }

    }
}

