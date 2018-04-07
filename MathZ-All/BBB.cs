using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
namespace MathZ_All
{
    class BBB : Common
    {
        static CookieContainer cookieJar = new CookieContainer();

        public static String Gethtml(string URL)
        {
            string html = "";
            if (bg == 1)
            {
                HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
                request1.Timeout = 200000;
                request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
                // request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
                // request1.Proxy = null;
                cookieJar.Add(new Uri("http://www.bedbathandbeyond.com"), new Cookie("BedBathUS1ntsh1", "US:USD"));
                cookieJar.Add(new Uri("http://www.bedbathandbeyond.com"), new Cookie("BedBathUSLVPrdts", ""));
                request1.CookieContainer = cookieJar;
                //  ServicePointManager.Expect100Continue = false;
                //   ServicePointManager.DefaultConnectionLimit = 2;
                //   ServicePointManager.MaxServicePointIdleTime = 2000;
                // request1.AllowAutoRedirect = true;
                HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
                // cookieJar.Add(response1.Cookies);
                StreamReader sr1 = new StreamReader(response1.GetResponseStream());
                html = sr1.ReadToEnd();
                sr1.Close();
                response1.Close();
                bg++;
            }
            else
            {
                HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
                request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
                request1.CookieContainer = cookieJar;
                // request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
                // request1.Proxy = null;
                //  cookieJar.Add(new Uri(URL), new Cookie("BedBathUS1ntsh1", "US:USD"));
                //   request1.CookieContainer = cookieJar;
                //  ServicePointManager.Expect100Continue = false;
                //   ServicePointManager.DefaultConnectionLimit = 2;
                //   ServicePointManager.MaxServicePointIdleTime = 2000;
                // request1.AllowAutoRedirect = true;
                HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
                // cookieJar.Add(response1.Cookies);
                StreamReader sr1 = new StreamReader(response1.GetResponseStream());
                html = sr1.ReadToEnd();
                sr1.Close();
                response1.Close();
            }

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
        public static List<string> ProductURL = new List<string>()  ;
        public static List<string> passpro(List<string> produt)
        {
            produt = ProductURL;
            return produt;
        }
         static List<string> li2 = new List<string>();
         static List<string> li3 = new List<string>();
         static List<string> human = new List<string>();
         static List<string> animal = new List<string>();
         static List<string> nala = new List<string>();
         static List<string> same = new List<string>();
         static List<string> samec = new List<string>();
         static List<string> nalu = new List<string>();
         static string str = null;
         static string str1 = null;
        //   string sub = "";
         static DataTable qvcp = new DataTable();
         static string sub1 = "";
         static string pattern = "";
         static string dgwq = "";
         static string abcd = "", abcd1 = "";
         static int x, y, c, v, cg, bg = 1;
        static bool access = true;
         static public void datetime()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
           
            qvcp.Columns.Add("Parent_SKU");
            qvcp.Columns.Add("Vender_SKU");
            qvcp.Columns.Add("Child_SKU");
            qvcp.Columns.Add("Parentage");
            qvcp.Columns.Add("Brand");
            qvcp.Columns.Add("Title");
            qvcp.Columns.Add("Product INFO");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Image1");
            qvcp.Columns.Add("Variation");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("Finish");
            qvcp.Columns.Add("Stock_Status");
            qvcp.Columns.Add("Description");
            qvcp.Columns.Add("Product_URL");
            dgwq = Application.StartupPath;
            string filename = DateTime.Now.ToString("ddMMyyyyThhmmss");
            if (tb.Text != "")
            {
                dgwq = dgwq + "\\" + "output data" + "\\" +tb.Text + ".txt";
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
         static public void datetime1()
        {
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            qvcp.Columns.Add("Parent_SKU");
            qvcp.Columns.Add("Vender_SKU");
            qvcp.Columns.Add("Child_SKU");
            qvcp.Columns.Add("Parentage");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Variation");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("Finish");
            qvcp.Columns.Add("Stock_Status");
            qvcp.Columns.Add("Product_URL");
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
         static public string getsubstring(string q, string we, string rs)
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
                        //string abid = "";
                        //x = rs.IndexOf("\"skuId\":\"");
                        //y = rs.IndexOf("\",", x);
                        //abid = rs.Substring(x + 9, y - x - 9);
                        //li3.Add(abid);
                        //labunshow(li3);
                        // sub = "";
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
         static public List<string> matchkar(string jabe, string aabe)
        {
            List<string> nirmal = new List<string>();
            MatchCollection matches = Regex.Matches(jabe, aabe, RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                string ad = "http://www.bedbathandbeyond.com" + match.Groups[1].Value;
                ad = Regex.Replace(ad, @"\s+", " ");
                nirmal.Add(ad);
            }
            return nirmal;
        }
         static public List<string> matchkar1(string jabe, string aabe)
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
         static public List<string> category(List<string> hulk)
        {
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
                    str = Gethtml(thor + "/1-96");
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
                if (str.IndexOf("class=\"prodImg") > 0)
                {
                    pattern = @"class=""prodImg "" href=[^>]*?""(.*?)"">";
                    ProductURL.AddRange(matchkar(str, pattern));
                    System.IO.File.WriteAllLines(abcd1, ProductURL);
                    Plb.Text = ProductURL.Count.ToString();
                    x = str.IndexOf("class=\"prodImg");
                    int fr = 1;
                    while (x > 0)
                    {
                        fr = fr + 1;
                        string next = thor + "/" + fr + "-96";

                        str = null;
                    jskt:
                        try
                        {
                            str = Gethtml(next);
                        }
                        catch(Exception df)
                        {
                            if (df.ToString().Contains("404"))
                            {
                                break;
                            }
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

                            goto jskt;
                        }
                        if (human.Count >= 1)
                        {
                            human.Clear();
                        }
                        if (str.IndexOf("class=\"prodImg") < 0)
                        {
                            break;
                        }
                        pattern = @"class=""prodImg "" href=[^>]*?""(.*?)"">";
                        ProductURL.AddRange(matchkar(str, pattern));
                        System.IO.File.WriteAllLines(abcd1, ProductURL);
                        Plb.Text = ProductURL.Count.ToString();

                    }
                }
                else if (str.IndexOf("<h2>Categories</h2>") > 0)
                {
                    // v = str.Length;
                    List<string> temp = new List<string>();
                    // string cat = getsubstring("<h2>Categories</h2>", "</div>", str);
                    pattern = @"<li class=""catCaption""><a title=[^>]*?""(.*?)</a>";
                    temp.AddRange(matchkar(str, pattern));
                    if (temp.Count >= 1)
                    {
                        foreach (string tempo in temp)
                        {
                            string cati = "http://www.bedbathandbeyond.com" + getsubstring("\" href=\"", "\">", tempo);
                            iron.Add(cati);
                        }
                    }
                }
                else
                {
                    li3.Add(thor.Trim());
                    Ulb.Text = li3.Count.ToString();
                    System.IO.File.WriteAllLines(abcd, li3);
                    MessageBox.Show(thor);
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
         static public void product(List<string> yogesh)
        {
           
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
                string id = "";
                id = getsubstring("productId='", "';", str);
                if (id == "")
                {
                    id = getsubstring("productID: \"", "\",", str);
                }
                if (id == "")
                {
                    id = getsubstring("productId: '", "',", str);
                }
                if (id == "")
                {
                    li3.Add("NO ID" + rhon.Trim());
               
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                if (same.Contains(id + ","))
                {
                    li3.Add("SAME ID" + rhon.Trim());
                    Ulb.Text = li3.Count.ToString();
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                else
                {
                    same.Add(id + ",");
                }
                nalu.Add("q");
                lb.Text =nalu.Count.ToString();
                string name = "";
                name = getsubstring("<title>", "</title>", str);
                if (name == "")
                {
                    name = getsubstring("itemprop=\"name\">", "</h1>", str);
                }
                name = name.Replace("- BedBathandBeyond.com", "");
                name = name.Replace("&trade;", "").Replace("&reg;", "");
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                string price = "";
                price = getsubstring("<div class=\"prodPrice\" itemprop=\"price\">", "</div>", str);
                if (str.IndexOf("<span class=\"isPrice\">") > 0)
                {
                    price = getsubstring("<span class=\"isPrice\">", "</span>", str);
                }
                if (str.IndexOf("<li class=\"isPrice\">") > 0)
                {
                    price = getsubstring("<li class=\"isPrice\">", "</li>", str);
                }
                if (price != "")
                {
                    if (price.Contains("Add to Cart to See Price"))
                    {
                        price = getsubstring("<div class=\"prodPrice\" itemprop=\"price\">", "</div>", str);
                    }
                }
                price = Regex.Replace(price, @"\s+", " ");
                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                price = Regex.Replace(price, @"\s+", " ");
                if (price.Contains("$"))
                { }
                else if (price.Length >= 2)
                {
                    price = "$" + price;
                }
                string category = "";
                category = getsubstring("<div class=\"breadcrumbs grid_12\">", "</div>", str).Replace("&gt;", ">").Replace("&amp;", "&");
                category = Regex.Replace(category, @" ?\<.*?\>", string.Empty);
                category = Regex.Replace(category, @"\s+", " ");
                category = WebUtility.HtmlDecode(category);
                string mainimg = "";

                if (str.IndexOf("data-zoomhref=\"") > 0)
                {
                    mainimg = getsubstring("data-zoomhref=\"", "\" ", str);
                }
                else if (str.IndexOf("<img id=\"mainProductImg\" src=\"") > 0)
                {
                    mainimg = getsubstring("<img id=\"mainProductImg\" src=\"", "\" class", str);
                }
                if (mainimg != "")
                {
                    mainimg = "http:" + mainimg;
                }
                str = str.Replace("</ul>", "</UL>").Replace("<ul>", "<UL>").Replace("<li>", "<LI>").Replace("</li>", "</LI>");
                string des = "";
                string rdes = "";
                List<string> abdf = new List<string>();
                des = getsubstring("itemprop=\"description\">", "</UL>", str);
                if (des == "")
                {
                    des = getsubstring("itemprop=\"description\">", "<div class=\"appendSKUInfo\">", str);
                }
                if (des == "")
                {
                    des = getsubstring("itemprop=\"description\">", "<div id=\"prodVideo\" class", str);
                }
                if (des != "")
                {

                    pattern = @"<LI[^>]*?>(.*?)</LI>";
                    MatchCollection huma = Regex.Matches(des, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match dipu in huma)
                    {
                        string fg = dipu.Groups[1].Value;
                        fg = fg.Replace("&trade;", "").Replace("&reg;", "");
                        fg = Regex.Replace(fg, @" ?\<.*?\>", string.Empty);
                        fg = Regex.Replace(fg, @"\s+", " ");
                        abdf.Add(fg);
                    }
                    string imj = "|";

                    rdes = string.Join(imj, abdf.ToArray());
                }
                else
                {
                    rdes = "";
                }
                rdes = WebUtility.HtmlDecode(rdes);
                string info = "";
                info = getsubstring("<div class=\"noprint\">", "</div>", str);
                if (info == "")
                {
                    info = getsubstring("\"description\" content=\"", "\" />", str);
                }
                info = info.Replace("&trade;", "").Replace("&reg;", "");
                info = Regex.Replace(info, @" ?\<.*?\>", string.Empty);
                info = Regex.Replace(info, @"\s+", " ");
                info = WebUtility.HtmlDecode(info);
                string stock = "";
                stock = getsubstring("<link itemprop=\"availability\"", "</span>", str).Replace("href=\"http://schema.org/InStock\"/>", "").Replace("href=\"http://schema.org/OutOfStock\"/>", "");
                if (str.Contains("No Longer Available For Sale Online."))
                {
                    stock = "N-out of stock";
                }
                stock = Regex.Replace(stock, @" ?\<.*?\>", string.Empty);
                stock = Regex.Replace(stock, @"\s+", " ");
                string sku = "";
                sku = getsubstring("prodSKU\">", "</p>", str);
                sku = Regex.Replace(sku, @"\s+", " ");
                string brand = "";
                brand = getsubstring("<title>", "&reg;", str).Replace("\"", "");
                if (brand.Length > 80)
                {
                    brand = "";
                }
                if (brand == "")
                {
                    brand = getsubstring("<title>", "&trade;", str).Replace("\"", ""); ;
                }
                if (brand.Length > 80)
                {
                    brand = "";
                }
                brand = Regex.Replace(brand, @"\s+", " ");
                brand = Regex.Replace(brand, @" ?\<.*?\>", string.Empty);
                string iinfo = "";
                string variation = "";
                string parentage = "Individual";
                string varid = "";
                string color = "";
                string size = "";
                string finish = "";
                string colore = "";
                string sizee = "";
                List<string> col1 = new List<string>();
                List<string> size1 = new List<string>();
                List<string> finish1 = new List<string>();
                int c1, c2, s1, s2;
                iinfo = info;
                if (str.IndexOf("<label>Color</label>") > 0)
                {
                    pattern = @"class=""fl"" dat[^>]*?a(.*?)>";
                    col1.AddRange(matchkar1(str, pattern));
                    if (col1.Count < 1)
                    {
                        string fin = getsubstring("<label>Color</label>", "</div>", str);
                        pattern = @"<a href=""#"" class=[^>]*?""(.*?)<span>";
                        col1.AddRange(matchkar1(fin, pattern));
                    }
                }
                if (str.IndexOf("Select a Size<") > 0)
                {
                    pattern = @"<option data-attr=[^>]*?""(.*?)/option>";
                    size1 = matchkar(str, pattern);
                    if (size1.Count < 1)
                    {
                        size = "check manully";
                    }
                }
                if (col1.Count >= 1 && size1.Count >= 1)
                {
                    parentage = "child";
                    variation = "color/size";
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories/child";
                    }
                    for (c1 = 0; c1 <= col1.Count - 1; c1++)
                    {

                        for (s1 = 0; s1 <= size1.Count - 1; s1++)
                        {
                            potter.Add("c");
                            clb.Text = potter.Count.ToString();
                            color = getsubstring("-attr=\"", "\" ", col1[c1]);
                            mainimg = "http:" + getsubstring("data-imgURLThumb=\"", "$\"", col1[c1]).Replace("$83", "hei=2000&wid=2000&qlt=50,1");
                            size = getsubstring(">", "<", size1[s1]);
                            colore = Uri.EscapeDataString(color);
                            sizee = Uri.EscapeDataString(size);
                            string qurl = "http://www.bedbathandbeyond.com/store/browse/SKU_rollup_details.jsp?productId=" + id + "&prodSize=" + sizee + "&prodColor=" + colore;
                            str = null;
                        jswk:
                            try
                            {
                                str = Gethtml(qurl);
                            }
                            catch
                            {

                            }
                            if (str == null || str == "")
                            {

                                goto jswk;
                            }
                            info = iinfo;
                            varid = getsubstring("\"skuId\":\"", "\",", str);
                            name = getsubstring("productDetails\":\"", "\",", str);
                            name = name.Replace("&trade;", "").Replace("&reg;", "");
                            name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                            name = Regex.Replace(name, @"\s+", " ");
                            name = WebUtility.HtmlDecode(name);
                            string ides = getsubstring("\"productDesc\":\"", "&nbsp;", str);
                            ides = ides.Replace("&trade;", "").Replace("&reg;", "");
                            ides = Regex.Replace(ides, @" ?\<.*?\>", string.Empty);
                            ides = Regex.Replace(ides, @"\s+", " ");
                            ides = WebUtility.HtmlDecode(ides);
                            if (ides != iinfo)
                            {
                                info = ides;
                            }
                            price = getsubstring("\"isPrice\":\"", "\"}", str);
                            if (price == "")
                            {
                                price = getsubstring("\"price\":\"", "\",", str);
                            }
                            string st = getsubstring("\"inStock\":", "\"a", str);
                            if (st.Contains("true"))
                            {
                                stock = "In Stock";
                            }
                            else
                            {
                                stock = "Out Of Stock";
                            }
                            string zoom = getsubstring("\"zoomFlag\":\"", "\"}", str);
                            if (zoom.Contains("true"))
                            {
                            }
                            else
                            {
                                mainimg = mainimg.Replace("hei=2000&wid=2000&qlt=50,1", "$478$");
                            }
                            if (samec.Contains(varid + ","))
                            {
                                li3.Add("SAME child ID" + rhon.Trim());
                                Ulb.Text = li3.Count.ToString();
                                System.IO.File.WriteAllLines(abcd, li3);
                                goto psadk;
                            }
                            else
                            {
                                samec.Add(varid + ",");
                            }
                            color = WebUtility.HtmlDecode(color);
                            size = WebUtility.HtmlDecode(size);
                            if (name == "" && price == "" && stock == "Out Of Stock")
                            {
                                potter.RemoveAt(0);
                                clb.Text = potter.Count.ToString();
                            }
                            else
                            {
                                qvcp.Rows.Add(id, sku, varid, parentage, brand, name, info, category, price, mainimg, variation, color, size, finish, stock, rdes, rhon);
                               // fb.lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        psadk:
                            int vd;
                        }

                    }
                }
                else if (col1.Count >= 1 && size1.Count < 1)
                {
                    parentage = "child";
                    variation = "color";
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories/child";
                    }
                    for (c1 = 0; c1 <= col1.Count - 1; c1++)
                    {
                        potter.Add("c");
                        clb.Text = potter.Count.ToString();
                        color = getsubstring("-attr=\"", "\" ", col1[c1]);
                        mainimg = "http:" + getsubstring("data-imgURLThumb=\"", "$\"", col1[c1]).Replace("$83", "hei=2000&wid=2000&qlt=50,1");
                        colore = Uri.EscapeDataString(color);
                        string qurl = "http://www.bedbathandbeyond.com/store/browse/SKU_rollup_details.jsp?productId=" + id + "&prodSize=null&prodColor=" + colore;
                        str = null;
                    jswk:
                        try
                        {
                            str = Gethtml(qurl);
                        }
                        catch
                        {

                        }
                        if (str == null || str == "")
                        {

                            goto jswk;
                        }
                        info = iinfo;
                        varid = getsubstring("\"skuId\":\"", "\",", str);
                        name = getsubstring("productDetails\":\"", "\",", str);
                        name = name.Replace("&trade;", "").Replace("&reg;", "");
                        name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                        name = Regex.Replace(name, @"\s+", " ");
                        name = WebUtility.HtmlDecode(name);
                        string ides = getsubstring("\"productDesc\":\"", "&nbsp;", str);
                        ides = ides.Replace("&trade;", "").Replace("&reg;", "");
                        ides = Regex.Replace(ides, @" ?\<.*?\>", string.Empty);
                        ides = Regex.Replace(ides, @"\s+", " ");
                        ides = WebUtility.HtmlDecode(ides);
                        if (ides != iinfo)
                        {
                            info = ides;
                        }
                        price = getsubstring("\"isPrice\":\"", "\"}", str);
                        if (price == "")
                        {
                            price = getsubstring("\"price\":\"", "\",", str);
                        }
                        string st = getsubstring("\"inStock\":", "\"a", str);
                        if (st.Contains("true"))
                        {
                            stock = "In Stock";
                        }
                        else
                        {
                            stock = "Out Of Stock";
                        }
                        string zoom = getsubstring("\"zoomFlag\":\"", "\"}", str);
                        if (zoom.Contains("true"))
                        {
                        }
                        else
                        {
                            mainimg = mainimg.Replace("hei=2000&wid=2000&qlt=50,1", "$478$");
                        }
                        if (samec.Contains(varid + ","))
                        {
                            li3.Add("SAME child ID" + rhon.Trim());
                            Ulb.Text = li3.Count.ToString();
                            System.IO.File.WriteAllLines(abcd, li3);
                            goto psack;
                        }
                        else
                        {
                            samec.Add(varid + ",");
                        }
                        color = WebUtility.HtmlDecode(color);
                        size = WebUtility.HtmlDecode(size);
                        if (name == "" && price == "" && stock == "Out Of Stock")
                        {
                            potter.RemoveAt(0);
                            clb.Text = potter.Count.ToString();
                            
                        }
                        else
                        {
                            qvcp.Rows.Add(id, sku, varid, parentage, brand, name, info, category, price, mainimg, variation, color, size, finish, stock, rdes, rhon);
                            // lab6show(qvcp);
                            WriteDataToFile(qvcp, dgwq);
                        }
                    psack:
                        int vc;
                    }


                }
                else if (col1.Count < 1 && size1.Count >= 1)
                {
                    parentage = "child";
                    variation = "size";
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories/child";
                    }
                    for (s1 = 0; s1 <= size1.Count - 1; s1++)
                    {
                        potter.Add("c");
                        clb.Text = potter.Count.ToString();
                        size = getsubstring(">", "<", size1[s1]);
                        sizee = Uri.EscapeDataString(size);
                        string qurl = "http://www.bedbathandbeyond.com/store/browse/SKU_rollup_details.jsp?productId=" + id + "&prodSize=" + sizee + "&prodColor=null";
                        str = null;
                    jswk:
                        try
                        {
                            str = Gethtml(qurl);
                        }
                        catch
                        {

                        }
                        if (str == null || str == "")
                        {

                            goto jswk;
                        }
                        info = iinfo;
                        varid = getsubstring("\"skuId\":\"", "\",", str);
                        name = getsubstring("productDetails\":\"", "\",", str);
                        name = name.Replace("&trade;", "").Replace("&reg;", "");
                        name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                        name = Regex.Replace(name, @"\s+", " ");
                        name = WebUtility.HtmlDecode(name);
                        string ides = getsubstring("\"productDesc\":\"", "&nbsp;", str);
                        ides = ides.Replace("&trade;", "").Replace("&reg;", "");
                        ides = Regex.Replace(ides, @" ?\<.*?\>", string.Empty);
                        ides = Regex.Replace(ides, @"\s+", " ");
                        ides = WebUtility.HtmlDecode(ides);
                        if (ides != iinfo)
                        {
                            info = ides;
                        }
                        price = getsubstring("\"isPrice\":\"", "\"}", str);
                        if (price == "")
                        {
                            price = getsubstring("\"price\":\"", "\",", str);
                        }
                        string st = getsubstring("\"inStock\":", "\"a", str);
                        if (st.Contains("true"))
                        {
                            stock = "In Stock";
                        }
                        else
                        {
                            stock = "Out Of Stock";
                        }
                        if (str.IndexOf("\"imgURL\":\"") > 0)
                        {
                            mainimg = "http:" + getsubstring("\"imgURL\":\"", "\",", str);
                        }
                        string zoom = getsubstring("\"zoomFlag\":\"", "\"}", str);
                        if (zoom.Contains("true"))
                        {
                            mainimg = mainimg.Replace("$478$", "hei=2000&wid=2000&qlt=50,1");
                        }
                        else
                        {
                            mainimg = mainimg.Replace("hei=2000&wid=2000&qlt=50,1", "$478$");
                        }
                        if (samec.Contains(varid + ","))
                        {
                            li3.Add("SAME child ID" + rhon.Trim());
                            Ulb.Text = li3.Count.ToString();
                            System.IO.File.WriteAllLines(abcd, li3);
                            goto psabk;
                        }
                        else
                        {
                            samec.Add(varid + ",");
                        }
                        color = WebUtility.HtmlDecode(color);
                        size = WebUtility.HtmlDecode(size);
                        if (name == "" && price == "" && stock == "Out Of Stock")
                        {
                            potter.RemoveAt(0);
                            clb.Text = potter.Count.ToString();
                        }
                        else
                        {
                            qvcp.Rows.Add(id, sku, varid, parentage, brand, name, info, category, price, mainimg, variation, color, size, finish, stock, rdes, rhon);
                            // lab6show(qvcp);
                            WriteDataToFile(qvcp, dgwq);
                        }
                    psabk:
                        int vc;
                    }


                }
                else if (str.IndexOf("<label>Finish</label>") > 0)
                {
                    parentage = "child";
                    variation = "Fcolor";
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories/child";
                    }
                    string fin = getsubstring("<label>Finish</label>", "</div>", str);
                    pattern = @"<a href=""#"" class=[^>]*?""(.*?)<span>";
                    finish1.AddRange(matchkar(fin, pattern));
                    if (finish1.Count >= 1)
                    {
                        foreach (string cbd in finish1)
                        {
                            potter.Add("c");
                            clb.Text = potter.Count.ToString();
                            finish = getsubstring("data-attr=\"", "\" title", cbd);
                            mainimg = getsubstring("data-imgURLThumb=\"", "\">", cbd);
                            mainimg = "http:" + mainimg.Replace("$83$", "$478$");
                            colore = Uri.EscapeDataString(finish);
                            string qurl = "http://www.bedbathandbeyond.com/store/browse/SKU_rollup_details.jsp?productId=" + id + "&prodSize=null&prodColor=null&prodFinish=" + colore;
                            str = null;
                        jswk:
                            try
                            {
                                str = Gethtml(qurl);
                            }
                            catch
                            {

                            }
                            if (str == null || str == "")
                            {

                                goto jswk;
                            }
                            info = iinfo;
                            varid = getsubstring("\"skuId\":\"", "\",", str);
                            name = getsubstring("productDetails\":\"", "\",", str);
                            name = name.Replace("&trade;", "").Replace("&reg;", "");
                            name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                            name = Regex.Replace(name, @"\s+", " ");
                            name = WebUtility.HtmlDecode(name);
                            string ides = getsubstring("\"productDesc\":\"", "&nbsp;", str);
                            ides = ides.Replace("&trade;", "").Replace("&reg;", "");
                            ides = Regex.Replace(ides, @" ?\<.*?\>", string.Empty);
                            ides = Regex.Replace(ides, @"\s+", " ");
                            ides = WebUtility.HtmlDecode(ides);
                            if (ides != iinfo)
                            {
                                info = ides;
                            }
                            price = getsubstring("\"isPrice\":\"", "\"}", str);
                            if (price == "")
                            {
                                price = getsubstring("\"price\":\"", "\",", str);
                            }
                            string st = getsubstring("\"inStock\":", "\"a", str);
                            if (st.Contains("true"))
                            {
                                stock = "In Stock";
                            }
                            else
                            {
                                stock = "Out Of Stock";
                            }
                            string zoom = getsubstring("\"zoomFlag\":\"", "\"}", str);
                            if (zoom.Contains("true"))
                            {
                                mainimg = mainimg.Replace("$478$", "hei=2000&wid=2000&qlt=50,1");
                            }
                            if (samec.Contains(varid + ","))
                            {
                                li3.Add("SAME child ID" + rhon.Trim());
                                Ulb.Text = li3.Count.ToString();
                                System.IO.File.WriteAllLines(abcd, li3);
                                goto psaak;
                            }
                            else
                            {
                                samec.Add(varid + ",");
                            }
                            finish = WebUtility.HtmlDecode(finish);
                            if (name == "" && price == "" && stock == "Out Of Stock")
                            {
                                potter.RemoveAt(0);
                                clb.Text = potter.Count.ToString();
                            }
                            else
                            {
                                qvcp.Rows.Add(id, sku, varid, parentage, brand, name, info, category, price, mainimg, variation, color, size, finish, stock, rdes, rhon);
                                // lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        psaak:
                            int vb;
                        }



                    }


                }
                else
                {
                    if (varid == "")
                    {
                        varid = id;
                    }
                    if (str.Contains("CHOOSE YOUR ITEMS BELOW"))
                    {
                        parentage = "Collection";
                    }
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories";
                    }
                    if (str.IndexOf("<h3><span class=\"error\">") > 0)
                    {
                        string fg = getsubstring("<h3><span class=\"error\">", "</span>", str);
                        if (fg.Contains("Product not available"))
                        {
                            parentage = "product not available";
                        }
                    }
                    if (name == "" && price == "" && stock == "Out Of Stock" && potter.Count >= 1)
                    {
                        potter.RemoveAt(0);
                        clb.Text = potter.Count.ToString();
                    }
                    else
                    {
                        qvcp.Rows.Add(id, sku, varid, parentage, brand, name, info, category, price, mainimg, variation, color, size, finish, stock, rdes, rhon);
                        // lab6show(qvcp);
                        WriteDataToFile(qvcp, dgwq);
                    }
                }
            psk:
                str = null;
                potter.Clear();
                //clb.Text = potter.Count.ToString();
            }
        }
         static public void stock(List<string> kuk)
        {
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
        //    clb.Visible = true;
            Gethtml("http://www.bedbathandbeyond.com");
            foreach (string rhon in kuk)
            {
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
                cg = 3;
                string id = "";
                id = getsubstring("productId='", "';", str);
                if (id == "")
                {
                    id = getsubstring("productID: \"", "\",", str);
                }
                if (id == "")
                {
                    id = getsubstring("productId: '", "',", str);
                }
                if (id == "")
                {
                    li3.Add("NO ID" + rhon.Trim());
                    Ulb.Text = li3.Count.ToString();
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                //if (same.Contains(id + ","))
                //{
                //    li3.Add("SAME ID" + rhon.Trim());
                //    labunshow(li3);
                //    System.IO.File.WriteAllLines(abcd, li3);
                //    goto psk;
                //}
                //else
                //{
                //    same.Add(id + ",");
                //}
                nalu.Add("q");
                Plb.Text = nalu.Count.ToString();
                string price = "";
                price = getsubstring("<div class=\"prodPrice\" itemprop=\"price\">", "</div>", str);
                if (str.IndexOf("<span class=\"isPrice\">") > 0)
                {
                    price = getsubstring("<span class=\"isPrice\">", "Was<", str);
                    if (price == "")
                    {
                        price = getsubstring("<span class=\"isPrice\">", "</span>", str);
                    }
                }
                if (str.IndexOf("<li class=\"isPrice\">") > 0)
                {
                    price = getsubstring("<li class=\"isPrice\">", "Was<", str);
                    if (price == "")
                    {
                        price = getsubstring("<li class=\"isPrice\">", "</li>", str);
                    }

                }
                if (price != "")
                {
                    if (price.Contains("Add to Cart to See Price"))
                    {
                        price = getsubstring("<div class=\"prodPrice\" itemprop=\"price\">", "</div>", str);
                    }
                }
                price = Regex.Replace(price, @"\s+", " ");
                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                price = Regex.Replace(price, @"\s+", " ");
                if (price.Contains("$"))
                { }
                else if (price.Length >= 2)
                {
                    price = "$" + price;
                }
                string stock = "";
                stock = getsubstring("<link itemprop=\"availability\"", "</span>", str).Replace("href=\"http://schema.org/InStock\"/>", "").Replace("href=\"http://schema.org/OutOfStock\"/>", "").Replace("href=", "<href=");
                if (str.Contains("No Longer Available For Sale Online."))
                {
                    stock = "N-out of stock";
                }
                stock = Regex.Replace(stock, @" ?\<.*?\>", string.Empty);
                stock = Regex.Replace(stock, @"\s+", " ");
                string sku = "";
                sku = getsubstring("prodSKU\">", "</p>", str);
                sku = Regex.Replace(sku, @"\s+", " ");
                string iinfo = "";
                string variation = "";
                string parentage = "Individual";
                string varid = "";
                string color = "";
                string size = "";
                string finish = "";
                string colore = "";
                string sizee = "";
                List<string> col1 = new List<string>();
                List<string> size1 = new List<string>();
                List<string> finish1 = new List<string>();
                int c1, c2, s1, s2;
                if (str.IndexOf("<label>Color</label>") > 0)
                {
                    pattern = @"class=""fl"" dat[^>]*?a(.*?)>";
                    col1.AddRange(matchkar1(str, pattern));
                    if (col1.Count < 1)
                    {
                        string fin = getsubstring("<label>Color</label>", "</div>", str);
                        pattern = @"<a href=""#"" class=[^>]*?""(.*?)<span>";
                        col1.AddRange(matchkar1(fin, pattern));
                    }
                }
                if (str.IndexOf("Select a Size<") > 0)
                {
                    pattern = @"<option data-attr=[^>]*?""(.*?)/option>";
                    size1 = matchkar(str, pattern);
                    if (size1.Count < 1)
                    {
                        size = "check manully";
                    }
                }
                if (col1.Count >= 1 && size1.Count >= 1)
                {
                    parentage = "child";
                    variation = "color/size";
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories/child";
                    }
                    for (c1 = 0; c1 <= col1.Count - 1; c1++)
                    {

                        for (s1 = 0; s1 <= size1.Count - 1; s1++)
                        {
                            potter.Add("c");
                            clb.Text = potter.Count.ToString();
                            color = getsubstring("-attr=\"", "\" ", col1[c1]);
                            colore = Uri.EscapeDataString(color);
                            sizee = Uri.EscapeDataString(size);
                            string qurl = "http://www.bedbathandbeyond.com/store/browse/SKU_rollup_details.jsp?productId=" + id + "&prodSize=" + sizee + "&prodColor=" + colore;
                            str = null;
                        jswk:
                            try
                            {
                                str = Gethtml(qurl);
                            }
                            catch
                            {

                            }
                            if (str == null || str == "")
                            {

                                goto jswk;
                            }
                            price = getsubstring("\"isPrice\":\"", "\"}", str);
                            if (price == "")
                            {
                                price = getsubstring("\"price\":\"", "\",", str);
                            }
                            string st = getsubstring("\"inStock\":", "\"a", str);
                            if (st.Contains("true"))
                            {
                                stock = "In Stock";
                            }
                            else
                            {
                                stock = "Out Of Stock";
                            }
                            //if (samec.Contains(varid + ","))
                            //{
                            //    li3.Add("SAME child ID" + rhon.Trim());
                            //    labunshow(li3);
                            //    System.IO.File.WriteAllLines(abcd, li3);
                            //    goto psadk;
                            //}
                            //else
                            //{
                            //    samec.Add(varid + ",");
                            //}
                            color = WebUtility.HtmlDecode(color);
                            size = WebUtility.HtmlDecode(size);
                            if (price == "" && stock == "Out Of Stock")
                            {
                                potter.RemoveAt(0);
                                clb.Text = potter.Count.ToString();
                            }
                            else
                            {
                                qvcp.Rows.Add(id, sku, varid, parentage, price, variation, color, size, finish, stock, rhon);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        psadk:
                            int vd;
                        }

                    }
                }
                else if (col1.Count >= 1 && size1.Count < 1)
                {
                    parentage = "child";
                    variation = "color";
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories/child";
                    }
                    for (c1 = 0; c1 <= col1.Count - 1; c1++)
                    {
                        potter.Add("c");
                        clb.Text = potter.Count.ToString();
                        color = getsubstring("-attr=\"", "\" ", col1[c1]);

                        colore = Uri.EscapeDataString(color);
                        string qurl = "http://www.bedbathandbeyond.com/store/browse/SKU_rollup_details.jsp?productId=" + id + "&prodSize=null&prodColor=" + colore;
                        str = null;
                    jswk:
                        try
                        {
                            str = Gethtml(qurl);
                        }
                        catch
                        {

                        }
                        if (str == null || str == "")
                        {

                            goto jswk;
                        }
                        string ides = getsubstring("\"productDesc\":\"", "&nbsp;", str);
                        ides = ides.Replace("&trade;", "").Replace("&reg;", "");
                        ides = Regex.Replace(ides, @" ?\<.*?\>", string.Empty);
                        ides = Regex.Replace(ides, @"\s+", " ");
                        ides = WebUtility.HtmlDecode(ides);
                        price = getsubstring("\"isPrice\":\"", "\"}", str);
                        if (price == "")
                        {
                            price = getsubstring("\"price\":\"", "\",", str);
                        }
                        string st = getsubstring("\"inStock\":", "\"a", str);
                        if (st.Contains("true"))
                        {
                            stock = "In Stock";
                        }
                        else
                        {
                            stock = "Out Of Stock";
                        }
                        //if (samec.Contains(varid + ","))
                        //{
                        //    li3.Add("SAME child ID" + rhon.Trim());
                        //    labunshow(li3);
                        //    System.IO.File.WriteAllLines(abcd, li3);
                        //    goto psack;
                        //}
                        //else
                        //{
                        //    samec.Add(varid + ",");
                        //}
                        color = WebUtility.HtmlDecode(color);
                        size = WebUtility.HtmlDecode(size);
                        if (price == "" && stock == "Out Of Stock")
                        {
                            potter.RemoveAt(0);
                            clb.Text = potter.Count.ToString();
                        }
                        else
                        {
                            qvcp.Rows.Add(id, sku, varid, parentage, price, variation, color, size, finish, stock, rhon);
                            WriteDataToFile(qvcp, dgwq);
                        }
                    psack:
                        int vc;
                    }


                }
                else if (col1.Count < 1 && size1.Count >= 1)
                {
                    parentage = "child";
                    variation = "size";
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories/child";
                    }
                    for (s1 = 0; s1 <= size1.Count - 1; s1++)
                    {
                        potter.Add("c");
                        clb.Text = potter.Count.ToString();
                        size = getsubstring(">", "<", size1[s1]);
                        sizee = Uri.EscapeDataString(size);
                        string qurl = "http://www.bedbathandbeyond.com/store/browse/SKU_rollup_details.jsp?productId=" + id + "&prodSize=" + sizee + "&prodColor=null";
                        str = null;
                    jswk:
                        try
                        {
                            str = Gethtml(qurl);
                        }
                        catch
                        {

                        }
                        if (str == null || str == "")
                        {

                            goto jswk;
                        }

                        price = getsubstring("\"isPrice\":\"", "\"}", str);
                        if (price == "")
                        {
                            price = getsubstring("\"price\":\"", "\",", str);
                        }
                        string st = getsubstring("\"inStock\":", "\"a", str);
                        if (st.Contains("true"))
                        {
                            stock = "In Stock";
                        }
                        else
                        {
                            stock = "Out Of Stock";
                        }
                        //if (samec.Contains(varid + ","))
                        //{
                        //    li3.Add("SAME child ID" + rhon.Trim());
                        //    labunshow(li3);
                        //    System.IO.File.WriteAllLines(abcd, li3);
                        //    goto psabk;
                        //}
                        //else
                        //{
                        //    samec.Add(varid + ",");
                        //}
                        color = WebUtility.HtmlDecode(color);
                        size = WebUtility.HtmlDecode(size);
                        if (price == "" && stock == "Out Of Stock")
                        {
                            potter.RemoveAt(0);
                            clb.Text = potter.Count.ToString();
                        }
                        else
                        {
                            qvcp.Rows.Add(id, sku, varid, parentage, price, variation, color, size, finish, stock, rhon);
                            WriteDataToFile(qvcp, dgwq);
                        }
                    psabk:
                        int vc;
                    }


                }
                else if (str.IndexOf("<label>Finish</label>") > 0)
                {
                    parentage = "child";
                    variation = "Fcolor";
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories/child";
                    }
                    string fin = getsubstring("<label>Finish</label>", "</div>", str);
                    pattern = @"<a href=""#"" class=[^>]*?""(.*?)<span>";
                    finish1.AddRange(matchkar(fin, pattern));
                    if (finish1.Count >= 1)
                    {
                        foreach (string cbd in finish1)
                        {
                            potter.Add("c");
                            clb.Text = potter.Count.ToString();
                            finish = getsubstring("data-attr=\"", "\" title", cbd);
                            colore = Uri.EscapeDataString(finish);
                            string qurl = "http://www.bedbathandbeyond.com/store/browse/SKU_rollup_details.jsp?productId=" + id + "&prodSize=null&prodColor=null&prodFinish=" + colore;
                            str = null;
                        jswk:
                            try
                            {
                                str = Gethtml(qurl);
                            }
                            catch
                            {

                            }
                            if (str == null || str == "")
                            {

                                goto jswk;
                            }
                            price = getsubstring("\"isPrice\":\"", "\"}", str);
                            if (price == "")
                            {
                                price = getsubstring("\"price\":\"", "\",", str);
                            }
                            string st = getsubstring("\"inStock\":", "\"a", str);
                            if (st.Contains("true"))
                            {
                                stock = "In Stock";
                            }
                            else
                            {
                                stock = "Out Of Stock";
                            }
                            //if (samec.Contains(varid + ","))
                            //{
                            //    li3.Add("SAME child ID" + rhon.Trim());
                            //    labunshow(li3);
                            //    System.IO.File.WriteAllLines(abcd, li3);
                            //    goto psaak;
                            //}
                            //else
                            //{
                            //    samec.Add(varid + ",");
                            //}
                            finish = WebUtility.HtmlDecode(finish);
                            if (price == "" && stock == "Out Of Stock")
                            {
                                potter.RemoveAt(0);
                                clb.Text = potter.Count.ToString();
                            }
                            else
                            {
                                qvcp.Rows.Add(id, sku, varid, parentage, price, variation, color, size, finish, stock, rhon);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        psaak:
                            int vb;
                        }



                    }


                }
                else
                {
                    if (varid == "")
                    {
                        varid = id;
                    }
                    if (str.Contains("CHOOSE YOUR ITEMS BELOW"))
                    {
                        parentage = "Collection";
                    }
                    if (str.IndexOf("<h2>Accessories</h2>") > 0)
                    {
                        parentage = "Accessories";
                    }
                    if (str.IndexOf("<h3><span class=\"error\">") > 0)
                    {
                        string fg = getsubstring("<h3><span class=\"error\">", "</span>", str);
                        if (fg.Contains("Product not available"))
                        {
                            parentage = "product not available";
                        }
                    }
                    if (price == "" && stock == "Out Of Stock" && potter.Count >= 1)
                    {
                        potter.RemoveAt(0);
                        clb.Text = potter.Count.ToString();
                    }
                    else
                    {
                        qvcp.Rows.Add(id, sku, varid, parentage, price, variation, color, size, finish, stock, rhon);
                        WriteDataToFile(qvcp, dgwq);
                    }
                }
            psk:
                str = null;
                //potter.Clear();
                //clb.Text = potter.Count.ToString();
            }
        }
    }
}
