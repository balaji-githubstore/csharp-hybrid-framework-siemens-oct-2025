using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Utilities
{
    /// <summary>
    /// This class contains all data and also map all data from external files like excel, json for the [TestCaseSource] 
    /// 
    /// </summary>
    public class DataSource
    {
        public static object[] ValidLoginData()
        {
            string[] data1 = { "Admin", "admin123", "Dashboard" };
            string[] data2 = { "Admin", "admin123", "Dashboard" };

            object[] allData = { data1, data2 };

            return allData;
        }
        public static object[] InvalidLoginData()
        {
            string[] data1 = new string[3];
            data1[0] = "john";
            data1[1] = "john123";
            data1[2] = "Invalid credentials";

            string[] data2 = new string[3];
            data2[0] = "saul";
            data2[1] = "saul123";
            data2[2] = "Invalid credentials";

            object[] allData = new object[2];
            allData[0] = data1;
            allData[1] = data2;

            return allData;
        }


        public static object[] InvalidLoginDataFromExcel()
        {
            object[] allData = ExcelSource.GetSheetIntoObjectArray("TestData/orange-test-data.xlsx", "InvalidLoginTest");
            return allData;
        }
    }
}
