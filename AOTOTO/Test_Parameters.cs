

namespace AOTOTO
{
    public class Test_Parameters
    {
        /// Provide parameters for test
        //public const string Browser = "Chrome"; //Chrome or IE
        public const string Environment = "REI-INT"; //ex. UTL, UAT, REI-INT, QA, perf, HRSA-INT
        public const string Environment_Number = "2"; //Change environment number here but if QA, REI-INT not need so just comment it
        public const string UserRole = "DIR Staff"; //QC or GMO
        public const string Password = "INT-EH3S-re!1"; //Change Password here
        public const string connetionString = @"Data Source=hsa-txn-int.reisys.com;Initial Catalog=GEMS;User ID=qauser;Password=qauser";
        public const string File_Location = @"Y:\\Test_Data\\";
        public const string ARM_ID = @"ADuahAgyema";
        public const string ARM_Password = @"#Tonydee1";
        public const string TestDocument = @"Test_Document.txt";
        public const string Comment_SkipPO = @"This is a test only for Skip PO process";

        //public readonly string TeamName1;
        //public readonly string TeamName2;
        //public readonly string TeamName3;

        //public Test_Parameters()
        //{
        //    Random rnd = new Random();
        //    TeamName1 = "Team" + rnd.Next(1, 100).ToString() + rnd.Next(1, 100).ToString();
        //    TeamName2 = "Team" + rnd.Next(1, 100).ToString() + rnd.Next(1, 100).ToString();
        //    TeamName3 = "Team" + rnd.Next(1, 100).ToString() + rnd.Next(1, 100).ToString();
        //}
    }
}
