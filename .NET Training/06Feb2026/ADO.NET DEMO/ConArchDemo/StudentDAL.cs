using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For ado.net
using System.Data.SqlClient;
using System.Data;

namespace ConArchDemo
{
    /// <summary>
    /// Demo code for connected architecture in SudentDAL class
    /// </summary>
    internal class StudentDAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAL()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\Sqlexpress;Integrated Security=SSPI;Database=LPU_DB;TrustServerCertificate=true";
        }

        public List<Student> ShowAllStudents()
        {
            List<Student> studList = null;

            // Code for connected arch below
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                //holding data via reader
                sdr = cmd.ExecuteReader();

                DataTable myDt = new DataTable();
                myDt.Load(sdr);

                // convert table into list
                if (myDt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }
                foreach(DataRow drow in myDt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[3].ToString(),
                        PhoneNo = drow[5].ToString()
                    };
                    if(sObj != null)
                    {
                        studList.Add(sObj);
                    }

                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }


            return studList;
        }

        public List<Student> SearchByName(string name)
        {
            List<Student> studList = null;
            SqlParameter nameParam = new SqlParameter("@Name", name);

            // Code for connected arch below
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo where Name =@Name";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                // Adding Params to command
                cmd.Parameters.Add(nameParam);


                //holding data via reader
                sdr = cmd.ExecuteReader();

                DataTable myDt = new DataTable();
                myDt.Load(sdr);

                // convert table into list
                if (myDt.Rows.Count > 0)
                {
                    studList = new List<Student>();
                }
                foreach (DataRow drow in myDt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(drow[0].ToString()),
                        Name = drow[1].ToString(),
                        Address = drow[3].ToString(),
                        PhoneNo = drow[5].ToString()
                    };
                    if (sObj != null)
                    {
                        studList.Add(sObj);
                    }

                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }


            return studList;
        }

        public Student SearchByID()
        {
            Student std = null;
            return std;
        }

        public bool AddStudent(Student student)
        {

            con.Open();

            SqlParameter[] paramArr = new SqlParameter[5];
            paramArr[0] = new SqlParameter("@RollNo", student.RollNo);
            paramArr[1] = new SqlParameter("@Name", student.Name);
            paramArr[2] = new SqlParameter("@Age", student.Age);
            paramArr[3] = new SqlParameter("@Addr", student.Address);
            paramArr[4] = new SqlParameter("@PhoneNo", student.PhoneNo);

            cmd = new SqlCommand();
            cmd.CommandText = "Insert into StudentInfo(RollNo,name,age,localaddr,peraddr,phoneNo) values(@RollNo,@Name,@Age,@Addr,@Addr,@PhoneNo);";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 10000;

            cmd.Parameters.AddRange(paramArr);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected == 1)
            {
                return true;
            }
            else return false;
            

        }
    }
}
