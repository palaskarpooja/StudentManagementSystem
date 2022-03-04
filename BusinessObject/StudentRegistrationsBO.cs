using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    class StudentRegistrationsBO
    {
        private int id;
        private string firstName;
        private string lastName;
        private long contactNumber;
        private int collegeId;
        private DateTime createdDate;

        public StudentRegistrationsBO()
        {

        }

        public StudentRegistrationsBO(int id, string firstName, string lastName, long contactNumber, int collegeId, DateTime createdDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
            this.collegeId = collegeId;
            this.createdDate = createdDate;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public long ContactNumber { get => contactNumber; set => contactNumber = value; }
        public int CollegeId { get => collegeId; set => collegeId = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
    }
}
