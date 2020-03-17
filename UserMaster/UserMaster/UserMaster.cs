using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace UserMaster
{
    public partial class UserMaster : Form
    {
        int valErr = 0;
        //SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "' ;MultipleActiveResultSets=True");
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Database.accdb");


        public UserMaster()
        {
            InitializeComponent();
        }

        private void UserMaster_Load(object sender, EventArgs e)
        {
            conn.Open();
            Showdata();
            ClearData();
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[varindex].Name = "UserID";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "UserName";
            dataGridView1.Columns[varindex].Width = 250;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Authority";
            dataGridView1.Columns[varindex].Width = 100;
            
            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Section";
            dataGridView1.Columns[varindex].Width = 100;
            
            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Position";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Password";
            dataGridView1.Columns[varindex].Width = 5;
            dataGridView1.Columns[varindex].DefaultCellStyle.ForeColor = Color.White; 

            string sql = " Select * from UserMaster order by UserID ";
            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["UserID"].ToString(), dr["UserName"].ToString(), dr["Authority"].ToString(), dr["Section"].ToString(), dr["Position"].ToString(), dr["Password"].ToString());
            }
            dr.Close();

        }


        private void ClearData()
        {
            txtUserID.Text = null;
            txtID.Text = null;
            txtPassword.Text = null;
            txtUserName.Clear();
            //txtUserID.ReadOnly = false;
            comAuthority.Text = "";
            comAuthority.SelectedIndex = -1;
            txtSection.Text = "";
            txtPosition.Text = "";
            bttAdd.Enabled = true;
            bttChange.Enabled = false;
            bttDelete.Enabled = false;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            CheckError();
            if (valErr == 0)
            {
                String sql = "INSERT INTO UserMaster (UserID,Password,UserName,Authority,Section,Position) VALUES ('" + txtUserID.Text + "','" + txtPassword.Text + "','" + txtUserName.Text + "','" + comAuthority.Text + "','" + txtSection.Text + "','" + txtPosition.Text + "')";
                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();
                MessageBox.Show("Add completed");
                ClearData();
                Showdata();
            }
        }

        private void bttChange_Click(object sender, EventArgs e)
        {
            CheckErrorUpdate();
            if (valErr != 0) { return; }
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Please select data"); return;
            }
            String sql = "Update UserMaster SET UserID='" + txtUserID.Text + "',Password='" + txtPassword.Text + "',UserName='" + txtUserName.Text + "',Authority = '" + comAuthority.Text + "',Section = '" + txtSection.Text + "',Position = '" + txtPosition.Text + "' where UserID='" + txtID.Text + "' ";
            OleDbCommand com = new OleDbCommand(sql, conn);
            com.ExecuteNonQuery();
            MessageBox.Show("Update completed");
            Showdata();
            ClearData();
        }

        private void CheckError()
        {
            valErr = 0;
            if (txtUserID.Text == "") { MessageBox.Show("Invalid user ID"); valErr = +1; return; }
            else if (txtPassword.Text == "") { MessageBox.Show("Please input password "); valErr = +1; return; }
            else if (txtUserName.Text == "") { MessageBox.Show("Please input user name "); valErr = +1; return; }
            else
            {
                string sql = " Select * FROM UserMaster where UserID='" + txtUserID.Text + "' ";
                OleDbCommand com = new OleDbCommand(sql, conn);
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show("This user already exist "); valErr = +1; return;
                }
                dr.Close();
            }

            if (comAuthority.Text == "") { MessageBox.Show("Please input Authority"); valErr = +1; return; }
        }

        private void CheckErrorUpdate()
        {
            valErr = 0;
            if (txtUserID.Text == "") { MessageBox.Show("Invalid user ID"); valErr = +1; return; }
            else if (txtPassword.Text == "") { MessageBox.Show("Please input password "); valErr = +1; return; }
            else if (txtUserName.Text == "") { MessageBox.Show("Please input user name "); valErr = +1; return; }
            else if (comAuthority.Text == "") { MessageBox.Show("Please input Authority"); valErr = +1; return; }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                txtUserID.Text = dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                comAuthority.Text = dataGridView1.Rows[e.RowIndex].Cells["Authority"].Value.ToString();
                txtSection.Text = dataGridView1.Rows[e.RowIndex].Cells["Section"].Value.ToString();
                txtPosition.Text = dataGridView1.Rows[e.RowIndex].Cells["Position"].Value.ToString();
                //txtUserID.ReadOnly = true;
                bttAdd.Enabled = false;
                bttChange.Enabled = true;
                bttDelete.Enabled = true;
            }
            catch
            {
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "") { MessageBox.Show("Please select data"); return; }
            if (MessageBox.Show("Do you want to delete the data ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Delete from UserMaster where UserID='" + txtID.Text + "' ";
                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Delete completed");
                Showdata();
                ClearData();

            }
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void bttSearchEmployee_Click(object sender, EventArgs e)
        {
            SearchEmployee WinD = new SearchEmployee();
            WinD.ShowDialog();
            txtUserID.Text = MyGlobal.GlobalEmployeeCode;
            txtUserName.Text = MyGlobal.GlobalEmployeeName;  
        }

    }
}
