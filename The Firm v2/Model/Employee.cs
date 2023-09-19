using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.Model
{
    internal class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string cpr;
        protected string phoneNumber;
        protected bool salary;
        protected string email;

        protected string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        protected string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        protected string Cpr
        {
            get => cpr;
            set => cpr = value;
        }
        protected string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        protected bool Salary
        {
            get => salary;
            set => salary = value;
        }
        protected string Email
        {
            get => email;
            set => email = value;
        }

        public Employee(string firstName, string lastName, string cpr, string phoneNumber, bool salary, string email)
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