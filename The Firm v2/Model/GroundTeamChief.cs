using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm_v2.Model
{
    internal class GroundTeamChief : Employee
    {
        private bool getsFixedSalary;
        private bool allowedToSchedule;

        internal GroundTeamChief(string firstName, string lastName, string cpr, string phoneNumber, string email, bool getsFixedSalary, bool allowedToSchedule) : base(firstName, lastName, cpr, phoneNumber, true, email)
        {
            this.getsFixedSalary = getsFixedSalary; // Assign the provided value to the field
            this.allowedToSchedule = allowedToSchedule; // Assign the provided value to the field
        }


        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, CPR number: {Cpr}, PhoneNumber: {PhoneNumber}, Salary: {Salary}, Email: {Email}, FixedSalary: {getsFixedSalary}, Allowed to schedule: {allowedToSchedule}";
        }
    }
}

