using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MenuCreation
{
    public partial class MDIParent : Form
    {
        private ToolStripMenuItem MnuStripItem;
        DataTable dtForms;
        public MDIParent()
        {
            InitializeComponent();
            createMenu();
        }

        private void createMenu()
        {
            try
            {
                DataTable dtMainMenu = sp_sqlconnection.get_sp("MainMenuDetail", "qtype=SelectAllMenu");
                dtForms = sp_sqlconnection.get_sp("FormMasterDetail", "qtype=SelectByUser|user_id=" + User_Detail.user_id);

                var results = (from mn in dtMainMenu.AsEnumerable()
                               join
                                   fm in dtForms.AsEnumerable() on mn.Field<int>("menuid") equals fm.Field<int>("mainmenuid")
                               select mn).ToList().Distinct();
                dtMainMenu = results.CopyToDataTable();

                string query = "Select f.id, f.mainmenuid, m.menuname mainmenu, f.formname, f.formtext, isnull(f.parentmenuid,0) parentmenuid," + Environment.NewLine +
                               "isnull(p.formtext,'') parentmenu, f.formdisplayorder, isnull(f.param,'') param" + Environment.NewLine +
                               "from FormMaster f" + Environment.NewLine +
                               "left join MainMenu m on f.mainmenuid = m.menuid" + Environment.NewLine +
                               "left join FormMaster p on p.id = f.parentmenuid";
                DataTable dt = sqlconnection.fetchdatatable(query);

                results = (from mn in dt.AsEnumerable()
                           join fm in
                               (from d in dtForms.AsEnumerable()
                                select new { fid = d.Field<int>("parentmenuid") }
                               ).Distinct().ToList() on mn.Field<int>("id") equals fm.fid
                           select mn).ToList().Distinct();

                dt = results.CopyToDataTable();
                dtForms.Merge(dt);

                for (int i = 0; i < dtMainMenu.Rows.Count; i++)
                {
                    MnuStripItem = new ToolStripMenuItem(dtMainMenu.Rows[i]["menuname"].ToString());

                    DataRow[] dr = dtForms.Select("mainmenuid=" + dtMainMenu.Rows[i]["menuid"] + " and parentmenuid=0");
                    for (int j = 0; j < dr.Length; j++)
                    {
                        ToolStripMenuItem SSMenu = new ToolStripMenuItem(dr[j]["formtext"].ToString(), null, new EventHandler(ChildClick));
                        MnuStripItem.DropDownItems.Add(SSMenu);
                        addSubMenu(int.Parse(dr[j]["id"].ToString()), SSMenu);
                    }
                    MnuStripItem.DropDownOpened += new EventHandler(ToolStripMenuItem_DropDownOpened);
                    MnuStripItem.DropDownClosed += new EventHandler(ToolStripMenuItem_DropDownClosed);
                    menuStrip.Items.Add(MnuStripItem);
                }
            }
            catch (Exception)
            {
            }
        }

        private void addSubMenu(int ParentMenuID, ToolStripMenuItem SSMenu)
        {
            try
            {
                dtForms.DefaultView.RowFilter = "parentmenuid=" + ParentMenuID;
                for (int j = 0; j < dtForms.DefaultView.Count; j++)
                {
                    ToolStripMenuItem SMenu = new ToolStripMenuItem(dtForms.DefaultView[j]["formtext"].ToString(), null, new EventHandler(ChildClick));
                    SSMenu.DropDownItems.Add(SMenu);

                    DataView dv = new DataView(dtForms);
                    dv.RowFilter = "parentmenuid=" + dtForms.DefaultView[j]["id"];
                    DataTable dtChild = dv.ToTable();

                    for (int k = 0; k < dtChild.Rows.Count; k++)
                    {
                        ToolStripMenuItem ScMenu = new ToolStripMenuItem(dtChild.Rows[k]["formtext"].ToString(), null, new EventHandler(ChildClick));
                        SMenu.DropDownItems.Add(ScMenu);

                        DataRow[] dr = dtForms.Select("parentmenuid=" + dtForms.DefaultView[j]["id"]);
                        if (dr.Length > 0)
                        {
                            addSubChildMenu(int.Parse(dtChild.Rows[k]["id"].ToString()), ScMenu);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void addSubChildMenu(int ParentMenuID, ToolStripMenuItem SSMenu)
        {
            try
            {
                DataView dv = new DataView(dtForms);
                dv.RowFilter = "parentmenuid=" + ParentMenuID;
                DataTable dtChild = dv.ToTable();

                for (int j = 0; j < dtChild.Rows.Count; j++)
                {
                    ToolStripMenuItem SMenu = new ToolStripMenuItem(dtChild.Rows[j]["formtext"].ToString(), null, new EventHandler(ChildClick));
                    SSMenu.DropDownItems.Add(SMenu);
                    DataRow[] dr = dtForms.Select("parentmenuid=" + dtChild.Rows[j]["id"]);
                    if (dr.Length > 0)
                    {
                        addSubMenu(int.Parse(dtChild.Rows[j]["id"].ToString()), SMenu);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void ChildClick(object sender, EventArgs e)
        {
            try
            {
                DataRow[] dr = dtForms.Select("formtext='" + sender.ToString() + "'");
                if (dr.Length > 0)
                {
                    Type t = Type.GetType(Application.ProductName + "." + dr[0]["formname"].ToString());
                    if (t != null)
                    {
                        object[] param = dr[0]["param"].ToString().Split(',');
                        int l = t.GetConstructors()[0].GetParameters().Length;
                        if (param.Length != l)
                        {
                            Form c = Activator.CreateInstance(t) as Form;
                            c.Parent = MdiParent;
                            c.Show();
                            frm_global = c;
                            c.Shown += frm_Shown;
                        }
                        else
                        {
                            Form c = Activator.CreateInstance(t, param) as Form;
                            c.Parent = MdiParent;
                            c.Show();
                            frm_global = c;
                            c.Shown += frm_Shown;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        Form frm_global = null;
        void frm_Shown(object sender, EventArgs e)
        {
            frm_global.Activate();
        }

        private void ToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).ForeColor = Color.Black;
            (sender as ToolStripMenuItem).BackColor = Color.Blue;
        }

        private void ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).ForeColor = Color.Black;
            (sender as ToolStripMenuItem).BackColor = Color.White;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MDIParent_FormClosing(null, null);
        }

        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
