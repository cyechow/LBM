using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using ExcelLibrary.SpreadSheet;

namespace LBM
{
    public class ReportGenerator
    {
        public ReportGenerator()
        {

        }

        public bool GenerateTestReport(string filePath)
        {
            try
            {
                Workbook wb = new Workbook();
                Worksheet ws = new Worksheet("TestSheet");
                ws.Cells[0, 0] = new Cell("TestCell", CellFormat.General);
                wb.Worksheets.Add(ws);
                wb.Save(filePath);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
                return false;
            }

            return true;
        }
    }
}
