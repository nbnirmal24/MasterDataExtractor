using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Data;
using System.Collections.Specialized;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace MathZ_All
{
    class CbcChurchSupply : Common
    {
        public class CookieAwareWebClient : WebClient
        {
            private CookieContainer cookie = new CookieContainer();

            protected override WebRequest GetWebRequest(Uri address)
            {
                WebRequest request = base.GetWebRequest(address);
                if (request is HttpWebRequest)
                {
                    (request as HttpWebRequest).CookieContainer = cookie;
                }
                return request;
            }
        }
        public static String Gethtml(string URL)
        {

            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
            request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
            request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //request1.Referer = "http://www.supplyhouse.com/PEX-Tubing-223000";
            //  request1.Proxy = null;
            //ServicePointManager.Expect100Continue = false;
            //ServicePointManager.DefaultConnectionLimit = 5;
            //ServicePointManager.MaxServicePointIdleTime = 2000;
            // request1.AllowAutoRedirect = true;
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            StreamReader sr1 = new StreamReader(response1.GetResponseStream());
            string html = sr1.ReadToEnd();
            sr1.Close();
            response1.Close();

            return html;
        }
        //public static void WriteDataToFile(DataTable submittedDataTable, string submittedFilePath)//method for printing datatable into textfile
        //{//here submittedfilepath is path given and second is data table
        //    int i = 0;
        //    StreamWriter sw = null;

        //    sw = new StreamWriter(submittedFilePath, false);

        //    for (i = 0; i < submittedDataTable.Columns.Count - 1; i++)
        //    {

        //        sw.Write(submittedDataTable.Columns[i].ColumnName + "\t");//printing each column diff. by \t--tab

        //    }
        //    sw.Write(submittedDataTable.Columns[i].ColumnName);
        //    sw.WriteLine();

        //    foreach (DataRow row in submittedDataTable.Rows)
        //    {
        //        object[] array = row.ItemArray;

        //        for (i = 0; i < array.Length - 1; i++)
        //        {
        //            sw.Write(array[i].ToString() + "\t");
        //        }
        //        sw.Write(array[i].ToString());
        //        sw.WriteLine();

        //    }

        //    sw.Close();
        //}
        static List<string> li1 = new List<string>();
        static List<string> potter = new List<string>();
        static List<string> ProductURL = new List<string>();
        static List<string> li2 = new List<string>();
        static List<string> li3 = new List<string>();
        static List<string> human = new List<string>();
        static List<string> animal = new List<string>();
        static List<string> nala = new List<string>();
        static List<string> nalu = new List<string>();
        static List<string> extra = new List<string>();
        static List<string> files = new List<string>();
        static string fileName = "DATA" + DateTime.Now.ToString("ddMMyyyyThhmmss") + ".txt";
        static string outputPath = Path.Combine(GetOutputPath("CbcChurchSupply"), fileName);
        static string unprocessedPath = Path.Combine(GetUnprocessedPath("CbcChurchSupply"), fileName);
        static string productPath = Path.Combine(GetProductPath("CbcChurchSupply"), fileName);
        public static List<string> passpro(List<string> produt)
        {
            produt = ProductURL;
            return produt;
        }
        static string str = null;
        static string str1 = null;
        static bool access = true;
        //   string sub = "";
        static DataTable qvcp = new DataTable();
        static string sub1 = "";
        static string pattern = "";
        static string dgwq = "";
        static string abcd = "", abcd1 = "";
        static int x, y, c, v, cg;
        private object sku;

        public static void datetime()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();

            qvcp.Columns.Add("Product_Url");
            qvcp.Columns.Add("Product_Id");
            qvcp.Columns.Add("Product_SKU");
            qvcp.Columns.Add("Stock_Status");
            qvcp.Columns.Add("New_Product_Url");
            tb1.Text = outputPath;
            //  textBox2.Invoke(new Action(() => { textBox2.Text = dgwq; }));


        }
        public static void datetime1()
        {
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            qvcp.Columns.Add("ProductURL");
            qvcp.Columns.Add("Stock");
            tb1.Text = outputPath;
        }
        public static string getsubstring(string q, string we, string rs)
        {

            string sub = "";
            try
            {
                x = rs.IndexOf(q);
                if (x >= 0)
                {
                    y = rs.IndexOf(we, x);
                    if (y < 0)
                    {
                        string abid = "";
                        x = rs.IndexOf("\"skuId\":\"");
                        y = rs.IndexOf("\",", x);
                        abid = rs.Substring(x + 9, y - x - 9);
                        li3.Add(abid);
                        //labunshow(li3);
                    }
                    else
                    {
                        sub = rs.Substring(x + q.Length, y - x - q.Length);
                    }
                }
            }
            catch
            {

            }
            return sub;
        }
        public static List<string> matchkar(string jabe, string aabe)
        {
            List<string> nirmal = new List<string>();
            MatchCollection matches = Regex.Matches(jabe, aabe, RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                string ad = match.Groups[1].Value;
                ad = Regex.Replace(ad, @"\s+", " ");
                nirmal.Add(ad);
            }
            return nirmal;
        }
        public static void stock(List<string> kuk)
        {
            


            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
            foreach (string rhonq in kuk)
            {
                ScrapingBrowser Browser = new ScrapingBrowser();
                Browser.AllowAutoRedirect = true; // Browser has settings you can access in setup
                Browser.AllowMetaRedirect = true;
                WebPage PageResult = Browser.NavigateToPage(new Uri(rhonq));
                try
                {
                    string rhon = "";
                    string[] abde1 = rhonq.Split('\t');
                    if (abde1.Count() >= 1)
                    {
                        rhon = abde1[0];
                    }
                jsk:
                    try
                    {
                        str = Gethtml(rhon);
                    }
                    catch(Exception es)
                    {
                        if (es.ToString().Contains("Internal Server Error"))
                        {
                            qvcp.Rows.Add(rhon, "out of stock");
                            //  lab6show(qvcp);
                            WriteDataToFile(qvcp, outputPath);
                            // }
                            lb.Text = qvcp.Rows.Count.ToString();
                            goto psk;
                        }
                        if (es.ToString().Contains("(404) Not Found"))
                        {
                            qvcp.Rows.Add(rhon, "", "", "out of stock", "");
                            //  lab6show(qvcp);
                            WriteDataToFile(qvcp, outputPath);
                            // }
                            lb.Text = qvcp.Rows.Count.ToString();
                            goto psk;
                        }
                        human.Add(rhon.Trim());
                        if (human.Count > 500)
                        {
                            human.Clear();
                            nalu.Add("s");
                            lb.Text = nalu.Count.ToString();
                            goto psk;
                        }
                    }
                    if (str == null || str == "")
                    {

                        goto jsk;
                    }
                    if (human.Count >= 1)
                    {
                        human.Clear();
                    }
                    string stat = "";
                    stat = getsubstring("\"status\": \"", "\",", str);
                      stat = Regex.Replace(stat, @" ?\<.*?\>", string.Empty);
                stat = Regex.Replace(stat, @"\s+", " ");
                    string msg = "";
                    msg = getsubstring("\"message\": \"", "\",", str);
                      msg = Regex.Replace(msg, @" ?\<.*?\>", string.Empty);
                msg = Regex.Replace(msg, @"\s+", " ");
                string stock = "";
                stock = msg + "-" + stat;
                    qvcp.Rows.Add(rhon, stock);
                    //  lab6show(qvcp);
                    WriteDataToFile(qvcp, outputPath);
                    // }
                    lb.Text = qvcp.Rows.Count.ToString();
                psk:
                    str = null;
                }
                catch
                {

                }
            }
        }
        static public void producta(List<string> yogesh)
        {
            var client = new CookieAwareWebClient();
            client.BaseAddress = @"http://catholic.cbcgroups.com/shop.jsp";
            var loginData = new NameValueCollection();
            loginData.Add("customer_number", "86626801");
            loginData.Add("aad_number", "15581");
            client.UploadValues("http://catholic.cbcgroups.com/aad_login2.jsp", "POST", loginData);
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
            clb.Visible = true;
            //  string combine=Form1.abcde();
            //if (combine != "")
            //{ 

            //}
            foreach (string rhon in yogesh)
            {

            jsk:
                try
                {
                    str = client.DownloadString(rhon);
                }
                catch(Exception es)
                {
                    if (es.ToString().Contains("Internal Server Error"))
                    {
                        qvcp.Rows.Add(rhon,"", "", "out of stock","");
                        //  lab6show(qvcp);
                        WriteDataToFile(qvcp, outputPath);
                        // }
                        lb.Text = qvcp.Rows.Count.ToString();
                        goto psk;
                    }
                    if (es.ToString().Contains("(404) Not Found"))
                    {
                        qvcp.Rows.Add(rhon, "", "", "out of stock", "");
                        //  lab6show(qvcp);
                        WriteDataToFile(qvcp, outputPath);
                        // }
                        lb.Text = qvcp.Rows.Count.ToString();
                        goto psk;
                    }
                    if (es.ToString().Contains("The connection was closed unexpectedly."))
                    {
                        qvcp.Rows.Add(rhon, "", "", "out of stock-Page not available", "");
                        //  lab6show(qvcp);
                        WriteDataToFile(qvcp, outputPath);
                        // }
                        lb.Text = qvcp.Rows.Count.ToString();
                        goto psk;
                    }
                    human.Add(rhon.Trim());
                    if (human.Count > 500)
                    {
                        human.Clear();
                        li3.Add(rhon.Trim());
                        Ulb.Text = li3.Count.ToString();
                        System.IO.File.WriteAllLines(abcd, li3);
                         goto psk;
                    }
                }
                if (str == null || str == "")
                {

                    goto jsk;
                }
                if (human.Count >= 1)
                {
                    human.Clear();
                }
                string id = "";
                id = getsubstring("Item Number:", "</li>", str);
                id = Regex.Replace(id, @" ?\<.*?\>", string.Empty);
                id = Regex.Replace(id, @"\s+", " ");
                //nalu.Add("q");
                //lb.Text = nalu.Count.ToString();
                string productId = "";
                string newStr = "";
                string stock = "";
                string newUrl = "";
                if (str.IndexOf(">Product Not Available<") > 0) {
                    productId = "Product_Not_Available";
                    goto TSK;
                }
                productId = getsubstring("productId = \"", "\";", str);
                productId = Regex.Replace(productId, @" ?\<.*?\>", string.Empty);
                productId = Regex.Replace(productId, @"\s+", " ");
                newUrl="http://catholic.cbcgroups.com/check_availability.jsp?id=" + productId;
                if (!string.IsNullOrEmpty(productId))
                {
                jsks:
                    try
                    {
                        newStr = Gethtml(newUrl);
                    }
                    catch(Exception es)
                    {
                        if (es.ToString().Contains("Internal Server Error"))
                        {
                            qvcp.Rows.Add(rhon, productId, id, "out of stock", newUrl);
                            //  lab6show(qvcp);
                            WriteDataToFile(qvcp, outputPath);
                            // }
                            lb.Text = qvcp.Rows.Count.ToString();
                            goto psk;
                        }
                        human.Add(rhon.Trim());
                        if (human.Count > 50)
                        {
                            human.Clear();
                            li3.Add(rhon.Trim());
                            Ulb.Text = li3.Count.ToString();
                            System.IO.File.WriteAllLines(abcd, li3);
                             goto psk;
                        }
                    }
                    if (newStr == null || newStr == "")
                    {

                        goto jsks;
                    }
                    if (human.Count >= 1)
                    {
                        human.Clear();
                    }
                    string stat = "";
                    stat = getsubstring("\"status\": \"", "\",", newStr);
                      stat = Regex.Replace(stat, @" ?\<.*?\>", string.Empty);
                stat = Regex.Replace(stat, @"\s+", " ");
                    string msg = ""; 
                    msg=getsubstring("\"message\": \"", "\",", newStr);
                      msg = Regex.Replace(msg, @" ?\<.*?\>", string.Empty);
                msg = Regex.Replace(msg, @"\s+", " ");
                stock = msg + "-" + stat;
                }
            TSK:
                qvcp.Rows.Add(rhon,productId,id,stock,newUrl);
                //  lab6show(qvcp);
                WriteDataToFile(qvcp, outputPath);
                // }
                lb.Text = qvcp.Rows.Count.ToString();
            psk:
                str = null;
            }
        }
    }
}
