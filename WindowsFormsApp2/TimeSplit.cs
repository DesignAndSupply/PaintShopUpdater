using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data;

namespace WindowsFormsApp2
{
    class TimeSplit
    {
        public int GetTimeSplit(string op)
        {
            int SplitTimes;

            if (MessageBox.Show("Do you wish to allocate this time to a specific person?", "Time Split", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplitTimes = 1;
                
                return SplitTimes;
            }
            else
            {
                SplitTimes = 0;
                
                return SplitTimes;
            }

        }




        public Tuple<int, int, int> GetAllInDept(string op)
        {

            DataSet ds = new DataSet();
            ds.ReadXml(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\PaintShop\xml.xml");



            DataTable xmlDt = ds.Tables["Table1"];
            string expression;
            string Staff1;
            string Staff2;
            string Staff3;
            int staffId1;
            int staffId2;
            int staffId3;

            expression = "Column4='" + op + "'";

            DataRow[] results = xmlDt.Select(expression);



            Staff1 = Convert.ToString(results[0]["Column1"]);

            Staff2 = Convert.ToString(results[0]["Column2"]);

            Staff3 = Convert.ToString(results[0]["Column3"]);

            SqlStatements sql = new SqlStatements();


            try
            {
                staffId1 = sql.GetStaffIDFromName(Staff1);
            }
            catch
            {
                staffId1 = 0;
            }
            try
            {
                staffId2 = sql.GetStaffIDFromName(Staff2);
            }
            catch
            {
                staffId2 = 0;
            }

            try
            {
                staffId3 = sql.GetStaffIDFromName(Staff3);
            }
            catch
            {
                staffId3 = 0;
            }




            var tuple = new Tuple<int, int, int>(staffId1, staffId2, staffId3);

            return tuple;

        }



    }

    
}
