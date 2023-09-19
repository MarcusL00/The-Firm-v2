using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.Model
{
    internal class TechnicianCheif : Technician
    {
        private bool decidesFocus; // Use a separate backing field

        protected bool DecidesFocus
        {
            get => decidesFocus;
            set => decidesFocus = value; // Set the backing field to the provided value
        }

        // Constructor for TechnicianCheif
        internal TechnicianCheif(string firstName, string lastName, string cpr, string phoneNumber, string email, bool getsFixedSalary, bool decidesFocus) : base(firstName, lastName, cpr, phoneNumber, email, getsFixedSalary)
        {
            this.decidesFocus = decidesFocus; // Assign the provided value to DecidesFocus
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, CPR number: {Cpr}, PhoneNumber: {PhoneNumber}, Salary: {Salary}, Email: {Email}, FixedPay: {DecidesFocus}";
        }
    }
}