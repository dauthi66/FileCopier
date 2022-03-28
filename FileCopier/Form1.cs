using System.Globalization;

namespace FileCopier
{
    public partial class FrmFileCopier : Form
    {
        public FrmFileCopier()
        {
            InitializeComponent();
        }

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            //TODO: Test all exceptions

            //find file location
            string userDirectory = "C:/Test Folder";

            string[] filePaths = Directory.GetFiles(userDirectory);

            if (Directory.Exists(userDirectory))
            {
                string newestDate = FindNewestFile(filePaths);
                CopyFile(filePaths);
            }
        }

        private static string FindNewestFile(string[] filePaths)
        {
            //Create array of files from directory

            DateTime nextDate = new();

            //Fence post: format string and convert to DateTime. 
            string newestDateString = FormatPathToDate(filePaths[0]);
            DateTime newestDate = ParseToDateTime(newestDateString);

            for (int i = 1; i < filePaths.Length; i++)
            {
                if (!filePaths.Any())
                {
                    throw new NullReferenceException("There are no files in that folder");
                }

                //create next date for comparison
                nextDate = ParseToDateTime(filePaths[i]);

                //compare the dates, keep the newest
                if (newestDate.CompareTo(nextDate) < 0)
                {   
                    newestDateString = filePaths[i];
                    newestDate = nextDate;
                }
            }

            return newestDateString;
        }

        private static DateTime ParseToDateTime(string dateOnly)
        {          
                try
                {
                    DateTime date = DateTime.ParseExact(dateOnly, "yyyyMMdd", new CultureInfo("en-US"));
                    return date;
                }
                catch (FormatException)
                {
                    throw new FormatException($"The file with date {dateOnly} is not labeled in the correct yyyyMMdd format");
                }
        }
        private static string FormatPathToDate(string pathToFormat)
        {
            if (pathToFormat.Contains("_"))
            {
                //create string of only dates
                int indexOfName = pathToFormat.IndexOf("_") + 1;
                string dateOnly = pathToFormat.Substring(indexOfName, 8);

                return dateOnly;
            }
            else
            {
                throw new FormatException($"The file {pathToFormat} is not using a _ in it's format");
            }
        }

        private static void CopyFile(string[] filePaths)
        {

        }
    }
}