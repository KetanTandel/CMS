using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace MenuCreation
{
    class sqlconnection
    {
        public static string con_str = "";
        //public static string con_str = System.IO.File.ReadAllText(Application.StartupPath + "\\constring.txt");
        // public static String con_str = ConfigurationManager.ConnectionStrings["connectionstring1"].ConnectionString;
        //public static string APIConst = System.IO.File.ReadAllText(Application.StartupPath + "\\API.txt");

        //================= Get Line Number In Error =================//
        public static int LineNumber(Exception ex)
        {

            int linenum = 0;
            try
            {
                linenum = Convert.ToInt32(ex.StackTrace.Substring(ex.StackTrace.LastIndexOf(":line") + 5));
            }
            catch
            {
                //Stack trace is not available!
            }
            return linenum;
        }

        // for get Datatable
        public static DataTable fetchdatatable(String query)
        {
            DataTable dt1 = new DataTable();
            try
            {
                SqlConnection cn = new SqlConnection(con_str);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand = cmd;
                da.Fill(dt1);
                cn.Close();
            }
            catch
            { }
            return (dt1);

        }
        // For Simple Procedure
        public static string insertdata(String query)
        {
            string id = "";
            try
            {
                SqlConnection cn = new SqlConnection(con_str);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandTimeout = 1000000;
                id = Convert.ToString(cmd.ExecuteNonQuery());
                cn.Close();
            }
            catch (Exception)
            { }
            return id;
        }

        public static string insertdataid(String query)
        {
            string id = "";
            try
            {
                SqlConnection cn = new SqlConnection(con_str);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                id = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception)
            { }
            return id;
        }

        //==============Insert Error in Table ========================//
        public static void error(string error_name, string form_name, string module_name, int linenumber)
        {
            sqlconnection.insertdata("insert into error_tbl(error_name,form_name,date,time,module_name,linenumber) values('" + error_name + "','" + form_name + "','" + DateTime.Today.ToString("MM-dd-yyyy") + "','" + string.Format("{0:hh:mm:ss tt}", DateTime.Now) + "','" + module_name + "','" + linenumber + "')");
        }

        // For Get Maximum ID
        public static int getlastid(string tbl, string id)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            DataTable dtid = new DataTable();
            new System.Data.SqlClient.SqlDataAdapter("select * from " + tbl + " ORDER BY " + id + "", con_str).Fill(dtid);

            if (dtid.Rows.Count == 0)
            {
                return 1;
            }
            else
            {

                int id1 = int.Parse(dtid.Rows[dtid.Rows.Count - 1][0].ToString());
                id1 += 1;
                return id1;
            }
        }


        public static int insertBulk(DataTable dt, string tableName)
        {
            int i = 0;
            using (SqlConnection connection = new SqlConnection(sqlconnection.con_str))
            {
                SqlBulkCopy bulkCopy =
                    new SqlBulkCopy
                    (
                    connection,
                    SqlBulkCopyOptions.TableLock |
                    SqlBulkCopyOptions.FireTriggers |
                    SqlBulkCopyOptions.UseInternalTransaction,
                    null
                    );

                bulkCopy.DestinationTableName = tableName;
                bulkCopy.BulkCopyTimeout = 1000000000;
                connection.Open();

                bulkCopy.WriteToServer(dt);

                i = 1;
                connection.Close();
            }
            return i;
        }

        //Get Single Value From Database
        public static string getSingleValue(String query)
        {
            string value = "";
            try
            {
                SqlConnection cn = new SqlConnection(con_str);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);                
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    value = dr[0].ToString();
                }
                cn.Close();
            }
            catch
            { }
            return value;
        }
    }
}
