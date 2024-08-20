using System.Data;
using System.Data.SqlClient;

namespace WebApplicationNew_ADONET
{
    public class StudentDataAccessLayer
    {
        string connectionString = ConnectionString.CName;

        public IEnumerable<Student> GetAllStudent()
        {
            List<Student> lstStudent = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(rdr["Id"]);
                    student.FirstName = rdr["FirstName"].ToString();
                    student.LastName = rdr["LastName"].ToString();
                    student.Email = rdr["Email"].ToString();
                    student.Mobile = rdr["Mobile"].ToString();
                    student.Address = rdr["Address"].ToString();

                    lstStudent.Add(student);
                }
                con.Close();
            }
            return lstStudent;

        }



        }
    }

   

