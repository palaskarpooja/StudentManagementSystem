using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessObject;
using System.Data;
using System.Text.RegularExpressions;
using ExceptionLayer;

namespace DataAccessLayer
{
    public class StudentDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());

        public int AddStudDetails(StudentRegistrationBO ObjBO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_addStudentDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ObjBO.Id);
                cmd.Parameters.AddWithValue("@FirstName", ObjBO.FirstName);
                cmd.Parameters.AddWithValue("@LastName", ObjBO.LastName);
                cmd.Parameters.AddWithValue("@ContactNumber", ObjBO.ContactNumber);
                /* Regex r = new Regex(@"^(\+[0-9]{9})$");
                 if (!r.IsMatch(ObjBO.ContactNumber.ToString()))
                 {
                     throw new InvalidMobileException("Please enter 10 digit mobile number");
                 }*/
                /*if (ObjBO.ContactNumber != 10)
                {
                    throw new InvalidMobileException("Please enter 10 digit mobile number");
                }*/
                cmd.Parameters.AddWithValue("@CollegeId", ObjBO.CollegeId);
                cmd.Parameters.AddWithValue("@CreatedDate", ObjBO.CreatedDate);

                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result;
            }

            catch//(InvalidMobileException i)
            {
                /* return (i.Message);*/
                throw;
            }
        }



        public int UpdateStudInfo(StudentRegistrationBO ObjBO1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateStudentDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ObjBO1.Id);
                cmd.Parameters.AddWithValue("@FirstName", ObjBO1.FirstName);
                cmd.Parameters.AddWithValue("@LastName", ObjBO1.LastName);
                cmd.Parameters.AddWithValue("@ContactNumber", ObjBO1.ContactNumber);
                cmd.Parameters.AddWithValue("@CollegeId", ObjBO1.CollegeId);
                cmd.Parameters.AddWithValue("@CreatedDate", ObjBO1.CreatedDate);

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

      

        public DataSet GetStudentById(int Id)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetStudentDataById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    throw new DataNotFoundException("Give valid Student Id");
                }
                return ds;

            }
            catch
            {
                throw;
            }
        }

        public DataSet ViewStudentById(int StudentId)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ViewStudentDetailsById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", StudentId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    throw new DataNotFoundException("Give valid Student Id");
                }
                return ds;

            }
            catch
            {
                throw;
            }
        }


    }


}


