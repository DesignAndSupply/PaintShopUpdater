using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class frmLooseItems : Form
    {

        private int doorID;
        
        public frmLooseItems(int door_no)
        {
            InitializeComponent();

            doorID = door_no;
            FillList();
            FillData();
            AddDeleteButton();

        }

        private void frmLooseItems_Load(object sender, EventArgs e)
        {

        }


        void SaveDataGrid()
        {

            //in your code this would be:
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);
            con.Open();

            //sqlPaintAdap.Update(dtLooseItems);

        }
        public void FillData()
        {
            
            try
            {

                SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

                SqlCommand sqlLooseItems = new SqlCommand();
                sqlLooseItems.Connection = con;
                sqlLooseItems.CommandType = CommandType.Text;
                sqlLooseItems.CommandText = String.Format("SELECT id,door_id,description, [quantity],[note] from dbo.c_view_painting_loose_items where door_id = @id order by id");
                sqlLooseItems.Parameters.AddWithValue("@id", doorID);
                SqlDataAdapter sqlPaintAdap = new SqlDataAdapter(sqlLooseItems);
                DataTable dtLooseItems = new DataTable();
                sqlPaintAdap.Fill(dtLooseItems);
                dgLooseItems.DataSource = dtLooseItems;

                
            }
            catch (Exception)
            {

            }

        }

        void FillList()
        {
            using (SqlConnection c = new SqlConnection(SqlStatements.ConnectionString))
            {
                c.Open();

                using (SqlDataAdapter a = new SqlDataAdapter("Select id, description From dbo.paint_loose_item order by description", c))
                {
                    var t = new DataTable();
                    a.Fill(t);

                    lstItems.DisplayMember = "Description";
                    lstItems.ValueMember = "ID";
                    lstItems.DataSource = t;
                    
                }
            }
        }

        void AddDeleteButton()
        {
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Delete";
            bcol.Text = "Delete";
            bcol.Name = "btnDelete";
            bcol.UseColumnTextForButtonValue = true;
            dgLooseItems.Columns.Add(bcol);
            dgLooseItems.Columns[0].ReadOnly = true;
            dgLooseItems.Columns[1].ReadOnly = true;
            dgLooseItems.Columns[2].ReadOnly = true;
        }

        private void dgLooseItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (MessageBox.Show("Are you sure you wish to delete this loose item?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var senderGrid = (DataGridView)sender;
                int looseItemId;
                int selectedrowindex = dgLooseItems.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgLooseItems.Rows[selectedrowindex];
                looseItemId = Int32.Parse(selectedRow.Cells["id"].Value.ToString());

                SqlConnection delConn = new SqlConnection(SqlStatements.ConnectionString);
                delConn.Open();
                SqlCommand del = new SqlCommand();
                del.Connection = delConn;
                del.CommandType = CommandType.Text;
                del.CommandText = "DELETE  FROM dbo.paint_loose_item_to_door WHERE id = @id";
                del.Parameters.AddWithValue("@id", looseItemId);

                del.ExecuteNonQuery();

                FillData();

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemId = int.Parse(lstItems.SelectedValue.ToString());

            SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);

            sqlconn.Open();

            SqlCommand sc = new SqlCommand();
            sc.Connection = sqlconn;
            sc.CommandType = CommandType.Text;
            sc.CommandText = "INSERT INTO dbo.paint_loose_item_to_door (door_id,loose_item_id,quantity,[date]) " +
                             "VALUES (@door_id,@loose_item_id,1,@date_added);";
            sc.Parameters.AddWithValue("@door_id", doorID);
            sc.Parameters.AddWithValue("@loose_item_id", itemId);
            sc.Parameters.AddWithValue("@date_added", DateTime.Now);


            sc.ExecuteNonQuery();

            FillData();
        }

        private void dgLooseItems_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //sqlPaintAdap.Update(dtLooseItems);
        }

        private void dgLooseItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            int looseItemId;
            int qty;
            string loose_item_note;


            int selectedrowindex = dgLooseItems.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgLooseItems.Rows[selectedrowindex];
            looseItemId = Int32.Parse(selectedRow.Cells["id"].Value.ToString());
            qty = Int32.Parse(selectedRow.Cells["quantity"].Value.ToString());
            loose_item_note = selectedRow.Cells["note"].Value.ToString();

            SqlConnection upConn = new SqlConnection(SqlStatements.ConnectionString);
            upConn.Open();
            SqlCommand up = new SqlCommand();
            up.Connection = upConn;
            up.CommandType = CommandType.Text;
            up.CommandText = "UPDATE dbo.paint_loose_item_to_door set [note] = @note , [quantity]=@quantity WHERE id=@id";
            up.Parameters.AddWithValue("@id", looseItemId);
            up.Parameters.AddWithValue("@quantity", qty);
            up.Parameters.AddWithValue("@note", loose_item_note);
            up.ExecuteNonQuery();

            FillData();


        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }
    }
}
