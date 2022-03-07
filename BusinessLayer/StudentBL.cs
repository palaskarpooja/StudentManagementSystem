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
                StudentDAL ObjStud2 = new StudentDAL();
                DataSet dr1 = ObjStud2.GetStudentById(Id);
                return dr1;
                
            }
            catch
            {
                throw;
            }

        }

        //----------------------------------------------------------------------------


    }
}
