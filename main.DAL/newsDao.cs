using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using main.Entities;


namespace main.DAL
{
    public class newsDao
    {
        khabar kh = new khabar();
        public List<khabar> loadfirstnews()
        {
            khabar kh = new khabar();

            string sqlConnectionString = ("Data Source=.;Initial Catalog=newsdata;"
                  + "Integrated Security=true;");

            using (SqlConnection con = new SqlConnection(sqlConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand("SELECT id, title, textbox FROM text", con))
                {

                    List<khabar> khabars = new List<khabar>();

                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {

                        while (sdr.Read())
                        {
                            try
                            {
                                khabars.Add(new khabar
                                {

                                    id = Convert.ToInt32(sdr["id"]),
                                    title = sdr["title"].ToString(),
                                    textbox = sdr["textbox"].ToString()

                                });
                            }
                            catch { }

                        }
                    }
                    con.Close();

                    return khabars;
                }
            }
        }

        public void editDatabase()
        {

        }

        public void removefromdatabase(string id)
        {
            string sqlConnectionString = "Data Source=.;Initial Catalog=newsdata;"
                  + "Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();

            // my query
            string query = "DELETE FROM text WHERE id = @id";

            // create command
            SqlCommand myCommand = new SqlCommand(query, sqlConnection);
            myCommand.Parameters.AddWithValue("@id", id);

            // run command
            myCommand.ExecuteNonQuery();

            // close database
            sqlConnection.Close();
        }

        public void AddToDatabase()
        {
            string sqlConnectionString = ("Data Source=.;Initial Catalog=newsdata;"
                  + "Integrated Security=true;");
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();

            string query = "INSERT INTO text (title, textbox)";
            query += " VALUES (@title, @textbox)";

            // create command
            SqlCommand mc = new SqlCommand(query, sqlConnection);

            mc.Parameters.AddWithValue("@title", Convert.ToString(kh.title));
            mc.Parameters.AddWithValue("@textbox", Convert.ToString(kh.textbox));

            // run command
            mc.ExecuteNonQuery();

            // close database
            sqlConnection.Close();

        }
    }
}


