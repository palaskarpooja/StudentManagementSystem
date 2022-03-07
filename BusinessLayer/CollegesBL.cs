using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

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
    }
}
