using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Document;

namespace WindowsFormsApp2
{
    class Document
    {

        public int boxID { get; set; }
        public string colour { get; set; }
        public DateTime delDate { get; set; }
        public double kgsWhenFull { get; set; }

        public Document(int _boxID, string _colour, DateTime _dateDel, double _kgsWhenFull)
        {
            boxID = _boxID;
            colour = _colour;
            delDate = _dateDel;
            kgsWhenFull = _kgsWhenFull;
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
