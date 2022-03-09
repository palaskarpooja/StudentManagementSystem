using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using ExceptionLayer;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\t\t\t\t\tWelcome to Student Management System\n");
                bool isEnd = false;
                while (!isEnd)
                {
                    Console.WriteLine("Are You Faculty or Student?\n");
                    
                    Console.WriteLine("1.Faculty 2.Student 3.Exit");
                    Console.WriteLine("\n******************************************\n");
                    int n = Convert.ToInt32(Console.ReadLine());
                
                    switch (n)
                    {
                        case 1:
                            bool isEnd1 = false;
                            while (!isEnd1)
                            {
                                Console.WriteLine("1. Manage Student Details \n 2. Manages Courses \n 3.Manage Enrollments \n 4.Manage College \n 5.Back");
                                Console.WriteLine("\n******************************************\n");
                                int n1 = Convert.ToInt32(Console.ReadLine());                            
                                switch (n1)
                                {
                                    case 1:
                                        bool isEnd2 = false;
                                        while (!isEnd2)
                                        {
                                            Console.WriteLine("1. Add New Student \n 2. Edit \n 3.View \n 4.Back");
                                            Console.WriteLine("\n******************************************\n");
                                            int n2 = Convert.ToInt32(Console.ReadLine());
                                        
                                            switch (n2)
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
                                                    bo2.ContactNumber = Convert.ToInt64(Console.ReadLine());
                                                    bo2.CollegeId = Convert.ToInt32(Console.ReadLine());
                                                    bo2.CreatedDate = Convert.ToDateTime(Console.ReadLine());

                                                    int g = sbl1.UpdateStudBL(bo2);
                                                    if (g != 0)
                                                        Console.WriteLine("Successfully Updated Student Details");
                                                    else
                                                        Console.WriteLine("Failed to Update Student Details");

                                                    Console.WriteLine("\n******************************************\n");
                                                    break;

                                                case 3:
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

                                                case 4:
                                                    isEnd2 = true;
                                                    break;
                                            }
                                           

                                        }
                                        break;

                                    //_------------------------Courses---------------------------------

                                    case 2:
                                        bool isEnd3 = false;
                                        while (!isEnd3)
                                        {
                                            Console.WriteLine("1. Add New Courses \n 2. View \n 3.Edit \n 4.Back");

                                            Console.WriteLine("\n******************************************\n");

                                            int n3 = Convert.ToInt32(Console.ReadLine());
                                        
                                            switch (n3)
                                            {
                                                case 1:
                                                    Console.WriteLine("Add Course");
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

                                                case 2:
                                                    CoursesBO cbo = new CoursesBO();
                                                    CoursesBL cbl = new CoursesBL();
                                                    DataSet ds1 = cbl.ListofCourses(cbo);
                                                    Console.WriteLine("List Of Courses");
                                                    foreach (DataRow dr in ds1.Tables[0].Rows)
                                                    {
                                                        Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
                                                    }
                                                    Console.ReadKey();
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Edit ");
                                                    {
                                                        Console.WriteLine("Enter Course ID");
                                                        int CourseId = Convert.ToInt32(Console.ReadLine());
                                                        CoursesBL cbl1 = new CoursesBL();
                                                        DataSet ds3 = cbl1.GetCoursesById(CourseId);
                                                        Console.WriteLine(" Course Details");
                                                        Console.WriteLine("ID \t CourseName \t Duration \t Description");
                                                        foreach (DataRow dr in ds3.Tables[0].Rows)
                                                        {
                                                            Console.WriteLine(dr[0] + "\t" + dr[1] + "\t\t" + dr[2] + "\t" + dr[3]);
                                                        }
                                                        CoursesBO bo4 = new CoursesBO();
                                                        Console.WriteLine("Enter the CourseId, CourseName, Duration and Description");
                                                        bo4.Id = Convert.ToInt32(Console.ReadLine());
                                                        bo4.Name = Console.ReadLine();
                                                        bo4.Duration = Console.ReadLine();
                                                        bo4.Description = Console.ReadLine();

                                                        CoursesBL blc2 = new BusinessLayer.CoursesBL();
                                                        int cd1 = blc2.UpdateCourseDataBL(bo4);
                                                        if (cd1 != 0)
                                                            Console.WriteLine("Successfully update Course Details");
                                                        else
                                                            Console.WriteLine("Failed to update Course Details");
                                                    }
                                                    Console.WriteLine("\n******************************************\n");
                                                    break;

                                                case 4:
                                                    isEnd3 = true;
                                                    break;
                                            }
                                            
                                        }
                                        break;

                                    //_------------------------Enrollment---------------------------------

                                    case 3:
                                        bool isEnd4 = false;
                                        while (!isEnd4)
                                        {
                                            Console.WriteLine("1. Add New enrollment \n 2. View \n 3.Back");

                                        Console.WriteLine("\n******************************************\n");

                                        int n4 = Convert.ToInt32(Console.ReadLine());
                                        
                                            switch (n4)
                                            {
                                                case 1:
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

                                                case 2:
                                                    EnrollmentsBO ebo = new EnrollmentsBO();
                                                    EnrollmentBL ebl = new EnrollmentBL();
                                                    DataSet ds1 = ebl.ViewEnrollment(ebo);
                                                    Console.WriteLine("Course Enrollment Details of Student");
                                                    Console.WriteLine("----------------------------------------------");
                                                    Console.WriteLine("FirstName | LastName | CourseName | Duration | Description | CreatedDate");
                                                    foreach (DataRow dr in ds1.Tables[0].Rows)
                                                    {
                                                       /* for (int i = 0; i <= 5; i++)
                                                        {
                                                            Console.Write(dr[i] + "   ");
                                                        }*/
                                                        
                                                        Console.WriteLine(dr[0] + "\t" + dr[1] + "    " + dr[2] + "  " + dr[3] + "   " + dr[4] + "  " + dr[5]);
                                                    }
                                                    Console.WriteLine("\n******************************************\n");
                                                    break;

                                                /*case 3:
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
                                                    break;*/

                                                case 3:
                                                    isEnd4 = true;
                                                    break;                                                                                                 
                                            }
                                        }
                                        break;

                                        //-------------------------Colleges--------------------

                                    case 4:
                                        bool isEnd6 = false;
                                        while (!isEnd6)
                                        {
                                            Console.WriteLine("1. Manage Colleges \n 2.View Colleges \n 3.Back");

                                            Console.WriteLine("\n******************************************\n");
                                            int c1 = Convert.ToInt32(Console.ReadLine());
                                        
                                            switch(c1)
                                            {
                                                case 1:
                                                    CollegesBO bo5 = new CollegesBO();
                                                    Console.WriteLine("Enter the CollegeId and CollegeName");
                                                    bo5.Id = Convert.ToInt32(Console.ReadLine());
                                                    bo5.Name = Console.ReadLine();

                                                    CollegesBL blcl1 = new BusinessLayer.CollegesBL();
                                                    int cl = blcl1.CollegeDataBL(bo5);
                                                    if (cl != 0)
                                                        Console.WriteLine("Successfully add College Details");
                                                    else
                                                        Console.WriteLine("Failed to add College Deatils ");
                                                    break;

                                                case 2:
                                                    Console.WriteLine("Enter College ID");
                                                    int Id = Convert.ToInt32(Console.ReadLine());
                                                    CollegesBL cbl = new CollegesBL();
                                                    DataSet ds = cbl.GetCollegesById(Id);
                                                    Console.WriteLine(" Colleges Details");
                                                    foreach (DataRow dr in ds.Tables[0].Rows)
                                                    {
                                                        Console.WriteLine(dr[0] + "\t" + dr[1]);
                                                    }

                                                    Console.WriteLine("\n---------------------------------------\n");

                                                    break;

                                                    

                                                case 3:
                                                    isEnd6 = true;
                                                    break;                                
                                            }
                                        }
                                        break;

                                    case 5:
                                        isEnd1 = true;
                                        break;
                                }
                            }
                            break;

                            //---------------------Student----------------------------

                        case 2:
                            bool isEnd5 = false;
                            while (!isEnd5)
                            {
                                Console.WriteLine("1. Manage Student Details \n 2. My Courses \n 3.List Of Courses \n 4.Back");

                                Console.WriteLine("\n******************************************\n");

                                int s1 = Convert.ToInt32(Console.ReadLine());
                            
                                switch (s1)
                                {
                                    case 1:
                                        bool isEnd6 = false;
                                        while (!isEnd6)
                                        {
                                            Console.WriteLine("1. Register \n 2. View \n 3.Edit \n 4.Back");

                                            Console.WriteLine("\n******************************************\n");

                                        int s2 = Convert.ToInt32(Console.ReadLine());
                                        
                                            switch (s2)
                                            {
                                                case 1:
                                                    Console.WriteLine("Register");
                                                    StudentRegistrationBO bo = new StudentRegistrationBO();
                                                    Console.WriteLine("Enter the Student id ,FirstName, LastName, ContactNumber, CollegeId and CreatedDate");
                                                    bo.Id = Convert.ToInt32(Console.ReadLine());
                                                    bo.FirstName = Console.ReadLine();
                                                    bo.LastName = Console.ReadLine();
                                                    bo.ContactNumber = Convert.ToInt64(Console.ReadLine());
                                                    /*Regex r = new Regex(@"^(\+[0-9]{9})$");
                                                    if (!r.IsMatch(bo.ContactNumber.ToString()))
                                                    {
                                                        throw new InvalidMobileException("Please enter 10 digit mobile number");
                                                    }*/
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
                                                    int StudentId1 = Convert.ToInt32(Console.ReadLine());
                                                    StudentBL sbl1 = new StudentBL();
                                                    DataSet ds3 = sbl1.ViewStudentById(StudentId1);
                                                    Console.WriteLine(" Student Details");
                                                    Console.WriteLine("ID \t FirstName \t LastName \t ContactNo. \t CreatedDate \t\t CollegeName");
                                                    foreach (DataRow dr in ds3.Tables[0].Rows)
                                                    {
                                                        Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5]);
                                                    }
                                                    break;

                                                case 3:
                                                    Console.WriteLine("Edit Student Details");
                                                    Console.WriteLine("Enter Student ID");
                                                    int Id = Convert.ToInt32(Console.ReadLine());
                                                    StudentBL sbl = new StudentBL();
                                                    DataSet  ds= sbl.GetStudentById(Id);
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
                                                    bo2.ContactNumber = Convert.ToInt64(Console.ReadLine());
                                                    bo2.CollegeId = Convert.ToInt32(Console.ReadLine());
                                                    bo2.CreatedDate = Convert.ToDateTime(Console.ReadLine());

                                                    int g = sbl.UpdateStudBL(bo2);
                                                    if (g != 0)
                                                        Console.WriteLine("Successfully Updated Student Details");
                                                    else
                                                        Console.WriteLine("Failed to Update Student Details");

                                                    Console.WriteLine("\n******************************************\n");
                                                  
                                                    break;

                                                case 4:
                                                    isEnd6 = true;
                                                    break;
                                            }
                                        }
                                        break;

                                    case 2:

                                        Console.WriteLine("Enter your student id to view course deatils");
                                        int StudentId = Convert.ToInt32(Console.ReadLine());
                                        CoursesBL cbl = new CoursesBL();
                                        DataSet ds1 = cbl.GetMyCoursesById(StudentId);
                                        Console.WriteLine("My Courses");
                                        Console.WriteLine("-------------------");
                                       Console.WriteLine("ID \t CourseName");
                                        foreach (DataRow dr in ds1.Tables[0].Rows)
                                        {
                                            Console.WriteLine(dr[0] + "\t" + dr[1]);
                                        }
                                        Console.ReadKey();
                                        break;

                                    case 3:
                                        CoursesBO cbo1 = new CoursesBO();
                                        CoursesBL cbl1 = new CoursesBL();
                                        DataSet ds2 = cbl1.ListofCourses(cbo1);
                                        Console.WriteLine("List Of Courses");
                                        foreach (DataRow dr in ds2.Tables[0].Rows)
                                        {
                                            Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
                                        }
                                        Console.ReadKey();
                                        break;

                                    

                                }
                                break;

                            }
                            break;

                        case 3:                           
                            isEnd = true;
                            break;

                    }

                }
            }

            catch (Exception e)
            {
                Console.Write(e.Message);
            }


            Console.ReadLine();
        }

    }
}


