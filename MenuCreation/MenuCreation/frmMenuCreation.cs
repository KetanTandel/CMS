using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCreation
{
    public partial class frmMenuCreation : Form
    {
        int main_menu_update_id = 0;
        int form_update_id = 0;
        string conString = "";
        DataTable dtForms = new DataTable();
        public frmMenuCreation()
        {
            InitializeComponent();
            dgvMainMenu.AutoGenerateColumns = false;
            dgvForms.AutoGenerateColumns = false;
            bindservername();
        }

        public void get_databasename()
        {
            try
            {
                if (cmbServerName.Text.Trim().Length == 0)
                    return;
                if (txtId.Text.Trim().Length == 0)
                    return;
                if (txtPassword.Text.Trim().Length == 0)
                    return;

                conString = "server=" + cmbServerName.Text.Trim() + ";uid=" + txtId.Text.Trim() + ";pwd=" + txtPassword.Text.Trim() + "";

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cmbDatabase.Items.Add(dr[0].ToString());
                            }
                        }
                    }
                    if (cmbDatabase.Items.Count > 0)
                        cmbDatabase.SelectedIndex = 0;
                    else
                        cmbDatabase.Text = "";
                    con.Close();
                }
            }
            catch (Exception)
            {
                cmbDatabase.Items.Clear();
                MessageBox.Show("Enter Valid ID And Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public void bindservername()
        {
            try
            {
                DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["InstanceName"].ToString() == "")
                        cmbServerName.Items.Add(string.Concat(dr["ServerName"]));
                    else
                        cmbServerName.Items.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
                }
                if (cmbServerName.Items.Count > 0)
                    cmbServerName.SelectedIndex = 0;
                else
                    cmbServerName.Text = "";
            }
            catch (Exception)
            {
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

        private void btnSaveMainMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMainMenuName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Enter menu name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMainMenuName.Focus();
                    return;
                }

                if (txtDisplayOrderMainMenu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Enter display order number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDisplayOrderMainMenu.Focus();
                    return;
                }

                //Check Exist
                DataTable dtCheck = sp_sqlconnection.get_sp("MainMenuDetail", "qtype=CheckExist|menuid=" + main_menu_update_id + "|menuname=" + txtMainMenuName.Text.Trim());
                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show(txtMainMenuName.Text + " already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMainMenuName.Focus();
                    return;
                }

                if (main_menu_update_id == 0)
                {
                    //Insert
                    main_menu_update_id = int.Parse(sp_sqlconnection.dml_sp_id("MainMenuDetail", "qtype=Insert|menuid=" + sqlconnection.getSingleValue("Select isnull(max(menuid),0)+1  From  MainMenu") + "|menuname=" + txtMainMenuName.Text.Trim() + "|displayorder=" + txtDisplayOrderMainMenu.Text.Trim()));

                    if (main_menu_update_id != 0)
                        MessageBox.Show("Successfully Inserted..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Update
                    string status = sp_sqlconnection.dml_sp("MainMenuDetail", "qtype=Update|menuid=" + main_menu_update_id + "|menuname=" + txtMainMenuName.Text.Trim() + "|displayorder=" + txtDisplayOrderMainMenu.Text.Trim());

                    if (status == "1")
                        MessageBox.Show("Successfully Updated..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                resetMainMenuDetail();
            }
            catch (Exception)
            {
            }
        }

        private void btnDeleteMainMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string status = sp_sqlconnection.dml_sp("MainMenuDetail", "qtype=Delete|menuid=" + main_menu_update_id);
                if (status == "1")
                    MessageBox.Show("Successfully Deleted..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("\"" + txtMainMenuName.Text + "\"" + status, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetMainMenuDetail();
            }
            catch (Exception)
            {
            }
        }

        private void btnCancelMainMenu_Click(object sender, EventArgs e)
        {
            resetMainMenuDetail();
        }

        private void btnSaveForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMainMenu.SelectedValue.ToString() == "0")
                {
                    MessageBox.Show("Select main menu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMainMenu.Focus();
                    return;
                }

                if (txtFormText.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Enter from text.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFormText.Focus();
                    return;
                }

                if (txtDisplayOrderForm.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Enter display order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDisplayOrderForm.Focus();
                    return;
                }

                ////Check Exist
                //DataTable dtCheck = sp_sqlconnection.get_sp("MainMenuDetail", "qtype=CheckExist|menuid=" + main_menu_update_id + "|menuname=" + txtMainMenuName.Text.Trim());
                //if (dtCheck.Rows.Count > 0)
                //{
                //    MessageBox.Show(txtMainMenuName.Text + " already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtMainMenuName.Focus();
                //    return;
                //}

                if (form_update_id == 0)
                {
                    //Insert
                    form_update_id = int.Parse(sp_sqlconnection.dml_sp_id("FormMasterDetail", "qtype=Insert|id=" + sqlconnection.getSingleValue("Select isnull(max(id),0)+1  From  FormMaster") + "|mainmenuid=" + cmbMainMenu.SelectedValue + "|formname=" + txtFormName.Text.Trim() + "|formtext=" + txtFormText.Text.Trim() + "|parentmenuid=" + cmbParentMenu.SelectedValue + "|formdisplayorder=" + txtDisplayOrderForm.Text + "|param=" + txtDefaultParameter.Text.Trim()));

                    if (form_update_id != 0)
                        MessageBox.Show("Successfully Inserted..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Update
                    string status = sp_sqlconnection.dml_sp("FormMasterDetail", "qtype=Update|id=" + form_update_id + "|mainmenuid=" + cmbMainMenu.SelectedValue + "|formname=" + txtFormName.Text.Trim() + "|formtext=" + txtFormText.Text.Trim() + "|parentmenuid=" + cmbParentMenu.SelectedValue + "|formdisplayorder=" + txtDisplayOrderForm.Text + "|param=" + txtDefaultParameter.Text.Trim());

                    if (status == "1")
                        MessageBox.Show("Successfully Updated..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                resetFormDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            try
            {
                string status = sp_sqlconnection.dml_sp("FormMasterDetail", "qtype=Delete|id=" + form_update_id);
                if (status == "1")
                    MessageBox.Show("Successfully Deleted..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFormDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelForm_Click(object sender, EventArgs e)
        {
            resetFormDetail();
        }

        private void txtDisplayOrderMainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSaveMainMenu.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                this.Close();

        }

        private void txtDisplayOrderForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSaveForm.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            get_databasename();
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conString = "server=" + cmbServerName.Text + ";Initial Catalog=" + cmbDatabase.Text + ";uid=" + txtId.Text + ";pwd=" + txtPassword.Text + "";
            }
            catch (Exception)
            {
            }
        }

        private void resetMainMenuDetail()
        {
            main_menu_update_id = 0;
            txtMainMenuName.Text = "";
            txtDisplayOrderMainMenu.Text = "";
            btnDeleteMainMenu.Enabled = false;
            LoadMainMenu();
            BindMainMenu();
            BindParentMenu();
            txtMainMenuName.Focus();
        }

        private void resetFormDetail()
        {
            form_update_id = 0;
            BindParentMenu();
            //cmbMainMenu.SelectedValue = 0;
            //cmbParentMenu.SelectedValue = 0;
            txtFormName.Text = "";
            txtFormText.Text = "";
            txtDefaultParameter.Text = "";
            txtDisplayOrderForm.Text = "";
            LoadForms();
            cmbMainMenu.Focus();
            btnDeleteForm.Enabled = false;
        }

        private void cmbDatabase_Leave(object sender, EventArgs e)
        {
            sp_sqlconnection.con_str = "server=" + cmbServerName.Text.Trim() + ";Initial Catalog=" + cmbDatabase.Text.Trim() + ";Persist Security Info=True;uid=" + txtId.Text.Trim() + ";pwd=" + txtPassword.Text.Trim() + "";
            sqlconnection.con_str = "server=" + cmbServerName.Text.Trim() + ";Initial Catalog=" + cmbDatabase.Text.Trim() + ";Persist Security Info=True;uid=" + txtId.Text.Trim() + ";pwd=" + txtPassword.Text.Trim() + "";
            LoadMainMenu();
            BindMainMenu();
            BindParentMenu();
            LoadForms();
        }

        private void LoadMainMenu()
        {
            try
            {
                DataTable dt = sp_sqlconnection.get_sp("MainMenuDetail", "qtype=SelectAll");
                dgvMainMenu.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void LoadForms()
        {
            try
            {
                dtForms = sp_sqlconnection.get_sp("FormMasterDetail", "qtype=SelectAll");
                DataView dv = new DataView(dtForms);

                if (cmbMainMenu.SelectedValue.ToString() != "0")
                    dv.RowFilter = "mainmenuid=" + cmbMainMenu.SelectedValue;
                if (cmbParentMenu.SelectedValue.ToString() != "0")
                    dv.RowFilter = "parentmenuid=" + cmbParentMenu.SelectedValue;

                dtForms = dv.ToTable();

                dgvForms.DataSource = dtForms;
            }
            catch (Exception)
            {
            }
        }

        private void dgvMainMenu_Click(object sender, EventArgs e)
        {
            try
            {
                main_menu_update_id = int.Parse(dgvMainMenu.CurrentRow.Cells["menuid"].Value.ToString());
                txtMainMenuName.Text = dgvMainMenu.CurrentRow.Cells["menuname"].Value.ToString();
                txtDisplayOrderMainMenu.Text = dgvMainMenu.CurrentRow.Cells["displayorder"].Value.ToString();
                if (main_menu_update_id != 0)
                    btnDeleteMainMenu.Enabled = true;
                txtMainMenuName.Focus();
            }
            catch (Exception)
            {
            }
        }

        private void BindMainMenu()
        {
            try
            {
                DataTable dt_combo = sp_sqlconnection.get_sp("MainMenuDetail", "qtype=SelectAllMenu");

                DataRow dr = dt_combo.NewRow();
                dr.ItemArray = new object[] { 0, "Select Main Menu" };
                dt_combo.Rows.InsertAt(dr, 0);

                cmbMainMenu.DisplayMember = "menuname";
                cmbMainMenu.ValueMember = "menuid";
                cmbMainMenu.DataSource = dt_combo;
            }
            catch
            {
            }
        }

        private void BindParentMenu()
        {
            try
            {
                DataTable dt_combo = sp_sqlconnection.get_sp("FormMasterDetail", "qtype=SelectParentMenu");
                DataRow dr = dt_combo.NewRow();
                dr.ItemArray = new object[] { 0, "Select Parent Menu" };
                dt_combo.Rows.InsertAt(dr, 0);

                cmbParentMenu.DisplayMember = "formtext";
                cmbParentMenu.ValueMember = "id";
                cmbParentMenu.DataSource = dt_combo;
            }
            catch
            {
            }
        }

        private void dgvForms_Click(object sender, EventArgs e)
        {
            try
            {
                form_update_id = int.Parse(dgvForms.CurrentRow.Cells["id"].Value.ToString());

                cmbMainMenu.SelectedIndexChanged -= cmbMainMenu_SelectedIndexChanged;
                cmbMainMenu.SelectedValue = dgvForms.CurrentRow.Cells["mainmenuid"].Value;
                cmbMainMenu.SelectedIndexChanged += cmbMainMenu_SelectedIndexChanged;

                cmbParentMenu.SelectedIndexChanged -= cmbParentMenu_SelectedIndexChanged;
                cmbParentMenu.SelectedValue = dgvForms.CurrentRow.Cells["parentmenuid"].Value;
                cmbParentMenu.SelectedIndexChanged += cmbParentMenu_SelectedIndexChanged;

                txtFormText.Text = dgvForms.CurrentRow.Cells["formtext"].Value.ToString();
                txtFormName.Text = dgvForms.CurrentRow.Cells["formname"].Value.ToString();                
                txtDisplayOrderForm.Text = dgvForms.CurrentRow.Cells["formdisplayorder"].Value.ToString();
                txtDefaultParameter.Text = dgvForms.CurrentRow.Cells["param"].Value.ToString();
                if (form_update_id != 0)
                    btnDeleteForm.Enabled = true;
                cmbMainMenu.Focus();
            }
            catch (Exception)
            {
            }
        }

        private void cmbMainMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadForms();
        }

        private void cmbParentMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadForms();
        }

        private void AllowIntegerOnly(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnMainMenuExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvForms.Rows.Count > 0)
                {
                    
                    StringBuilder sb = new StringBuilder();
                    DataTable dt = (DataTable)dgvMainMenu.DataSource;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i != 0)
                            sb.Append(Environment.NewLine);
                        sb.Append("INSERT INTO MainMenu (menuid, menuname, displayorder, insertOnUTC) VALUES (" + dt.Rows[i]["menuid"] + ", '" + dt.Rows[i]["menuname"] + "', " + dt.Rows[i]["displayorder"] + ", getdate())");
                    }
                    if (sb.Length > 0)
                    {
                        SaveFileDialog sFD = new SaveFileDialog();
                        if (sFD.ShowDialog() == DialogResult.OK)
                        {
                            System.IO.File.WriteAllText(sFD.FileName + ".txt", sb.ToString());
                            MessageBox.Show("Successfully File Generated..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFormExport_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (dgvForms.Rows.Count > 0)
                    {
                        
                        StringBuilder sb = new StringBuilder();
                        DataTable dt = (DataTable)dgvForms.DataSource;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (i != 0)
                                sb.Append(Environment.NewLine);
                            sb.Append("INSERT INTO FormMaster(id, mainmenuid, formname, formtext, parentmenuid, formdisplayorder, param, insertOnUTC) VALUES (" + dt.Rows[i]["id"] + ", " + dt.Rows[i]["mainmenuid"] + ", '" + dt.Rows[i]["formname"] + "', '" + dt.Rows[i]["formtext"] + "', " + dt.Rows[i]["parentmenuid"] + ", " + dt.Rows[i]["formdisplayorder"] + ", '" + dt.Rows[i]["param"] + "', getdate())");
                        }
                        if (sb.Length > 0)
                        {
                            SaveFileDialog sFD = new SaveFileDialog();
                            if (sFD.ShowDialog() == DialogResult.OK)
                            {
                                System.IO.File.WriteAllText(sFD.FileName + ".txt", sb.ToString());
                                MessageBox.Show("Successfully File Generated..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
