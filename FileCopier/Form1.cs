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
            //find file location
            string userDirectory = "C:/Test Folder";

            if (Directory.Exists(userDirectory))
            {
                DateTime newestDate = FileNamesToDateTimes(userDirectory);
            }
        }

        private static DateTime FileNamesToDateTimes(string userDirectory)
        {
            string[] filePaths = Directory.GetFiles(userDirectory);

            DateTime nextDate = new();

            //fencepost first date
            string filePath = filePaths[0];
            //format string
            int indexOfName = filePath.IndexOf("_") + 1;
            string dateOnly = filePath.Substring(indexOfName, 8);
            //convert to DateTime
            DateTime newestDate = DateTime.ParseExact(dateOnly, "yyyyMMdd", new CultureInfo("en-US"));

            //start from 1 to avoid fencepost
            for (int i = 1; i < filePaths.Length; i++)
            {
                if (!filePaths.Any())
                {
                    throw new NullReferenceException("There are no files in that folder");
                }
                
                filePath = filePaths[i];

                if (filePath.Contains("_"))
                {   
                    //create string of only dates
                    indexOfName = filePath.IndexOf("_") + 1;
                    dateOnly = filePath.Substring(indexOfName, 8);

                    //Convert string to DateTime and add to list
                    try
                    {
                        nextDate = DateTime.ParseExact(dateOnly, "yyyyMMdd", new CultureInfo("en-US"));
                    }
                    catch (FormatException)
                    {
                        throw new FormatException($"The file {filePath} is not labeled in the correct yyyyMMdd format");
                    }

                    if (newestDate.CompareTo(nextDate) < 0)
                    {
                        
                        newestDate = nextDate;
                    }
                }
                else
                {
                    throw new FormatException($"The file {filePath} is not using a _ in it's format");
                }
            }

            return newestDate;
        }


    }
}