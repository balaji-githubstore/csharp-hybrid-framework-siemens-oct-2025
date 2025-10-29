namespace EmployeeManagementAutomation.Base
{
    public class BrowserSettings
    {
        public string BrowserName { get; set; } = "ch"; // chromium, firefox, webkit
        public string BaseUrl { get; set; }
        public string ChromeBinaryLocation { get; set; }

        public string EdgeBinaryLocation { get; set; }
    }
}