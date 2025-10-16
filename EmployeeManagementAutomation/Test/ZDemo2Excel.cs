using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using EmployeeManagementAutomation.Utilities;

namespace EmployeeManagementAutomation.Test
{
    public class ZDemo2Excel
    {
        [Test]
        public void ReadExcelTest()
        {
            XLWorkbook book = new XLWorkbook(@"TestData/orange-test-data.xlsx");

            var sheet = book.Worksheet("InvalidLoginTest");

            var range = sheet.RangeUsed();

            int rowCount = range.RowCount();
            int colCount=range.ColumnCount();

            object[] allData = new object[rowCount-1];

            //read all cell value and print it
            for (int r=2;r<=rowCount;r++)
            {
                string[] data = new string[colCount];
                for(int c=1;c<=colCount;c++)
                {
                    string cellValue = range.Cell(r, c).GetString();
                    Console.WriteLine(cellValue);
                    data[c-1] = cellValue;
                }

                allData[r-2]=data;
            }


            book.Dispose();

        }
    }
}
