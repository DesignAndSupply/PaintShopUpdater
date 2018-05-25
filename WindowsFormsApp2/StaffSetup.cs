using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class StaffSetup : Form
    {
 
        private DataSet dataSet = new DataSet();
        

        public StaffSetup()
        {
            InitializeComponent();
        }

        

        private void StaffSetup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_painting_staff' table. You can move, or remove it, as needed.
            this.c_view_painting_staffTableAdapter.Fill(this.user_infoDataSet.c_view_painting_staff);

            DataTable dt = new DataTable();
            dt.Columns.Add("Column4", typeof(String));
            //dt.Columns.Add("Staff1", typeof(int));
            //dt.Columns.Add("Staff2", typeof(int));
            //dt.Columns.Add("Staff3", typeof(int));
            dgStaffSetup.DataSource = dt;

            dt.Rows.Add(new object[] { "Up" });
            dt.Rows.Add(new object[] { "Wash/Wipe" });
            dt.Rows.Add(new object[] { "Etch" });
            dt.Rows.Add(new object[] { "Sand" });
            dt.Rows.Add(new object[] { "Powder Prime" });
            dt.Rows.Add(new object[] { "Powder Coat" });
            dt.Rows.Add(new object[] { "Oven" });
            dt.Rows.Add(new object[] { "Wet Prep" });
            dt.Rows.Add(new object[] { "Wet Paint" });
            dt.Rows.Add(new object[] { "Oven 2" });
            dgStaffSetup.DataSource = dt;

            //XmlReader xmlFile;
            //xmlFile = XmlReader.Create("xml.xml", new XmlReaderSettings());
            //DataSet ds = new DataSet();
            //ds.ReadXml(xmlFile);


            dgStaffSetup.AutoGenerateColumns = false;
            //XmlReader xmlFile;
            //xmlFile = XmlReader.Create("xml.xml", new XmlReaderSettings());
            //DataSet ds = new DataSet();
            //ds.ReadXml(xmlFile);
            //dgVisual.DataSource = ds.Tables[0];
            //dgStaffSetup.DataSource = ds.Tables[0];

            string myXMLfile = @"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\PaintShop\xml.xml";
            DataSet ds = new DataSet();
            // Create new FileStream with which to read the schema.
            System.IO.FileStream fsReadXml = new System.IO.FileStream
                (myXMLfile, System.IO.FileMode.Open);
            try
            {
                ds.ReadXml(fsReadXml);
                dgStaffSetup.DataSource = ds;

                dgStaffSetup.DataMember = "Table1";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fsReadXml.Close();
            }

        }

        private void dgStaffSetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteToFile();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void WriteToFile()
        {

            XmlTextWriter newXml = new XmlTextWriter(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\PaintShop\\xml.xml", Encoding.UTF8);
            DataSet ds = (DataSet)dgStaffSetup.DataSource;
            ds.WriteXml(newXml);
            ds.Dispose();
            newXml.Close();
            MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void cviewpaintingstaffBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
