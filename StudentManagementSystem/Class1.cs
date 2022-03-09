/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Class1
    {
        *//*Console.WriteLine("1. Manage Student Details \n 2. Manages Courses \n 3.Manage Enrollments \n 4.Back");
                        bool isEnd3 = false;
                        while (!isEnd3)
                        int s1 = Convert.ToInt32(Console.ReadLine());*//*
    }
}*/

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
    class Program1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Are You Faculty or Student");
            Console.WriteLine("1.Faculty 2.Student 3.Exit");
            int n = Convert.ToInt32(Console.ReadLine());


            switch (n)
            {
                case 1:
                    Console.WriteLine("Faculty");
                    bool isEnd = false;
                    while (!isEnd)
                    {
                        Console.WriteLine("1.Add Student Details \n 2. View Student Deatils \n 3.Manage Student Details \n 4.Add Course Details \n " +
                                        "5.Manage Course Details \n 6.Add Enrollments Details \n 7.Manage Enrollments Details " +
                                        "\n 8.Add College Details \n 9.Manage College Details \n 10.Add Course Duration Details");

                        Console.WriteLine("\n******************************************\n");
                        int n1 = Convert.ToInt32(Console.ReadLine());


                        switch (n1)
                        {
                            case 1:
                                Console.WriteLine("Add New Student Details");
                                StudentRegistrationBO bo = new StudentRegistrationBO();
                                Console.WriteLine("Enter the Student id ,FirstName, LastName, ContactNumber, CollegeId and CreatedDate");
                                bo.Id = Convert.ToInt32(Console.ReadLine());
                                bo.FirstName = Console.ReadLine();
                                bo.LastName = Console.ReadLine();
                                bo.ContactNumber = Convert.ToInt64(Console.ReadLine());
                                bo.CollegeId = Convert.ToInt32(Console.ReadLine());
                                bo.CreatedDate = Convert.ToDateTime(Console.ReadLine());

                                StudentBL bl = new StudentBL();
                                int h = bl.AddStudDataBL(bo);
                                if (h != 0)
                                    Console.WriteLine("Successfully Added Student Details");
                                else
                                    Console.WriteLine("Failed to add Student Details");

                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 2:

                                Console.WriteLine("Enter Student ID");
                                int Id = Convert.ToInt32(Console.ReadLine());
                                StudentBL sbl = new StudentBL();
                                DataSet ds = sbl.GetStudentById(Id);
                                Console.WriteLine(" Student Details");
                                Console.WriteLine("ID \t FirstName \t LastName \t ContactNo. \t CollegeId \t CreatedDate");
                                foreach (DataRow dr in ds.Tables[0].Rows)
                                {
                                    Console.WriteLine(dr[0] + "\t" + dr[1] + "\t\t" + dr[2] + "\t\t" + dr[3] + "\t" + dr[4] + "\t\t" + dr[5]);
                                }
                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 3:
                                Console.WriteLine("Edit Student Details");
                                Console.WriteLine("Enter Student ID");
                                int StudentId = Convert.ToInt32(Console.ReadLine());
                                StudentBL sbl1 = new StudentBL();
                                DataSet ds3 = sbl1.GetStudentById(StudentId);
                                Console.WriteLine(" Student Details");
                                Console.WriteLine("ID \t FirstName \t LastName \t ContactNo. \t CollegeId \t CreatedDate");
                                foreach (DataRow dr in ds3.Tables[0].Rows)
                                {
                                    Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5]);
                                }
                                StudentRegistrationBO bo2 = new StudentRegistrationBO();
                                Console.WriteLine("Edit the FirstName, LastName, ContactNumber, CollegeId and CreatedDate");
                                bo2.Id = Convert.ToInt32(Console.ReadLine());
                                bo2.FirstName = Console.ReadLine();
                                bo2.LastName = Console.ReadLine();
                                bo2.ContactNumber = Convert.ToInt32(Console.ReadLine());
                                bo2.CollegeId = Convert.ToInt32(Console.ReadLine());
                                bo2.CreatedDate = Convert.ToDateTime(Console.ReadLine());

                                int g = sbl1.UpdateStudBL(bo2);
                                if (g != 0)
                                    Console.WriteLine("Successfully Updated Student Details");
                                else
                                    Console.WriteLine("Failed to Update Student Details");

                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 4:
                                Console.WriteLine("Add Course Details");
                                CoursesBO bo3 = new CoursesBO();
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
                                    Console.WriteLine("Failed to add Course Details");
                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 5:
                                Console.WriteLine("Edit Course Details");
                                {
                                    Console.WriteLine("Enter Course ID");
                                    int CourseId = Convert.ToInt32(Console.ReadLine());
                                    CoursesBL cbl1 = new CoursesBL();
                                    DataSet ds1 = cbl1.GetCoursesById(CourseId);
                                    Console.WriteLine(" College Details");
                                    foreach (DataRow dr in ds1.Tables[0].Rows)
                                    {
                                        Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
                                    }
                                    CoursesBO bo4 = new CoursesBO();
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
                                        Console.WriteLine("Failed to add Course Details");
                                }
                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 6:
                                Console.WriteLine("Add Enrollments Details");
                                EnrollmentsBO bo7 = new EnrollmentsBO();
                                Console.WriteLine("Enter the Id, StudentId, CourseId and CreatedDate");
                                bo7.Id = Convert.ToInt32(Console.ReadLine());
                                bo7.StudentId = Convert.ToInt32(Console.ReadLine());
                                bo7.CourseId = Convert.ToInt32(Console.ReadLine());
                                bo7.CreatedDate = Convert.ToDateTime(Console.ReadLine());

                                EnrollmentBL blen1 = new BusinessLayer.EnrollmentBL();
                                int e = blen1.AddEnrollmentBL(bo7);
                                if (e != 0)
                                    Console.WriteLine("Successfully Enrolled");
                                else
                                    Console.WriteLine("Failed to Enroll");
                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 7:
                                Console.WriteLine("Edit Enrollments Details");
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
                                    Console.WriteLine("Failed to Update");
                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 8:
                                Console.WriteLine("Add College Details");
                                CollegesBO bo5 = new CollegesBO();
                                Console.WriteLine("Enter the CollegeId and CollegeName");
                                bo5.Id = Convert.ToInt32(Console.ReadLine());
                                bo5.Name = Console.ReadLine();

                                CollegesBL blcl1 = new BusinessLayer.CollegesBL();
                                int cl = blcl1.CollegeDataBL(bo5);
                                if (cl != 0)
                                    Console.WriteLine("Successfully added Course Details");
                                else
                                    Console.WriteLine("Failed to add Course Details");
                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 9:
                                Console.WriteLine("Manage College Deatils");
                                Console.WriteLine("Enter College ID");
                                int CollegeId = Convert.ToInt32(Console.ReadLine());
                                CollegesBL cbl = new CollegesBL();
                                DataSet ds2 = cbl.GetCollegesById(CollegeId);
                                Console.WriteLine(" College Details");
                                foreach (DataRow dr in ds2.Tables[0].Rows)
                                {
                                    Console.WriteLine(dr[0] + "\t" + dr[1]);
                                }
                                CollegesBO bo6 = new CollegesBO();
                                Console.WriteLine("Enter the CollegeId and CollegeName");
                                bo6.Id = Convert.ToInt32(Console.ReadLine());
                                bo6.Name = Console.ReadLine();
                                CollegesBL blcl2 = new BusinessLayer.CollegesBL();
                                int c2 = blcl2.UpdateCollegeDataBL(bo6);
                                if (c2 != 0)
                                    Console.WriteLine("Successfully Updated Course Details");
                                else
                                    Console.WriteLine("Failed to Update Course Details");
                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 10:
                                Console.WriteLine("Add Course Duration Deatils");
                                {
                                    Console.WriteLine("Enter Course ID");
                                    int CourseId = Convert.ToInt32(Console.ReadLine());
                                    CoursesBL cbl1 = new CoursesBL();
                                    DataSet ds4 = cbl1.GetCoursesById(CourseId);
                                    Console.WriteLine(" Course Details");
                                    foreach (DataRow dr in ds4.Tables[0].Rows)
                                    {
                                        Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
                                    }
                                }
                                Console.WriteLine("\n******************************************\n");
                                break;
                        }
                    }

                    break;

                case 2:
                    Console.WriteLine("Student");
                    bool isEnd1 = false;
                    while (!isEnd1)
                    {
                        Console.WriteLine("1. Registration \n 2.Edit Details");
                        int n2 = Convert.ToInt32(Console.ReadLine());


                        switch (n2)
                        {
                            case 1:
                                Console.WriteLine("Register");
                                StudentRegistrationBO bo = new StudentRegistrationBO();
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


                                Console.WriteLine("\n******************************************\n");
                                break;

                            case 2:
                                Console.WriteLine("Edit Deatils");
                                Console.WriteLine("Enter Student ID");
                                int Id = Convert.ToInt32(Console.ReadLine());
                                StudentBL sbl = new StudentBL();
                                DataSet ds = sbl.GetStudentById(Id);
                                Console.WriteLine(" Student Details");
                                Console.WriteLine("ID \t FirstName \t LastName \t ContactNo. \t CollegeId \t CreatedDate");
                                foreach (DataRow dr in ds.Tables[0].Rows)
                                {
                                    Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + dr[5]);
                                }
                                StudentRegistrationBO bo2 = new StudentRegistrationBO();
                                Console.WriteLine("Edit the FirstName, LastName, ContactNumber, CollegeId and CreatedDate");
                                bo2.Id = Convert.ToInt32(Console.ReadLine());
                                bo2.FirstName = Console.ReadLine();
                                bo2.LastName = Console.ReadLine();
                                bo2.ContactNumber = Convert.ToInt32(Console.ReadLine());
                                bo2.CollegeId = Convert.ToInt32(Console.ReadLine());
                                bo2.CreatedDate = Convert.ToDateTime(Console.ReadLine());

                                int g = sbl.UpdateStudBL(bo2);
                                if (g != 0)
                                    Console.WriteLine("Successfully Updated Student Details");
                                else
                                    Console.WriteLine("Failed to Update Student Details");
                                Console.WriteLine("\n******************************************\n");
                                break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Exit");
                    break;

            }

            Console.ReadKey();
            //---------------------------

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


            //----------------Student update query------------------

            /*Console.WriteLine("Enter Student ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            StudentBL sbl = new StudentBL();
            DataSet ds = sbl.GetStudentById(Id);
            Console.WriteLine(" Student Details");
            Console.WriteLine("ID \t FirstName \t LastName \t ContactNo. \t CollegeId \t CreatedDate");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5]);
            }
            StudentRegistrationBO bo2 = new StudentRegistrationBO();
            Console.WriteLine("Edit the FirstName, LastName, ContactNumber, CollegeId and CreatedDate");
            bo2.Id = Convert.ToInt32(Console.ReadLine());
            bo2.FirstName = Console.ReadLine();
            bo2.LastName = Console.ReadLine();
            bo2.ContactNumber = Convert.ToInt32(Console.ReadLine());
            bo2.CollegeId = Convert.ToInt32(Console.ReadLine());
            bo2.CreatedDate = Convert.ToDateTime(Console.ReadLine());

            int g = sbl.UpdateStudBL(bo2);
            if (g != 0)
                Console.WriteLine("Successfully Updated Student Details");
            else
                Console.WriteLine("Failed to Update Student Details");
            
            Console.ReadKey();*/

            //-------------------Delete Student-----------------


            /*Console.WriteLine("Enter the department id:");
            int Id = Convert.ToInt32(Console.ReadLine());
            StudentBL sbl = new StudentBL();*/


            //-----------------Student Select Query------------------

            /*Console.WriteLine("Enter Student ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            StudentBL sbl = new StudentBL();
            DataSet ds = sbl.GetStudentById(Id);
            Console.WriteLine(" Student Details");
            Console.WriteLine("ID \t FirstName \t LastName \t ContactNo. \t CollegeId \t CreatedDate");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t\t" + dr[2] + "\t\t" + dr[3] + "\t" + dr[4] + "\t\t" + dr[5]);
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

            //----------------------Course update-----------------

            /*Console.WriteLine("Enter Course ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            CoursesBL cbl = new CoursesBL();
            DataSet ds = cbl.GetCoursesById(Id);
            Console.WriteLine(" College Details");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
            }
            CoursesBO bo4 = new CoursesBO();
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

            //-------------------Course Select Query-------------------

            /*Console.WriteLine("Enter Course ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            CoursesBL cbl = new CoursesBL();
            DataSet ds = cbl.GetCoursesById(Id);
            Console.WriteLine(" College Details");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
            }
            Console.ReadKey();*/

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

            //-------------------College Update Query------------------

            Console.WriteLine("Enter College ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            CollegesBL cbl = new CollegesBL();
            DataSet ds = cbl.GetCollegesById(Id);
            Console.WriteLine(" Course Details");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1]);
            }
            CollegesBO bo6 = new CollegesBO();
            Console.WriteLine("Enter the CollegeId and CollegeName");
            bo6.Id = Convert.ToInt32(Console.ReadLine());
            bo6.Name = Console.ReadLine();
            CollegesBL blcl2 = new BusinessLayer.CollegesBL();
            int c2 = blcl2.UpdateCollegeDataBL(bo6);
            if (c2 != 0)
                Console.WriteLine("Successfully Updated Course Details");
            else
                Console.WriteLine("Failed to Update Course Details");*/

            //-------------------College Select Query------------------

            /*Console.WriteLine("Enter College ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            CollegesBL cbl = new CollegesBL();
            DataSet ds = cbl.GetCollegesById(Id);
            Console.WriteLine(" Course Details");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1]);
            }
            Console.ReadKey();*/

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

            //----------------Enrollment Update Query----------------

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

            //----------------Enrollment Select Query----------------

            /*Console.WriteLine("Enter Enrollment Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            EnrollmentBL cbl = new EnrollmentBL();
            DataSet ds = cbl.GetEnrollmentsById(Id);
            Console.WriteLine(" Enrollment Details");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
            }
            Console.ReadKey();*/

            //*********************Duration***********************************


        }

    }
}


