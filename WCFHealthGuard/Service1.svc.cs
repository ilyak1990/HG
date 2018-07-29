using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HealthGuardObjects;


namespace WCFHealthGuard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public static string strcon = ConfigurationManager.ConnectionStrings["HealthGuardDB"].ConnectionString;


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void userRegister(string login, string password, string password2, string name,string email)


        {



            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {
                  
                    SqlCommand comm = new SqlCommand("registerPatient", con);
                    con.Open();

                    comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@login", login);
                        comm.Parameters.AddWithValue("@password", password);
                    comm.Parameters.AddWithValue("@password2", password2);
                    comm.Parameters.AddWithValue("@name", name);
                    comm.Parameters.AddWithValue("@email", email);

                    comm.ExecuteNonQuery();

                       

                    
                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }

        public int loginUser(string login, string password)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                int returnvalue = 0;
                try
                {
                    using (SqlCommand comm = new SqlCommand("loginValidation", con))
                    {
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@login", login);
                        comm.Parameters.AddWithValue("@password", password);
                        con.Open();
                        SqlParameter p1 = new SqlParameter("@ret", SqlDbType.Int);
                        p1.Direction = ParameterDirection.ReturnValue;
                        comm.Parameters.Add(p1);
                        comm.ExecuteNonQuery();
                        returnvalue = Convert.ToInt32(comm.Parameters["@ret"].Value);

                    }
                }
                catch (Exception e)
                {


                    throw e;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
                return returnvalue;
            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }





        public void InsertingtheData(string login, string password, string password2, string name)


        {



            using (SqlConnection con = new SqlConnection(strcon))
            {
                try
                {

                    SqlCommand comm = new SqlCommand("updateSproc", con);
                    con.Open();

                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@login", login);
                    comm.Parameters.AddWithValue("@password", password);
                    comm.Parameters.AddWithValue("@password2", password2);
                    comm.Parameters.AddWithValue("@name", name);

                    comm.ExecuteNonQuery();




                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }


        
     

            public int getprofileID(string login)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {

                int profileID = 0;

                try
                {
                    using (SqlCommand comm = new SqlCommand("getProfID", con))
                    {
                        int localID = 0;
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@login", login);
                        con.Open();
                        SqlDataReader read = comm.ExecuteReader();
                        while (read.Read())
                        {
                            localID = Convert.ToInt32(read.GetInt32(0));
                        }
                        profileID = localID;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
                return profileID;
            }
        }


        public user getPatientInformation(int login)
        {

            user list = new user();

            using (SqlConnection con = new SqlConnection(strcon))
            {

             

                try
                {

                   


                    using (SqlCommand comm = new SqlCommand("SELECT * from patienttest where patientid =" + login  , con))
                    {
                        
               
                      
                      
               
                        con.Open();
                        SqlDataReader reader = comm.ExecuteReader();







                        while (reader.Read())
                        {

                            list.theLogin = (string) reader["login"];
                            list.thePassword = (string)reader["password"];
                           // list.thePassword2 = (string)reader["password2"];
                            list.theName = (string)reader["name"];



                        }
                        

                        return list;

                    }
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
             
            }
        }


    }
}
