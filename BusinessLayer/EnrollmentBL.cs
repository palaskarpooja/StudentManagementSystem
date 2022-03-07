using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class EnrollmentBL
    {
        public int AddEnrollmentBL(EnrollmentsBO ObjEnBO1)
        {
            try
            {
                EnrollmentDAL ObjEn = new EnrollmentDAL();
                return ObjEn.AddEnrollment(ObjEnBO1);
            }
            catch
            {
                throw;

            }
        }

        public int UpdateEnrollmentBL(EnrollmentsBO ObjEnBO2)
        {
            try
            {
                EnrollmentDAL ObjEn1 = new EnrollmentDAL();
                return ObjEn1.UpdateEnrollment(ObjEnBO2);
            }
            catch
            {
                throw;

            }
        }

        public DataSet GetEnrollmentsById(int Id)
        {
            try
            {
                EnrollmentDAL ObjStud2 = new EnrollmentDAL();
                DataSet dr1 = ObjStud2.GetEnrollmentsById(Id);
                return dr1;

            }
            catch
            {
                throw;
            }

        }
    }
}
