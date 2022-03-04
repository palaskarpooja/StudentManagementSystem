using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
   public class EnrollmentsBO
    {
        private int id;
        private int studentId;
        private int courseId;
        private DateTime createdDate;

        public EnrollmentsBO()
        {

        }

        public EnrollmentsBO(int id, int studentId, int courseId, DateTime createdDate)
        {
            this.Id = id;
            this.StudentId = studentId;
            this.CourseId = courseId;
            this.CreatedDate = createdDate;
        }


        public int Id { get => id; set => id = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int CourseId { get => courseId; set => courseId = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
    }

   
}
