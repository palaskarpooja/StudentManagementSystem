using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessObject;
using System.Data;
using System.Configuration;
using ExceptionLayer;

namespace DataAccessLayer
{
    public class CoursesDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
        public int AddCourseDetails(CoursesBO ObjC1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_addCourses1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ObjC1.Id);
                cmd.Parameters.AddWithValue("@Name", ObjC1.Name);
                cmd.Parameters.AddWithValue("@Duration", ObjC1.Duration);
                cmd.Parameters.AddWithValue("@Description", ObjC1.Description);

                con.Open();
                int Result1 = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result1;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateCourseDetail(CoursesBO ObjC2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateCourses1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ObjC2.Id);
                cmd.Parameters.AddWithValue("@Name", ObjC2.Name);
                cmd.Parameters.AddWithValue("@Duration", ObjC2.Duration);
                cmd.Parameters.AddWithValue("@Description", ObjC2.Description);

                con.Open();
                int Result2 = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result2;
            }
            catch
            {
                throw;
            }
        }

        public DataSet MyCourses(int Id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetCoursesById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    throw new DataNotFoundException("Give valid Course Id");
                }
                return ds;

            }
            catch
            {
                throw;
            }
        }

        public DataSet GetMyCourses(int StudentId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_MyCourses", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", StudentId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    throw new DataNotFoundException("Give valid Course Id");
                }
                return ds;
            }
            catch
            {
                throw;
            }

           
        }

        public DataSet ListOfCourses(CoursesBO objlist)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ListOfCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                return ds1;
            }
            catch
            {
                throw;
            }
        }

    }
}
