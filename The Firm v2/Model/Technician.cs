using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.Model
{

    internal class Technician : Employee
    {
        private bool getsFixedSalary;

        internal Technician(string firstName, string lastName, string cpr, string phoneNumber, string email, bool getsFixedSalary)
            : base(firstName, lastName, cpr, phoneNumber, true, email)
        {
            this.getsFixedSalary = getsFixedSalary; // Assign the provided value to the backing field
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, CPR number: {Cpr}, PhoneNumber: {PhoneNumber}, Salary: {Salary}, Email: {Email}, FixedSalary: {getsFixedSalary}";
        }
    }
}

