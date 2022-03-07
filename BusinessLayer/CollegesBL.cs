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
    public class CollegesBL
    {
        public int CollegeDataBL(CollegesBO ObjCollegeBO)
        {
            try
            {
                CollegesDAL ObjCollege = new CollegesDAL();
                return ObjCollege.AddCollegesDetails(ObjCollegeBO);
            }
            catch
            {
                throw;

            }
        }

        public int UpdateCollegeDataBL(CollegesBO ObjCollegeBO1)
        {
            try
            {
                CollegesDAL ObjCollege1 = new CollegesDAL();
                return ObjCollege1.UpdateCollegesInfo(ObjCollegeBO1);
            }
            catch
            {
                throw;

            }
        }
        public DataSet GetCollegesById(int Id)
        {
            try
            {
                CollegesDAL ObjStud2 = new CollegesDAL();
                DataSet dr1 = ObjStud2.GetCollegesById(Id);
                return dr1;

            }
            catch
            {
                throw;
            }

        }

    }
}
