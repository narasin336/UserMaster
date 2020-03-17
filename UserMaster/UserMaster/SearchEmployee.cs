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
    public partial class SearchEmployee : Form
    {
        int valErr = 0;
        //SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Database.accdb");

        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            conn.Open();
            Showdata();
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[varindex].Name = "EmployeeCode";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "EmployeeName";
            dataGridView1.Columns[varindex].Width = 350;

            string sql = " Select * from HR_Employee order by EmployeeID ";
            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string varEmployeeName = dr["ThaiName"].ToString() + " " + dr["ThaiSurname"].ToString(); 
                dataGridView1.Rows.Add(dr["EmployeeID"].ToString(), varEmployeeName);
            }
            dr.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                MyGlobal.GlobalEmployeeCode = dataGridView1.Rows[e.RowIndex].Cells["EmployeeCode"].Value.ToString();
                MyGlobal.GlobalEmployeeName = dataGridView1.Rows[e.RowIndex].Cells["EmployeeName"].Value.ToString();
                this.Close();
            }
            catch
            {

            }
        }
    }
}
