using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Data;

namespace MathZ_All
{
    class Common
    {
        static string userFilePath=Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MathzAll");
        static DataTable productDetailsTable = new DataTable();
        public static void CreateBaseFolder() {
            Directory.CreateDirectory(userFilePath);
        }
        public static void CreateWebsiteBaseFolder(string websiteName) {
            string path = Path.Combine(userFilePath, websiteName);
            Directory.CreateDirectory(path);

            Directory.CreateDirectory(Path.Combine(path, "output data"));
            Directory.CreateDirectory(Path.Combine(path, "unprocessed data"));
            Directory.CreateDirectory(Path.Combine(path, "ProductURL"));
        }
        public static string GetOutputPath(string websiteName) {
            string path = Path.Combine(userFilePath, websiteName);
            path = Path.Combine(path, "output data");
            return path;
        }
        public static string GetUnprocessedPath(string websiteName) {
            string path = Path.Combine(userFilePath, websiteName);
            path = Path.Combine(path, "unprocessed data");
            return path;
        }
        public static string GetProductPath(string websiteName) {
            string path = Path.Combine(userFilePath, websiteName);
            path = Path.Combine(path, "ProductURL");
            return path;
        }
        public static string GetSubString(string startIndex, string endIndex, string data)
        {

            string output = "";
            int x, y;
            try
            {
                x = data.IndexOf(startIndex);
                if (x >= 0)
                {
                    y = data.IndexOf(endIndex,x);
                    if (y > 0) {
                        output = data.Substring(x + startIndex.Length, y - x - startIndex.Length);
                    }
                }
            }
            catch
            {

            }
            return output;
        }
        public static List<string> MatchPattern(string Data, string Pattern)
        {
            List<string> output = new List<string>();
            MatchCollection matches = Regex.Matches(Data, Pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                string ad = match.Groups[1].Value;
                ad = Regex.Replace(ad, @"\s+", " ");
                output.Add(ad);
            }
            return output;
        }
        public static String GetHtml(string URL)
        {
            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
            request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            StreamReader sr1 = new StreamReader(response1.GetResponseStream());
            string html = sr1.ReadToEnd();
            sr1.Close();
            response1.Close();

            return html;
        }
        public static void WriteDataToFile(DataTable submittedDataTable, string submittedFilePath)//method for printing datatable into textfile
        {                                                                                         //here submittedfilepath is path given and second is data table
            int i = 0;
            StreamWriter sw = null;

            sw = new StreamWriter(submittedFilePath, false);

            for (i = 0; i < submittedDataTable.Columns.Count - 1; i++)
            {

                sw.Write(submittedDataTable.Columns[i].ColumnName + "\t");//printing each column diff. by \t--tab

            }
            sw.Write(submittedDataTable.Columns[i].ColumnName);
            sw.WriteLine();

            foreach (DataRow row in submittedDataTable.Rows)
            {
                object[] array = row.ItemArray;

                for (i = 0; i < array.Length - 1; i++)
                {
                    sw.Write(array[i].ToString() + "\t");
                }
                sw.Write(array[i].ToString());
                sw.WriteLine();

            }
            sw.Close();
        }

    }
}
