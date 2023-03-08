using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmOutstandingUp : Form
    {
        public frmOutstandingUp()
        {
            InitializeComponent();

            //load the data

            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                conn.Open();

                string sql = "select d.id,dt.door_type_description,s.[NAME],up_complete_date,date_paint from dbo.door d " +
                    "left join dbo.door_type dt on d.door_type_id = dt.id " +
                    "left join dbo.SALES_LEDGER s on d.customer_acc_ref = s.ACCOUNT_REF " +
                    "where up_complete_date is not null AND date_paint is not null " +
                    "AND (complete_paint is null or complete_paint  = 0)  and  " +
                    "(status_id = 1 or status_id = 2 or status_id = 3) and up_complete_date >= '20230101' " +
                    "and cast(up_complete_date as date) <=  dbo.func_work_days(CAST(GETDATE() as date),1) " +
                    "order by up_complete_date";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                conn.Close();
            }
            format();
        }
        private void format()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

