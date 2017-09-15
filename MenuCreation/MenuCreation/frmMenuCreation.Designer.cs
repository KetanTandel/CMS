namespace MenuCreation
{
    partial class frmMenuCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpMainMenu = new System.Windows.Forms.GroupBox();
            this.btnMainMenuExport = new System.Windows.Forms.Button();
            this.btnCancelMainMenu = new System.Windows.Forms.Button();
            this.btnDeleteMainMenu = new System.Windows.Forms.Button();
            this.dgvMainMenu = new System.Windows.Forms.DataGridView();
            this.menuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisplayOrderMainMenu = new System.Windows.Forms.TextBox();
            this.btnSaveMainMenu = new System.Windows.Forms.Button();
            this.lblMainMenuName = new System.Windows.Forms.Label();
            this.txtMainMenuName = new System.Windows.Forms.TextBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFormExport = new System.Windows.Forms.Button();
            this.btnCancelForm = new System.Windows.Forms.Button();
            this.btnDeleteForm = new System.Windows.Forms.Button();
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbParentMenu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMainMenu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDisplayOrderForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefaultParameter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFormText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.dgvForms = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainmenuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formtext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentmenuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formdisplayorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatabseSelection = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.grpMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).BeginInit();
            this.grpDatabseSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainMenu
            // 
            this.grpMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpMainMenu.Controls.Add(this.btnMainMenuExport);
            this.grpMainMenu.Controls.Add(this.btnCancelMainMenu);
            this.grpMainMenu.Controls.Add(this.btnDeleteMainMenu);
            this.grpMainMenu.Controls.Add(this.dgvMainMenu);
            this.grpMainMenu.Controls.Add(this.label1);
            this.grpMainMenu.Controls.Add(this.txtDisplayOrderMainMenu);
            this.grpMainMenu.Controls.Add(this.btnSaveMainMenu);
            this.grpMainMenu.Controls.Add(this.lblMainMenuName);
            this.grpMainMenu.Controls.Add(this.txtMainMenuName);
            this.grpMainMenu.Location = new System.Drawing.Point(12, 83);
            this.grpMainMenu.Name = "grpMainMenu";
            this.grpMainMenu.Size = new System.Drawing.Size(342, 458);
            this.grpMainMenu.TabIndex = 1;
            this.grpMainMenu.TabStop = false;
            this.grpMainMenu.Text = "Main Menu";
            // 
            // btnMainMenuExport
            // 
            this.btnMainMenuExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnMainMenuExport.Location = new System.Drawing.Point(251, 78);
            this.btnMainMenuExport.Name = "btnMainMenuExport";
            this.btnMainMenuExport.Size = new System.Drawing.Size(75, 26);
            this.btnMainMenuExport.TabIndex = 8;
            this.btnMainMenuExport.Text = "Export";
            this.btnMainMenuExport.UseVisualStyleBackColor = true;
            this.btnMainMenuExport.Click += new System.EventHandler(this.btnMainMenuExport_Click);
            // 
            // btnCancelMainMenu
            // 
            this.btnCancelMainMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelMainMenu.Location = new System.Drawing.Point(170, 78);
            this.btnCancelMainMenu.Name = "btnCancelMainMenu";
            this.btnCancelMainMenu.Size = new System.Drawing.Size(75, 26);
            this.btnCancelMainMenu.TabIndex = 6;
            this.btnCancelMainMenu.Text = "Cancel";
            this.btnCancelMainMenu.UseVisualStyleBackColor = true;
            this.btnCancelMainMenu.Click += new System.EventHandler(this.btnCancelMainMenu_Click);
            this.btnCancelMainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // btnDeleteMainMenu
            // 
            this.btnDeleteMainMenu.Enabled = false;
            this.btnDeleteMainMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteMainMenu.Location = new System.Drawing.Point(89, 78);
            this.btnDeleteMainMenu.Name = "btnDeleteMainMenu";
            this.btnDeleteMainMenu.Size = new System.Drawing.Size(75, 26);
            this.btnDeleteMainMenu.TabIndex = 5;
            this.btnDeleteMainMenu.Text = "Delete";
            this.btnDeleteMainMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMainMenu.Click += new System.EventHandler(this.btnDeleteMainMenu_Click);
            this.btnDeleteMainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // dgvMainMenu
            // 
            this.dgvMainMenu.AllowUserToAddRows = false;
            this.dgvMainMenu.AllowUserToDeleteRows = false;
            this.dgvMainMenu.AllowUserToOrderColumns = true;
            this.dgvMainMenu.AllowUserToResizeColumns = false;
            this.dgvMainMenu.AllowUserToResizeRows = false;
            this.dgvMainMenu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMainMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMainMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuid,
            this.menuname,
            this.displayorder});
            this.dgvMainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMainMenu.Location = new System.Drawing.Point(3, 116);
            this.dgvMainMenu.MultiSelect = false;
            this.dgvMainMenu.Name = "dgvMainMenu";
            this.dgvMainMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainMenu.Size = new System.Drawing.Size(336, 339);
            this.dgvMainMenu.TabIndex = 7;
            this.dgvMainMenu.Click += new System.EventHandler(this.dgvMainMenu_Click);
            this.dgvMainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // menuid
            // 
            this.menuid.DataPropertyName = "menuid";
            this.menuid.HeaderText = "Menu ID";
            this.menuid.Name = "menuid";
            this.menuid.ReadOnly = true;
            this.menuid.Visible = false;
            // 
            // menuname
            // 
            this.menuname.DataPropertyName = "menuname";
            this.menuname.HeaderText = "Menu Name";
            this.menuname.Name = "menuname";
            this.menuname.ReadOnly = true;
            this.menuname.Width = 200;
            // 
            // displayorder
            // 
            this.displayorder.DataPropertyName = "displayorder";
            this.displayorder.HeaderText = "Order";
            this.displayorder.Name = "displayorder";
            this.displayorder.ReadOnly = true;
            this.displayorder.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(262, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disp. Ord.";
            // 
            // txtDisplayOrderMainMenu
            // 
            this.txtDisplayOrderMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayOrderMainMenu.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtDisplayOrderMainMenu.Location = new System.Drawing.Point(265, 43);
            this.txtDisplayOrderMainMenu.Name = "txtDisplayOrderMainMenu";
            this.txtDisplayOrderMainMenu.Size = new System.Drawing.Size(67, 26);
            this.txtDisplayOrderMainMenu.TabIndex = 3;
            this.txtDisplayOrderMainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisplayOrderMainMenu_KeyDown);
            this.txtDisplayOrderMainMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowIntegerOnly);
            // 
            // btnSaveMainMenu
            // 
            this.btnSaveMainMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveMainMenu.Location = new System.Drawing.Point(8, 78);
            this.btnSaveMainMenu.Name = "btnSaveMainMenu";
            this.btnSaveMainMenu.Size = new System.Drawing.Size(75, 26);
            this.btnSaveMainMenu.TabIndex = 4;
            this.btnSaveMainMenu.Text = "Save";
            this.btnSaveMainMenu.UseVisualStyleBackColor = true;
            this.btnSaveMainMenu.Click += new System.EventHandler(this.btnSaveMainMenu_Click);
            this.btnSaveMainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // lblMainMenuName
            // 
            this.lblMainMenuName.AutoSize = true;
            this.lblMainMenuName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMainMenuName.Location = new System.Drawing.Point(6, 22);
            this.lblMainMenuName.Name = "lblMainMenuName";
            this.lblMainMenuName.Size = new System.Drawing.Size(85, 18);
            this.lblMainMenuName.TabIndex = 0;
            this.lblMainMenuName.Text = "Menu Name";
            // 
            // txtMainMenuName
            // 
            this.txtMainMenuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMainMenuName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtMainMenuName.Location = new System.Drawing.Point(9, 43);
            this.txtMainMenuName.Name = "txtMainMenuName";
            this.txtMainMenuName.Size = new System.Drawing.Size(242, 26);
            this.txtMainMenuName.TabIndex = 1;
            this.txtMainMenuName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpMenu.Controls.Add(this.btnExit);
            this.grpMenu.Controls.Add(this.btnFormExport);
            this.grpMenu.Controls.Add(this.btnCancelForm);
            this.grpMenu.Controls.Add(this.btnDeleteForm);
            this.grpMenu.Controls.Add(this.btnSaveForm);
            this.grpMenu.Controls.Add(this.label7);
            this.grpMenu.Controls.Add(this.cmbParentMenu);
            this.grpMenu.Controls.Add(this.label6);
            this.grpMenu.Controls.Add(this.cmbMainMenu);
            this.grpMenu.Controls.Add(this.label5);
            this.grpMenu.Controls.Add(this.txtDisplayOrderForm);
            this.grpMenu.Controls.Add(this.label4);
            this.grpMenu.Controls.Add(this.txtDefaultParameter);
            this.grpMenu.Controls.Add(this.label3);
            this.grpMenu.Controls.Add(this.txtFormText);
            this.grpMenu.Controls.Add(this.label2);
            this.grpMenu.Controls.Add(this.txtFormName);
            this.grpMenu.Controls.Add(this.dgvForms);
            this.grpMenu.Location = new System.Drawing.Point(360, 80);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(866, 458);
            this.grpMenu.TabIndex = 2;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Forms";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(588, 131);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFormExport
            // 
            this.btnFormExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnFormExport.Location = new System.Drawing.Point(507, 131);
            this.btnFormExport.Name = "btnFormExport";
            this.btnFormExport.Size = new System.Drawing.Size(75, 26);
            this.btnFormExport.TabIndex = 16;
            this.btnFormExport.Text = "Export";
            this.btnFormExport.UseVisualStyleBackColor = true;
            this.btnFormExport.Click += new System.EventHandler(this.btnFormExport_Click);
            // 
            // btnCancelForm
            // 
            this.btnCancelForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelForm.Location = new System.Drawing.Point(426, 131);
            this.btnCancelForm.Name = "btnCancelForm";
            this.btnCancelForm.Size = new System.Drawing.Size(75, 26);
            this.btnCancelForm.TabIndex = 14;
            this.btnCancelForm.Text = "Cancel";
            this.btnCancelForm.UseVisualStyleBackColor = true;
            this.btnCancelForm.Click += new System.EventHandler(this.btnCancelForm_Click);
            this.btnCancelForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // btnDeleteForm
            // 
            this.btnDeleteForm.Enabled = false;
            this.btnDeleteForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteForm.Location = new System.Drawing.Point(345, 131);
            this.btnDeleteForm.Name = "btnDeleteForm";
            this.btnDeleteForm.Size = new System.Drawing.Size(75, 26);
            this.btnDeleteForm.TabIndex = 13;
            this.btnDeleteForm.Text = "Delete";
            this.btnDeleteForm.UseVisualStyleBackColor = true;
            this.btnDeleteForm.Click += new System.EventHandler(this.btnDeleteForm_Click);
            this.btnDeleteForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveForm.Location = new System.Drawing.Point(264, 131);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(75, 26);
            this.btnSaveForm.TabIndex = 12;
            this.btnSaveForm.Text = "Save";
            this.btnSaveForm.UseVisualStyleBackColor = true;
            this.btnSaveForm.Click += new System.EventHandler(this.btnSaveForm_Click);
            this.btnSaveForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Parent Menu";
            // 
            // cmbParentMenu
            // 
            this.cmbParentMenu.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbParentMenu.FormattingEnabled = true;
            this.cmbParentMenu.Location = new System.Drawing.Point(9, 99);
            this.cmbParentMenu.Name = "cmbParentMenu";
            this.cmbParentMenu.Size = new System.Drawing.Size(218, 26);
            this.cmbParentMenu.TabIndex = 7;
            this.cmbParentMenu.SelectedIndexChanged += new System.EventHandler(this.cmbParentMenu_SelectedIndexChanged);
            this.cmbParentMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Main Menu";
            // 
            // cmbMainMenu
            // 
            this.cmbMainMenu.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbMainMenu.FormattingEnabled = true;
            this.cmbMainMenu.Location = new System.Drawing.Point(9, 46);
            this.cmbMainMenu.Name = "cmbMainMenu";
            this.cmbMainMenu.Size = new System.Drawing.Size(218, 26);
            this.cmbMainMenu.TabIndex = 1;
            this.cmbMainMenu.SelectedIndexChanged += new System.EventHandler(this.cmbMainMenu_SelectedIndexChanged);
            this.cmbMainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(791, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disp. Ord.";
            // 
            // txtDisplayOrderForm
            // 
            this.txtDisplayOrderForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayOrderForm.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtDisplayOrderForm.Location = new System.Drawing.Point(794, 99);
            this.txtDisplayOrderForm.Name = "txtDisplayOrderForm";
            this.txtDisplayOrderForm.Size = new System.Drawing.Size(67, 26);
            this.txtDisplayOrderForm.TabIndex = 11;
            this.txtDisplayOrderForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisplayOrderForm_KeyDown);
            this.txtDisplayOrderForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowIntegerOnly);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(230, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Default Parameter (Ex. Abc,10,10.20)";
            // 
            // txtDefaultParameter
            // 
            this.txtDefaultParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDefaultParameter.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtDefaultParameter.Location = new System.Drawing.Point(233, 99);
            this.txtDefaultParameter.Name = "txtDefaultParameter";
            this.txtDefaultParameter.Size = new System.Drawing.Size(555, 26);
            this.txtDefaultParameter.TabIndex = 9;
            this.txtDefaultParameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(547, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Form Text";
            // 
            // txtFormText
            // 
            this.txtFormText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormText.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtFormText.Location = new System.Drawing.Point(550, 46);
            this.txtFormText.Name = "txtFormText";
            this.txtFormText.Size = new System.Drawing.Size(310, 26);
            this.txtFormText.TabIndex = 5;
            this.txtFormText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(230, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Form Name";
            // 
            // txtFormName
            // 
            this.txtFormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtFormName.Location = new System.Drawing.Point(233, 46);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(311, 26);
            this.txtFormName.TabIndex = 3;
            this.txtFormName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // dgvForms
            // 
            this.dgvForms.AllowUserToAddRows = false;
            this.dgvForms.AllowUserToDeleteRows = false;
            this.dgvForms.AllowUserToOrderColumns = true;
            this.dgvForms.AllowUserToResizeRows = false;
            this.dgvForms.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mainmenuid,
            this.mainmenu,
            this.formname,
            this.formtext,
            this.parentmenuid,
            this.parentmenu,
            this.formdisplayorder,
            this.param});
            this.dgvForms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvForms.Location = new System.Drawing.Point(3, 163);
            this.dgvForms.MultiSelect = false;
            this.dgvForms.Name = "dgvForms";
            this.dgvForms.Size = new System.Drawing.Size(860, 292);
            this.dgvForms.TabIndex = 15;
            this.dgvForms.Click += new System.EventHandler(this.dgvForms_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // mainmenuid
            // 
            this.mainmenuid.DataPropertyName = "mainmenuid";
            this.mainmenuid.HeaderText = "mainmenuid";
            this.mainmenuid.Name = "mainmenuid";
            this.mainmenuid.ReadOnly = true;
            this.mainmenuid.Visible = false;
            // 
            // mainmenu
            // 
            this.mainmenu.DataPropertyName = "mainmenu";
            this.mainmenu.HeaderText = "Main Menu";
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.ReadOnly = true;
            this.mainmenu.Width = 150;
            // 
            // formname
            // 
            this.formname.DataPropertyName = "formname";
            this.formname.HeaderText = "Form Name";
            this.formname.Name = "formname";
            this.formname.ReadOnly = true;
            this.formname.Width = 150;
            // 
            // formtext
            // 
            this.formtext.DataPropertyName = "formtext";
            this.formtext.HeaderText = "Form Text";
            this.formtext.Name = "formtext";
            this.formtext.ReadOnly = true;
            this.formtext.Width = 150;
            // 
            // parentmenuid
            // 
            this.parentmenuid.DataPropertyName = "parentmenuid";
            this.parentmenuid.HeaderText = "parentmenuid";
            this.parentmenuid.Name = "parentmenuid";
            this.parentmenuid.ReadOnly = true;
            this.parentmenuid.Visible = false;
            // 
            // parentmenu
            // 
            this.parentmenu.DataPropertyName = "parentmenu";
            this.parentmenu.HeaderText = "Parent Menu";
            this.parentmenu.Name = "parentmenu";
            this.parentmenu.ReadOnly = true;
            this.parentmenu.Width = 150;
            // 
            // formdisplayorder
            // 
            this.formdisplayorder.DataPropertyName = "formdisplayorder";
            this.formdisplayorder.HeaderText = "Order";
            this.formdisplayorder.Name = "formdisplayorder";
            this.formdisplayorder.ReadOnly = true;
            this.formdisplayorder.Width = 50;
            // 
            // param
            // 
            this.param.DataPropertyName = "param";
            this.param.HeaderText = "Default Param";
            this.param.Name = "param";
            this.param.ReadOnly = true;
            this.param.Width = 150;
            // 
            // grpDatabseSelection
            // 
            this.grpDatabseSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatabseSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpDatabseSelection.Controls.Add(this.label11);
            this.grpDatabseSelection.Controls.Add(this.cmbDatabase);
            this.grpDatabseSelection.Controls.Add(this.label10);
            this.grpDatabseSelection.Controls.Add(this.txtPassword);
            this.grpDatabseSelection.Controls.Add(this.label9);
            this.grpDatabseSelection.Controls.Add(this.txtId);
            this.grpDatabseSelection.Controls.Add(this.label8);
            this.grpDatabseSelection.Controls.Add(this.cmbServerName);
            this.grpDatabseSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatabseSelection.Location = new System.Drawing.Point(15, 4);
            this.grpDatabseSelection.Name = "grpDatabseSelection";
            this.grpDatabseSelection.Size = new System.Drawing.Size(1206, 70);
            this.grpDatabseSelection.TabIndex = 0;
            this.grpDatabseSelection.TabStop = false;
            this.grpDatabseSelection.Text = "Database";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(734, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Database";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDatabase.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(737, 32);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(284, 26);
            this.cmbDatabase.TabIndex = 7;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            this.cmbDatabase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            this.cmbDatabase.Leave += new System.EventHandler(this.cmbDatabase_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(578, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtPassword.Location = new System.Drawing.Point(581, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "cis@123";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(422, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtId.Location = new System.Drawing.Point(425, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 26);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "sa";
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(120, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Server Name";
            // 
            // cmbServerName
            // 
            this.cmbServerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbServerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServerName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(123, 32);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(296, 26);
            this.cmbServerName.TabIndex = 1;
            this.cmbServerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allkeydown);
            // 
            // frmMenuCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 553);
            this.Controls.Add(this.grpDatabseSelection);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grpMainMenu);
            this.MaximizeBox = false;
            this.Name = "frmMenuCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Creation";
            this.grpMainMenu.ResumeLayout(false);
            this.grpMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForms)).EndInit();
            this.grpDatabseSelection.ResumeLayout(false);
            this.grpDatabseSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMainMenu;
        private System.Windows.Forms.Button btnSaveMainMenu;
        private System.Windows.Forms.Label lblMainMenuName;
        private System.Windows.Forms.TextBox txtMainMenuName;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDisplayOrderMainMenu;
        private System.Windows.Forms.DataGridView dgvMainMenu;
        private System.Windows.Forms.Button btnCancelMainMenu;
        private System.Windows.Forms.Button btnDeleteMainMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDisplayOrderForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDefaultParameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFormText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.DataGridView dgvForms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbParentMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMainMenu;
        private System.Windows.Forms.Button btnCancelForm;
        private System.Windows.Forms.Button btnDeleteForm;
        private System.Windows.Forms.Button btnSaveForm;
        private System.Windows.Forms.GroupBox grpDatabseSelection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainmenuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainmenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn formname;
        private System.Windows.Forms.DataGridViewTextBoxColumn formtext;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentmenuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentmenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn formdisplayorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn param;
        private System.Windows.Forms.Button btnMainMenuExport;
        private System.Windows.Forms.Button btnFormExport;
        private System.Windows.Forms.Button btnExit;
    }
}

