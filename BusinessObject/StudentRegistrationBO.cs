using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class StudentRegistrationBO
    {
        private int id;
        private string firstName;
        private string lastName;
        private int contactNumber;
        private int collegeId;
        private DateTime createdDate;

        public StudentRegistrationBO()
        {

        }
        public StudentRegistrationBO(int id, string firstName, string lastName, int contactNumber, int collegeId, DateTime createdDate)
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
        public int ContactNumber { get => contactNumber; set => contactNumber = value; }
        public int CollegeId { get => collegeId; set => collegeId = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
    }
}
