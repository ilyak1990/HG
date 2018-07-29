using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;




namespace CRUD_App
{
    public class DAL
    {

 

        public static string AddPatient(string login, string password, string name)
        {

            //SqlConnection con = new SqlConnection
            //("Data Source=oz-ist-iissql.abington.psu.edu;Initial Catalog = IST440GRP4;UserId=ist440grp4; Password=ist440grp4");
            SqlConnection con = new SqlConnection(DataBase.ConnectionString);


            try
            {
          

                con.Open();
                SqlCommand cmd = new SqlCommand("insertPatient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
             
                cmd.ExecuteNonQuery();
                            return null; // success    

            }
            catch (Exception ex)
            {
                return ex.Message; // return error message   
            }
            finally
            {
                con.Close();
            }
        }

        public static Patient GetPatient(string login,string password)
     {
            //       SqlConnection con = new SqlConnection
            //("Data Source=oz-ist-iissql.abington.psu.edu;Initial Catalog = IST440GRP4;UserId=ist440grp4; Password=ist440grp4");
            SqlConnection con = new SqlConnection(DataBase.ConnectionString);
            try   
         {   
            con.Open();   
           SqlCommand cmd = new SqlCommand("getPatient", con);   
            cmd.CommandType = CommandType.StoredProcedure;   
           cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = cmd.ExecuteReader();   
            if (dr.Read())   
            {   
              Patient b = new Patient();


                    b.name = dr["name"].ToString();  
               return b;   
            }   
            else   
              return null;   
       }   
         catch (Exception ex)   
         {   
            return null;   
         }   
         finally   
         {   
            con.Close();   
         }   
      }
       


    }

}

     

    


