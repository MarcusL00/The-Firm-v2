using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.Model
{
    internal class ProjectCreator : Technician
    {
        protected bool decideOrderOperation
        {
            get => decideOrderOperation;
            set => decideOrderOperation = true;
        }

        // Constructor for TechnicianCheif
        internal ProjectCreator(string firstName, string lastName, string cpr, string phoneNumber, string email, bool getsFixedSalary, bool decidesFocus) : base(firstName, lastName, cpr, phoneNumber, email, true)
        {
            this.decideOrderOperation = decideOrderOperation; // Assign the provided value to DecidesFocus
        }

        public override string ToString()
        {
            return $"First name: {firstName}, Last name:{lastName}, CPR number: {cpr}, PhoneNumber: {PhoneNumber}, Salary: {Salary}, Email: {Email}, FixedPay: {decideOrderOperation}";
        }
    }
}