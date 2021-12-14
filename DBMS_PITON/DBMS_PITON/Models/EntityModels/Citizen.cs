using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMS_PITON.Models.EntityModels
{
    public class Citizen
    {
        private int citizenID;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private char gender;
        private DateTime birthDate;

        public int CitizenID
        {
            get { return this.citizenID; }
            set { this.citizenID = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public char Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
    }
}
