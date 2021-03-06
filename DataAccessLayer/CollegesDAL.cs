using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessObject;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class CollegesDAL
    { 
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
    
        public int AddCollegesDetails(CollegesBO ObjCollegeBO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_addColleges", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ObjCollegeBO.Id);
                cmd.Parameters.AddWithValue("@Name", ObjCollegeBO.Name);
               

                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result;
            }

            catch
            {
                throw;
            }
        }

        public int UpdateCollegesInfo(CollegesBO ObjCollegeBO1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateColleges", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ObjCollegeBO1.Id);
                cmd.Parameters.AddWithValue("@Name", ObjCollegeBO1.Name);
          

                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result;
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
                SqlCommand cmd = new SqlCommand("sp_GetCollegesDataById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch
            {
                throw;
            }

        }

    }
}
