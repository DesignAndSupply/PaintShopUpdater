using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Document;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class Document
    {

        public int boxID { get; set; }
        public string colour { get; set; }
        public DateTime delDate { get; set; }
        public double kgsWhenFull { get; set; }

        public Document(int _boxID)
        {
            boxID = _boxID;
            getBoxDetails(_boxID);
        }

        private void getBoxDetails(int boxID)
        {
            SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlconn;

            cmd.CommandText = "Select * From c_view_paint_box_list where [Box ID]=@boxID";
            cmd.Parameters.AddWithValue("@boxID", boxID);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                colour = rdr["Colour"].ToString();
                delDate = Convert.ToDateTime(rdr["Date Delivered"]);
                kgsWhenFull = Convert.ToDouble(rdr["Kgs When New"]);
            }

            rdr.Close();
            
        }

        public void PrintBoxLabel()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            DocumentModel document = DocumentModel.Load(@"\\designsvr1\apps\Design and Supply CSharp\Documents\PaintShop\BoxLabel.docx");

            //string pathToResources = "Resources";

            document.Bookmarks["BOXID"].GetContent(false).LoadText(boxID.ToString());
            document.Bookmarks["COLOUR"].GetContent(false).LoadText(colour);
            document.Bookmarks["DATEDELIVERED"].GetContent(false).LoadText(delDate.ToShortDateString());
            document.Bookmarks["KGSWHENFULL"].GetContent(false).LoadText(kgsWhenFull.ToString());

            document.Print();
        }


    }
}
