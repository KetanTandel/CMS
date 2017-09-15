using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MenuCreation
{
    class sp_sqlconnection
    {
        public static string con_str = "";
        //public static string con_str = System.IO.File.ReadAllText(Application.StartupPath + "\\constring.txt");
        //public static string con_str = ConfigurationManager.ConnectionStrings["connectionstring1"].ConnectionString;
        public static string id;
        public static string status;


        //  For Simple Store Procedure
        public static string dml_sp(string sp_name, string all_parameters)
        {
            try
            {
                SqlConnection cn = new SqlConnection(con_str);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sp_name, cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // for removing "|" data string 
                string[] parameters = all_parameters.Split('|');

                // for removing "=" data string
                for (int i = 0; i < parameters.Length; i++)
                {
                    // for removing "=" data string
                    string[] this_param = parameters[i].Split('=');

                    //now addding @status ans select
                    cmd.Parameters.Add(new SqlParameter("@" + this_param[0], this_param[1]));
                }

                status = Convert.ToString(cmd.ExecuteNonQuery());
                cn.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("reference"))
                {
                    status = " further used so you can not delete.";
                }
                else
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return status;
        }
        //get connection
        public static System.Data.SqlClient.SqlConnection getconnection()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(con_str);
            con.Open();
            return con;
        }
        // For Get Datatable
        public static DataTable get_sp(string sp_name, string all_parameters)
        {
            DataTable tmp = new DataTable();
            try
            {
                SqlConnection cn = new SqlConnection(con_str);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sp_name, cn);
                // for removing "|" data string 
                string[] parameters = all_parameters.Split('|');
                // for removing "=" data string
                for (int i = 0; i < parameters.Length; i++)
                {
                    // for removing "=" data string
                    string[] this_param = parameters[i].Split('=');

                    //now addding @status ans select
                    cmd.Parameters.Add(new SqlParameter("@" + this_param[0], this_param[1]));
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tmp);
                cn.Close();
            }
            catch (Exception)
            {}

            return (tmp);

        }

        // For Get Max ID
        public static string dml_spid(string sp_name, string all_parameters)
        {
            try
            {
                SqlConnection cn = new SqlConnection(con_str);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sp_name, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                string[] parameters = all_parameters.Split('|');
                for (int i = 0; i < parameters.Length; i++)
                {
                    string[] this_param = parameters[i].Split('=');
                    cmd.Parameters.Add(new SqlParameter("@" + this_param[0], this_param[1]));
                }
                id = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception)
            {}
            return id;
        }
        public static string dml_sp_id(string sp_name, string all_parameters)
        {
            try
            {
                SqlConnection cn = new SqlConnection(con_str);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sp_name, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                string[] parameters = all_parameters.Split('|');
                for (int i = 0; i < parameters.Length; i++)
                {
                    string[] this_param = parameters[i].Split('=');
                    cmd.Parameters.Add(new SqlParameter("@" + this_param[0], this_param[1]));
                }
                id = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.InnerException, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("There Is A Problem While Working With DataBase", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return id;
        }
    }
}
