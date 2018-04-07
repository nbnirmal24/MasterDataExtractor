using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;

namespace MathZ_All
{
    class Stuller
    {
        public static String Gethtml(string URL)
        {

            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
            request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
            request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
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
        public static void WriteDataToFile(DataTable submittedDataTable, string submittedFilePath)//method for printing datatable into textfile
        {//here submittedfilepath is path given and second is data table
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

            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("Model_No");
            qvcp.Columns.Add("ColorId");
            qvcp.Columns.Add("SizeId");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("ProductURL");
            qvcp.Columns.Add("Product Name");
            qvcp.Columns.Add("Old_Price");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("You_Save");
            qvcp.Columns.Add("Shipping_Charge");
            qvcp.Columns.Add("Avg_Rating Out_of 5");
            qvcp.Columns.Add("Total_Reviews");
            qvcp.Columns.Add("Shipping");
            qvcp.Columns.Add("Delivery");
            qvcp.Columns.Add("StockStatus");
            qvcp.Columns.Add("Image1");
            qvcp.Columns.Add("Image2");
            qvcp.Columns.Add("Image3");
            qvcp.Columns.Add("Image4");
            qvcp.Columns.Add("Image5");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("SKU");
            qvcp.Columns.Add("VenderSKU");
            qvcp.Columns.Add("CountryOrgin");
            qvcp.Columns.Add("Description");
            qvcp.Columns.Add("Features");
            qvcp.Columns.Add("Specification");
            qvcp.Columns.Add("InputSKU");
            qvcp.Columns.Add("AmazonSKU");
            dgwq = Application.StartupPath;
            string filename = DateTime.Now.ToString("ddMMyyyyThhmmss");
            if (tb.Text != "")
            {
                dgwq = dgwq + "\\" + "output data" + "\\" + tb.Text + ".txt";
            }
            else
            {
                //string[] fileArray = Directory.GetFiles(dgwq + "\\" + "output data" + "\\", "*.txt");
                //if (fileArray.Contains(tb.Text))
                //{
                //    if (tb.Text.Contains("_("))
                //    {
                //        int num = 0;
                //        string name = getsubstring("", "_(", tb.Text);
                //        string number = getsubstring("_(", ")", tb.Text);
                //        if (number != "")
                //        {
                //            num = Convert.ToInt32(number);
                //            num++;
                //        }
                //        tb.Text = name + "_(" + num + ")";
                //    }
                //    else
                //    {
                //        tb.Text = tb.Text + "_(1)";
                //    }
                //}
                dgwq = dgwq + "\\" + "output data" + "\\" + "DATA" + filename + ".txt";
            }
            tb1.Text = dgwq;
            //  textBox2.Invoke(new Action(() => { textBox2.Text = dgwq; }));


        }
        public static void datetime1()
        {
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            qvcp.Columns.Add("ProductURL");
            qvcp.Columns.Add("Stock");
            dgwq = Application.StartupPath;
            string filename = DateTime.Now.ToString("ddMMyyyyThhmmss");
            if (tb.Text != "")
            {
                dgwq = dgwq + "\\" + "output data" + "\\" + tb.Text + ".txt";
            }
            else
            {
                dgwq = dgwq + "\\" + "output data" + "\\" + "DATA" + filename + ".txt";
            }
            // textBox2.Invoke(new Action(() => { textBox2.Text = dgwq; }));
            tb1.Text = dgwq;
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
                        if (es.ToString().Contains("Internal Server Error")) {
                            qvcp.Rows.Add(rhon,"out of stock");
                            //  lab6show(qvcp);
                            WriteDataToFile(qvcp, dgwq);
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
                                string stock = "";
                                stock = getsubstring("\"InStockStatusMessage\":\"", "\",", str).Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("\u003c\\u003e", "").Replace("\\r", "").Replace("\\n", "").Replace("\\t", "").Replace("\\u003c\\u003e", "");
                                if (string.IsNullOrEmpty(stock)) {
                                    stock = getsubstring("<div class=\"importantLarge\">", "</div>", str);
                                }
                                qvcp.Rows.Add(rhon,stock);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
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
    }
}
