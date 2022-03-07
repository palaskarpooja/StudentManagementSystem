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
    public class CourseDurationBL
    {
        public int UpdateCourseDuration(CoursesBO ObjCourseBO1)
        {
            try
            {
                DurationDAL ObjCourse1 = new DurationDAL();
                return ObjCourse1.UpdateCourseDuration(ObjCourseBO1);
            }
            catch
            {
                throw;

            }
        }
    }
}
