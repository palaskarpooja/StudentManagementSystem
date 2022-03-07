﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace BusinessLayer
{
    public class CoursesBL
    {
        public int CourseDataBL(CoursesBO ObjCourseBO)
        {
            try
            {
                CoursesDAL ObjCourse = new CoursesDAL();
                return ObjCourse.AddCourseDetails(ObjCourseBO);
            }
            catch
            {
                throw;

            }
        }

        public int UpdateCourseDataBL(CoursesBO ObjCourseBO1)
        {
            try
            {
                CoursesDAL ObjCourse1 = new CoursesDAL();
                return ObjCourse1.AddCourseDetails(ObjCourseBO1);
            }
            catch
            {
                throw;

            }
        }

    }
}
