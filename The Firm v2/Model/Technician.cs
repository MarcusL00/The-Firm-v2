using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.Model
{

    internal class Technician : Employee
    {
        protected bool getsFixedSalary;
        protected bool allowedToRepair;

        internal Technician(string firstName, string lastName, string cpr, string phoneNumber, string email, bool getsFixedSalary, bool allowedToRepair) : base(firstName, lastName, cpr, phoneNumber, true, email)
        {
            this.getsFixedSalary = getsFixedSalary; // Assign the provided value to the field
            this.allowedToRepair = allowedToRepair;
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, CPR number: {Cpr}, PhoneNumber: {PhoneNumber}, Salary: {Salary}, Email: {Email}, FixedSalary: {getsFixedSalary}, Allowed to repair:{allowedToRepair}";
        }
    }
}

