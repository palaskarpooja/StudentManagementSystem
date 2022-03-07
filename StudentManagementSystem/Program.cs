using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessLayer;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StudentRegistrationBO bo = new StudentRegistrationBO();
            Console.WriteLine("Enter the Student id ,FirstName, LastName, ContactNumber, CollegeId and CreatedDate");
            bo.Id = Convert.ToInt32(Console.ReadLine());
            bo.FirstName = Console.ReadLine();
            bo.LastName = Console.ReadLine();
            bo.ContactNumber = Convert.ToInt32(Console.ReadLine());
            bo.CollegeId = Convert.ToInt32(Console.ReadLine());
            bo.CreatedDate = Convert.ToDateTime(Console.ReadLine());

            StudentBL bl = new StudentBL();
            int h = bl.AddStudDataBL(bo);
            if (h != 0)
                Console.WriteLine("Successfully Added Student Details");
            else
                Console.WriteLine("Failed to add Student Details");

            Console.ReadKey();*/


            //---Student update----

            /*StudentRegistrationBO bo2 = new StudentRegistrationBO();
            Console.WriteLine("Enter the FirstName, LastName, ContactNumber, CollegeId and CreatedDate");       
            bo2.FirstName = Console.ReadLine();
            bo2.LastName = Console.ReadLine();
            bo2.ContactNumber = Convert.ToInt32(Console.ReadLine());
            bo2.CollegeId = Convert.ToInt32(Console.ReadLine());
            bo2.CreatedDate = Convert.ToDateTime(Console.ReadLine());

            StudentBL bl1 = new StudentBL();
            int g = bl1.UpdateStudBL(bo2);
            if (g != 0)
                Console.WriteLine("Successfully Updated Student Details");
            else
                Console.WriteLine("Failed to Update Student Details");*/

            //-----------------Select Query------------------
            Console.WriteLine("Enter Student ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            StudentBL sbl = new StudentBL();
            DataSet ds = sbl.GetStudentById(Id);
            Console.WriteLine(" Student Details");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5]);
            }
            Console.ReadKey();

            /*Console.WriteLine("Enter Student Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            StudentBL sbl = new StudentBL();
            SqlDataReader dr = sbl.GetStudentById(Id);
           
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + dr[2] + dr[3] + dr[4] + dr[5]);
            }
            Console.ReadKey();*/



            //*******************CourseDeatils*********************************


            /*CoursesBO bo3 = new CoursesBO();
            Console.WriteLine("Enter the CourseId, CourseName, Duration and Description");
            bo3.Id = Convert.ToInt32(Console.ReadLine());
            bo3.Name = Console.ReadLine();
            bo3.Duration = Console.ReadLine();
            bo3.Description = Console.ReadLine();

            CoursesBL blc1 = new BusinessLayer.CoursesBL();
            int c = blc1.CourseDataBL(bo3);
            if (c != 0)
                Console.WriteLine("Successfully added Course Details");
            else
                Console.WriteLine("Failed to add Course Details");*/

            //------Course update----

            /*CoursesBO bo4 = new CoursesBO();
            Console.WriteLine("Enter the CourseId, CourseName, Duration and Description");
            bo4.Id = Convert.ToInt32(Console.ReadLine());
            bo4.Name = Console.ReadLine();
            bo4.Duration = Console.ReadLine();
            bo4.Description = Console.ReadLine();

            CoursesBL blc2 = new BusinessLayer.CoursesBL();
            int c1 = blc2.UpdateCourseDataBL(bo4);
            if (c1 != 0)
                Console.WriteLine("Successfully added Course Details");
            else
                Console.WriteLine("Failed to add Course Details*/

            //*******************CollegeDeatils*********************************

            /*CollegesBO bo5 = new CollegesBO();
            Console.WriteLine("Enter the CollegeId and CollegeName");
            bo5.Id = Convert.ToInt32(Console.ReadLine());
            bo5.Name = Console.ReadLine();

            CollegesBL blcl1 = new BusinessLayer.CollegesBL();
            int cl = blcl1.CollegeDataBL(bo5);
            if (cl != 0)
                Console.WriteLine("Successfully added Course Details");
            else
                Console.WriteLine("Failed to add Course Details");


            CollegesBO bo6 = new CollegesBO();
            Console.WriteLine("Enter the CollegeId and CollegeName");
            bo6.Id = Convert.ToInt32(Console.ReadLine());
            bo6.Name = Console.ReadLine();


            CollegesBL blcl2 = new BusinessLayer.CollegesBL();
            int c2 = blcl2.UpdateCollegeDataBL(bo6);
            if (c2 != 0)
                Console.WriteLine("Successfully added Course Details");
            else
                Console.WriteLine("Failed to add Course Details");*/

            //*******************EnrollmentDeatils*********************************

            /*EnrollmentsBO bo7 = new EnrollmentsBO();
            Console.WriteLine("Enter the Id, StudentId, CourseId and CreatedDate");
            bo7.Id = Convert.ToInt32(Console.ReadLine());
            bo7.StudentId = Convert.ToInt32(Console.ReadLine());
            bo7.CourseId = Convert.ToInt32(Console.ReadLine());
            bo7.CreatedDate = Convert.ToDateTime(Console.ReadLine());

            EnrollmentBL blen1 = new BusinessLayer.EnrollmentBL();
            int e = blen1.AddEnrollmentBL(bo7);
            if (e != 0)
                Console.WriteLine("Successfully Enroll");
            else
                Console.WriteLine("Failed to Enroll");


            EnrollmentsBO bo8 = new EnrollmentsBO();
            Console.WriteLine("Enter the Id, StudentId, CourseId and CreatedDate");
            bo8.Id = Convert.ToInt32(Console.ReadLine());
            bo8.StudentId = Convert.ToInt32(Console.ReadLine());
            bo8.CourseId = Convert.ToInt32(Console.ReadLine());
            bo8.CreatedDate = Convert.ToDateTime(Console.ReadLine());


            EnrollmentBL blen2 = new BusinessLayer.EnrollmentBL();
            int e1 = blen2.UpdateEnrollmentBL(bo8);
            if (e1 != 0)
                Console.WriteLine("Successfully Update Enrollment");
            else
                Console.WriteLine("Failed to Update");*/
        }

    }
}
