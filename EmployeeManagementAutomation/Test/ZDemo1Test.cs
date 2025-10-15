using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Test
{
    public class ZDemo1Test
    {

        public static object[] invalidData()
        {
            //data1[] size = number of arguments
            string[] data1 = new string[2];
            data1[0] = "saul";
            data1[1] = "88989898";

            string[] data2=new string[2];
            data2[0] = "peter";
            data2[1] = "peter123";

            string[] data3=new string[2];
            data3[0] = "kim";
            data3[1] = "kim123";

            //allData[] size = number of testcase
            object[] allData = new object[3];
            allData[0]=data1;
            allData[1]=data2;
            allData[2]=data3;

            return allData;
        }

        [Test]
        [TestCaseSource(nameof(invalidData))]
        public void InvalidTest(string username,string password)
        {
            Console.WriteLine("invalid"+username+password);
        }
    }
}