/*/*Console.WriteLine("Edit Deatils");
                                                    Console.WriteLine("Enter Student ID");
                                                    int Id = Convert.ToInt32(Console.ReadLine());
                                                    StudentBL sbl = new StudentBL();
                                                    DataSet ds = sbl.GetStudentById(Id);
                                                    Console.WriteLine(" Student Details");
                                                    Console.WriteLine("ID \t FirstName \t LastName \t ContactNo.  \t College Id \t CreatedDate");
                                                    foreach (DataRow dr in ds.Tables[0].Rows)
                                                    {
                                                        Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5] );
                                                    }
                                                    StudentRegistrationBO bo2 = new StudentRegistrationBO();
                                                    Console.WriteLine("Edit the FirstName, LastName, ContactNumber, College Id and CreatedDate");
                                                    bo2.Id = Convert.ToInt32(Console.ReadLine());
                                                    bo2.FirstName = Console.ReadLine();
                                                    bo2.LastName = Console.ReadLine();
                                                    bo2.ContactNumber = Convert.ToInt64(Console.ReadLine());
                                                    bo2.CollegeId = Convert.ToInt32(Console.ReadLine());
                                                    bo2.CreatedDate = Convert.ToDateTime(Console.ReadLine());

                                                    int g = sbl.UpdateStudBL(bo2);
                                                    if (g != 0)
                                                        Console.WriteLine("Successfully Updated Student Details");
                                                    else
                                                        Console.WriteLine("Failed to Update Student Details");
                                                    Console.WriteLine("\n******************************************\n");*/
