using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Data;
using System.Collections.Specialized;

namespace MathZ_All
{
    class cafepress
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
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("ProductURL");
            qvcp.Columns.Add("Product Name");
            qvcp.Columns.Add("Old_Price");
            qvcp.Columns.Add("You_Save");
            qvcp.Columns.Add("Design_Name");
            qvcp.Columns.Add("Normal_Img");
            qvcp.Columns.Add("Zoom_Img");
            qvcp.Columns.Add("StockStatus");
            qvcp.Columns.Add("Features");
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
           
            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("Model_No");
            qvcp.Columns.Add("ColorId");
            qvcp.Columns.Add("SizeId");
            qvcp.Columns.Add("Old_Price");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("You_Save");
            qvcp.Columns.Add("Shipping_Charge");
            qvcp.Columns.Add("Avg_Rating Out_of 5");
            qvcp.Columns.Add("Total_Reviews");
            qvcp.Columns.Add("Shipping");
            qvcp.Columns.Add("Delivery");
            qvcp.Columns.Add("StockStatus");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("SKU");
            qvcp.Columns.Add("VenderSKU");
            qvcp.Columns.Add("ProductURL");
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
        public static List<string> category(List<string> hulk)
        {
            //if (access == true)
            //{
            //    string dono = Form1.abcde();
            //    string[] abj = Regex.Split(dono, "---");
            //    abcd = abj[0];
            //    abcd1 = abj[1];
            //    access = false;
            //}
            List<string> iron = new List<string>();
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Count", false).FirstOrDefault();
            foreach (string thor in hulk)
            {
            jsk:
                try
                {
                    str = Gethtml(thor);
                }
                catch
                {
                    human.Add(thor.Trim());
                    if (human.Count > 500)
                    {
                        human.Clear();
                        li3.Add(thor.Trim());
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
                int xl = str.IndexOf("<a itemprop=\"name\" href=\"");
                if (xl > 0)
                {
                    pattern = @"<a itemprop=""name"" href=[^>]*?""(.*?)"" title";
                    MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    //if (matches.Count <= 1)
                    //{
                    //    pattern = @"<div class=""prod-image""[^>]*?>(.*?)"">";
                    //}
                    //matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in matches)
                    {
                        string fg = match.Groups[1].Value;
                       
                        if (fg != "")

                            if (animal.Contains(fg))
                            { }
                            else
                            {
                                animal.Add(fg);
                                ProductURL.Add(fg);
                                System.IO.File.WriteAllLines(abcd1, ProductURL);
                                Plb.Text = ProductURL.Count.ToString();
                            }
                    }
                    string nextPage = "";
                    while (str.IndexOf("<a rel=\"next\" class=\"uc button\" href=\"") > 0) {
                        nextPage = getsubstring("<a rel=\"next\" class=\"uc button\" href=\"", "\">", str);
                    if (!string.IsNullOrEmpty(nextPage)) 
                    {
                        nextPage = nextPage.Replace("&amp;", "&");
                    pska:
                        try
                        {
                            str = "";
                            str = Gethtml(nextPage);
                        }
                        catch (Exception fv)
                        {
                            if (fv.ToString().Contains("The remote server returned an error: (404) Not Found."))
                            {
                                break;
                            }
                        }
                        if (str == null || str == "")
                        {
                            goto pska;
                        }
                        pattern = @"<a itemprop=""name"" href=[^>]*?""(.*?)"" title";
                        MatchCollection matches1 = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        //if (matches.Count <= 1)
                        //{
                        //    pattern = @"<div class=""prod-image""[^>]*?>(.*?)"">";
                        //}
                        //matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match match in matches1)
                        {
                            string fg = match.Groups[1].Value;

                            if (fg != "")

                                if (animal.Contains(fg))
                                { }
                                else
                                {
                                    animal.Add(fg);
                                    ProductURL.Add(fg);
                                    System.IO.File.WriteAllLines(abcd1, ProductURL);
                                    Plb.Text = ProductURL.Count.ToString();
                                }
                        }
                }
                }

                }
                else if (str.IndexOf("<div class=\"cat-image\">") > 0)
                {
                    pattern = @"<div class=""cat-image[^>]*?"">(.*?)"">";
                    MatchCollection matchu = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    foreach (Match veta in matchu)
                    {
                        string cat = veta.Groups[1].Value;
                        cat = cat.Substring(cat.IndexOf("<a href=\"")).Replace("<a href=\"", "");
                        if (!cat.Contains("http"))
                        {
                            cat = "http://www.dickssportinggoods.com" + cat;
                        }
                        if (potter.Contains(cat))
                        { }
                        else
                        {
                            potter.Add(cat);
                            iron.Add(cat);
                        }

                    }

                }
            psk:
                str = null;
            }

            if (iron.Count >= 1)
            {
                return iron;
            }
            else
            {
                ProductURL.Add("ab_de_be_eb");
                return ProductURL;
            }
        }
        public static void product(List<string> yogesh)
        {
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
            clb.Visible = true;
            foreach (string rhonq in yogesh)
            {
                string rhon = "";
                string[] abde1 = rhonq.Split('\t');
                rhon = abde1[0];
            jsk:
                try
                {
                    str = Gethtml(rhon);
                }
                catch
                {
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
                string productsku = "";
                productsku = getsubstring("\"id\": \"", "\",", str);
                if (productsku == "")
                {
                    productsku = getsubstring("productId = ", ";", str);
                }
                productsku = productsku.Replace("\"", "");
                productsku = Regex.Replace(productsku, @" ?\<.*?\>", string.Empty);
                productsku = Regex.Replace(productsku, @"\s+", "");
                string inputsku = "";
                string amazonsku = "";
                if (abde1.Count() >= 2)
                {
                    inputsku = abde1[1];
                }
                if (abde1.Count() >= 3)
                {
                    amazonsku = abde1[2];
                }
                if (productsku != "")
                {
                    //goto psk;


                    //if (nala.Contains(productsku))
                    //{
                    //      goto psk;
                    //}
                    //else
                    //{
                    //    nala.Add(productsku);
                    //}
                    if (sub1 == "Extra_")
                    {
                        nalu.Add("s");
                        // Elab6show(nalu);
                    }
                    else
                    {
                        nalu.Add("s");
                        lb.Text = nalu.Count.ToString();
                    }
                    productsku = "#" + productsku;
                    string model = "";
                    string estimate = "";
                    string name = "";
                    name = getsubstring("itemprop=\"name\">", "</h1>", str);
                    name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                    name = Regex.Replace(name, @"\s+", " ");
                    string price = "";
                    string wprice = "";
                    string sprice = "";
                    wprice = getsubstring("sellprice\">", "</div>", str).Replace("&#036;", "$").Replace("*", "");
                    wprice = Regex.Replace(wprice, @" ?\<.*?\>", string.Empty);
                    wprice = Regex.Replace(wprice, @"\s+", "");
                    sprice = getsubstring("itemprop=\"price\">", "<", str).Replace("&#036;", "$").Replace("Save", "");
                    sprice = Regex.Replace(sprice, @" ?\<.*?\>", string.Empty);
                    sprice = Regex.Replace(sprice, @"\s+", " ");
                    string des = "";
                    des = getsubstring("<div class=\"prod-short-desc\" itemprop=\"description\">", "</", str);
                    des = Regex.Replace(des, @" ?\<.*?\>", string.Empty);
                    des = Regex.Replace(des, @"\s+", " ");
                    string feature = "";
                    List<string> feat = new List<string>();
                    string fea = getsubstring("itemprop=\"description\">", "</ul>", str).Replace("<li>", "<LI>").Replace("</li>", "</LI>");
                    pattern = @"<LI[^>]*?>(.*?)</LI>";
                    if (fea != "")
                    {
                        feat.AddRange(matchkar(fea, pattern));
                        if (feat.Count < 1)
                        {
                            fea = fea.Replace("\n", "|").Replace("\r", "|").Replace("\t", "|").Replace("<B>", "").Replace("</B>", "").Replace("<br>", "").Replace("FEATURES:", "");
                            feature = fea;
                            feature = Regex.Replace(feature, @"\s+", " ");
                        }
                        else
                        {
                            string image83 = "|";
                            feature = string.Join(image83, feat.ToArray());
                        }
                    }
                    string designName = "";
                    designName = getsubstring("Design Name:", "<b", str);
                    designName = Regex.Replace(designName, @" ?\<.*?\>", string.Empty);
                    designName = Regex.Replace(designName, @"\s+", " ");
                    string ground = "";
                    string origin = "";
                    string category = "";
                    category = getsubstring("breadcrumb-type\">", "</div>", str).Replace("&gt;", ">");
                    category = Regex.Replace(category, @" ?\<.*?\>", string.Empty);
                    category = Regex.Replace(category, @"\s+", " ");
                    string imgstr = "";
                    List<string> img1 = new List<string>();
                    List<string> zoomImg = new List<string>();
                    string normalimg = "";
                    string zoomimg1 = "";
                jsk2:
                    try
                    {
                        imgstr = Gethtml("http://www.cafepress.com/s/productinfo/productthumbnails?productId="+productsku.Replace("#",""));
                        imgstr = imgstr.Replace("\\u0026amp;", "&").Replace("\\u0026quot;", "\"").Replace("{productid}", productsku.Replace("#", ""));
                    }
                    catch
                    {
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

                        goto jsk2;
                    }
                    if (human.Count >= 1)
                    {
                        human.Clear();
                    }
                     pattern = @"""SubstitutableUrl"":[^>]*?""(.*?)"",""Caption";
                    MatchCollection matches = Regex.Matches(imgstr, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in matches)
                    {
                        string result = match.Groups[1].Value;
                        img1.Add(result);
                        zoomImg.Add(result.Replace("460", "1000"));
                    }
                    if (img1.Count >= 1) {
                        normalimg = string.Join("|", img1.ToArray());
                    }
                    if (zoomImg.Count >= 1) {
                        zoomimg1 = string.Join("|", zoomImg.ToArray());
                    }
                    string stockstr = "";
                    string stockStatus = "";
                jsk3:
                    try
                    {
                        stockstr = Gethtml("http://www.cafepress.com/m/productinfo/getstockinformation?callback=swatchcb&productId=" + productsku.Replace("#", "")+"&salesChannel=1");
                       
                    }
                    catch
                    {
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
                    if (stockstr == null || stockstr == "")
                    {

                        goto jsk3;
                    }
                    if (human.Count >= 1)
                    {
                        human.Clear();
                    }
                    stockStatus = getsubstring("\"StockAvailabilityMessage\":\"", "\",", stockstr);
                    stockStatus = Regex.Replace(stockStatus, @" ?\<.*?\>", string.Empty);
                    stockStatus = Regex.Replace(stockStatus, @"\s+", " ");
                     qvcp.Rows.Add(productsku,category, rhon, name, wprice,sprice,designName,normalimg,zoomimg1,stockStatus, feature);
                      // lab6show(qvcp);
                        WriteDataToFile(qvcp, dgwq);
                }
                else
                {
                    nalu.Add("s");
                    lb.Text = nalu.Count.ToString();
                    productsku = "Product Not Available";
                    qvcp.Rows.Add(productsku, rhon, inputsku, amazonsku);
                    // lab6show(qvcp);
                    WriteDataToFile(qvcp, dgwq);

                }
            psk:
                str = null;
            }
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
                    catch
                    {
                        human.Add(rhon.Trim());
                        if (human.Count > 500)
                        {
                            human.Clear();
                            if (abde1.Count() >= 1)
                            {
                                rhon = abde1[0];
                            }
                            string inputsku1 = "";
                            string amazonsku1 = "";
                            if (abde1.Count() >= 2)
                            {
                                inputsku1 = abde1[1];
                            }
                            if (abde1.Count() >= 3)
                            {
                                amazonsku1 = abde1[2];
                            }
                            nalu.Add("s");
                            lb.Text = nalu.Count.ToString();
                            string productsku1 = "Exception";
                            qvcp.Rows.Add(productsku1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", rhon, inputsku1, amazonsku1);
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
                    string stockas = getsubstring("\"InStockStatusMessage\":\"", "\",", str).Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace("\u003c\\u003e", "").Replace("\\r", "").Replace("\\n", "").Replace("\\t", "").Replace("\\u003c\\u003e", "");
                    if (str.Contains("class=\"prod-link\">") && str.Contains("Showing results"))
                    {
                        pattern = @"<div class=""prod-image"">[^>]*?""(.*?)"" class=""prod-link"">";
                        MatchCollection matchu = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        foreach (Match veta in matchu)
                        {
                            string cat = veta.Groups[1].Value;
                            cat = cat.Replace("<a href=\"", "");
                            cat = Regex.Replace(cat, @" ?\<.*?\>", string.Empty);
                            cat = Regex.Replace(cat, @"\s+", " ");
                            cat = "http://www.dickssportinggoods.com" + cat;
                            if (extra.Contains(cat))
                            { }
                            else
                            {
                                extra.Add(cat);
                            }

                        }
                        nalu.Add("s");
                        lb.Text = nalu.Count.ToString();
                        goto psk;

                    }
                    string productsku = "";
                    productsku = getsubstring("productId: \"", "}", str);
                    if (productsku == "")
                    {
                        productsku = getsubstring("itemid = \"", "\";", str);
                    }
                    productsku = productsku.Replace("\"", "");
                    productsku = Regex.Replace(productsku, @" ?\<.*?\>", string.Empty);
                    productsku = Regex.Replace(productsku, @"\s+", "");
                    string inputsku = "";
                    string amazonsku = "";
                    if (abde1.Count() >= 2)
                    {
                        inputsku = abde1[1];
                    }
                    if (abde1.Count() >= 3)
                    {
                        amazonsku = abde1[2];
                    }
                    if (productsku != "")
                    {
                        //if (nala.Contains(productsku))
                        //{
                        //    goto psk;
                        //}
                        //else
                        //{
                        //    nala.Add(productsku);
                        //}
                        if (sub1 == "Extra_")
                        {
                            nalu.Add("s");
                            //  Elab6show(nalu);
                        }
                        else
                        {
                            nalu.Add("s");
                            lb.Text = nalu.Count.ToString();
                        }
                        productsku = "#" + productsku;
                        string model = "";
                        model = getsubstring("Model:", "<", str).Trim();
                        model = Regex.Replace(model, @"\s+", "");
                        if (model != "")
                        {
                            model = "#" + model;
                        }
                        string estimate = "";
                        estimate = getsubstring("<p class=\"shipping-info\">", "</p", str);
                        estimate = Regex.Replace(estimate, @" ?\<.*?\>", string.Empty);
                        estimate = Regex.Replace(estimate, @"\s+", " ");
                        string ship = "";
                        ship = getsubstring("<ul class=\"promos\">", "</ul>", str);
                        ship = Regex.Replace(ship, @" ?\<.*?\>", string.Empty);
                        ship = Regex.Replace(ship, @"\s+", " ");
                        string price = "";
                        string wprice = "";
                        string sprice = "";
                        price = getsubstring("itemprop=\"price\">", "</", str).Replace("&#036;", "$");
                        price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                        price = Regex.Replace(price, @"\s+", " ");
                        wprice = getsubstring("<span class=\"price was\">", "</span>", str).Replace("&#036;", "$").Replace("*", "");
                        wprice = Regex.Replace(wprice, @" ?\<.*?\>", string.Empty);
                        wprice = Regex.Replace(wprice, @"\s+", " ");
                        sprice = getsubstring("<div class=\"save\">", "</div>", str).Replace("&#036;", "$").Replace("Save", "");
                        sprice = Regex.Replace(sprice, @" ?\<.*?\>", string.Empty);
                        sprice = Regex.Replace(sprice, @"\s+", " ");
                        string review = "";
                        string rate = "";
                        string rev = "";
                        review = getsubstring("\"BVRRContent", "<div id=", str);
                        if (review != "")
                        {
                            rate = getsubstring("<span itemprop=\"ratingValue\">", "out of", review);
                            rev = getsubstring("<span itemprop=\"reviewCount\">", "</span>", review);
                        }
                        rate = Regex.Replace(rate, @" ?\<.*?\>", string.Empty);
                        rate = Regex.Replace(rate, @"\s+", " ");
                        rev = Regex.Replace(rev, @" ?\<.*?\>", string.Empty);
                        rev = Regex.Replace(rev, @"\s+", " ");
                        string ground = "";
                        ground = getsubstring("<p class=\"freight-info\">", "</p>", str);
                        ground = Regex.Replace(ground, @" ?\<.*?\>", string.Empty);
                        ground = Regex.Replace(ground, @"\s+", " ");
                        string octo = rhon.Replace("http://www.dickssportinggoods.com/product/index.jsp?productId=", "");
                        octo = Regex.Replace(octo, @"\s+", "");
                        if (octo.Length > 15)
                        {
                            octo = "";
                        }
                        List<string> sk = new List<string>();
                        string fbs = getsubstring("'" + octo, "}", str);
                        if (fbs != "")
                        {
                            sk.Add(fbs);
                        }
                        if (sk.Count >= 1)
                        {
                            foreach (string d in sk)
                            {
                                //if (("#" + octo) == productsku || octo == "" || d.Contains(octo))
                                //{
                                string stock = "";
                                stock = getsubstring("\"avail\": '", "',", d);
                                string size = "";
                                size = getsubstring("\"size\": '", "',", d);
                                if (size != "")
                                {
                                    size = "#" + size;
                                }
                                string sizeid = "";
                                sizeid = getsubstring("\"sizeId\": '", "',", d);
                                string color = "";
                                color = getsubstring("\"color\": '", "',", d);
                                if (color != "")
                                {
                                    color = "#" + color;
                                }
                                string colorid = "";
                                colorid = getsubstring("\"colorId\": '", "',", d);
                                string pri = getsubstring("\"price\": \"", "\",", d);
                                if (pri != "")
                                {
                                    price = pri;
                                }
                                string sku = "";
                                sku = octo; //getsubstring(": '", "',", d);
                                string vendersku = "";
                                vendersku = getsubstring("\"vendorSku_id\": '", "',", d);
                                qvcp.Rows.Add(productsku, model, colorid, sizeid, wprice, price, sprice, ground, rate, rev, ship, estimate, stock, color, size, sku, vendersku, rhon, inputsku, amazonsku);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                                // }

                            }
                        }
                        else
                        {
                            string ab = "";
                            string cd = "";
                            qvcp.Rows.Add(productsku, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "Required_product_not_available", "", rhon, inputsku, amazonsku);
                            //  lab6show(qvcp);
                            WriteDataToFile(qvcp, dgwq);

                        }

                    }
                    else
                    {

                        nalu.Add("s");
                        lb.Text = nalu.Count.ToString();
                        productsku = "Product Not Available";
                        qvcp.Rows.Add(productsku, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", rhon, inputsku, amazonsku);
                        // lab6show(qvcp);
                        WriteDataToFile(qvcp, dgwq);

                    }
                psk:
                    str = null;
                }
                catch
                {
                    string rhon = "";
                    string[] abde1 = rhonq.Split('\t');
                    if (abde1.Count() >= 1)
                    {
                        rhon = abde1[0];
                    }
                    string inputsku = "";
                    string amazonsku = "";
                    if (abde1.Count() >= 2)
                    {
                        inputsku = abde1[1];
                    }
                    if (abde1.Count() >= 3)
                    {
                        amazonsku = abde1[2];
                    }
                    nalu.Add("s");
                    lb.Text = nalu.Count.ToString();
                    string productsku = "Exception";
                    qvcp.Rows.Add(productsku, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", rhon, inputsku, amazonsku);
                }
            }
        }

    }
}
