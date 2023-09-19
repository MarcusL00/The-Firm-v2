using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.Model
{
    internal class Cleaner : Employee
    {


        internal Cleaner(string firstName, string lastName, string cpr, string phoneNumber, bool salary, string email) : base(firstName, lastName, cpr, phoneNumber, salary, email)
        {
            FirstName = firstName;
            LastName = lastName;
            Cpr = cpr;
            PhoneNumber = phoneNumber;
            Salary = salary;
            Email = email;
        }

        public override string ToString()
        {
            return $"First name: {firstName}, Last name:{lastName}, CPR number: {cpr}, PhoneNumber: {PhoneNumber}, Salary: {Salary}, Email: {Email}";
        }
    }
}
