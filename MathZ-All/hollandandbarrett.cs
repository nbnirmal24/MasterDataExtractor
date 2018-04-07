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
using System.Web;
using System.IO.Compression;

namespace MathZ_All
{
    class hollandandbarrett
    {
        public static String Gethtml(string URL)
        {
  //HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://www.hollandandbarrett.com/shop/product-group/coconut-oil/");
  //  req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";

  //  req.KeepAlive = true;

  //  CookieContainer cookies = new CookieContainer();
  //  req.CookieContainer = cookies;

  //  req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
  //  req.Headers.Add("Accept-Language", "en-US,en;q=0.8");
  //  req.Headers.Add("Upgrade-Insecure-Requests", "1");
              
  //  req.Host = "www.hollandandbarrett.com";
  ////  req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
  //  //getting the request stream and posting da

  //  using (var response = (HttpWebResponse)req.GetResponse())
  //  {
  //      using (var responseStream = response.GetResponseStream())
  //      {
  //          string res;
  //          using (var decompress = new GZipStream(responseStream, CompressionMode.Decompress))
  //          using (var sr = new StreamReader(decompress))
  //          {
  //              res = sr.ReadToEnd();
  //          }
  //      }
  //  }


  //    string url = "http://example/views/ajax?name=Sports&view_name=Events&view_display_id=page_1&view_args=Sports&view_path=events%2FSports&view_base_path=events&view_dom_id=1&pager_element=0";
            string cd = "";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(URL);
      request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
      request.KeepAlive = true;
      request.Headers.Add("X-Requested-With", "XMLHttpRequest");
      request.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
      request.Headers.Add("Accept-Language", "en-US,en;q=0.8");
      request.Host = "www.hollandandbarrett.com";
      request.Method = "GET";
    //  request.Referer = "http://www.hollandandbarrett.com/shop/product-group/coconut-oil/";
      request.Accept = "application/json, text/javascript, */*; q=0.01";

     // request.CookieContainer = cookies;
      request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

      using (var response = (HttpWebResponse)request.GetResponse())
    {


        using (var responseStream = response.GetResponseStream())
        {
            using (var decompress = new GZipStream(responseStream, CompressionMode.Decompress))
            using (var sr = new StreamReader(decompress))
            {
                cd = sr.ReadToEnd();
            }
        }
        
    }
      return cd;
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
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("Title");
            qvcp.Columns.Add("Variable Name");
            qvcp.Columns.Add("ImageURL");
            qvcp.Columns.Add("Alternate ImageURL");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Stock Status");
            qvcp.Columns.Add("description");
            qvcp.Columns.Add("Features");
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
        public static string LastStr(string input,string source)
        {
            string sub = "";
            try
            {
                x = source.IndexOf(input);
                if (x >= 0)
                {
                    y = source.Length;
                    if (y < 0)
                    {

                    }
                    else
                    {
                        sub = source.Substring(x + input.Length, y - x - input.Length);
                    }
                }
            }
            catch
            {

            }
            return sub;
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
                if (str.IndexOf("\"records\":[{") > 0)
                {
                    pattern = @"""records"":[[^>]*?{(.*?)}";
                    MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in matches)
                    {
                        string cd = match.Groups[1].Value.Replace("\\/","/");
                        string bd = getsubstring("\"recordState\":\"", "\",", cd);
                        if (!bd.Contains("http"))
                        {
                            bd = "http://www.hollandandbarrett.com" + bd;
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
                    int cxl = 2;
                    string category = LastStr("shop", thor).Replace("/", "%2F");
                    while (str.IndexOf("\"records\":[{") > 0)
                    {
                        str = "";
                    bts:
                        try
                        {
                            str = Gethtml(thor + "?page=" + cxl + "&pageHa=1&es=true&cat=" + category + "&vm=grid&format=json&single=true&pageType=CATEGORY");
                        }
                        catch
                        {
                        }
                        if (str == null || str == "")
                        {
                            goto bts;
                        }
                        pattern = @"""records"":[[^>]*?{(.*?)}";
                        MatchCollection matches1 = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match match in matches1)
                        {
                            string cd = match.Groups[1].Value.Replace("\\/", "/");
                            string bd = getsubstring("\"recordState\":\"", "\",", cd);
                            if (!bd.Contains("http"))
                            {
                                bd = "http://www.hollandandbarrett.com" + bd;
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
                        cxl++;
                    }
                }
                else if (str.IndexOf("<div class=\"middle\">") > 0)
                {
                    string raw = getsubstring("<div class=\"middle\">", "</ul>", str);
                    if (raw != "")
                    { 
                    pattern=@""" href=[^>]*?""(.*?)"">";
                    List<string> temp = new List<string>();
                    temp.AddRange(matchkar(raw, pattern));
                    foreach (string abcd in temp)
                    {
                        string rd = "";
                        if (!abcd.Contains("http"))
                        {
                            rd = "http://www.hollandandbarrett.com" + abcd;
                        }
                        iron.Add(rd);
                    }
                    }
                }
                else if (str.IndexOf("<div class=\"nbtopnav\">") > 0)
                {
                    string raw = getsubstring("<div class=\"nbtopnav\">", "</ul>", str);
                    if (raw != "")
                    {
                        pattern = @""" href=[^>]*?""(.*?)"">";
                        List<string> temp = new List<string>();
                        temp.AddRange(matchkar(raw, pattern));
                        foreach (string abcd in temp)
                        {
                            string rd = "";
                            if (!abcd.Contains("http"))
                            {
                                rd = "http://www.hollandandbarrett.com" + abcd;
                            }
                            iron.Add(rd);
                        }
                    }
                
                }
                else if (str.IndexOf("<div id=\"navcontainer\">") > 0)
                {
                    string raw = getsubstring("<div id=\"navcontainer\">", "</ul>", str);
                    if (raw != "")
                    {
                        pattern = @"<a href=[^>]*?""(.*?)"">";
                        List<string> temp = new List<string>();
                        temp.AddRange(matchkar(raw, pattern));
                        foreach (string abcd in temp)
                        {
                            string rd = "";
                            if (!abcd.Contains("http"))
                            {
                                rd = "http://www.hollandandbarrett.com" + abcd;
                            }
                            iron.Add(rd);
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
                    prdid = getsubstring("productId: \"", "}", str).Replace("\"","");
                    if (string.IsNullOrEmpty(prdid)) {
                        prdid = getsubstring("\"id\" : \"", "\",", str);
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

                List<string> outs = new List<string>();
                string sku = "";
                string color = "";
                try
                {
                    sku = getsubstring("SKU:", "<", str).Replace("&nbsp;","");
                    if (string.IsNullOrEmpty(sku)) {
                        sku = getsubstring("\"sku_code\" : \"", "\",", str);
                    }
                    sku = Regex.Replace(sku, @" ?\<.*?\>", string.Empty);
                    sku = Regex.Replace(sku, @"\s+", " ");
                }
                catch { }
                string name = "";
                name=getsubstring("<h1 class=\"page-title\">","</span>",str);
                if (string.IsNullOrEmpty(name)) {
                    name = getsubstring("\"name\": \"", "}", str).Replace("\"", "");
                }
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                string price = "";
                try
                {
                    price = getsubstring("<div class=\"prod-size-price\">", "</div>", str).Replace("&pound;", "£").Replace("Our price:", "");
                   if(string.IsNullOrEmpty(price)){
                    price=getsubstring("<span class=\"sku-price\">","</span>",str);
                    }
                    price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                    price = Regex.Replace(price, @"\s+", " ");
                }
                catch { }
                 string stockstatus = "";
                stockstatus=getsubstring("</span> <div class=\"user-msg alert-msg \">","</div>",str);
                stockstatus = Regex.Replace(stockstatus, @" ?\<.*?\>", string.Empty);
                    stockstatus = Regex.Replace(stockstatus, @"\s+", " ");
                string rewards="";
                rewards=getsubstring("<span class=\"prod-rfl-pts\">","rewards",str);
                rewards = Regex.Replace(rewards, @" ?\<.*?\>", string.Empty);
                    rewards = Regex.Replace(rewards, @"\s+", " ");
                string offers="";
                offers=getsubstring("<ul class=\"prod-offers\">","</ul>",str);
                 offers = Regex.Replace(offers, @" ?\<.*?\>", string.Empty);
                    offers = Regex.Replace(offers, @"\s+", " ");
                string otherDetails="";
                otherDetails=getsubstring("</div> <div class=\"label-txt-cell-row\"> <span class=\"prod-meta\">","<br>",str).Replace("&nbsp;","");
                 otherDetails = Regex.Replace(otherDetails, @" ?\<.*?\>", string.Empty);
                    otherDetails = Regex.Replace(otherDetails, @"\s+", " ");
                string category="";
                category=getsubstring("<div class=\"crumb\">","</ul>",str).Replace("</a>","/");
                  category = Regex.Replace(category, @" ?\<.*?\>", string.Empty);
                    category = Regex.Replace(category, @"\s+", " ");
                  string img = "";
                List<string> imga = new List<string>();
                pattern = @"data-img-zoom=[^>]*?'(.*?)'>";
                imga.AddRange(matchkar(str, pattern));
                 img = string.Join("|", imga.ToArray());
             string description="";
                description=getsubstring("<div id=\"skuDescription\">","</div> </div>",str).Replace("<p>","|||").Replace("<ul><li>",":-").Replace("<li>","|");
                 description = Regex.Replace(description, @" ?\<.*?\>", string.Empty);
                    description = Regex.Replace(description, @"\s+", " ");
                string directions="";
                directions=getsubstring("Directions:","</p>",str);
                 directions = Regex.Replace(directions, @" ?\<.*?\>", string.Empty);
                    directions = Regex.Replace(directions, @"\s+", " ");
                string ingredients="";
                ingredients=getsubstring("Ingredients:","</p>",str);
                 ingredients = Regex.Replace(ingredients, @" ?\<.*?\>", string.Empty);
                    ingredients = Regex.Replace(ingredients, @"\s+", " ");
                string freeFrom="";
                freeFrom=getsubstring("Free from:","</p>",str);
                 freeFrom = Regex.Replace(freeFrom, @" ?\<.*?\>", string.Empty);
                    freeFrom = Regex.Replace(freeFrom, @"\s+", " ");
                string advisory="";
                advisory=getsubstring("Advisory information:","</p>",str);
                 advisory = Regex.Replace(advisory, @" ?\<.*?\>", string.Empty);
                    advisory = Regex.Replace(advisory, @"\s+", " ");
                string remember="";
                remember=getsubstring("Remember to:","</p>",str);
                 remember = Regex.Replace(remember, @" ?\<.*?\>", string.Empty);
                    remember = Regex.Replace(remember, @"\s+", " ");
                string ratings="";
                ratings=getsubstring("ratingValue\" itemprop=\"ratingValue\">","<",str);
                 ratings = Regex.Replace(ratings, @" ?\<.*?\>", string.Empty);
                    ratings = Regex.Replace(ratings, @"\s+", " ");
                string review="";
                review=getsubstring("reviewCount\">","<",str);
                 review = Regex.Replace(review, @" ?\<.*?\>", string.Empty);
                    review = Regex.Replace(review, @"\s+", " ");
               string size="";
                size=getsubstring("\"size\" : \"","\",",str);
                 size = Regex.Replace(size, @" ?\<.*?\>", string.Empty);
                    size = Regex.Replace(size, @"\s+", " ");
        if(str.IndexOf("Select Size:")>0){
            List<string>all=new List<string>();
     pattern=@"data-size-id=[^>]*?""(.*?)"" value";
             MatchCollection matches = Regex.Matches(str,pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                if(sku!=match.Groups[1].Value)
                {
                string rawsize="";
                    rawsize=getsubstring("data-sku-id=\""+match.Groups[1].Value+"\" data-product-id","<div class=\"form-item-status",str);
                    rewards=getsubstring("prod-rfl-pts\">","reward",rawsize).Replace("&nbsp;","");
                     rewards = Regex.Replace(rewards, @" ?\<.*?\>", string.Empty);
                    rewards = Regex.Replace(rewards, @"\s+", " ");
                    otherDetails=getsubstring("prod-meta\">","<",rawsize).Replace("&nbsp;"," ");
                    otherDetails = Regex.Replace(otherDetails, @" ?\<.*?\>", string.Empty);
                    otherDetails = Regex.Replace(otherDetails, @"\s+", " ");
                    string displayName="";
                    displayName=getsubstring("data-display-name=\"","\"/>",str);
                    if(!string.IsNullOrEmpty(displayName)){
                    displayName="&displayName="+displayName;
                    }
                    //string dataequv="";
                    //dataequv=getsubstring("checked data-equiv=\"","\" class",str);
                    //if(!string.IsNullOrEmpty(dataequv)){
                    //dataequv=
                    //}
                    string varsource="";
                    string varUrl = "http://www.hollandandbarrett.com/browse/json/selectSkuForPDP.jsp?equiv=500&skuId=" + match.Groups[1].Value + "&productId=" + prdid.Replace(" ","") + displayName;
                    jskt:
                try
                {
                    varsource = Gethtml(varUrl);
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
                if (varsource == null || varsource == "")
                {

                    goto jskt;
                }
                if (human.Count >= 1)
                {
                    human.Clear();
                }
                varsource = varsource.Replace("\\\"", "\"").Replace("\\/", "/");
                description = getsubstring("\"description\":\"", "</p>", varsource);
                }
               
            }

        }
            psk:
                str = null;
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
       
    }
}
