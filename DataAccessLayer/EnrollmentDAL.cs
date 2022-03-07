﻿using System;
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
    public class EnrollmentDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());

        public int AddEnrollment(EnrollmentsBO ObjEnBO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_addEnrollments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ObjEnBO.Id);
                cmd.Parameters.AddWithValue("@StudentId", ObjEnBO.StudentId);
                cmd.Parameters.AddWithValue("@CourseId", ObjEnBO.CourseId);
                cmd.Parameters.AddWithValue("@CreatedDate", ObjEnBO.CreatedDate);


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

        public int UpdateEnrollment(EnrollmentsBO ObjEnBO1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateEnrollments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ObjEnBO1.Id);
                cmd.Parameters.AddWithValue("@StudentId", ObjEnBO1.StudentId);
                cmd.Parameters.AddWithValue("@CourseId", ObjEnBO1.CourseId);
                cmd.Parameters.AddWithValue("@CreatedDate", ObjEnBO1.CreatedDate);


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

        public int GetEnrollment(EnrollmentsBO ObjEnBO2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_enrollments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader Result = cmd.ExecuteReader();
                cmd.Dispose();
                con.Close();
                return (Int32)cmd.ExecuteScalar();

            }
            catch
            {
                throw;
            }

        }
    }
}
