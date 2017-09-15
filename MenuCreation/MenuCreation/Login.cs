using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCreation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            sqlconnection.con_str = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            sp_sqlconnection.con_str = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_user = sp_sqlconnection.get_sp("UserDetail", "qtype=VerifyUser|user_name=" + txtusername.Text + "|password=" + txtpassword.Text);
                if(dt_user.Rows.Count > 0)
                {
                    User_Detail.user_id = int.Parse(dt_user.Rows[0]["user_id"].ToString());
                    User_Detail.user_name = dt_user.Rows[0]["user_name"].ToString();

                    MDIParent mdi = new MDIParent();
                    mdi.Show();
                    this.Hide();
                }
                else
                {
                    txtusername.Text = string.Empty;
                    txtpassword.Text = string.Empty;
                    User_Detail.user_id = 0;
                    User_Detail.user_name = "";
                    MessageBox.Show("Authentication Failed.", "Authentication Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Focus();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void allkeydown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);                    
                }
            }
            catch (Exception)
            { }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    btnlogin.PerformClick();
                }
            }
            catch (Exception)
            { }
        }
    }
}
