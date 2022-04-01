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
            //TODO: Rename indexOfName variable

            string userDirectory = txtUserDirectory.Text;
            //"C:/Test Folder";
            string destinationDirectory = txtDestinationDirectory.Text;
            //"C:/Test Folder/Copied";

            //Create array of files from directory
            string[] filePaths = Directory.GetFiles(userDirectory);

            if (Directory.Exists(userDirectory) && Directory.Exists(destinationDirectory))
            {
                string newestFilePath = FindNewestFilePath(filePaths);
                CopyFile(newestFilePath, destinationDirectory);
            }
            else
            {
                throw new ArgumentOutOfRangeException("One of the given directory paths is not valid");
            }
        }

        /// <summary>
        /// Uses an array of file paths and determines which path containes the newest date
        /// depicted in a specifically named file.
        /// </summary>
        /// <param name="filePaths"></param>
        /// <returns>The directory path containing the file with the newest date in it's name</returns>
        /// <exception cref="NullReferenceException">When given folder contains no files</exception>
        private static string FindNewestFilePath(string[] filePaths)
        {

            //check if the array is empty
            if (!filePaths.Any())
            {
                throw new NullReferenceException("There are no files in that folder");
            }

            DateTime nextDate = new();

            //Fence post: save original path, format string and convert to DateTime.
            string newestDatePath = filePaths[0];
            string DateOnly = FormatPathToDate(newestDatePath);
            DateTime newestDate = ParseToDateTime(DateOnly);

            //find newest date using array
            for (int i = 1; i < filePaths.Length; i++)
            {

                //create next date for comparison
                string nextDateString = FormatPathToDate(filePaths[i]);
                nextDate = ParseToDateTime(nextDateString);

                //compare the dates, keep the newest
                if (newestDate.CompareTo(nextDate) < 0)
                {   
                    newestDatePath = filePaths[i];
                    newestDate = nextDate;
                }
            }

            return newestDatePath;
        }

        /// <summary>
        /// Turns a specifically formatted (yyyyMMdd) string to a date time
        /// </summary>
        /// <param name="dateOnly">String</param>
        /// <returns>A DateTime version of the string</returns>
        /// <exception cref="FormatException">When a date does not have the correct format in its name yyyyDDmm </exception>
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

        /// <summary>
        /// Removes formats a file path to just the date portion of a purposely named file (yyyyMMdd);
        /// </summary>
        /// <param name="pathToFormat">The path to turn into a date</param>
        /// <returns></returns>
        /// <exception cref="FormatException">When file creator is not using a _ to seperate the file name from the date</exception>
        private static string FormatPathToDate(string pathToFormat)
        {
            if (pathToFormat.Contains("_"))
            {
                //create string of only dates
                int startOfFileDate = pathToFormat.IndexOf("_") + 1;
                string dateOnly = pathToFormat.Substring(startOfFileDate, 8);

                return dateOnly;
            }
            else
            {
                throw new FormatException($"The file {pathToFormat} is not using a _ in it's format");
            }
        }

        /// <summary>
        /// Uses two directories, one to copy a file from, and one to copy a file to
        /// </summary>
        /// <param name="Directory">The directory to copy from</param>
        /// <param name="destinationDirectory">The directory to copy to</param>
        private static void CopyFile(string Directory, string destinationDirectory)
        {

        string fileName = Path.GetFileName(Directory);
        string directoryPath = Path.GetDirectoryName(Directory);

        //use paths to copy to directories
        string sourceFile = Path.Combine(directoryPath, fileName);
        string destFile = Path.Combine(destinationDirectory, fileName);

        File.Copy(sourceFile, destFile, true);

        }
    }
}