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
using System.Collections;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet1.c_view_paint_on_door' table. You can move, or remove it, as needed.
            //this.c_view_paint_on_doorTableAdapter.Fill(this.order_databaseDataSet1.c_view_paint_on_door);
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_painting_staff' table. You can move, or remove it, as needed.
            this.c_view_painting_staffTableAdapter.Fill(this.user_infoDataSet.c_view_painting_staff);
            // TODO: This line of code loads data into the 'user_infoDataSet.user' table. You can move, or remove it, as needed.
            //this.userTableAdapter.Fill(this.user_infoDataSet.user);

            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;

            txtSearch.Validating += new CancelEventHandler(txtSearch_Validating);
            cmdOp.Validating += new CancelEventHandler(cmdOp_Validating);
        }


        public string FinishID
        {
            get { return txtFinish.Text; }
            set { txtFinish.Text = value; }
        }

        private void userinfoDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {

                //UPDATES OPERATIONS DATAGRID
                SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

                RefreshMainGrid();
                RefreshProgressGrid();

                //UPDATES THE PAINT TO DOOR DATAGRID
                SqlCommand sqlPaint = new SqlCommand();
                sqlPaint.Connection = con;
                sqlPaint.CommandType = CommandType.Text;
                sqlPaint.CommandText = String.Format("Select * From c_view_paint_on_door WHERE door_id={0}", txtSearch.Text);
                SqlDataAdapter sqlPaintAdap = new SqlDataAdapter(sqlPaint);

                RefreshDoorData();

                try
                {

                    DataTable dtPaint = new DataTable();
                    sqlPaintAdap.Fill(dtPaint);
                    dgPaintToDoor.DataSource = dtPaint;

                }
                catch (Exception)
                {
                    MessageBox.Show("Please ensure you enter a valid door number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //////

                //REFRESHES OPERATION COMBO BOX
                refreshCombo();


            }
            else
            {
                MessageBox.Show("Door number is required before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.c_view_painting_sectionsTableAdapter.FillBy(this.order_databaseDataSet1.c_view_painting_sections);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void refreshCombo()
        {
            try
            {
                int finish_id = Convert.ToInt32(txtFinishID.Text);
                cmdOp.Items.Clear();
                switch (finish_id)
                {
                    //NO FINISH
                    case 1:
                    case 3:
                    case 6:
                        cmdOp.Items.Clear();
                        break;
                    //ETCH PRIME
                    case 2:
                        cmdOp.Items.Add("Up");
                        cmdOp.Items.Add("Wash/Wipe");
                        cmdOp.Items.Add("Etch");
                        cmdOp.Items.Add("Sand");
                        cmdOp.Items.Add("Oven");
                        break;
                    //TWO TONE WET
                    case 4:
                    case 10:
                        cmdOp.Items.Add("Up");
                        cmdOp.Items.Add("Wash/Wipe");
                        cmdOp.Items.Add("Etch");
                        cmdOp.Items.Add("Sand");
                        cmdOp.Items.Add("Powder Coat");
                        cmdOp.Items.Add("Oven");
                        cmdOp.Items.Add("Wet Prep");
                        cmdOp.Items.Add("Wet Paint");
                        cmdOp.Items.Add("Oven 2");

                        break;
                    //JUST WET PAINT
                    case 5:
                        cmdOp.Items.Add("Up");
                        cmdOp.Items.Add("Wash/Wipe");
                        cmdOp.Items.Add("Etch");
                        cmdOp.Items.Add("Sand");
                        cmdOp.Items.Add("Wet Prep");
                        cmdOp.Items.Add("Wet Paint");
                        cmdOp.Items.Add("Oven 2");
                        break;
                    //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                    case 7:
                    case 11:

                        cmdOp.Items.Add("Up");
                        cmdOp.Items.Add("Wash/Wipe");
                        cmdOp.Items.Add("Etch");
                        cmdOp.Items.Add("Sand");
                        cmdOp.Items.Add("Powder Coat");
                        cmdOp.Items.Add("Oven");


                        break;

                    //COASTAL GRADE
                    case 9:
                    case 12:
                    case 13:
                        cmdOp.Items.Add("Up");
                        cmdOp.Items.Add("Wash/Wipe");
                        cmdOp.Items.Add("Etch");
                        cmdOp.Items.Add("Sand");
                        cmdOp.Items.Add("Powder Prime");
                        cmdOp.Items.Add("Oven");
                        cmdOp.Items.Add("Powder Coat");
                        cmdOp.Items.Add("Oven 2");

                        break;
                    case 14:
                        cmdOp.Items.Add("Up");
                        cmdOp.Items.Add("Wash/Wipe");
                        cmdOp.Items.Add("Etch");
                        cmdOp.Items.Add("Sand");
                        cmdOp.Items.Add("Powder Prime");
                        cmdOp.Items.Add("Oven");
                        cmdOp.Items.Add("Wet Prep");
                        cmdOp.Items.Add("Wet Paint");
                        cmdOp.Items.Add("Powder Coat");
                        cmdOp.Items.Add("Oven 2");

                        break;
                    default:
                        cmdOp.Items.Clear();

                        break;

                }

            }
            catch { }

        }

        private void updateAll(string oper)
        {
                Operations op = new Operations();
                SqlStatements sqlUpdate = new SqlStatements();

                Boolean checkGrid = GridCheck(oper);

                //NEEDS TO CHECK CELL VALUE
                if (checkGrid == false)
                {
                    //MessageBox.Show("This operation has already been completed!", "Already Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //WORK OUT THE TIME SPLIT
                    TimeSplit ts = new TimeSplit();
                    int SplitTime = ts.GetTimeSplit(oper);
                    int staff_no1 = 0;
                    int staff_no2 = 0;
                    int staff_no3 = 0;
                    int menIn = 0;
                    int staffDynamic;
                    int finishType = Int32.Parse(this.txtFinishID.Text);

                    var allStaff = ts.GetAllInDept(oper);


                    staff_no1 = allStaff.Item1;
                    staff_no2 = allStaff.Item2;
                    staff_no3 = allStaff.Item3;

                    //Works out the amount of men in the department

                    if (staff_no3 == 195)
                    {
                        if (staff_no2 == 195)
                        {
                            menIn = 1;
                        }
                        else
                        {
                            menIn = 2;
                        }
                    }
                    else
                    {
                        menIn = 3;
                    }



                    staffDynamic = 0;
                    for (int i = 1; i <= menIn; ++i)
                    {

                        switch (i)
                        {
                            case 1:
                               staffDynamic = staff_no1;
                               break;
                            case 2:
                                staffDynamic = staff_no2;
                                break;
                            case 3:
                                staffDynamic = staff_no3;
                                break;
                        }

                        sqlUpdate.InsertPartCompletion(Int32.Parse(txtSearch.Text), oper, op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), oper, finishType, menIn), staffDynamic, i);

                        }

                 

                    //UPDATE DailyGoals
                    sqlUpdate.UpdateDailyGoals(op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), oper, finishType));

                    switch (oper)
                    {
                        case "Up":
                            //UPDATE DOOR
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Up", finishType) / int.Parse(txtQuantitySame.Text), "up", staff_no1, staff_no2, staff_no3);
                        //Opens the palletizer to take the jobs off the pallet
                        //palletize(true);
                            break;
                        case "Wash/Wipe":
                            //UPDATE DOOR
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Wash/Wipe", finishType) / int.Parse(txtQuantitySame.Text), "ww", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Etch":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Etch", finishType) / int.Parse(txtQuantitySame.Text), "etch", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Sand":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Sand", finishType) / int.Parse(txtQuantitySame.Text), "sand", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Powder Prime":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Powder Prime", finishType) / int.Parse(txtQuantitySame.Text), "pp", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Powder Coat":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Powder Coat", finishType) / int.Parse(txtQuantitySame.Text), "pc", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Oven":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Oven", finishType) / int.Parse(txtQuantitySame.Text), "oven", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Wet Prep":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Wet Prep", finishType) / int.Parse(txtQuantitySame.Text), "wp", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Wet Paint":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Wet Paint", finishType) / int.Parse(txtQuantitySame.Text), "wet", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Oven 2":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Oven 2", finishType) / int.Parse(txtQuantitySame.Text), "oven1", staff_no1, staff_no2, staff_no3);
                            break;
                        default:
                            MessageBox.Show("No operation has been selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                SqlStatements sqlCheck100 = new SqlStatements();
                sqlCheck100.timeStamp100();

                //REFRESH THE DATAGRID
                RefreshMainGrid();
           
                }
        }
    


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmdOp.SelectedIndex > -1) { 
                Operations op = new Operations();
                SqlStatements sqlUpdate = new SqlStatements();

                Boolean checkGrid = GridCheck(cmdOp.Text);

                //NEEDS TO CHECK CELL VALUE
                if (checkGrid == false)
                {
                    MessageBox.Show("This operation has already been completed!", "Already Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //WORK OUT THE TIME SPLIT
                    TimeSplit ts = new TimeSplit();
                    int SplitTime = ts.GetTimeSplit(cmdOp.Text.ToString());
                    int staff_no1 = 0;
                    int staff_no2 = 0;
                    int staff_no3 = 0;
                    int menIn = 0;
                    int staffDynamic;
                    int finishType = Int32.Parse(this.txtFinishID.Text);



                    //UPDATE DOOR PART COMPLETION LOG
                    if (SplitTime == 1)
                    {
                        frmTimeAllocation ta = new frmTimeAllocation(cmdOp.Text.ToString());
                        ta.ShowDialog();
                        sqlUpdate.InsertPartCompletion(Int32.Parse(txtSearch.Text), cmdOp.Text.ToString(), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), cmdOp.Text.ToString(), finishType), ta.ReturnStaffId);

                        staff_no1 = ta.ReturnStaffId;
                        staff_no2 = 0;
                        staff_no3 = 0;

                    }
                    else
                    {


                        var allStaff = ts.GetAllInDept(cmdOp.Text.ToString());


                        staff_no1 = allStaff.Item1;
                        staff_no2 = allStaff.Item2;
                        staff_no3 = allStaff.Item3;

                        //Works out the amount of men in the department

                        if (staff_no3 == 195)
                        {
                            if (staff_no2 == 195)
                            {
                                menIn = 1;
                            }
                            else
                            {
                                menIn = 2;
                            }
                        }
                        else
                        {
                            menIn = 3;
                        }



                        staffDynamic = 0;
                        for (int i = 1; i <= menIn; ++i)
                        {

                            switch (i)
                            {
                                case 1:
                                    staffDynamic = staff_no1;
                                    break;
                                case 2:
                                    staffDynamic = staff_no2;
                                    break;
                                case 3:
                                    staffDynamic = staff_no3;
                                    break;
                            }

                            sqlUpdate.InsertPartCompletion(Int32.Parse(txtSearch.Text), cmdOp.Text.ToString(), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), cmdOp.Text.ToString(), finishType, menIn), staffDynamic,i);

                        }

                    }

                    //UPDATE DailyGoals
                    sqlUpdate.UpdateDailyGoals(op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), cmdOp.Text.ToString(), finishType));

                    switch (cmdOp.SelectedItem)
                    {
                        case "Up":
                            //UPDATE DOOR
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Up", finishType) / int.Parse(txtQuantitySame.Text), "up", staff_no1, staff_no2, staff_no3);

                            //Opens the palletizer to take the jobs off the pallet
                           // palletize(true);



                            break;
                        case "Wash/Wipe":
                            //UPDATE DOOR
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Wash/Wipe", finishType) / int.Parse(txtQuantitySame.Text), "ww", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Etch":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Etch", finishType) / int.Parse(txtQuantitySame.Text), "etch", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Sand":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Sand", finishType) / int.Parse(txtQuantitySame.Text), "sand", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Powder Prime":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Powder Prime", finishType) / int.Parse(txtQuantitySame.Text), "pp", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Powder Coat":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Powder Coat", finishType) / int.Parse(txtQuantitySame.Text), "pc", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Oven":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Oven", finishType) / int.Parse(txtQuantitySame.Text), "oven", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Wet Prep":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Wet Prep", finishType) / int.Parse(txtQuantitySame.Text), "wp", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Wet Paint":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Wet Paint", finishType) / int.Parse(txtQuantitySame.Text), "wet", staff_no1, staff_no2, staff_no3);
                            break;
                        case "Oven 2":
                            sqlUpdate.UpdateDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), "Oven 2", finishType) / int.Parse(txtQuantitySame.Text), "oven1", staff_no1, staff_no2, staff_no3);
                            break;
                        default:
                            MessageBox.Show("No operation has been selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    //btnSearch_Click(sender,e);

                    SqlStatements sqlCheck100 = new SqlStatements();
                    sqlCheck100.timeStamp100();


                    //REFRESH THE DATAGRID
                    RefreshMainGrid();
                }
            }
            else
            {
                MessageBox.Show("You must select an operation to continue!", "No operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void palletize(bool useArgs)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
         
            psi.FileName = @"C:\Users\" + Environment.UserName + @"\source\repos\Palletizer\Palletizer\bin\Debug\Palletizer.exe";

            if (useArgs == false)
            {

            }
            else
            {
                psi.Arguments = "Paint " + txtSearch.Text;
            }
           
            p.StartInfo = psi;
            p.Start();
        }

        private void RefreshProgressGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = String.Format("Select op,date_op,date_op_complete FROM c_view_door_production_progress where id={0} order by op_order", txtSearch.Text);
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dgProductionProgress.DataSource = dtRecord;
        }
        private void RefreshMainGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = String.Format("Select id,section,staff1,staff2,staff3,dateComplete from c_view_painting_sections where id={0} order by op_order", txtSearch.Text);
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }

        private void RefreshDoorData()
        {
            try
            {
                //GETS DOOR DATA
                //UPDATES OPERATIONS DATAGRID
                SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);
                SqlCommand sqlDoorData = new SqlCommand();
                sqlDoorData.Connection = con;
                sqlDoorData.CommandType = CommandType.Text;
                sqlDoorData.CommandText = String.Format("Select * From dbo.c_view_door_data WHERE id={0}", txtSearch.Text);
                SqlDataAdapter sqlDoorDataAdap = new SqlDataAdapter(sqlDoorData);

                DataTable dtDoorData = new DataTable();
                sqlDoorDataAdap.Fill(dtDoorData);

                txtFinishID.Text = dtDoorData.Rows[0]["finish_id"].ToString();
                txtFinish.Text = dtDoorData.Rows[0]["finish_description"].ToString();
                txtCustomer.Text = dtDoorData.Rows[0]["NAME"].ToString();
                txtDoorType.Text = dtDoorData.Rows[0]["door_type_description"].ToString();
                txtPaintingStatus.Text = dtDoorData.Rows[0]["paint_status"].ToString();
                txtPaintingNote.Text = dtDoorData.Rows[0]["painting_note"].ToString();
                txtQuantitySame.Text = dtDoorData.Rows[0]["quantity_same"].ToString();
                colourStatus();
            }
            catch
            {
                MessageBox.Show("No door number found, please try again!", "No Matching ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void dgStaffSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStaffSetup_Click(object sender, EventArgs e)
        {
           
            StaffSetup f2 = new StaffSetup();
            f2.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmdOp.SelectedIndex > -1)
            {
                Operations op = new Operations();
                SqlStatements sqlUpdate = new SqlStatements();
                //NEEDS TO CHECK CELL VALUE
                Boolean checkGrid = GridCheck(cmdOp.Text);
                if (checkGrid == true)
                {
                    MessageBox.Show("This operation has not been completed so cannot be removed.", "Cannot Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int finishType = Int32.Parse(this.txtFinishID.Text);
                    string short_op = "";

                    //DELETE FROM COMPLETION LOG
                    sqlUpdate.DeletePartCompletion(Int32.Parse(txtSearch.Text), cmdOp.Text.ToString());


                    //ADD BACK TO DOOR

                    switch (cmdOp.SelectedItem)
                    {
                        case "Up":
                            short_op = "up";
                            break;
                        case "Wash/Wipe":
                            short_op = "ww";
                            break;
                        case "Etch":
                            short_op = "etch";
                            break;
                        case "Sand":
                            short_op = "sand";
                            break;
                        case "Powder Prime":
                            short_op = "pp";
                            break;
                        case "Powder Coat":
                            short_op = "pc";
                            break;
                        case "Oven":
                            short_op = "oven";
                            break;
                        case "Wet Prep":
                            short_op = "wp";
                            break;
                        case "Wet Paint":
                            short_op = "wet";
                            break;
                        case "Oven 2":
                            short_op = "oven1";
                            break;
                        default:
                            MessageBox.Show("No operation has been selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                    }

                    sqlUpdate.AddToDoor(Int32.Parse(txtSearch.Text), op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), cmdOp.Text.ToString(), finishType) / int.Parse(txtQuantitySame.Text), short_op);


                    //Remove from daily goals

                    sqlUpdate.DeductDailyGoals(op.CalcTimeRemaining(Int32.Parse(txtSearch.Text), cmdOp.Text.ToString(), finishType));
                    //btnSearch_Click(sender, e);

                    //REFRESH THE MAIN DATAGRID
                    RefreshMainGrid();
                }
            }
            else
            {
                MessageBox.Show("You must select an operation to continue!", "No operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(txtSearch.Text, out int n);

            if (isNumeric == true)
            {

                    foreach (object o in cmdOp.Items)
                    {
                        updateAll(o.ToString());
                    }


                    //NEEDS TO MARK THE DOOR AS COMPLETE
                    SqlStatements sqlUpdate = new SqlStatements();

                    frmLooseItems fli = new frmLooseItems(int.Parse(this.txtSearch.Text));

                    fli.ShowDialog();


                    

                    sqlUpdate.CompleteDoor(Int32.Parse(txtSearch.Text), -1);
                    RefreshDoorData();
               
            }
        }

        private void colourStatus()
        {
            if (txtPaintingStatus.Text == "Complete")
            {
                txtPaintingStatus.BackColor = Color.Green;
            }
            else
            {
                txtPaintingStatus.BackColor = Color.Red;
            }
        }


        private Boolean GridCheck(string op)
        {
            string up = dataGridView1.Rows[0].Cells[5].Value.ToString();
            string ww = dataGridView1.Rows[1].Cells[5].Value.ToString();
            string etch = dataGridView1.Rows[2].Cells[5].Value.ToString();
            string sand = dataGridView1.Rows[3].Cells[5].Value.ToString();
            string pp = dataGridView1.Rows[4].Cells[5].Value.ToString();
            string pc = dataGridView1.Rows[5].Cells[5].Value.ToString();
            string oven = dataGridView1.Rows[6].Cells[5].Value.ToString();
            string wp = dataGridView1.Rows[7].Cells[5].Value.ToString();
            string wet = dataGridView1.Rows[8].Cells[5].Value.ToString();
            string oven1 = dataGridView1.Rows[9].Cells[5].Value.ToString();

            
            Boolean isBlank;

            switch (op)
            {
                case "Up":
                       if (string.IsNullOrWhiteSpace(up))
                       {
                        isBlank = true;
                       }
                       else
                       {
                        isBlank = false;
                       }
                    break;
                case "Wash/Wipe":
                    if (string.IsNullOrWhiteSpace(ww))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                case "Etch":
                    if (string.IsNullOrWhiteSpace(etch))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                case "Sand":
                    if (string.IsNullOrWhiteSpace(sand))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                case "Powder Prime":
                    if (string.IsNullOrWhiteSpace(pp))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                case "Powder Coat":
                    if (string.IsNullOrWhiteSpace(pc))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                case "Oven":
                    if (string.IsNullOrWhiteSpace(oven))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                case "Wet Prep":
                    if (string.IsNullOrWhiteSpace(wp))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                case "Wet Paint":
                    if (string.IsNullOrWhiteSpace(wet))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                case "Oven 2":
                    if (string.IsNullOrWhiteSpace(oven1))
                    {
                        isBlank = true;
                    }
                    else
                    {
                        isBlank = false;
                    }
                    break;
                default:
                    isBlank = false;
                    break;
            }

            return isBlank;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(txtSearch.Text, out int n);

            if (isNumeric == true)
            {
                SqlStatements sqlUpdate = new SqlStatements();
                sqlUpdate.CompleteDoor(Int32.Parse(txtSearch.Text), 0);
                RefreshDoorData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RepaintsList rl = new RepaintsList();
            rl.ShowDialog();
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            Reporting rp = new Reporting();
            rp.ShowDialog();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tb, "Numerical value is required.");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb, string.Empty);
            }
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlStatements sqlUpdateNote = new SqlStatements();
                sqlUpdateNote.SaveNote(int.Parse(txtSearch.Text), this.txtPaintingNote.Text);
                MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("Note error, did not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdOp_Validating(object sender, CancelEventArgs e)
        {
            //var tb = (ComboBox)sender;
            //if (string.IsNullOrWhiteSpace(tb.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider2.SetError(tb, "You must select an operation!");

            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider2.SetError(tb, string.Empty);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLooseItems fli = new frmLooseItems(int.Parse(this.txtSearch.Text));
            fli.ShowDialog();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
           // btnSearch_Click(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(txtSearch.Text, out int n);

            if (isNumeric == true)
            {
                int num = int.Parse(this.txtSearch.Text);
                num++;
                this.txtSearch.Text = num.ToString();
                btnSearch_Click(sender, e);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(txtSearch.Text, out int n);

            if (isNumeric == true)
            {
                int num = int.Parse(this.txtSearch.Text);
                num--;
                this.txtSearch.Text = num.ToString();
                btnSearch_Click(sender, e);
            }
        }

        private void staffSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffSetup f2 = new StaffSetup();
            f2.ShowDialog();
        }

        private void repaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepaintsList rl = new RepaintsList();
            rl.ShowDialog();
        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting rp = new Reporting();
            rp.ShowDialog();
        }

        private void looseItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(txtSearch.Text, out int n);

            if (isNumeric == true)
            {
                frmLooseItems fli = new frmLooseItems(int.Parse(this.txtSearch.Text));
                fli.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cannot open loose items when a door number is not selected!", "Select door number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDoorType_TextChanged(object sender, EventArgs e)
        {

        }

        private void balanceStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockBalance frmSB = new frmStockBalance();
            frmSB.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (object o in cmdOp.Items)
            {
                updateAll(o.ToString());
            }
            
        }

        private void palletizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            palletize(false);
        }
    }
}
