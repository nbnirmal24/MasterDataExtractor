using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace MathZ_All
{
    class argos : Form1
    {
         
        public static String Gethtml(string URL)
        {

            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
            request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
            request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request1.Proxy = null;
            request1.CookieContainer = new CookieContainer();
            request1.CookieContainer.Add(new Uri(URL),new Cookie("PostCodeSessionCookie","RM202ZP%2C%2C"));
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.DefaultConnectionLimit = 5;
            ServicePointManager.MaxServicePointIdleTime = 2000;
            request1.AllowAutoRedirect = true;
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            StreamReader sr1 = new StreamReader(response1.GetResponseStream());
            string html = sr1.ReadToEnd();
            sr1.Close();
            response1.Close();

            return html;
        }
          public static String AGethtml(string URL)
        {
            string html = "";
            cmd.Capacity = 50000;
           
        kdf:
            try
            {
                HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
                request1.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8,gzip, deflate, sdch,en-US,en;q=0.8";
                request1.KeepAlive = true;
                request1.CookieContainer = cmd;
                
                request1.Host = "www.amazon.co.uk";
                request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
                request1.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
                cmd.Add(response1.Cookies);
                
                StreamReader sr1 = new StreamReader(response1.GetResponseStream());
                html = sr1.ReadToEnd();
                sr1.Close();
                response1.Close();
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("The remote server returned an error: (500) Internal Server Error."))
                {
                    goto dfgh;
                }
                if (html == "")
                {
                    goto kdf;
                }
            }
        dfgh:
            int xcx;
            return html;
        }
        public static void WriteDataColumn(DataTable submittedDataTable, string submittedFilePath)
        {
            int i = 0;
            StreamWriter sw = null;

            sw = new StreamWriter(submittedFilePath, false);

            for (i = 0; i < submittedDataTable.Columns.Count - 1; i++)
            {

                sw.Write(submittedDataTable.Columns[i].ColumnName + "\t");//printing each column diff. by \t--tab

            }
            sw.Write(submittedDataTable.Columns[i].ColumnName);
            sw.WriteLine();
            sw.Close();
        }
        public static void WriteDataToFile(DataRow row, string submittedFilePath)
        {//here submittedfilepath is path given and second is data table
            int i = 0;
            System.IO.StreamWriter sw = new System.IO.StreamWriter(submittedFilePath, true);
            object[] array = row.ItemArray;

            for (i = 0; i < array.Length - 1; i++)
            {
                sw.Write(array[i].ToString() + "\t");
            }
            sw.Write(array[i].ToString());
            sw.WriteLine();
            sw.Close();
        }
        public static List<string> matchkar(string jabe, string aabe, string url)
        {
            List<string> nirmal = new List<string>();
            MatchCollection matches = Regex.Matches(jabe, aabe, RegexOptions.Singleline | RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                string ad = match.Groups[1].Value;
                ad = url + ad;
                ad = Regex.Replace(ad, @"\s+", " ");
                nirmal.Add(ad);
            }
            return nirmal;
        }
        Boolean ready = false;
        static bool sizevar = true;
        static bool colorvar = true;
        static List<string> li1 = new List<string>();
        static List<string> potter = new List<string>();
        static List<string> ProductURL = new List<string>();
        static List<string> li2 = new List<string>();
        static List<string> li3 = new List<string>();
        static List<string> human = new List<string>();
        static List<string> animal = new List<string>();
        static List<string> nala = new List<string>();
        static List<string> nalu = new List<string>();
        static List<string> checkid = new List<string>();
        static List<string> checkchildid = new List<string>();
        static List<string> varcolsizeproduct = new List<string>();
        static CookieContainer cmd = new CookieContainer();
        static CookieContainer amd = new CookieContainer();
        public static List<string> passpro(List<string> produt)
        {
            produt = ProductURL;
            return produt;
        }
        static string str = null;
        static string str1 = null;
        //   string sub = "";
        static DataTable qvcp = new DataTable();
        static string sub1 = "";
        static string pattern = "";
        static string dgwq = "";
        static string abcd = "", abcd1 = "";
        static int x, y, c, v, cg, h;
        static string cat = "";
        static bool access = true;
       
        //public Form1()
        //{
        //    InitializeComponent();
        //}
        public static void datetime()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("SKU");
            qvcp.Columns.Add("Brand");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("Title");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("ImageURL");
            qvcp.Columns.Add("Shipping_info");
            qvcp.Columns.Add("Special Offer");
            qvcp.Columns.Add("Was_price");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Price_Comment");
            qvcp.Columns.Add("Rating");
            qvcp.Columns.Add("Review");
            qvcp.Columns.Add("Stock Status");
            qvcp.Columns.Add("description");
            qvcp.Columns.Add("Features");
            qvcp.Columns.Add("Additional Info");
            qvcp.Columns.Add("Product URL");
            qvcp.Columns.Add("ATitle");
            qvcp.Columns.Add("ASIN");
            qvcp.Columns.Add("Rank");
            qvcp.Columns.Add("Amazon_Category");
            qvcp.Columns.Add("Number of seller");
            qvcp.Columns.Add("Amazon_Price");
            qvcp.Columns.Add("Amazon_Shipping");
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
            WriteDataColumn(qvcp, dgwq);

        }
        public static void datetime1()
        {
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            // qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("Child_ID");
            qvcp.Columns.Add("UPC");
            qvcp.Columns.Add("Parantage");
            qvcp.Columns.Add("Product_URL");
            qvcp.Columns.Add("Title");
            qvcp.Columns.Add("Type_Of_Price");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Stock_Status");
            qvcp.Columns.Add("Variation_Type");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
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
            WriteDataColumn(qvcp, dgwq);
            // textBox2.Invoke(new Action(() => { textBox2.Text = dgwq; }));
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
                        // labunshow(li3);
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
            MatchCollection matches = Regex.Matches(jabe, aabe, RegexOptions.Singleline | RegexOptions.IgnoreCase);
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
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Count", false).FirstOrDefault();
            List<string> iron = new List<string>();
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
                if (str.IndexOf("<li><a id=\"lhnCategoryLink") > 0)
                {
                    List<string> had = new List<string>();
                    pattern = @"<li><a id=""lhnCategoryLin[^>]*?k(.*?)</li>";
                    had.AddRange(matchkar(str, pattern, ""));
                    if (had.Count >= 1)
                    {
                        foreach (string raw in had)
                        {
                            string abc = getsubstring("href=\"", "\">", raw);
                            if (abc != "")
                            {
                                iron.Add("http://www.argos.co.uk" + abc);
                            }
                        }
                    }
                }
                  else  if (str.IndexOf("<dt class=\"title\">") > 0)
                {
                    pattern = @"<dt class=""title""[^>]*?>(.*?)</a>";
                    MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in matches)
                    {
                        string ad = match.Groups[1].Value;
                        string bd = getsubstring("href=\"", "\" title", ad);
                        if (!bd.Contains("http"))
                        {
                            bd = "http://www.argos.co.uk" + bd;
                        }
                        if (!animal.Contains(bd))
                        {
                            animal.Add(bd);
                            ProductURL.Add(bd);
                            Plb.Text = ProductURL.Count.ToString();
                            File.WriteAllLines(abcd1, ProductURL);
                            //  lab3show(ProductURL);
                        }
                    }
                    while (str.IndexOf(" rel=\"next\" class") > 0)
                    {
                        string dc = getsubstring(" rel=\"next\" class", "Next<", str);
                        string next = "";
                        if (dc != "")
                        {
                            next = getsubstring("href=\"", "\">", dc);
                            if (next != "")
                            {
                                if (!next.Contains("http"))
                                {
                                    next = "http://www.argos.co.uk" + next;
                                }
                            }
                        }
                        str = "";
                    bts:
                        try
                        {
                            str = Gethtml(next);
                        }
                        catch
                        {
                        }
                        if (str == null || str == "")
                        {
                            goto bts;
                        }
                        pattern = @"<dt class=""title""[^>]*?>(.*?)</a>";
                        MatchCollection matches1 = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match match in matches1)
                        {
                            string ad = match.Groups[1].Value;
                            string bd = getsubstring("href=\"", "\" title", ad);
                            if (!bd.Contains("http"))
                            {
                                bd = "http://www.argos.co.uk" + bd;
                            }
                            if (!animal.Contains(bd))
                            {
                                animal.Add(bd);
                                ProductURL.Add(bd);
                                Plb.Text = ProductURL.Count.ToString();
                                File.WriteAllLines(abcd1, ProductURL);
                                // lab3show(ProductURL);
                            }
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
            Thread webBrowseThread = new Thread(new ThreadStart(PerformWebBrowseOp));
            webBrowseThread.SetApartmentState(ApartmentState.STA);
            webBrowseThread.Start();
         
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
            clb.Visible = true;
            if (yogesh.Contains("ab_de_be_eb"))
            {
                yogesh.Remove("ab_de_be_eb");
            }
            phirse:
            foreach (string rhonq in yogesh)
            {
                string rhon = "";
                string[] abde1 = rhonq.Split('\t');
                if (abde1.Count() >= 1)
                {
                    rhon = abde1[0].Replace("_�_", "_–_").Replace("â€™", "’").Replace("â€“", "–").Replace("_ï¿½_", "_–_").Replace("ï¿½", "-");
                }
            jsk:
                try
                {
                    str = Gethtml(rhon.Replace("�", "-").Replace(" �", "-"));
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
                str = str.Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "").Replace("&#33;", "!").Replace("&#163;", "£");
                string inputsku = "";
                string amazonsku = "";
                string brand = "";
                string brand1 = "";
                if (abde1.Count() >= 2)
                {
                    inputsku = abde1[1];
                }
                if (abde1.Count() >= 3)
                {
                    amazonsku = abde1[2];
                }
                List<string> sizcd = new List<string>();
                string prdid = "";
                try
                {
                    prdid = getsubstring("data.prod_id = \"", "\";",str);
                    if (prdid == "")
                    {
                        prdid = getsubstring("productID = \"", "\";",str);
                    }
                    prdid = Regex.Replace(prdid, @" ?\<.*?\>", string.Empty);
                    prdid = Regex.Replace(prdid, @"\s+", " ");
                }
                catch { }
                if (checkid.Contains("#" + prdid))
                {

                    goto psk;
                }
                else
                {
                    checkid.Add("#" + prdid);
                }
                string sku = "";
                sku = getsubstring("productId\" value=\"", "\" />", str);
                sku = Regex.Replace(sku, @" ?\<.*?\>", string.Empty);
                sku = Regex.Replace(sku, @"\s+", " ");
                List<string> outs = new List<string>();
                string prodtit = "";
                string color = "";
                try
                {
                    prodtit = getsubstring("<h2 class=\"product-title", "</h2>", str);
                    if (prodtit != "")
                    {
                        if (prodtit.Contains(">"))
                        {
                            prodtit = "<" + prodtit;
                        }
                    }
                    prodtit = Regex.Replace(prodtit, @" ?\<.*?\>", string.Empty);
                    prodtit = Regex.Replace(prodtit, @"\s+", " ");
                }
                catch { }
                string price = "";
                try
                {
                    price = getsubstring("<li class=\"price\"", "</li>", str).Replace("&pound;", "£");
                    if (price != "")
                    {
                        if (price.Contains(">"))
                        {
                            price = "<" + price;
                        }
                    }
                    price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                    price = Regex.Replace(price, @"\s+", " ");
                    //if (price != "")
                    //{
                    //    try
                    //    {
                    //        double cnvrt = Convert.ToDouble(price.Replace("£", ""));
                    //        if (cnvrt > 20)
                    //        {
                    //            goto psk;
                    //        }
                    //    }
                    //    catch
                    //    { 
                    //    }
                    //}
                    //price = GetSubString(str, "Regular:", "</p>").Replace("&nbsp;", "");
                    //price = price.Split('$')[1].Trim();
                    //price = Regex.Replace(price, "<[/?[a-z][a-z0-9]*[^<>]*>", "");
                }
                catch { }
                string newprc = "";
                try
                {
                    newprc = getsubstring("<li class=\"pricewas\"", "</li>", str).Replace("&pound;", "£").Replace("was","");
                    if (newprc != "")
                    {
                        if (newprc.Contains(">"))
                        {
                            newprc = "<" + newprc;
                        }
                    }
                    newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                    newprc = Regex.Replace(newprc, @"\s+", " ");
                }
                catch
                {
                   
                }
                string prcomment = "";
                prcomment = getsubstring("<li class=\"pricesale\"", "</li>", str).Replace("&pound;", "£");
                if (prcomment != "")
                {
                    if (prcomment.Contains(">"))
                    {
                        prcomment = "<" + prcomment;
                    }
                    prcomment = Regex.Replace(prcomment, @" ?\<.*?\>", string.Empty);
                    prcomment = Regex.Replace(prcomment, @"\s+", " ");
                }
                brand = getsubstring("pdp-view-brand-main\">", "</", str);
                brand = Regex.Replace(brand, @" ?\<.*?\>", string.Empty);
                brand = Regex.Replace(brand, @"\s+", " ");
                List<string> sz = new List<string>();
                List<string> siztype = new List<string>();
                string invenstatus = "";
                string usav = "";
                //avg rating and review

                string avgrating = "";
                try
                {
                    avgrating = getsubstring("starRating = \"", "\";", str);
                    avgrating = Regex.Replace(avgrating, @" ?\<.*?\>", string.Empty);
                    avgrating = Regex.Replace(avgrating, @"\s+", " ");
                   
                }
                catch { }
                string review = "";
                try
                {
                    review = getsubstring("numberOfReviews = \"", "\";", str);
                    review = Regex.Replace(review, @" ?\<.*?\>", string.Empty);
                    review = Regex.Replace(review, @"\s+", " ");
                }
                catch { }
                string prdcategry = "";
                nalu.Add("s");
                lb.Text = nalu.Count.ToString();
                prdcategry = getsubstring("class=\"breadcrumb\"", "</ol>", str).Replace("</a>","|");
                if (prdcategry != "")
                {
                    prdcategry = ">" + prdcategry;
                }
                prdcategry = Regex.Replace(prdcategry, @"\s+", " ");
                prdcategry = Regex.Replace(prdcategry, @" ?\<.*?\>", string.Empty);
                prdcategry = Regex.Replace(prdcategry, @"\s+", " ");
                prdcategry = prdcategry.Replace("> itemscope itemtype=\"http://schema.org/BreadcrumbList\">", "");
                List<string> sizecount = new List<string>();
                List<string> colcount = new List<string>();
                string size = "";
                string colorz = "";
                pattern = @"<option class=""sizeOption[^>]*?""(.*?)/option>";
                sizecount.AddRange(matchkar(str, pattern));
                if (sizecount.Count >= 1)
                {
                        foreach (string abcd in sizecount)
                        {
                            if (abcd.Contains("selected=\"selected\""))
                            {
                                size = getsubstring("\">", "<", abcd);
                            }
                            else
                            {
                                if (sizevar == true)
                                {
                                    varcolsizeproduct.Add("http://www.argos.co.uk" + getsubstring("value=\"", "\" rel", abcd));
                                }
                            }
                        }
                }
                string colvar = getsubstring("colour-picker\">", "</ul>", str);
                if (colvar != "")
                {
                    pattern = @"<li[^>]*?>(.*?)</li>";
                    colcount.AddRange(matchkar(colvar, pattern));
                    int onlyone = 1;
                    if (colcount.Count >= 1)
                    {
                        foreach (string efgh in colcount)
                        {
                            if (onlyone == 1)
                            {
                                colorz = getsubstring("data-name=\"", "\" data", efgh);
                                onlyone = 2;
                            }
                            else
                            {
                                if (colorvar == true)
                                {
                                    varcolsizeproduct.Add(getsubstring("<a href=\"", "\" class", efgh));
                                }
                            }
                        }
                    
                    }
                
                }
                string summry = "";
                string des = "";
                string features = "";
                string additionalinfo = "";
                string deleveryinfo = "";
                string stockstatus = "";
                summry = getsubstring("pdp-summary-desc\"", "Full Details", str);
                if (summry != "")
                {
                    des = getsubstring(">", "<ul>", summry);
                    des = Regex.Replace(des, @" ?\<.*?\>", string.Empty);
                    des = Regex.Replace(des, @"\s+", " ");
                    features = getsubstring("<ul>", "</ul>", summry).Replace("</li>","|");
                    features = Regex.Replace(features, @" ?\<.*?\>", string.Empty);
                    features = Regex.Replace(features, @"\s+", " ");
                }
                additionalinfo = getsubstring("Additional Information", "</div>", str).Replace("</p>","|").Replace("<br>","|");
                additionalinfo = Regex.Replace(additionalinfo, @" ?\<.*?\>", string.Empty);
                additionalinfo = Regex.Replace(additionalinfo, @"\s+", " ");
                deleveryinfo = getsubstring("<li class=\"free-delivery\"", "</li>", str);
                if (deleveryinfo.Contains(">"))
                {
                    deleveryinfo = "<" + deleveryinfo;
                }
                deleveryinfo = Regex.Replace(deleveryinfo, @" ?\<.*?\>", string.Empty);
                deleveryinfo = Regex.Replace(deleveryinfo, @"\s+", " ");
                string tempstock=getsubstring("stockAvailabilityType = \"","\";",str);
                if (tempstock == "Collection|Homedelivery" || tempstock == "Homedelivery")
                {
                    stockstatus = "In Stock";
                }
                else
                {
                    stockstatus = "Out Of Stock";
                }
                string stockraw = "";
            gggg:
                try
                {
                    stockraw = Gethtml("http://www.argos.co.uk/webapp/wcs/stores/servlet/CollectionFfm?storeId=10151&langId=110&partNumber=" + prdid + "&collectable=true&deliverableOnly=false&collectableOnly=false&noCollectOrDeliver=false&prefixHTTP=http%3a%2f%2fwww.argos.co.uk%2fwebapp%2fwcs%2fstores%2fservlet&formattedPartNumber=" + prdid + "&pdMaxAvailable=10&catentryId=1390317&displayLayoutB=false&stockCheck=true&sourceId=&isOneClickEligibleForThisProduct=true&stockCheck=true");
                }
                catch
                {

                    goto gggg;
                }
            if (stockraw.IndexOf("\"stockQty\": 1") > 0)
            {
                stockstatus = "In Stock";
            }
            else if (stockraw.IndexOf("\"stockQty\": 0") > 0)
            {
                stockstatus = "Out Of Stock";
            }
                string img = "";
                if (str.IndexOf("<meta property=\"og:image:type\" content=\"image/jpeg\" />") > 0)
                {
                    if (str.IndexOf("<meta property=\"og:image:width\" content=") > 0)
                    {
                        img = "http://argos.scene7.com/is/image/Argos/" + prdid + "_R_SET?$Listers$&wid=1000&hei=1000";
                    }
                }
                string special_offer = "";
                special_offer = getsubstring("special-offers\">", "</div>", str).Replace("</p>","|");
                special_offer = Regex.Replace(special_offer, @" ?\<.*?\>", string.Empty);
                special_offer = Regex.Replace(special_offer, @"\s+", " ");
               
                string asinp = "";
                string rankp = "";
                string categoryp = "";
                string numselp = "";
                string pricep = "";
                string shipp = "";
                if (price != "")
                {
                    try
                    {
                        double cnvrt = Convert.ToDouble(price.Replace("£", ""));
                        if (cnvrt <= 20)
                        {
                            string abcde = "https://www.amazon.co.uk/s/ref=nb_sb_noss?url=search-alias%3Daps&field-keywords=" + prodtit;
                        pss:
                            try
                            {
                                str = AGethtml(abcde);
                            }
                            catch
                            {
                                goto pss;
                            }
                            if (str.Contains("did not match any products."))
                            {
                                asinp = "Match Not Found";
                                qvcp.Rows.Add(prdid, sku, brand, prdcategry, prodtit, colorz, size, img, deleveryinfo, special_offer, newprc, price, prcomment, avgrating, review, stockstatus, des, features, additionalinfo, rhon, prodtit, asinp, rankp, categoryp, numselp, pricep, shipp);
                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                            }
                            else
                            {
                                string abde = getsubstring("", "<div id=\"sponsoredLink", str);
                                if (abde != "")
                                {
                                    pattern = @"<li id=""result[^>]*?_(.*?)</li>";
                                    List<string> jabe = new List<string>();
                                    jabe.AddRange(matchkar(abde, pattern));
                                    if (jabe.Count >= 1)
                                    {
                                        foreach (string cbd in jabe)
                                        {
                                            asinp = "";
                                            rankp = "";
                                            categoryp = "";
                                            numselp = "";
                                            pricep = "";
                                            shipp = "";
                                            if (!cbd.Contains("-sponsored-"))
                                            {
                                                asinp = "";
                                                str = "";
                                                asinp = getsubstring("data-asin=\"", "\" class", cbd);
                                                asinp = Regex.Replace(asinp, @" ?\<.*?\>", string.Empty);
                                                asinp = Regex.Replace(asinp, @"\s+", " ");
                                                if (asinp != "")
                                                {
                                                papu:
                                                    try
                                                    {
                                                        str = AGethtml("https://www.amazon.co.uk/dp/" + asinp);
                                                    }
                                                    catch
                                                    {
                                                        goto papu;
                                                    }
                                                    string raw = getsubstring("Best Sellers Ran", "<a href=\"", str);
                                                    if (raw != "")
                                                    {
                                                        rankp = getsubstring("k", "in", raw);
                                                        rankp = Regex.Replace(rankp, @" ?\<.*?\>", string.Empty);
                                                        rankp = Regex.Replace(rankp, @"\s+", " ");
                                                        categoryp = getsubstring("in", "(", raw);
                                                        if (categoryp == "")
                                                        {
                                                            categoryp = getsubstring("in", "#", raw);
                                                        }
                                                        categoryp = Regex.Replace(categoryp, @" ?\<.*?\>", string.Empty);
                                                        categoryp = Regex.Replace(categoryp, @"\s+", " ");

                                                    }
                                                    else
                                                    {
                                                        raw = getsubstring("BestSellers Ran", "</li>", str);
                                                        if (raw == "")
                                                        {
                                                            raw = getsubstring("Bestsellers Ran", "</li>", str);
                                                        }
                                                        if (raw != "")
                                                        {
                                                            rankp = getsubstring("hrsr_rank\">", "</span>", raw).Replace("#", "");
                                                            if (rankp == "")
                                                            {
                                                                rankp = getsubstring("k", "in", raw).Replace(":", "");
                                                            }
                                                            rankp = Regex.Replace(rankp, @" ?\<.*?\>", string.Empty);
                                                            rankp = Regex.Replace(rankp, @"\s+", " ");
                                                            categoryp = getsubstring(">in", "</span>", raw).Replace("&nbsp;", "").Replace("&gt;", "|");
                                                            if (categoryp == "")
                                                            {
                                                                categoryp = getsubstring("in", "(", raw);
                                                                if (categoryp == "")
                                                                {
                                                                    categoryp = getsubstring("in", "#", raw);
                                                                }
                                                            }
                                                            categoryp = Regex.Replace(categoryp, @" ?\<.*?\>", string.Empty);
                                                            categoryp = Regex.Replace(categoryp, @"\s+", " ");


                                                        }

                                                    }
                                                    List<string> cccd = new List<string>();
                                                    pattern = @"<span class=""olp-padding-right""[^>]*?>(.*?)</span>";
                                                    cccd.AddRange(matchkar(str, pattern));
                                                    if (cccd.Count >= 1)
                                                    {
                                                        foreach (string xxx in cccd)
                                                        {
                                                            if (xxx.Contains("condition=new"))
                                                            {
                                                                string link = getsubstring("<a href=\"", "\">", xxx);
                                                                link = Regex.Replace(link, @" ?\<.*?\>", string.Empty);
                                                                link = Regex.Replace(link, @"\s+", " ");
                                                                numselp = getsubstring("\">", "new<", xxx).Replace("&nbsp;", "");
                                                                numselp = Regex.Replace(numselp, @" ?\<.*?\>", string.Empty);
                                                                numselp = Regex.Replace(numselp, @"\s+", " ");
                                                                if (link != "")
                                                                {
                                                                    if (!link.Contains("http"))
                                                                    {
                                                                        link = "https://www.amazon.co.uk" + link;
                                                                    }
                                                                    string temp = "";
                                                                bbk:
                                                                    try
                                                                    {
                                                                        temp = AGethtml(link);
                                                                    }
                                                                    catch
                                                                    {
                                                                        goto bbk;
                                                                    }
                                                                    pricep = getsubstring("olpOfferPrice", "</span>", temp);
                                                                    if (pricep.Contains(">"))
                                                                    {
                                                                        pricep = "<" + pricep;
                                                                    }
                                                                    pricep = Regex.Replace(pricep, @" ?\<.*?\>", string.Empty);
                                                                    pricep = Regex.Replace(pricep, @"\s+", " ");
                                                                    shipp = getsubstring("olpShippingInfo", "</span>", temp);
                                                                    if (shipp.Contains(">"))
                                                                    {
                                                                        shipp = "<" + shipp;
                                                                    }
                                                                    shipp = Regex.Replace(shipp, @" ?\<.*?\>", string.Empty);
                                                                    shipp = Regex.Replace(shipp, @"\s+", " ");
                                                                }
                                                            }

                                                        }

                                                    }
                                                    else
                                                    {
                                                        string link = "https://www.amazon.co.uk/gp/offer-listing/" + asinp + "/ref=dp_olp_new?ie=UTF8&condition=new";
                                                        link = Regex.Replace(link, @" ?\<.*?\>", string.Empty);
                                                        link = Regex.Replace(link, @"\s+", " ");

                                                        //numsel = getsubstring("\">", "new<", xxx).Replace("&nbsp;", "");
                                                        //numsel = Regex.Replace(numsel, @" ?\<.*?\>", string.Empty);
                                                        //numsel = Regex.Replace(numsel, @"\s+", " ");
                                                        if (!link.Contains("http"))
                                                        {
                                                            link = "https://www.amazon.co.uk" + link;
                                                        }
                                                        string temp = "";
                                                        int zcount = 0;
                                                    bbk:
                                                        try
                                                        {
                                                            temp = AGethtml(link);
                                                        }
                                                        catch
                                                        {
                                                            goto bbk;
                                                        }
                                                        pattern = @"olpOfferPric[^>]*?e(.*?)>";
                                                        List<string> count = new List<string>();
                                                        count.AddRange(matchkar(temp, pattern));
                                                        numselp = count.Count.ToString();
                                                        if (numselp == "0")
                                                        {
                                                            zcount++;
                                                            if (zcount > 3)
                                                            {
                                                                goto gbxk;
                                                            }
                                                            else
                                                            {
                                                                goto bbk;
                                                            }
                                                        }
                                                    gbxk:
                                                        pricep = getsubstring("olpOfferPrice", "</span>", temp);
                                                        if (pricep.Contains(">"))
                                                        {
                                                            pricep = "<" + pricep;
                                                        }
                                                        pricep = Regex.Replace(pricep, @" ?\<.*?\>", string.Empty);
                                                        pricep = Regex.Replace(pricep, @"\s+", " ");
                                                        shipp = getsubstring("olpShippingInfo", "</span>", temp);
                                                        if (shipp.Contains(">"))
                                                        {
                                                            shipp = "<" + shipp;
                                                        }
                                                        shipp = Regex.Replace(shipp, @" ?\<.*?\>", string.Empty);
                                                        shipp = Regex.Replace(shipp, @"\s+", " ");

                                                    }
                                                    if (pricep != "")
                                                    { 
                                                   

                                                    }
                                                }
                                                qvcp.Rows.Add(prdid, sku, brand, prdcategry, prodtit, colorz, size, img, deleveryinfo, special_offer, newprc, price, prcomment, avgrating, review, stockstatus, des, features, additionalinfo, rhon, prodtit, asinp, rankp, categoryp, numselp, pricep, shipp);
                                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                                            }
                                        }


                                    }
                                }
                            }
                        }
                        else
                        {
                            qvcp.Rows.Add(prdid, sku, brand, prdcategry, prodtit, colorz, size, img, deleveryinfo, special_offer, newprc, price, prcomment, avgrating, review, stockstatus, des, features, additionalinfo, rhon, prodtit, asinp, rankp, categoryp, numselp, pricep, shipp);
                            WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                        }
                    }
                    catch
                    {
                    }
                 
                }
            psk:
                str = null;
            }
            if (varcolsizeproduct.Count >= 1)   
            {
                colorvar = false;
                sizevar = false;
                yogesh.Clear();
                yogesh.AddRange(varcolsizeproduct);
                varcolsizeproduct.Clear();
                goto phirse;
            }
        }
        public static string GetSubString(string src, string stin, string enid)
        {
            int a1 = src.IndexOf(stin);
            int a2 = src.IndexOf(enid, a1);
            string sub = src.Substring(a1, a2 - a1).Trim();


            return sub;
        }
        public static void stock(List<string> kuk)
        {
            foreach (string rhonq in kuk)
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
                    str = Gethtml(rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–"));
                }
                catch
                {
                    human.Add(rhon.Trim());
                    if (human.Count > 500)
                    {
                        human.Clear();
                        li3.Add(rhon.Trim());
                        //   labunshow(li3);
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
                str = str.Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");
                string inputsku = "";
                string amazonsku = "";
                string brand = "";
                if (abde1.Count() >= 2)
                {
                    inputsku = abde1[1];
                }
                if (abde1.Count() >= 3)
                {
                    amazonsku = abde1[2];
                }
                List<string> sizcd = new List<string>();
                string prdid = "";
                try
                {
                    prdid = GetSubString(str, "<li class=\"current\" role=\"menuitem\">", "</li>");
                    prdid = prdid.Split(':')[1].Trim();
                }

                catch { }
                if (prdid == "")
                {
                    li3.Add("NO_ID" + rhon.Trim());
                    //   labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                if (checkid.Contains("#" + prdid))
                {

                    goto psk;
                }
                else
                {
                    checkid.Add("#" + prdid);
                }
                List<string> outs = new List<string>();
                string color = "";
                string price = "";
                try
                {
                    price = GetSubString(str, "Regular:", "</p>").Replace("&nbsp;", "");
                    price = price.Split('$')[1].Trim();
                    price = Regex.Replace(price, "<[/?[a-z][a-z0-9]*[^<>]*>", "");
                }
                catch { }
                string newprc = "";
                try
                {
                    newprc = GetSubString(str, "Sale:", "</span>").Replace("&nbsp;", "");
                    newprc = newprc.Split('$')[1].Trim();
                }
                catch
                {
                    try
                    {
                        newprc = GetSubString(str, ">Price:", "</p>").Replace("&nbsp;", "");
                        newprc = newprc.Split('$')[1].Trim();
                    }
                    catch
                    { }
                }
                List<string> sz = new List<string>();
                List<string> siztype = new List<string>();
                string invenstatus = "";
                try
                {
                    string siz = getsubstring("<div class=\"columns large-12 sizeChoiceContainer\">", "<div id=\"pdpAddToCartContainer\"", str);


                    pattern = @"<div class=[^>]*?""(.*?)/div>";
                    outs.AddRange(matchkar(siz, pattern, ""));

                    // sz = GetArraySubString(siz,"<a class=","</a>");
                    while (siz.IndexOf("<a class=") != -1)
                    {
                        int c1 = siz.IndexOf("<a class=");
                        int c2 = siz.IndexOf("</a>", c1 + 7);
                        string sub3 = siz.Substring(c1, c2 - c1).Trim();
                        sz.Add(sub3);
                        int index4 = siz.IndexOf("<a class=") + 15;
                        siz = siz.Substring(index4, siz.Length - index4).Trim();

                    }

                    foreach (string value6 in sz)
                    {
                        string val6 = value6;
                        string szcd = GetSubString(val6, "<span class=\"sku\">", "</span>");
                        string size = szcd.Split('>')[1].Trim();
                        sizcd.Add(size);
                    }
                    foreach (string value12 in sz)
                    {

                        string sze = GetSubString(value12, "<span class=\"size\">", "</span>");
                        string sztype = sze.Split('>')[1].Trim();
                        if (sztype != "")
                        {
                            sztype = "#" + sztype;
                        }
                        siztype.Add(sztype);
                    }
                }
                catch { }
                string usav = "";
                try
                {
                    string usave = GetSubString(str, "<p class=\"savedAmount\">", "</p>");
                    usav = GetSubString(usave, "<span class=\"savedAmountValue\">", "</span>").Split('>')[1].Trim();
                }
                catch { }
                //avg rating and review
                string shp = "";
                try
                {
                    shp = GetSubString(str, "<ul class=\"pdpLeftContent \">", "</div>");
                    shp = Regex.Replace(shp, "<[/?[a-z][a-z0-9]*[^<>]*>", "").Replace("\r", "").Replace("\t", "").Replace("\n", "");
                }
                catch { }
                string shiprate = "";
                try
                {
                    string shprat = GetSubString(str, "<ul class=\"pdpLeftContent \">", "</a>");
                    string shiprat = GetSubString(shprat, "</div>", "<a href=");
                    shiprate = GetSubString(shiprat, "<div class=\"pdpShippingMemo\">", "flat");
                    shiprate = shiprate.Split('>')[1].Trim();
                }
                catch { }
                string stckst = "";
                try
                {
                    string stck = GetSubString(str, "<meta itemprop=\"availability", "</span>");
                    stckst = GetSubString(stck, "content=", "/>");
                    stckst = stckst.Split('=')[1].Replace("\"", "").Trim();
                }
                catch { }
                string shipdt = "";
                try
                {
                    if (str.IndexOf("//images.footballfanatics.com/partners/ff/2015/fanatics_defense_desktop_sliver.jpg") != -1)
                    {
                        shipdt = "This item ships FREE with code: ZONE ";
                    }
                }
                catch
                {
                }
                string prdcategry = "";
                nalu.Add("s");
                // lab6show(nalu);
                int j = 0;
                if (prdid != "")
                {
                    prdid = "#" + prdid;
                }
                if (str.IndexOf("Color<") < 0)
                {
                    if (str.IndexOf(">Select Sport") > 0)
                    {
                        pattern = @"<option valu[^>]*?e(.*?)/option>";
                        MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        foreach (Match match in matches)
                        {
                            string ad = match.Groups[1].Value;
                            color = getsubstring("\">", "<", ad);
                            color = Regex.Replace(color, @" ?\<.*?\>", string.Empty);
                            color = Regex.Replace(color, @"\s+", " ");
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            foreach (string szval in sizcd)
                            {
                                if (szval != "")
                                {
                                    string rawd = getsubstring("sku-id=\"" + szval, "class=\"sku", str);
                                    if (rawd != "")
                                    {
                                        invenstatus = getsubstring("inventory-tier=\"", "\" on", rawd).Replace("2", "Less than 3 left!").Replace("5", "Less than 5 left!").Replace("8", "Less than 8 left!").Replace("10", "Less than 10 left!");
                                    }
                                    else
                                    {
                                        invenstatus = "";
                                    }
                                    string raw = getsubstring(szval + "\",", "});", str);
                                    if (raw != "")
                                    {
                                        string p = getsubstring("\"regular_price\":", ",", raw).Replace("\"", "");
                                        if (!p.Contains("productRegularPrice"))
                                        {
                                            price = p;
                                        }
                                        string sale = getsubstring("\"sale_price\":", ",", raw).Replace("\"", "");
                                        if (!sale.Contains("productSalePrice"))
                                        {
                                            newprc = sale;
                                        }
                                        string clr = getsubstring("\"clearance_price\":", ",", raw).Replace("\"", "");
                                        if (!clr.Contains("productClearancePrice"))
                                        {
                                            newprc = clr;
                                        }
                                    }
                                    string sc = getsubstring("'" + szval + "', '", "',", str);
                                    if (string.IsNullOrEmpty(sc) == false)
                                    {
                                        sc = sc.Replace("$", "");
                                        try
                                        {
                                            double scx = Convert.ToDouble(sc);
                                            double ogi = Convert.ToDouble(newprc.Replace("$", ""));
                                            double result = ogi + scx;
                                            newprc = result.ToString();
                                        }
                                        catch
                                        {
                                        }

                                    }
                                }
                                newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                                newprc = Regex.Replace(newprc, @"\s+", " ");
                                // if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , siztype[j] , szval.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() + "\t" + avgrating.Trim() + "\t" + review.Trim() + "\t" + shiprate.Trim() + "\t" + shp.Trim() + "\t" + proddet.Trim() + "\t" + prddsc.Trim() + "\t" + shipdt.Trim() + "\t" + prdcategry.Trim() + "\t" + stckst.Trim()))
                                //  {
                                qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand.Trim(), color.Trim(), siztype[j], szval.Trim(), price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                                // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                                // File.WriteAllLines("a.txt", prd);
                                //StreamWriter sw = new StreamWriter(dgwq, true);
                                //sw.WriteLine(prd[prd.Count - 1]);
                                //sw.Close();

                                j++;
                                h++;
                                //prdcnt_lbl.Text = Convert.ToString(i);
                                //  }
                            }
                            if (outs.Count >= 1)
                            {
                                foreach (string d in outs)
                                {
                                    invenstatus = "";
                                    string size = getsubstring("k\">", "<", d);
                                    if (size != "")
                                    {
                                        size = "#" + size;
                                    }
                                    string sk = "";
                                    if (d.Contains("Out of stock"))
                                    {
                                        stckst = "Out of stock";
                                    }
                                    newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                                    newprc = Regex.Replace(newprc, @"\s+", " ");
                                    //  if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , size , sk.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() , avgrating.Trim() , review.Trim() , shiprate.Trim() , shp.Trim() , proddet.Trim() , prddsc.Trim() , shipdt.Trim() , prdcategry.Trim() , stckst.Trim()))
                                    // {
                                    qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand.Trim(), color.Trim(), size, sk.Trim(), price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                                    // File.WriteAllLines("a.txt", prd);
                                    //StreamWriter sw = new StreamWriter(dgwq, true);
                                    //sw.WriteLine(prd[prd.Count - 1]);
                                    //sw.Close();
                                    WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                                    j++;
                                    h++;
                                    //prdcnt_lbl.Text = Convert.ToString(i);
                                    // }
                                }


                            }
                            h = 0;
                            j = 0;
                        }
                    }
                    else
                    {
                        foreach (string szval in sizcd)
                        {
                            if (szval != "")
                            {
                                string rawd = getsubstring("sku-id=\"" + szval, "class=\"sku", str);
                                if (rawd != "")
                                {
                                    invenstatus = getsubstring("inventory-tier=\"", "\" on", rawd).Replace("2", "Less than 3 left!").Replace("5", "Less than 5 left!").Replace("8", "Less than 8 left!").Replace("10", "Less than 10 left!");
                                }
                                else
                                {
                                    invenstatus = "";
                                }
                                string raw = getsubstring(szval + "\",", "});", str);
                                if (raw != "")
                                {
                                    string p = getsubstring("\"regular_price\":", ",", raw).Replace("\"", "");
                                    if (!p.Contains("productRegularPrice"))
                                    {
                                        price = p;
                                    }
                                    string sale = getsubstring("\"sale_price\":", ",", raw).Replace("\"", "");
                                    if (!sale.Contains("productSalePrice"))
                                    {
                                        newprc = sale;
                                    }
                                    string clr = getsubstring("\"clearance_price\":", ",", raw).Replace("\"", "");
                                    if (!clr.Contains("productClearancePrice"))
                                    {
                                        newprc = clr;
                                    }
                                }
                                string sc = getsubstring("'" + szval + "', '", "',", str);
                                if (string.IsNullOrEmpty(sc) == false)
                                {
                                    sc = sc.Replace("$", "");
                                    try
                                    {
                                        double scx = Convert.ToDouble(sc);
                                        double ogi = Convert.ToDouble(newprc.Replace("$", ""));
                                        double result = ogi + scx;
                                        newprc = result.ToString();
                                    }
                                    catch
                                    {
                                    }

                                }
                            }
                            newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                            newprc = Regex.Replace(newprc, @"\s+", " ");
                            // if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , siztype[j] , szval.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() + "\t" + avgrating.Trim() + "\t" + review.Trim() + "\t" + shiprate.Trim() + "\t" + shp.Trim() + "\t" + proddet.Trim() + "\t" + prddsc.Trim() + "\t" + shipdt.Trim() + "\t" + prdcategry.Trim() + "\t" + stckst.Trim()))
                            //  {
                            qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), color.Trim(), siztype[j], szval.Trim(), price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                            // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                            WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                            // File.WriteAllLines("a.txt", prd);
                            //StreamWriter sw = new StreamWriter(dgwq, true);
                            //sw.WriteLine(prd[prd.Count - 1]);
                            //sw.Close();

                            j++;
                            h++;
                            //prdcnt_lbl.Text = Convert.ToString(i);
                            //  }
                        }
                        if (outs.Count >= 1)
                        {
                            foreach (string d in outs)
                            {
                                invenstatus = "";
                                string size = getsubstring("k\">", "<", d);
                                if (size != "")
                                {
                                    size = "#" + size;
                                }
                                string sk = "";
                                if (d.Contains("Out of stock"))
                                {
                                    stckst = "Out of stock";
                                }
                                newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                                newprc = Regex.Replace(newprc, @"\s+", " ");
                                //  if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , size , sk.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() , avgrating.Trim() , review.Trim() , shiprate.Trim() , shp.Trim() , proddet.Trim() , prddsc.Trim() , shipdt.Trim() , prdcategry.Trim() , stckst.Trim()))
                                // {
                                qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), color.Trim(), size, sk.Trim(), price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                                // File.WriteAllLines("a.txt", prd);
                                //StreamWriter sw = new StreamWriter(dgwq, true);
                                //sw.WriteLine(prd[prd.Count - 1]);
                                //sw.Close();
                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                                j++;
                                h++;
                                //prdcnt_lbl.Text = Convert.ToString(i);
                                // }
                            }

                        }
                    }
                }
                else
                {
                    pattern = @"data-colo[^>]*?r(.*?)>";
                    MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    foreach (Match match in matches)
                    {

                        string cb = match.Groups[1].Value;
                        color = getsubstring("=\"", "\" data", cb);
                        color = Regex.Replace(color, @" ?\<.*?\>", string.Empty);
                        color = Regex.Replace(color, @"\s+", " ");

                        string ad = getsubstring("pid=\"", "data", cb);
                        ad = ad.Replace("\"", "");
                        ad = Regex.Replace(ad, @" ?\<.*?\>", string.Empty);
                        ad = Regex.Replace(ad, @"\s+", " ");
                        // ad=ad+"},"ad
                        if (ad.Length < 15)
                        {
                            prdid = "#" + ad;
                            if (checkid.Contains("#" + prdid))
                            {

                                goto dsk;
                            }
                            else
                            {
                                checkid.Add("#" + prdid);
                            }
                            string gopu = "";
                            try
                            {
                                gopu = Gethtml("http://www.fanatics.com/catalog/productjson/" + ad);
                            }
                            catch
                            {
                                human.Add(gopu.Trim());
                                if (human.Count > 500)
                                {
                                    human.Clear();
                                    li3.Add("ColorDefect" + gopu.Trim());
                                    // labunshow(li3);
                                    System.IO.File.WriteAllLines(abcd, li3);
                                    goto psk;
                                }
                            }
                            if (str == null || str == "")
                            {

                                goto psk;
                            }
                            if (human.Count >= 1)
                            {
                                human.Clear();
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            pattern = @"{""ID[^>]*?""(.*?)}";
                            MatchCollection matches1 = Regex.Matches(gopu, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                            foreach (Match match1 in matches1)
                            {
                                string bd = match1.Groups[1].Value;
                                bd = bd + "},";
                                string sizeid = getsubstring(":", ",", bd);
                                string sc = getsubstring("'" + sizeid + "', '", "',", str);
                                string sizename = getsubstring("\"Name\":\"", "\",", bd);
                                if (sizename != "")
                                {
                                    sizename = "#" + sizename;
                                }
                                newprc = getsubstring("\"Price\":\"", "\",", bd);
                                invenstatus = getsubstring("\"InventoryUrgencyTier\":", "},", bd).Replace("\"", "").Replace("2", "Less than 3 left!").Replace("5", "Less than 5 left!").Replace("8", "Less than 8 left!").Replace("10", "Less than 10 left!");
                                if (invenstatus == "null")
                                {
                                    invenstatus = "";
                                }
                                stckst = getsubstring("\"IsOutOfStock\":", ",", bd);
                                if (stckst == "false")
                                {
                                    stckst = "In_Stock";
                                }
                                else if (stckst == "true")
                                {
                                    stckst = "Out_Of_Stock";
                                    invenstatus = "";
                                }
                                newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                                newprc = Regex.Replace(newprc, @"\s+", " ");
                                qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), color.Trim(), sizename, sizeid.Trim(), price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                                // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                            }

                        }
                        else
                        {
                            newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                            newprc = Regex.Replace(newprc, @"\s+", " ");
                            qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), color.Trim(), "more than 15", "", price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                            // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                            WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                        }
                    dsk:
                        int vcb = 0;
                    }
                }
            psk:
                str = null;
            }
        }
        public static void stockCheck(List<string> kuk)
        {
            foreach (string rhonq in kuk)
            {
                Boolean checkfd = false;
                Boolean checkex = false;
                string rhon = "";
                string[] abde1 = rhonq.Split('\t');
                if (abde1.Count() >= 1)
                {
                    rhon = abde1[0].Replace("_�_", "_–_").Replace("â€™", "’").Replace("â€“", "–").Replace("_ï¿½_", "_–_").Replace("ï¿½", "-"); ;
                }
                string amazonsku = "";
                string brand = "";
                string brand1 = "";
                string inputsku = "";
                if (abde1.Count() >= 2)
                {
                    brand = abde1[1];
                }
                if (abde1.Count() >= 3)
                {
                    brand1 = abde1[2];
                }
                if (abde1.Count() >= 4)
                {
                    inputsku = abde1[3];
                }
                if (abde1.Count() >= 5)
                {
                    amazonsku = abde1[4];
                }
            jsk:
                try
                {

                    str = Gethtml(rhon.Replace("�", "-").Replace(" �", "-"));
                }
                catch
                {
                    human.Add(rhon.Trim());
                    if (human.Count > 50)
                    {
                        human.Clear();
                        nalu.Add("s");
                        //  lab6show(nalu);
                        checkfd = true;
                        checkex = true;
                        qvcp.Rows.Add("Exception", "", "", "", "", "", "", "", "", "", "", "", rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                        // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                        WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
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
                str = str.Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");


                List<string> sizcd = new List<string>();
                string prdid = "";
                try
                {
                    prdid = GetSubString(str, "<li class=\"current\" role=\"menuitem\">", "</li>");
                    prdid = prdid.Split(':')[1].Trim();
                }

                catch { }
                if (prdid == "")
                {
                    str = null;

                    if (brand != "")
                    {
                    jskr:
                        try
                        {
                            str = Gethtml("http://www.fanatics.com/search/" + brand);
                        }
                        catch
                        {
                            human.Add(rhon.Trim());
                            if (human.Count > 200)
                            {
                                human.Clear();
                                nalu.Add("s");
                                //  lab6show(nalu);
                                checkfd = true;
                                checkex = true;
                                qvcp.Rows.Add("IDException", "", "", "", "", "", "", "", "", "", "", "", rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                                // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                                goto psk;
                            }
                        }
                        if (str == null || str == "")
                        {

                            goto jskr;
                        }
                        if (human.Count >= 1)
                        {
                            human.Clear();
                        }
                        string link = getsubstring("<div class=\"BottomLink\">", "\" title", str).Replace("<a href=\"", "");
                        link = Regex.Replace(link, @" ?\<.*?\>", string.Empty);
                        link = Regex.Replace(link, @"\s+", "");
                        if (link != "")
                        {
                            str = null;
                            try
                            {
                                str = Gethtml(link);
                            }
                            catch
                            {
                                human.Add(rhon.Trim());
                                if (human.Count > 200)
                                {
                                    human.Clear();
                                    nalu.Add("s");
                                    //  lab6show(nalu);
                                    checkfd = true;
                                    checkex = true;
                                    qvcp.Rows.Add("linkException", "", "", "", "", "", "", "", "", "", "", "", rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                                    // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                                    WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                                    goto psk;
                                }
                            }
                            if (str == null || str == "")
                            {

                                goto jskr;
                            }
                            if (human.Count >= 1)
                            {
                                human.Clear();
                            }
                            try
                            {
                                prdid = GetSubString(str, "<li class=\"current\" role=\"menuitem\">", "</li>");
                                prdid = prdid.Split(':')[1].Trim();
                            }

                            catch { }
                            if (prdid == "")
                            {
                                nalu.Add("s");
                                // lab6show(nalu);
                                checkfd = true;
                                checkex = true;
                                qvcp.Rows.Add("No ID", "", "", "", "", "", "", "", "", "", "", "", rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                                // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                                goto psk;
                            }
                            else
                            {
                                rhon = link;
                            }
                        }
                        else
                        {
                            nalu.Add("s");
                            // lab6show(nalu);
                            checkfd = true;
                            checkex = true;
                            qvcp.Rows.Add("No ID", "", "", "", "", "", "", "", "", "", "", "", rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                            // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                            WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                            goto psk;
                        }

                    }

                }
                //if (checkid.Contains("#" + prdid))
                //{

                //    goto psk;
                //}
                //else
                //{
                //    checkid.Add("#" + prdid);
                //}
                List<string> outs = new List<string>();
                List<string> sizzzzz = new List<string>();
                string color = "";
                string price = "";
                try
                {
                    price = GetSubString(str, "Regular:", "</p>").Replace("&nbsp;", "");
                    price = price.Split('$')[1].Trim();
                    price = Regex.Replace(price, "<[/?[a-z][a-z0-9]*[^<>]*>", "");
                }
                catch { }
                string newprc = "";
                try
                {
                    newprc = GetSubString(str, "Sale:", "</span>").Replace("&nbsp;", "");
                    newprc = newprc.Split('$')[1].Trim();
                }
                catch
                {
                    try
                    {
                        newprc = GetSubString(str, ">Price:", "</p>").Replace("&nbsp;", "");
                        newprc = newprc.Split('$')[1].Trim();
                    }
                    catch
                    { }
                }
                //  List<string> sz = new List<string>();
                //  List<string> siztype = new List<string>();
                string invenstatus = "";
                //try
                //{
                //    string siz = getsubstring("<div class=\"columns large-12 sizeChoiceContainer\">", "<div id=\"pdpAddToCartContainer\"", str);


                //    pattern = @"<div class=[^>]*?""(.*?)/div>";
                //    outs.AddRange(matchkar(siz, pattern, ""));

                //    // sz = GetArraySubString(siz,"<a class=","</a>");
                //    while (siz.IndexOf("<a class=") != -1)
                //    {
                //        int c1 = siz.IndexOf("<a class=");
                //        int c2 = siz.IndexOf("</a>", c1 + 7);
                //        string sub3 = siz.Substring(c1, c2 - c1).Trim();
                //        sz.Add(sub3);
                //        int index4 = siz.IndexOf("<a class=") + 15;
                //        siz = siz.Substring(index4, siz.Length - index4).Trim();

                //    }

                //    foreach (string value6 in sz)
                //    {
                //        string val6 = value6;
                //        string szcd = GetSubString(val6, "<span class=\"sku\">", "</span>");
                //        string size = szcd.Split('>')[1].Trim();
                //        sizcd.Add(size);
                //    }
                //    foreach (string value12 in sz)
                //    {

                //        string sze = GetSubString(value12, "<span class=\"size\">", "</span>");
                //        string sztype = sze.Split('>')[1].Trim();
                //        if (sztype != "")
                //        {
                //            sztype = "#" + sztype;
                //        }
                //        siztype.Add(sztype);
                //    }
                //}
                //catch { }
                string usav = "";
                try
                {
                    string usave = GetSubString(str, "<p class=\"savedAmount\">", "</p>");
                    usav = GetSubString(usave, "<span class=\"savedAmountValue\">", "</span>").Split('>')[1].Trim();
                }
                catch { }
                //avg rating and review
                string shp = "";
                try
                {
                    shp = GetSubString(str, "<ul class=\"pdpLeftContent \">", "</div>");
                    shp = Regex.Replace(shp, "<[/?[a-z][a-z0-9]*[^<>]*>", "").Replace("\r", "").Replace("\t", "").Replace("\n", "");
                }
                catch { }
                string shiprate = "";
                try
                {
                    string shprat = GetSubString(str, "<ul class=\"pdpLeftContent \">", "</a>");
                    string shiprat = GetSubString(shprat, "</div>", "<a href=");
                    shiprate = GetSubString(shiprat, "<div class=\"pdpShippingMemo\">", "flat");
                    shiprate = shiprate.Split('>')[1].Trim();
                }
                catch { }
                string stckst = "";
                try
                {

                    if (str.IndexOf("availability\" content=\"Out Of Stock") > 0)
                    {
                        stckst = "out of stock";
                    }
                    else if (str.IndexOf("availability\" content=\"In Stock") > 0)
                    {
                        stckst = "In stock";
                    }


                    //string stck = GetSubString(str, "<meta itemprop=\"availability", "</span>");
                    //stckst = GetSubString(stck, "content=", "/>");
                    //stckst = stckst.Split('=')[1].Replace("\"", "").Trim();
                }
                catch { }
                string shipdt = "";
                try
                {
                    if (str.IndexOf("//images.footballfanatics.com/partners/ff/2015/fanatics_defense_desktop_sliver.jpg") != -1)
                    {
                        shipdt = "This item ships FREE with code: ZONE ";
                    }
                }
                catch
                {
                }
                string prdcategry = "";
                nalu.Add("s");
                // lab6show(nalu);
                int j = 0;
                if (prdid != "")
                {
                    prdid = "#" + prdid;
                }
                if (str.IndexOf("Color<") < 0)
                {
                    if (str.IndexOf(">Select Sport") > 0)
                    {
                        // pattern = @"<option valu[^>]*?e(.*?)/option>";
                        //  MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        // foreach (Match match in matches)
                        // {
                        //string ad = match.Groups[1].Value;
                        //color = getsubstring("\">", "<", ad);
                        //color = Regex.Replace(color, @" ?\<.*?\>", string.Empty);
                        //color = Regex.Replace(color, @"\s+", " ");
                        //if (color != "")
                        //{
                        //    color = "#" + color;
                        //}
                        //foreach (string szval in sizcd)
                        //{
                        //    if (szval != "")
                        //    {
                        //        string rawd = getsubstring("sku-id=\"" + szval, "class=\"sku", str);
                        //        if (rawd != "")
                        //        {
                        //            invenstatus = getsubstring("inventory-tier=\"", "\" on", rawd).Replace("2", "Less than 3 left!").Replace("5", "Less than 5 left!").Replace("8", "Less than 8 left!").Replace("10", "Less than 10 left!");
                        //        }
                        //        else
                        //        {
                        //            invenstatus = "";
                        //        }
                        //        string raw = getsubstring(szval + "\",", "});", str);
                        //        if (raw != "")
                        //        {
                        //            string p = getsubstring("\"regular_price\":", ",", raw).Replace("\"", "");
                        //            if (!p.Contains("productRegularPrice"))
                        //            {
                        //                price = p;
                        //            }
                        //            string sale = getsubstring("\"sale_price\":", ",", raw).Replace("\"", "");
                        //            if (!sale.Contains("productSalePrice"))
                        //            {
                        //                newprc = sale;
                        //            }
                        //            string clr = getsubstring("\"clearance_price\":", ",", raw).Replace("\"", "");
                        //            if (!clr.Contains("productClearancePrice"))
                        //            {
                        //                newprc = clr;
                        //            }
                        //        }
                        //        string sc = getsubstring("'" + szval + "', '", "',", str);
                        //        if (string.IsNullOrEmpty(sc) == false)
                        //        {
                        //            sc = sc.Replace("$", "");
                        //            try
                        //            {
                        //                double scx = Convert.ToDouble(sc);
                        //                double ogi = Convert.ToDouble(newprc.Replace("$", ""));
                        //                double result = ogi + scx;
                        //                newprc = result.ToString();
                        //            }
                        //            catch
                        //            {
                        //            }

                        //        }
                        //    }
                        //    newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                        //    newprc = Regex.Replace(newprc, @"\s+", " ");
                        // if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , siztype[j] , szval.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() + "\t" + avgrating.Trim() + "\t" + review.Trim() + "\t" + shiprate.Trim() + "\t" + shp.Trim() + "\t" + proddet.Trim() + "\t" + prddsc.Trim() + "\t" + shipdt.Trim() + "\t" + prdcategry.Trim() + "\t" + stckst.Trim()))
                        //  {
                        checkfd = true;
                        checkex = true;
                        qvcp.Rows.Add(prdid.Trim(), color.Trim(), "Dropdown present", "", price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), abde1[1], abde1[2], inputsku, amazonsku);
                        // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                        WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                        // File.WriteAllLines("a.txt", prd);
                        //StreamWriter sw = new StreamWriter(dgwq, true);
                        //sw.WriteLine(prd[prd.Count - 1]);
                        //sw.Close();

                        //  j++;
                        //  h++;
                        //prdcnt_lbl.Text = Convert.ToString(i);
                        //  }
                        //  }
                        //if (outs.Count >= 1)
                        //{
                        //    foreach (string d in outs)
                        //    {
                        //        invenstatus = "";
                        //        string size = getsubstring("k\">", "<", d);
                        //        if (size != "")
                        //        {
                        //            size = "#" + size;
                        //        }
                        //        string sk = "";
                        //        if (d.Contains("Out of stock"))
                        //        {
                        //            stckst = "Out of stock";
                        //        }
                        //        newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                        //        newprc = Regex.Replace(newprc, @"\s+", " ");
                        //        //  if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , size , sk.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() , avgrating.Trim() , review.Trim() , shiprate.Trim() , shp.Trim() , proddet.Trim() , prddsc.Trim() , shipdt.Trim() , prdcategry.Trim() , stckst.Trim()))
                        //        // {
                        //        qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Trim(), brand.Trim(), color.Trim(), size, sk.Trim(), price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                        //        // File.WriteAllLines("a.txt", prd);
                        //        //StreamWriter sw = new StreamWriter(dgwq, true);
                        //        //sw.WriteLine(prd[prd.Count - 1]);
                        //        //sw.Close();
                        //        WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                        //        j++;
                        //        h++;
                        //        //prdcnt_lbl.Text = Convert.ToString(i);
                        //        // }
                        //    }


                        //  }
                        //h = 0;
                        //j = 0;
                        //  }
                    }
                    else
                    {
                        sizzzzz.Add(brand1);
                        string sizename = "";
                        foreach (string szval in sizzzzz)
                        {
                            if (szval != "")
                            {
                                string rawd = getsubstring("sku-id=\"" + szval, "class=\"sku", str);
                                if (rawd != "")
                                {
                                    invenstatus = getsubstring("inventory-tier=\"", "\" on", rawd).Replace("2", "Less than 3 left!").Replace("5", "Less than 5 left!").Replace("8", "Less than 8 left!").Replace("10", "Less than 10 left!");

                                    sizename = getsubstring("size\">", "</span>", rawd);
                                    sizename = Regex.Replace(sizename, @" ?\<.*?\>", string.Empty);
                                    sizename = Regex.Replace(sizename, @"\s+", " ");
                                    string raw = getsubstring(szval + "\",", "});", str);
                                    if (raw != "")
                                    {
                                        string p = getsubstring("\"regular_price\":", ",", raw).Replace("\"", "");
                                        if (!p.Contains("productRegularPrice"))
                                        {
                                            price = p;
                                        }
                                        string sale = getsubstring("\"sale_price\":", ",", raw).Replace("\"", "");
                                        if (!sale.Contains("productSalePrice"))
                                        {
                                            newprc = sale;
                                        }
                                        string clr = getsubstring("\"clearance_price\":", ",", raw).Replace("\"", "");
                                        if (!clr.Contains("productClearancePrice"))
                                        {
                                            newprc = clr;
                                        }
                                    }
                                    string sc = getsubstring("'" + szval + "', '", "',", str);
                                    if (string.IsNullOrEmpty(sc) == false)
                                    {
                                        sc = sc.Replace("$", "");
                                        try
                                        {
                                            double scx = Convert.ToDouble(sc);
                                            double ogi = Convert.ToDouble(newprc.Replace("$", ""));
                                            double result = ogi + scx;
                                            newprc = result.ToString();
                                        }
                                        catch
                                        {
                                        }

                                    }
                                }

                                else
                                {
                                    stckst = "out of stock";
                                }
                            }

                            newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                            newprc = Regex.Replace(newprc, @"\s+", " ");
                            if (sizename != "")
                            {
                                sizename = "#" + sizename;
                            }
                            // if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , siztype[j] , szval.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() + "\t" + avgrating.Trim() + "\t" + review.Trim() + "\t" + shiprate.Trim() + "\t" + shp.Trim() + "\t" + proddet.Trim() + "\t" + prddsc.Trim() + "\t" + shipdt.Trim() + "\t" + prdcategry.Trim() + "\t" + stckst.Trim()))
                            //  {
                            checkfd = true;
                            checkex = true;
                            qvcp.Rows.Add(prdid.Trim(), color.Trim(), sizename, szval.Trim(), price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                            // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                            WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                            // File.WriteAllLines("a.txt", prd);
                            //StreamWriter sw = new StreamWriter(dgwq, true);
                            //sw.WriteLine(prd[prd.Count - 1]);
                            //sw.Close();

                            j++;
                            h++;
                            //prdcnt_lbl.Text = Convert.ToString(i);
                            //  }
                        }
                        //if (outs.Count >= 1)
                        //{
                        //    foreach (string d in outs)
                        //    {
                        //        invenstatus = "";
                        //        string size = getsubstring("k\">", "<", d);
                        //        if (size != "")
                        //        {
                        //            size = "#" + size;
                        //        }
                        //        string sk = "";
                        //        if (d.Contains("Out of stock"))
                        //        {
                        //            stckst = "Out of stock";
                        //        }
                        //        newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                        //        newprc = Regex.Replace(newprc, @"\s+", " ");
                        //        //  if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , size , sk.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() , avgrating.Trim() , review.Trim() , shiprate.Trim() , shp.Trim() , proddet.Trim() , prddsc.Trim() , shipdt.Trim() , prdcategry.Trim() , stckst.Trim()))
                        //        // {
                        //        qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Trim(), color.Trim(), size, sk.Trim(), price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                        //        // File.WriteAllLines("a.txt", prd);
                        //        //StreamWriter sw = new StreamWriter(dgwq, true);
                        //        //sw.WriteLine(prd[prd.Count - 1]);
                        //        //sw.Close();
                        //        WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                        //        j++;
                        //        h++;
                        //        //prdcnt_lbl.Text = Convert.ToString(i);
                        //        // }
                        //    }

                        // }
                        // }
                    }
                }
                else
                {
                    // pattern = @"data-colo[^>]*?r(.*?)>";
                    //MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    // foreach (Match match in matches)
                    //string match = getsubstring("data-pid=\"" + abde1[1], ">", str);
                    //if (match != "")
                    //{

                    //string cb = match.Groups[1].Value;
                    //color = getsubstring("=\"", "\" data", cb);
                    //color = Regex.Replace(color, @" ?\<.*?\>", string.Empty);
                    //color = Regex.Replace(color, @"\s+", " ");

                    //string ad = getsubstring("pid=\"", "data", cb);
                    //ad = ad.Replace("\"", "");
                    //ad = Regex.Replace(ad, @" ?\<.*?\>", string.Empty);
                    //ad = Regex.Replace(ad, @"\s+", "");
                    //if (ad != abde1[1])
                    //{
                    //    goto dsk;
                    //}
                    // ad=ad+"},"ad
                    //if (ad.Length < 15)
                    //{
                    //prdid = "#" + ad;
                    //if (checkid.Contains("#" + prdid))
                    //{

                    //    goto dsk;
                    //}
                    //else
                    //{
                    //    checkid.Add("#" + prdid);
                    //}
                    string match = brand;
                    if (str.Contains(match))
                    {
                        string gopu = "";
                    pskt:
                        try
                        {
                            gopu = Gethtml("http://www.fanatics.com/catalog/productjson/" + match);
                        }
                        catch
                        {
                            human.Add(gopu.Trim());
                            if (human.Count > 50)
                            {
                                human.Clear();
                                checkfd = true;
                                checkex = true;
                                qvcp.Rows.Add("ColorException", "", "", "", "", "", "", "", "", "", "", "", rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                                // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                                goto psk;
                            }
                        }
                        if (gopu == null || gopu == "")
                        {

                            goto pskt;
                        }
                        if (human.Count >= 1)
                        {
                            human.Clear();
                        }
                        color = getsubstring(brand + ",\"PrimaryColorName\":\"", "\",", gopu);
                        color = Regex.Replace(color, @" ?\<.*?\>", string.Empty);
                        color = Regex.Replace(color, @"\s+", " ");
                        if (color != "")
                        {
                            color = "#" + color;
                        }
                        string bd = getsubstring("{\"ID\":" + abde1[2], "}", gopu);
                        //pattern = @"{""ID[^>]*?""(.*?)}";
                        //MatchCollection matches1 = Regex.Matches(gopu, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        //foreach (Match match1 in matches1)
                        if (bd != "")
                        {
                            //string bd = match1.Groups[1].Value;
                            bd = bd + "},";
                            // string sizeid = getsubstring(":", ",", bd);

                            //string sc = getsubstring("'" + sizeid + "', '", "',", str);
                            string sizename = getsubstring("\"Name\":\"", "\",", bd);
                            if (sizename != "")
                            {
                                sizename = "#" + sizename;
                            }
                            newprc = getsubstring("\"Price\":\"", "\",", bd);
                            invenstatus = getsubstring("\"InventoryUrgencyTier\":", "},", bd).Replace("\"", "").Replace("2", "Less than 3 left!").Replace("5", "Less than 5 left!").Replace("8", "Less than 8 left!").Replace("10", "Less than 10 left!");
                            if (invenstatus == "null")
                            {
                                invenstatus = "";
                            }
                            stckst = getsubstring("\"IsOutOfStock\":", ",", bd);
                            if (stckst == "false")
                            {
                                stckst = "In_Stock";
                            }
                            else if (stckst == "true")
                            {
                                stckst = "Out_Of_Stock";
                                invenstatus = "";
                            }
                            newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                            newprc = Regex.Replace(newprc, @"\s+", " ");
                            checkfd = true;
                            checkex = true;
                            qvcp.Rows.Add(prdid.Trim(), color.Trim(), sizename, brand1, price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                            // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                            WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                        csk:
                            int xxxx = 0;
                        }
                    }
                    else
                    {
                        checkfd = true;
                        checkex = true;
                        qvcp.Rows.Add("Color id not found in product", "", "", "", "", "", "", "", "", "", "", "", rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                        // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                        WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                    }

                    //}
                    //else
                    //{
                    //    newprc = Regex.Replace(newprc, @" ?\<.*?\>", string.Empty);
                    //    newprc = Regex.Replace(newprc, @"\s+", " ");
                    //    checkfd = true;
                    //    qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), color.Trim(), "More than 15", "", price.Trim(), newprc.Trim(), usav.Trim(), shiprate.Trim(), shp.Trim(), shipdt.Trim(), stckst.Trim(), invenstatus.Trim());
                    //    // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                    //    WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                    //}
                    //}
                }
            psk:
                str = null;
                if (checkfd == false && checkex == false)
                {
                    qvcp.Rows.Add("", "", "", "", "", "", "", "", "", "", "out of stock", "", rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand, brand1, inputsku, amazonsku);
                    // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                    WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                }
            }
            //  MessageBox.Show("Completed");
            //LISTCONTAINS
        }
        public static void PerformWebBrowseOp()
        {
           // Form1 fbc = new Form1();
           // fbc.webBrowser1.Navigate("http://www.facebook.com");
        }

    }
}
