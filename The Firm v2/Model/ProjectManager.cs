using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.Model
{
    internal class ProjectManager : Technician
    {
        protected string Email
        {
            get => email;
            set => email = value;
        }
        internal ProjectManager(string firstName, string lastName, string cpr, string phoneNumber, string email) : base(firstName, lastName, cpr, phoneNumber, email, true)
        {
            FirstName = firstName;
            LastName = lastName;
            Cpr = phoneNumber;
            PhoneNumber = phoneNumber;
            Email = email;
        }


        public override string ToString()
        {
            return $"First name: {firstName}, Last name:{lastName}, CPR number: {cpr}, Phone number: {phoneNumber}, Email: {email}";
        }


    }
}
