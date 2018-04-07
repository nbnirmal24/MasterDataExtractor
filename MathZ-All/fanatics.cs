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
namespace MathZ_All
{
    class fanatics
    {
        public static String Gethtml(string URL)
        {

            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
            request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
            request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request1.Proxy = null;
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
            qvcp.Columns.Add("Prodcut URL");
            qvcp.Columns.Add("Brand");
            qvcp.Columns.Add("Brand1");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("Product_it");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size type");
            qvcp.Columns.Add("Size Value");
            qvcp.Columns.Add("Image1");
            qvcp.Columns.Add("Image2");
            qvcp.Columns.Add("Image3");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("New Price");
            qvcp.Columns.Add("Usav");
            qvcp.Columns.Add("Rating");
            qvcp.Columns.Add("Review");
            qvcp.Columns.Add("Shipping");
            qvcp.Columns.Add("detail");
            qvcp.Columns.Add("description");
            qvcp.Columns.Add("Shipping Detail");
            qvcp.Columns.Add("Shipping Charge");
            qvcp.Columns.Add("Stock Status");
            qvcp.Columns.Add("Inventory Status");
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
                if (str.IndexOf("<div class=\"ImageLink biImage\">") > 0)
                {
                    pattern = @"<div class=""ImageLink biImage""[^>]*?>(.*?)follow"">";
                    MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in matches)
                    {
                        string ad = match.Groups[1].Value;
                        string bd = getsubstring("<a href=\"", "\" title", ad);
                        if (!bd.Contains("http"))
                        {
                            bd = "http://www.fanatics.com" + bd;
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
                    while (str.IndexOf("<a class=\"paginationRightArrow\"") > 0)
                    {
                        string dc = getsubstring("<a class=\"paginationRightArrow", "Next Page\">", str);
                        string next = "";
                        if (dc != "")
                        {
                            next = getsubstring("href=\"", "\" title", dc);
                            if (next != "")
                            {
                                if (!next.Contains("http"))
                                {
                                    next = "http://www.fanatics.com" + next;
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
                        pattern = @"<div class=""ImageLink biImage""[^>]*?>(.*?)follow"">";
                        MatchCollection matches1 = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match match in matches1)
                        {
                            string ad = match.Groups[1].Value;
                            string bd = getsubstring("<a href=\"", "\" title", ad);
                            if (!bd.Contains("http"))
                            {
                                bd = "http://www.fanatics.com" + bd;
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
                else if (thor == "http://www.fanatics.com/Soccer")
                {
                    string raw = getsubstring("<section id=\"ShopByTeam\"", "<section id=\"BSpot\"", str);
                    if (raw != "")
                    {
                        pattern = @"<li><a href=[^>]""(.*?)"" title";
                        iron.AddRange(matchkar(raw, pattern, "http://www.fanatics.com"));
                    }
                }
                else if (str.IndexOf("<ul class=\"Shop") > 0)
                {
                    pattern = @"<ul class=""[^>]*?Shop(.*?)</ul>";
                    MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in matches)
                    {
                        string ad = match.Groups[1].Value;
                        pattern = @"<a href=[^>]*?""(.*?)"" title";
                        iron.AddRange(matchkar(ad, pattern, "http://www.fanatics.com"));
                    }
                }
                else if (str.IndexOf("<a class=\"category-card-link\" href=\"") > 0)
                {
                    pattern = @"<a class=""category-card-link"" href=[^>]*?""(.*?)"" title";
                    iron.AddRange(matchkar(str, pattern, "http://www.fanatics.com"));
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
                str = str.Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");
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
                    prdid = GetSubString(str, "<li class=\"current\" role=\"menuitem\">", "</li>");
                    prdid = prdid.Split(':')[1].Trim();
                }

                catch { }
                if (prdid == "")
                {
                    str = null;
                jskt:
                    try
                    {
                        str = Gethtml(rhon.Replace("_-_", "_–_"));

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

                        goto jskt;
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
                        li3.Add("NO_ID" + rhon.Trim());
                        Ulb.Text = li3.Count.ToString();
                        System.IO.File.WriteAllLines(abcd, li3);
                        goto psk;
                    }
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
                string prodtit = "";
                string color = "";
                try
                {
                    prodtit = getsubstring("itemprop=\"name\">", "</h2>", str);
                    prodtit = Regex.Replace(prodtit, @" ?\<.*?\>", string.Empty);
                    prodtit = Regex.Replace(prodtit, @"\s+", " ");
                }
                catch { }
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
                brand = getsubstring("Brand('", "');", str);
                brand1 = getsubstring("brand\" content=\"", "\" />", str);
                brand1 = Regex.Replace(brand1, @" ?\<.*?\>", string.Empty);
                brand1 = Regex.Replace(brand1, @"\s+", " ");
                brand = Regex.Replace(brand, @" ?\<.*?\>", string.Empty);
                brand = Regex.Replace(brand, @"\s+", " ");
                newprc = Regex.Replace(newprc, "<[/?[a-z][a-z0-9]*[^<>]*>", "");
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

                string avgrating = "";
                try
                {
                    string avgrat = GetSubString(str, "<div class=\"prStarsFullContainer\">", "</div>");
                    avgrating = GetSubString(str, "data-stars", ">").Split('=')[1].Replace("\"", "").Trim();
                }
                catch { }
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
                string proddet = "";
                try
                {
                    string prddet = GetSubString(str, "<ul class=\"product-bullet-list\">", "</ul>");
                    List<string> prddt = new List<string>();
                    List<string> prdim = new List<string>();
                    while (prddet.IndexOf("<li>") != -1)
                    {
                        int pd1 = prddet.IndexOf("<li>");
                        int pd2 = prddet.IndexOf("</li>", pd1 + 7);
                        string sub1 = prddet.Substring(pd1, pd2 - pd1).Split('>')[1].Trim();
                        prddt.Add(sub1);
                        int index1 = prddet.IndexOf("<li>") + 5;
                        prddet = prddet.Substring(index1, prddet.Length - index1).Trim();
                    }
                    foreach (string valg in prddt)
                    {
                        if (proddet == "")
                        {
                            proddet = valg.Trim(); ;
                        }
                        else
                            proddet = proddet + "|" + valg.Trim();
                    }
                }
                catch { }
                proddet = proddet.Replace("&quot;", "\"").Replace("&amp;", "&");
                string prddsc = "";
                try
                {
                    string prdds = GetSubString(str, "<div id=\"product-description", "</ul>");
                    prddsc = GetSubString(prdds, "<p>", "</p>");


                    prddsc = prddsc.Split('>')[1].Replace("\r", "").Replace("\t", "").Replace("\n", "").Trim();
                }
                catch { }
                string prodimg = "", image1 = "", image2 = "", image3 = "", image4 = "";
                try
                {
                    if (str.IndexOf("<div id=\"pdpMultiZoomControl") != -1)
                    {
                        prodimg = GetSubString(str, "<div id=\"pdpMultiZoomControl", "<div class=\"pdpButtonContainer");

                        try
                        {
                            string img1 = GetSubString(prodimg, "<div id=\"pdpMultiZoomImage1", "</div>");
                            string imag1 = GetSubString(img1, "path=", ">");
                            image1 = GetSubString(imag1, "//", "jpg");
                            image1 = image1.Replace("\"", "").Replace("//", "http://").Trim() + "jpg";


                        }
                        catch { }

                        try
                        {
                            string img2 = GetSubString(prodimg, "<div id=\"pdpMultiZoomImage2", "</div>");
                            string imag2 = GetSubString(img2, "path=", ">");

                            image2 = GetSubString(imag2, "//", "jpg");
                            image2 = image2.Replace("\"", "").Replace("//", "http://").Trim() + "jpg";


                        }
                        catch { }
                        try
                        {
                            string img3 = GetSubString(prodimg, "<div id=\"pdpMultiZoomImage3", "</div>");
                            string imag3 = GetSubString(img3, "path=", ">");
                            image3 = GetSubString(imag3, "//", "jpg");
                            image3 = image3.Replace("\"", "").Replace("//", "http://").Trim() + "jpg";


                        }
                        catch { }
                    }
                    else
                    {
                        string img4 = GetSubString(str, "<meta property=\"og:image", "<link rel=\"image_src");
                        string imag4 = GetSubString(img4, "content=", "/>");
                        image1 = GetSubString(imag4, "//", "\"");
                        image1 = image1.Replace("\"", "").Replace("//", "http://");
                    }
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

                /*  string shpdet = GetSubString(str, "<section id=\"ShippingSliver", "</div>");
                  string shipdt = GetSubString(shpdet, "alt=", "/>");
                  shipdt = shipdt.Split('\"')[1].Replace("\"", "").Trim();*/
                string prdcategry = "";
                nalu.Add("s");
                lb.Text = nalu.Count.ToString();
                //try
                //{
                //    string cat = GetSubString(str, "<ul class=\"breadcrumbs browseHeaderBreadCrumbs browseHeaderBreadCrumbs", "</ul>");
                //    List<string> prdcat = new List<string>();
                //    while (cat.IndexOf("<li") != -1)
                //    {
                //        int pdc1 = cat.IndexOf("<li");
                //        int pdc2 = cat.IndexOf("</li>", pdc1 + 7);
                //        string sub2 = cat.Substring(pdc1, pdc2 - pdc1).Trim();
                //        sub2 = Regex.Replace(sub2, "<[/?[a-z][a-z0-9]*[^<>]*>", "");
                //        prdcat.Add(sub2.Trim());
                //        int index3 = cat.IndexOf("<li") + 5;
                //        cat = cat.Substring(index3, cat.Length - index3).Trim();
                //    }


                //    foreach (string valc in prdcat)
                //    {
                //        string valca = valc.Replace("\t", "").Replace("\n", "").Replace("\r", "").Trim();
                //        if (prdcategry == "")
                //        {
                //            prdcategry = valca.Trim();
                //        }
                //        else
                //            prdcategry = prdcategry + " >" + valca.Trim();
                //    }
                //}
                //catch { }
                prdcategry = getsubstring("<ul class=\"breadcrumbs", "</ul>", str);
                if (prdcategry != "")
                {
                    prdcategry = "<" + prdcategry.Replace("</a>", ">");
                }
                prdcategry = Regex.Replace(prdcategry, @" ?\<span.*?\/span>", string.Empty);
                prdcategry = Regex.Replace(prdcategry, @" ?\<.*?\>", string.Empty);
                prdcategry = Regex.Replace(prdcategry, @"\s+", " ");
                string review = "";
                try
                {
                    review = GetSubString(str, "<div class=\"total-reviews\">", "</div>");
                    review = review.Replace("\t", "").Replace("\n", "").Split('>')[1].Trim();
                }
                catch { }
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
                            string gd = getsubstring("=\"", "\">", ad);
                            if (gd != "")
                            {
                                image1 = "http://images.fanatics.com/lf?set=key[sport],value[" + gd + "]&call=url[http://dmimages.ff.p10/chains/1081844.txt]&scale=size[600]&sink";
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
                                }
                                // if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , siztype[j] , szval.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() + "\t" + avgrating.Trim() + "\t" + review.Trim() + "\t" + shiprate.Trim() + "\t" + shp.Trim() + "\t" + proddet.Trim() + "\t" + prddsc.Trim() + "\t" + shipdt.Trim() + "\t" + prdcategry.Trim() + "\t" + stckst.Trim()))
                                //  {
                                qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand.Trim(), brand1.Trim(), prodtit.Trim(), color.Trim(), siztype[j], szval.Trim(), image1.Trim(), image2, image3, price.Trim(), newprc.Trim(), usav.Trim(), avgrating.Trim(), review.Trim(), shiprate.Trim(), shp.Trim(), proddet.Trim(), prddsc.Trim(), shipdt.Trim(), prdcategry.Trim(), stckst.Trim(), invenstatus.Trim());
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

                                    //  if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , size , sk.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() , avgrating.Trim() , review.Trim() , shiprate.Trim() , shp.Trim() , proddet.Trim() , prddsc.Trim() , shipdt.Trim() , prdcategry.Trim() , stckst.Trim()))
                                    // {
                                    qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand.Trim(), brand1.Trim(), prodtit.Trim(), "Dropdown present" + color.Trim(), size, sk.Trim(), image1.Trim(), image2, image3, price.Trim(), newprc.Trim(), usav.Trim(), avgrating.Trim(), review.Trim(), shiprate.Trim(), shp.Trim(), proddet.Trim(), prddsc.Trim(), shipdt.Trim(), prdcategry.Trim(), stckst.Trim(), invenstatus.Trim());
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
                            }
                            // if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , siztype[j] , szval.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() + "\t" + avgrating.Trim() + "\t" + review.Trim() + "\t" + shiprate.Trim() + "\t" + shp.Trim() + "\t" + proddet.Trim() + "\t" + prddsc.Trim() + "\t" + shipdt.Trim() + "\t" + prdcategry.Trim() + "\t" + stckst.Trim()))
                            //  {
                            qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand.Trim(), brand1.Trim(), prodtit.Trim(), color.Trim(), siztype[j], szval.Trim(), image1.Trim(), image2, image3, price.Trim(), newprc.Trim(), usav.Trim(), avgrating.Trim(), review.Trim(), shiprate.Trim(), shp.Trim(), proddet.Trim(), prddsc.Trim(), shipdt.Trim(), prdcategry.Trim(), stckst.Trim(), invenstatus.Trim());
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

                                //  if (!prd.Contains(prdid.Trim() , value8.Trim() , prodtit.Trim() , size , sk.Trim() , image1.Trim() , image2 , image3 , price.Trim() , newprc.Trim() , usav.Trim() , avgrating.Trim() , review.Trim() , shiprate.Trim() , shp.Trim() , proddet.Trim() , prddsc.Trim() , shipdt.Trim() , prdcategry.Trim() , stckst.Trim()))
                                // {
                                qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand.Trim(), brand1.Trim(), prodtit.Trim(), color.Trim(), size, sk.Trim(), image1.Trim(), image2, image3, price.Trim(), newprc.Trim(), usav.Trim(), avgrating.Trim(), review.Trim(), shiprate.Trim(), shp.Trim(), proddet.Trim(), prddsc.Trim(), shipdt.Trim(), prdcategry.Trim(), stckst.Trim(), invenstatus.Trim());
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
                                    Ulb.Text = li3.Count.ToString();
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

                            prodtit = getsubstring("\"Title\":\"", "\",", gopu).Replace("\\u0026", "&").Replace("\\u0027", "");
                            image1 = getsubstring("\"ImagePath\":\"", "\",", gopu);
                            if (image1 != "")
                            {
                                image1 = "http://" + image1 + "?w=600";
                            }
                            image1 = image1.Replace("////", "//");
                            image2 = ""; image3 = ""; image4 = "";
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


                                qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand.Trim(), brand1.Trim(), prodtit.Trim(), color.Trim(), sizename, sizeid.Trim(), image1.Trim(), image2, image3, price.Trim(), newprc.Trim(), usav.Trim(), avgrating.Trim(), review.Trim(), shiprate.Trim(), shp.Trim(), proddet.Trim(), prddsc.Trim(), shipdt.Trim(), prdcategry.Trim(), stckst.Trim(), invenstatus.Trim());
                                // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                                WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                            }

                        }
                        else
                        {
                            qvcp.Rows.Add(prdid.Trim(), rhon.Replace("�", "–").Replace("â€™", "’").Replace("â€“", "–").Trim(), brand.Trim(), brand1.Trim(), prodtit.Trim(), color.Trim(), "more than 15", "", image1.Trim(), image2, image3, price.Trim(), newprc.Trim(), usav.Trim(), avgrating.Trim(), review.Trim(), shiprate.Trim(), shp.Trim(), proddet.Trim(), prddsc.Trim(), shipdt.Trim(), prdcategry.Trim(), stckst.Trim(), invenstatus.Trim());
                            // qvcp.Rows.Add(rhonq, model, upc, "", "", mapprice, saleprice, discountpercent, rating, reviewcount, shipping, shipinfo, "", "", "", stock, color, size, "", "", rhon, inputsku, amazonsku, width, shortdes, productsalesamt, productrank, productdate);
                            WriteDataToFile(qvcp.Rows[qvcp.Rows.Count - 1], dgwq);
                        }
                    dsk:
                        int vcb = 0;
                    }
                }
            psk:
                str = null;
            } //LISTCONTAINS
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
      

      

     

       

     
     
    


    }
}
