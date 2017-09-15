using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCreation
{
    public partial class UserPermission : Form
    {
        string form_ids = "";
        DataTable dtForms;
        DataTable dt_allow_forms;
        TreeNode tree_node;
        
        public UserPermission()
        {
            InitializeComponent();            
        }

        private void generateMenuTree() 
        {
            try
            {
                if (tvMenu.Nodes.Count > 0)
                    tvMenu.Nodes.Clear();
                DataTable dtMainMenu = sp_sqlconnection.get_sp("MainMenuDetail", "qtype=SelectAllMenu");
                dtForms = sp_sqlconnection.get_sp("FormMasterDetail", "qtype=SelectAll");

                //Generate Root Node
                for (int i = 0; i < dtMainMenu.Rows.Count; i++)
                {
                    tree_node = new TreeNode();
                    tree_node.Name = dtMainMenu.Rows[i]["menuid"].ToString();
                    tree_node.Text = dtMainMenu.Rows[i]["menuname"].ToString();

                    DataRow[] dr = dtForms.Select("mainmenuid=" + tree_node.Name + " and parentmenuid=0");
                    for (int j = 0; j < dr.Length; j++)
                    {
                        TreeNode sub_tree_node = new TreeNode();
                        sub_tree_node.Name = dr[j]["id"].ToString();
                        sub_tree_node.Text = dr[j]["formtext"].ToString();
                        tree_node.Nodes.Add(sub_tree_node);
                        addSubMenu(int.Parse(dr[j]["id"].ToString()), sub_tree_node);
                    }
                    tvMenu.Nodes.Add(tree_node);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addSubMenu(int ParentMenuID, TreeNode sub_tree_node)
        {
            try
            {
                dtForms.DefaultView.RowFilter = "parentmenuid=" + ParentMenuID;
                for (int j = 0; j < dtForms.DefaultView.Count; j++)
                {

                    TreeNode sub_child_tree_node = new TreeNode();
                    sub_child_tree_node.Name = dtForms.DefaultView[j]["id"].ToString();
                    sub_child_tree_node.Text = dtForms.DefaultView[j]["formtext"].ToString();
                    sub_tree_node.Nodes.Add(sub_child_tree_node);

                    DataView dv = new DataView(dtForms);
                    dv.RowFilter = "parentmenuid=" + dtForms.DefaultView[j]["id"];
                    DataTable dtChild = dv.ToTable();

                    for (int k = 0; k < dtChild.Rows.Count; k++)
                    {

                        TreeNode sc_tree_node = new TreeNode();
                        sc_tree_node.Name = dtChild.Rows[k]["id"].ToString();
                        sc_tree_node.Text = dtChild.Rows[k]["formtext"].ToString();
                        sub_child_tree_node.Nodes.Add(sc_tree_node);

                        DataRow[] dr = dtForms.Select("parentmenuid=" + dtForms.DefaultView[j]["id"]);
                        if (dr.Length > 0)
                        {
                            addSubChildMenu(int.Parse(dtChild.Rows[k]["id"].ToString()), sc_tree_node);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void addSubChildMenu(int ParentMenuID, TreeNode sc_tree_node)
        {
            try
            {
                DataView dv = new DataView(dtForms);
                dv.RowFilter = "parentmenuid=" + ParentMenuID;
                DataTable dtChild = dv.ToTable();

                for (int j = 0; j < dtChild.Rows.Count; j++)
                {
                    TreeNode subc_tree_node = new TreeNode();
                    subc_tree_node.Name = dtChild.Rows[j]["id"].ToString();
                    subc_tree_node.Text = dtChild.Rows[j]["formtext"].ToString();
                    sc_tree_node.Nodes.Add(subc_tree_node);

                    DataRow[] dr = dtForms.Select("parentmenuid=" + dtChild.Rows[j]["id"]);
                    if (dr.Length > 0)
                    {
                        addSubMenu(int.Parse(dtChild.Rows[j]["id"].ToString()), subc_tree_node);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cmbUser.SelectedValue.ToString()) == 0)
                {
                    MessageBox.Show("Select User..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbUser.Focus();
                    return;
                }

                form_ids = "";
                foreach (TreeNode tn in tvMenu.Nodes)
                {
                    GetSelectedFormID(tn);
                }
                form_ids = form_ids.Remove(form_ids.Length - 1, 1);

                string[] form_ids_array = form_ids.Split(',');

                sqlconnection.insertdata("delete from user_permissinon where user_id = " + cmbUser.SelectedValue);

                DataTable dt = new DataTable();
                dt.Columns.Add("user_id", typeof(int));
                dt.Columns.Add("form_id", typeof(int));
                dt.Columns.Add("is_add", typeof(byte));
                dt.Columns.Add("is_delete", typeof(byte));
                dt.Columns.Add("is_edit", typeof(byte));

                for (int i = 0; i < form_ids_array.Length; i++)
                {
                    dt.Rows.Add(int.Parse(cmbUser.SelectedValue.ToString()), int.Parse(form_ids_array[i]), 1, 1, 1);
                }
                sqlconnection.insertBulk(dt, "user_permissinon");
                UserPermission_Load(null, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetSelectedFormID(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                if (tn.Nodes.Count > 0)
                    GetSelectedFormID(tn);
                else
                {
                    if (tn.Checked)
                        form_ids += tn.Name + ",";
                }
            }
        }

        private void setSavedFormID(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                if (tn.Nodes.Count > 0)
                    setSavedFormID(tn);
                else
                {
                    DataRow[] dr = dt_allow_forms.Select("form_id=" + tn.Name);
                    if (dr.Length > 0)
                        tn.Checked = true;
                    else
                        tn.Checked = false;
                }
            }
        }

        private void tvMenu_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            //CheckChildren(e.Node, e.Node.Checked);
        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                node.Checked = isChecked;
                CheckChildren(node, isChecked);
            }
        }

        private void tvMenu_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckChildren(e.Node, e.Node.Checked);
            tvMenu.AfterCheck -= tvMenu_AfterCheck;
            //checkRootIfChildChecked(e.Node);
            tvMenu.AfterCheck += tvMenu_AfterCheck;
        }

        private void checkRootIfChildChecked(TreeNode node)
        {
            if (node.Checked)
            {
                if (node.Parent != null)
                {
                    node.Parent.Checked = true;
                    checkRootIfChildChecked(node.Parent);
                }
            }
        }

        private void UserPermission_Load(object sender, EventArgs e)
        {
            try
            {
                generateMenuTree();
                DataTable dt_user = sqlconnection.fetchdatatable("select user_id, user_name from [user] order by user_name");
                DataRow dr = dt_user.NewRow();
                dr.ItemArray = new object[] { 0, "Select User" };
                dt_user.Rows.InsertAt(dr, 0);
                cmbUser.DisplayMember = "user_name"; cmbUser.ValueMember = "user_id"; cmbUser.DataSource = dt_user.Copy();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {             
            dt_allow_forms = sqlconnection.fetchdatatable("select * from user_permissinon where user_id = " + cmbUser.SelectedValue);
            foreach (TreeNode tn in tvMenu.Nodes)
            {
                setSavedFormID(tn);
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
    }
}
