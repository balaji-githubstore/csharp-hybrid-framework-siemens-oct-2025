using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Utilities
{
    public class ExcelSource
    {
        public static object[] GetSheetIntoObjectArray(string filePath,string sheetname)
        {
            XLWorkbook book = new XLWorkbook(filePath);
            var sheet = book.Worksheet(sheetname);
            var range = sheet.RangeUsed();
            int rowCount = range.RowCount();
            int colCount = range.ColumnCount();

            object[] allData = new object[rowCount - 1];
            for (int r = 2; r <= rowCount; r++)
            {
                string[] data = new string[colCount];
                for (int c = 1; c <= colCount; c++)
                {
                    string cellValue = range.Cell(r, c).GetString();
                    Console.WriteLine(cellValue);
                    data[c - 1] = cellValue;
                }

                allData[r - 2] = data;
            }
            book.Dispose();

            return allData;
        }
    }
}
