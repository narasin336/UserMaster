namespace UserMaster
{
    partial class UserMaster
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
            this.bttClear = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comAuthority = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttChange = new System.Windows.Forms.Button();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.bttAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttSearchEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttClear
            // 
            this.bttClear.Location = new System.Drawing.Point(743, 10);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(75, 23);
            this.bttClear.TabIndex = 36;
            this.bttClear.Text = "Clear";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(230, 47);
            this.txtPosition.MaxLength = 50;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(301, 20);
            this.txtPosition.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Position";
            // 
            // comAuthority
            // 
            this.comAuthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comAuthority.FormattingEnabled = true;
            this.comAuthority.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comAuthority.Location = new System.Drawing.Point(594, 24);
            this.comAuthority.Name = "comAuthority";
            this.comAuthority.Size = new System.Drawing.Size(124, 21);
            this.comAuthority.TabIndex = 33;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 79);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(92, 20);
            this.txtID.TabIndex = 32;
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.Red;
            this.bttDelete.Location = new System.Drawing.Point(743, 76);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 31;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttChange
            // 
            this.bttChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttChange.Location = new System.Drawing.Point(663, 76);
            this.bttChange.Name = "bttChange";
            this.bttChange.Size = new System.Drawing.Size(75, 23);
            this.bttChange.TabIndex = 30;
            this.bttChange.Text = "Change";
            this.bttChange.UseVisualStyleBackColor = false;
            this.bttChange.Click += new System.EventHandler(this.bttChange_Click);
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(594, 50);
            this.txtSection.MaxLength = 10;
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(124, 20);
            this.txtSection.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Authority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 51);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(94, 20);
            this.txtPassword.TabIndex = 24;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(231, 24);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(301, 20);
            this.txtUserName.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(804, 384);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(65, 24);
            this.txtUserID.MaxLength = 10;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(69, 20);
            this.txtUserID.TabIndex = 21;
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttAdd.Location = new System.Drawing.Point(743, 38);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 34);
            this.bttAdd.TabIndex = 20;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "User ID";
            // 
            // bttSearchEmployee
            // 
            this.bttSearchEmployee.Image = global::UserMaster.Properties.Resources.magnifer;
            this.bttSearchEmployee.Location = new System.Drawing.Point(140, 23);
            this.bttSearchEmployee.Name = "bttSearchEmployee";
            this.bttSearchEmployee.Size = new System.Drawing.Size(23, 23);
            this.bttSearchEmployee.TabIndex = 37;
            this.bttSearchEmployee.UseVisualStyleBackColor = true;
            this.bttSearchEmployee.Click += new System.EventHandler(this.bttSearchEmployee_Click);
            // 
            // UserMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 506);
            this.Controls.Add(this.bttSearchEmployee);
            this.Controls.Add(this.bttClear);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comAuthority);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttChange);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.label1);
            this.Name = "UserMaster";
            this.Text = "UserMaster";
            this.Load += new System.EventHandler(this.UserMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comAuthority;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttChange;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttSearchEmployee;
    }
}