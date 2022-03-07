using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DurationDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
        public int UpdateCourseDuration(CoursesBO ObjC2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_AddDuration", con);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@Name", ObjC2.Name);
                cmd.Parameters.AddWithValue("@Duration", ObjC2.Duration);

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
    }
}
