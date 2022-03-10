using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class StudentBL
    {
        public int AddStudDataBL(StudentRegistrationBO ObjStudBO)
        {
            try
            {
                StudentDAL ObjStud = new StudentDAL();
                return ObjStud.AddStudDetails(ObjStudBO);
            }
            catch
            {
                throw;

            }
        }

        public int UpdateStudBL(StudentRegistrationBO ObjStudBO1)
        {
            try
            {
                StudentDAL ObjStud1 = new StudentDAL();
                return ObjStud1.UpdateStudInfo(ObjStudBO1);
            }
            catch
            {
                throw;
            }
        }

        
        public DataSet GetStudentById(int Id)
        {
            try
            {
                StudentDAL ObjStud3 = new StudentDAL();
                DataSet dr1 = ObjStud3.GetStudentById(Id);
                return dr1;

            }
            catch
            {
                throw;
            }

            //----------------------------------------------------------------------------


        }

        public DataSet ViewStudentById(int StudentId)
        {
            try
            {
                StudentDAL ObjStud3 = new StudentDAL();
                DataSet dr1 = ObjStud3.ViewStudentById(StudentId);
                return dr1;

            }
            catch
            {
                throw;
            }

        }
    }
}
