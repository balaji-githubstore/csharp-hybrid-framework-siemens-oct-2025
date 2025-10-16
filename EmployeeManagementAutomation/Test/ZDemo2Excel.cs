using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using EmployeeManagementAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Test
{
    /// <summary>
    /// Not part of the framework.
    /// </summary>
    public class ZDemo2Excel
    {
        [Test]
        public void ReadExcelTest()
        {
            XLWorkbook book = new XLWorkbook(@"TestData/orange-test-data.xlsx");

            var sheet = book.Worksheet("AddValidEmployeeTest");

            var range = sheet.RangeUsed();

            int rowCount = range.RowCount();
            int colCount=range.ColumnCount();

            object[] allData=new object[2];

            //read all cell value and print it
            for (int r=2;r<=rowCount;r++)
            {
                string[] arr = new string[colCount];
                for(int c=1;c<=colCount;c++)
                {
                    string cellValue = range.Cell(r, c).GetString();
                    Console.WriteLine(cellValue);
                    arr[c-1] = cellValue;
                }

                allData[r-2] = arr;
            }


            book.Dispose();

        }
    }
}
