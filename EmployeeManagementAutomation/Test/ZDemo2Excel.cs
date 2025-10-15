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
            XLWorkbook book = new XLWorkbook(@"D:\Balaji\Company\Siemens Oct 2025\AutomationFramework\EmployeeManagementAutomation\TestData\orange-test-data.xlsx");

            var sheet = book.Worksheet("InvalidLoginTest");

            var range = sheet.RangeUsed();

            string cellValue = range.Cell(1, 2).GetString();
            Console.WriteLine(cellValue);

            //read all cell value and print it

            book.Dispose();

        }
    }
}
