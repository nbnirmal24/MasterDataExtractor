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
    class diapers
    {
        static CookieContainer cookieJar = new CookieContainer();
        public static String Gethtml(string URL)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["User-Agent"] =
                "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                "(compatible; MSIE 6.0; Windows NT 5.1; " +
                ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

                // Download data.
                string arr = client.DownloadString(URL);

                // Write values.
                // Console.WriteLine("--- WebClient result ---");
                //   Console.WriteLine(arr.Length);
            }
            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
            request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
            request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request1.Proxy = null;
            request1.Timeout = 10000;
            //  ServicePointManager.Expect100Continue = false;
            //  ServicePointManager.DefaultConnectionLimit = 3;
            //   ServicePointManager.MaxServicePointIdleTime = 2000;
            //  request1.AllowAutoRedirect = true;
          request1.CookieContainer = cookieJar;
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            StreamReader sr1 = new StreamReader(response1.GetResponseStream());
            cookieJar.Add(response1.Cookies);
            string html = sr1.ReadToEnd();
            sr1.Close();
            response1.Close();

            return html;
        }
        public static String Gethtml1(string URL)
        {
            string html = "";
            try
            {
                HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
                request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
                request1.UserAgent = "Foo";
                request1.Accept = "*/*";
                request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
                request1.Proxy = null;
                //  ServicePointManager.Expect100Continue = false;
                //   ServicePointManager.DefaultConnectionLimit = 5;
                //   ServicePointManager.MaxServicePointIdleTime = 2000;
                //    request1.AllowAutoRedirect = true;
                HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
                StreamReader sr1 = new StreamReader(response1.GetResponseStream());
                html = sr1.ReadToEnd();
                sr1.Close();
                response1.Close();
            }
            catch
            {

                html = null;
            }

            return html;
        }
        public static List<string> passpro(List<string> produt)
        {
            produt = ProductURL;
            return produt;
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
        static List<string> same = new List<string>();
        static List<string> nalu = new List<string>();
        static List<string> checkid = new List<string>();
        static string str = null;
        static string str1 = null;
        //   string sub = "";
        static DataTable qvcp = new DataTable();
        static string sub1 = "";
        static string pattern = "";
        static string dgwq = "";
        static string abcd = "", abcd1 = "";
        static int x, y, c, v, cg;
        public static void datetime()
        {

            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("Parentage");
            qvcp.Columns.Add("Product Name");
            qvcp.Columns.Add("Modified_Product_Name");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Mainimage");
            qvcp.Columns.Add("Var_ID");
            qvcp.Columns.Add("Rating");
            qvcp.Columns.Add("Reviews");
            qvcp.Columns.Add("Child_ASIN");
            qvcp.Columns.Add("Variation_Type");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("Count");
            qvcp.Columns.Add("Order_Count");
            qvcp.Columns.Add("Stock_Status");
            qvcp.Columns.Add("Description");
            qvcp.Columns.Add("Features");
            qvcp.Columns.Add("ProductURL");
            dgwq = Application.StartupPath;
            string filename = DateTime.Now.ToString("ddMMyyyyThhmmss");
            dgwq = dgwq + "\\" + "output data" + "\\" + "DATA" + filename + ".txt";
        }
        public static void datetime1()
        {

            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("Parentage");
            qvcp.Columns.Add("Product Name");
            qvcp.Columns.Add("Modified_Product_Name");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Var_ID");
            qvcp.Columns.Add("Child_ASIN");
            qvcp.Columns.Add("Variation_Type");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("Count");
            qvcp.Columns.Add("Order_Count");
            qvcp.Columns.Add("Stock_Status");
            qvcp.Columns.Add("ProductURL");
            dgwq = Application.StartupPath;
            string filename = DateTime.Now.ToString("ddMMyyyyThhmmss");
            dgwq = dgwq + "\\" + "output data" + "\\" + "DATA" + filename + ".txt";
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
        public static List<string> matchkar(string jabe, string aabe, string khabe)
        {
            List<string> nirmal = new List<string>();
            MatchCollection matches = Regex.Matches(jabe, aabe, RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                string ad = khabe + match.Groups[1].Value;
                ad = Regex.Replace(ad, @"\s+", " ");
                nirmal.Add(ad);
            }
            return nirmal;
        }
        public static List<string> matchkar1(string jabe, string aabe, string khabe)
        {
            List<string> nirmal = new List<string>();
            MatchCollection matches = Regex.Matches(jabe, aabe, RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                string ad = khabe + match.Groups[1].Value;
                ad = Regex.Replace(ad, @"\s+", " ");
                if (same.Contains(ad))
                {
                }
                else
                {
                    same.Add(ad);
                    nirmal.Add(ad);
                }
            }
            return nirmal;
        }

        public static List<string> categoryNew(List<string> hulk)
        {
            List<string> iron = new List<string>();
            foreach (string thorq in hulk)
            {
                string thor = "";
            jsk:
                try
                {
                    thor = thorq;
                    thor = thor.Replace("http://www.diapers.comhttp://www.diapers.com", "http://www.diapers.com");
                    str = Gethtml(thor);
                }
                catch
                {
                    human.Add(thor.Trim());
                    if (human.Count > 500)
                    {
                        human.Clear();
                        li3.Add(thor.Trim());
                      //  labunshow(li3);
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
                if (str.IndexOf("<div class=\"product-box\">") > 0)
                {
                    pattern = @"<div class=""product-box""[^>]*?>(.*?)"" title=";
                    MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    foreach (Match match in matches)
                    {
                        string ad = match.Groups[1].Value;
                        string bd = getsubstring("<a href=\"", "\" class", ad);
                        if (bd != "")
                        {
                            if (!bd.Contains("http"))
                            {
                                bd = "http://www.wag.com" + bd;
                            }
                        }
                        if (!animal.Contains(bd))
                        {
                            animal.Add(bd);
                            ProductURL.Add(bd);
                        }
                       // lab3show(ProductURL);
                    }
                    while (str.IndexOf("class=\"next\">") > 0)
                    {
                        c = str.IndexOf("lass=\"next\">");
                        v = c - 120;
                        string next = str.Substring(v, c - v);
                        if (next != "")
                        {
                            next = getsubstring("<a href=\"", "\"  c", next);
                        }
                        if (!next.Contains("http"))
                        {
                            if (next != "")
                            {
                                next = "http://www.wag.com" + next;
                            }
                        }
                        str = null;
                    jskt:
                        try
                        {
                            str = Gethtml(next);
                        }
                        catch
                        {
                        }
                        if (str == null || str == "")
                        {
                            goto jskt;
                        }
                        pattern = @"<div class=""product-box""[^>]*?>(.*?)"" title=";
                        MatchCollection matches1 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        foreach (Match match in matches1)
                        {
                            string ad = match.Groups[1].Value;
                            string bd = getsubstring("<a href=\"", "\" class", ad);
                            if (bd != "")
                            {
                                if (!bd.Contains("http"))
                                {
                                    bd = "http://www.wag.com" + bd;
                                }
                            }
                            if (!animal.Contains(bd))
                            {
                                animal.Add(bd);
                                ProductURL.Add(bd);
                            }
                           // lab3show(ProductURL);
                        }
                    }

                }
                else if (str.IndexOf("<div class=\"child-browse-node-header") > 0)
                {
                    pattern = @"<div class=""child-browse-node-header""><a href=[^>]*?""(.*?)"" title";
                    MatchCollection matches1 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    foreach (Match match in matches1)
                    {
                        string bd = match.Groups[1].Value;
                        if (bd != "")
                        {
                            if (!bd.Contains("http"))
                            {
                                bd = "http://www.wag.com" + bd;
                            }
                        }


                        if (!nalu.Contains(bd))
                        {
                            nalu.Add(bd);
                            iron.Add(bd);
                        }
                    }
                }
            psk:
                str = null;
            }
            return iron;
        }
        public static void product(List<string> yogesh)
        {
            foreach (string rhonq in yogesh)
            {
                string rhon = "";
            jsk:
                try
                {
                    rhon = rhonq;
                    rhon = rhon.Replace("http://www.diapers.comhttp://www.diapers.com", "http://www.diapers.com");
                    str = Gethtml(rhon);
                }
                catch
                {
                    human.Add(rhon.Trim());
                    if (human.Count > 50)
                    {
                        human.Clear();
                        li3.Add(rhon.Trim());
                      //  labunshow(li3);
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
                id = getsubstring("ProductId:\"", "\",", str);
                if (id == "")
                {
                    id = getsubstring("groupingASIN=", ",", str);
                }
                if (id == "")
                {
                    li3.Add("NO_ID" + rhon.Trim());
                  //  labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                if (checkid.Contains(id))
                {
                    li3.Add("SAME_ID" + rhon.Trim());
                   // labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                else
                {
                    checkid.Add(id);
                }
                nalu.Add("x");
               // lab6show(nalu);
                string name = "";
                string Mname = "";
                string count = "";
                name = getsubstring("<div class=\"productTitle\">", "</div>", str);
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                name = WebUtility.HtmlDecode(name);
                string rating = "";
                string review = "";
                rating = getsubstring("ratingValue\" content=\"", "\" />", str);
                rating = Regex.Replace(rating, @" ?\<.*?\>", string.Empty);
                rating = Regex.Replace(rating, @"\s+", " ");
                review = getsubstring("blueText linkToReviewSnapshot\">", "</span>", str).Replace("reviews", "");
                review = Regex.Replace(review, @" ?\<.*?\>", string.Empty);
                review = Regex.Replace(review, @"\s+", " ");
                string price = "";
                price = getsubstring("<span class='singlePrice'>", "</span>", str);
                price = Regex.Replace(price, @"\s+", " ");
                string category = "";
                category = getsubstring("<div class=\"positionNav \">", " </div>", str).Replace("&gt;", ">");
                if (category == "")
                {
                    category = getsubstring("\"ProductCategoryPath\" : \"", "\",", str);
                }
                category = Regex.Replace(category, @" ?\<.*?\>", string.Empty);
                category = Regex.Replace(category, @"\s+", " ");
                string des = "";
                string features = "";
                if (str.IndexOf("<b>Features</b>") > 0)
                {
                    des = getsubstring("<div class=\"descriptContentBox clearfix\">", "<b>Features</b>", str);
                    string cd = getsubstring("<b>Features</b>", "</ul>", str);
                    pattern = @"<li[^>]*?>(.*?)</li>";
                    List<string> fes = new List<string>();
                    fes.AddRange(matchkar(cd, pattern, ""));
                    if (fes.Count < 1)
                    {
                        pattern = @"<li[^>]*?>(.*?)</Il>";
                        fes.AddRange(matchkar(cd, pattern, ""));
                    }
                    string imj = "|";
                    features = string.Join(imj, fes.ToArray());
                }
                else if (str.IndexOf("<strong>Features") > 0)
                {
                    des = getsubstring("<div class=\"descriptContentBox clearfix\">", "<strong>Features", str);
                    string cd = getsubstring("<strong>Features", "</ul>", str);
                    pattern = @"<li[^>]*?>(.*?)</li>";
                    List<string> fes = new List<string>();
                    fes.AddRange(matchkar(cd, pattern, ""));
                    if (fes.Count < 1)
                    {
                        pattern = @"<li[^>]*?>(.*?)</Il>";
                        fes.AddRange(matchkar(cd, pattern, ""));
                    }
                    string imj = "|";
                    features = string.Join(imj, fes.ToArray());

                }
                else
                {
                    des = getsubstring("<div class=\"descriptContentBox clearfix\">", "</dd>", str);
                }
                des = Regex.Replace(des, @" ?\<.*?\>", string.Empty);
                des = Regex.Replace(des, @"\s+", " ");
                string mainimg = "";
                string varid = "";
                string color = "";
                string size = "";
                string ordercount = "";
                string stock = "";
                string childasin = "";
                string variation = "";
                mainimg = "http:" + getsubstring("rel=\"zoom-id:pdp\" href=\"", "\" style", str);
                if (mainimg == "http:")
                {
                    mainimg = "http:" + getsubstring("cSReftag\" rev=\"", "g\"", str) + "g";
                }
                if (mainimg == "http:g")
                {
                    string temp = getsubstring("<span class=\"vMiddle\">", "</span>", str);
                    mainimg = "http:" + getsubstring("<img src=\"", "g\"", temp).Replace("_1t", "_1z") + "g";
                }
                if (mainimg == "http:g")
                {
                    string temp = getsubstring("<span class=\"itemImageDiv vMiddle\">", "</span>", str);
                    mainimg = "http:" + getsubstring("<img src=\"", "g\"", temp).Replace("_1t", "_1z") + "g";
                }
                string stock12 = getsubstring("IsOutOfStock = \"", "\" ", str);
                if (stock12 == "N")
                {
                    stock = "In_Stock";
                }
                else if (stock12 == "Y")
                {
                    stock = "Out_Of_Stock";
                }
                if (str.IndexOf("Discontinued by vendor") > 0)
                {
                    stock = "Discontinued by vendor";
                }
                string parentage = "";
                parentage = "Individual";
                string sku = "";
                sku = getsubstring("NeedValidateSkuHidden:\"", ",\",", str);
                if (sku.Contains("DropShipSku"))
                {
                    sku = getsubstring("DropShipSkuHidden:\"", ",\",", str);
                }
                if (sku.Contains("ShipFreightSku"))
                {
                    sku = getsubstring("ShipFreightSkuHidden:\"", ",\",", str);
                }
                string[] skul = Regex.Split(sku, ",");
                if (skul.Count() >= 1)
                {

                    foreach (string jack in skul)
                    {
                        if (jack == "")
                        {

                            qvcp.Rows.Add(id, parentage, name, Mname, category, price, mainimg, varid, rating, review, childasin, variation, color, size, count, ordercount, stock, des, features, rhon);
                            //  lab6show(qvcp);
                            WriteDataToFile(qvcp, dgwq);
                        }
                        else if (str.IndexOf("id=\"" + jack.Replace("-", "_") + "SizeButton") > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring("id=\"" + jack.Replace("-", "_") + "SizeButton", "eCouponInfo" + jack.Replace("-", "_"), str);
                            id = getsubstring("productId=\"", "\" p", raw);
                            checkid.Add(id);
                            color = getsubstring("PrimaryAttributeValue=\"", "\" value", raw);
                            if (color == "")
                            {
                                color = getsubstring("value=\"", "\" canPers", raw);
                            }
                            color = WebUtility.HtmlDecode(color);
                            size = getsubstring("colorValue=\"", "\" c", raw);
                            if (size == "")
                            {
                                size = getsubstring("value=\"", "\" item", raw);
                            }
                            size = WebUtility.HtmlDecode(size);
                            name = getsubstring("skuName=\"", "\" after", raw);
                            name = WebUtility.HtmlDecode(name);
                            price = getsubstring("retailPrice=\"", "\" price", raw);
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" l", raw);
                            }
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" h", raw);

                            }
                            childasin = getsubstring("asin=\"", "\" sku", raw);
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");
                            mainimg = "http://c2.q-assets.com/images/products/p/" + alpha + "/" + jack + "_1z.jpg";
                            ordercount = getsubstring("<span class=\"middle\">", "-<", raw);
                            ordercount = Regex.Replace(ordercount, @"\s+", " ");
                            string stock1 = getsubstring("IsOutOfStock = \"", "\" ", raw);
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            string auto = description(jack, id);
                            string[] desfi = Regex.Split(auto, "------------");
                            des = desfi[0];
                            features = desfi[1];
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, category, price, mainimg, varid, rating, review, childasin, variation, color, size, count, ordercount, stock, des, features, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }

                        }
                        else if (str.IndexOf("id=\"" + jack.Replace("-", "_") + "ColorButton") > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring("id=\"" + jack.Replace("-", "_") + "ColorButton", "eCouponInfo" + jack.Replace("-", "_"), str);
                            id = getsubstring("productId=\"", "\" p", raw);
                            checkid.Add(id);
                            color = getsubstring("PrimaryAttributeValue=\"", "\" value", raw);
                            if (color == "")
                            {
                                color = getsubstring("value=\"", "\" canPers", raw);
                            }
                            color = WebUtility.HtmlDecode(color);
                            size = getsubstring("colorValue=\"", "\" c", raw);
                            if (size == "")
                            {
                                size = getsubstring("value=\"", "\" item", raw);
                            }
                            size = WebUtility.HtmlDecode(size);
                            name = getsubstring("skuName=\"", "\" after", raw);
                            name = WebUtility.HtmlDecode(name);
                            price = getsubstring("retailPrice=\"", "\" price", raw);
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" l", raw);
                            }
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" h", raw);

                            }
                            childasin = getsubstring("asin=\"", "\" sku", raw);
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");
                            mainimg = "http://c2.q-assets.com/images/products/p/" + alpha + "/" + jack + "_1z.jpg";
                            ordercount = getsubstring("<span class=\"middle\">", "-<", raw);
                            ordercount = Regex.Replace(ordercount, @"\s+", " ");
                            string stock1 = getsubstring("IsOutOfStock = \"", "\" ", raw);
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            string auto = description(jack, id);
                            string[] desfi = Regex.Split(auto, "------------");
                            des = desfi[0];
                            features = desfi[1];
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, category, price, mainimg, varid, rating, review, childasin, variation, color, size, count, ordercount, stock, des, features, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        }
                        else if (str.IndexOf("id=\"" + jack.Replace("-", "_")) > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring("id=\"" + jack.Replace("-", "_"), "</li>", str);
                            id = getsubstring("productId=\"", "\" p", raw);
                            checkid.Add(id);
                            color = getsubstring("PrimaryAttributeValue=\"", "\" value", raw);
                            size = getsubstring("value=\"", "\" item", raw);
                            name = getsubstring("skuName=\"", "\" after", raw);
                            name = WebUtility.HtmlDecode(name);
                            price = getsubstring("retailPrice=\"", "\" price", raw);
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" h", raw);

                            }
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" l", raw);
                            }
                            childasin = getsubstring("asin=\"", "\" sku", raw);
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");
                            mainimg = "http://c2.q-assets.com/images/products/p/" + alpha + "/" + jack + "_1z.jpg";
                            ordercount = getsubstring("<span class=\"middle\">", "-<", raw);
                            ordercount = Regex.Replace(ordercount, @"\s+", " ");
                            string stock1 = getsubstring("IsOutOfStock = \"", "\" ", raw);
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            string auto = description(jack, id);
                            string[] desfi = Regex.Split(auto, "------------");
                            des = desfi[0];
                            features = desfi[1];
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, category, price, mainimg, varid, rating, review, childasin, variation, color, size, count, ordercount, stock, des, features, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        }
                        else if (str.IndexOf("id=\"skuHidden" + jack.Replace("-", "_")) > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring("id=\"skuHidden" + jack.Replace("-", "_") + "\"", "/>", str);
                            name = getsubstring("skuName=\"", "\" after", raw);
                            name = WebUtility.HtmlDecode(name);
                            int cxz = str.IndexOf("id=\"skuHidden" + jack.Replace("-", "_"));
                            int zx = cxz - 2050;
                            string rowdy = str.Substring(zx, cxz - zx);
                            rowdy = rowdy.Replace("<li class=\"itemSize\">SIZE</li>", "").Replace("<li class=\"unitPriceColumn\">UNIT PRICE</li>", "").Replace("<li class=\"itemSize\">COUNT</li>", "");
                            color = getsubstring("Color</span>", "<div", raw).Replace("<td>", "(").Replace("</td>", ")");
                            size = getsubstring("Size</span>", "<div", rowdy).Replace("<td>", "--");
                            if (size == "")
                            {
                                if (str.IndexOf("Size</th>") > 0)
                                {
                                    size = getsubstring("<span>", "</span>", rowdy);
                                }
                                if (size == "" && str.IndexOf("SIZE</li>") > 0)
                                {
                                    size = getsubstring("<li class=\"itemSize\">", "</li>", rowdy);
                                }
                                if (str.IndexOf("Color</th>") > 0 || str.IndexOf("Colors</th>") > 0)
                                {
                                    color = getsubstring("<td>", "</td>", rowdy);
                                    if (color.Contains("<span>") && color.Contains("</span>"))
                                    {
                                        color = "";
                                    }
                                    if (color == "")
                                    {
                                        color = getsubstring("<td class=\"elseDescription\">", "</td>", rowdy);
                                    }
                                }
                                if (color == "" && str.IndexOf("COLOR</li>") > 0)
                                {
                                    color = getsubstring("<li class=\"itemColor\">", "</li>", rowdy);
                                }
                            }
                            if (color == "")
                            {
                                color = getsubstring("primaryAttr=\"", "\"   i", rowdy);
                            }
                            if (str.IndexOf("Character</th>") > 0)
                            {
                                color = getsubstring("<td class=\"elseDescription\">", "</td>", rowdy);
                            }
                            size = Regex.Replace(size, @" ?\<.*?\>", string.Empty);
                            size = Regex.Replace(size, @"\s+", " ");
                            size = WebUtility.HtmlDecode(size);

                            color = Regex.Replace(color, @" ?\<.*?\>", string.Empty);
                            color = Regex.Replace(color, @"\s+", " ");
                            color = WebUtility.HtmlDecode(color);
                            price = getsubstring("retailPrice=\"", "\" price", raw);
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" l", raw);

                            }
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" h", raw);

                            }
                            if (str.IndexOf("Price</th>") > 0)
                            {
                                string px = getsubstring("unitPrice\">", "</td>", rowdy);
                                px = Regex.Replace(px, @" ?\<.*?\>", string.Empty);
                                px = Regex.Replace(px, @"\s+", " ");
                                if (px != "")
                                {
                                    price = price + "(" + px + ")";
                                }
                            }
                            if (str.IndexOf("UNIT PRICE</li>") > 0)
                            {
                                string px = getsubstring("<li class=\"unitPriceColumn\">", "</li>", rowdy);
                                px = Regex.Replace(px, @" ?\<.*?\>", string.Empty);
                                px = Regex.Replace(px, @"\s+", " ");
                                if (px != "")
                                {
                                    price = price + "(" + px + ")";
                                }
                            }
                            if (str.IndexOf("Count</th>") > 0)
                            {
                                count = getsubstring("<td class=\"elseDescription\">", "</td>", rowdy);

                            }
                            if (str.IndexOf("COUNT</li>") > 0)
                            {

                                count = getsubstring("<li class=\"itemSize\">", "</li>", rowdy);
                            }
                            if (str.IndexOf("Content Weight</th>") > 0)
                            {
                                count = getsubstring("<td class=\"elseDescription\">", "</td>", rowdy);
                            }
                            count = Regex.Replace(count, @" ?\<.*?\>", string.Empty);
                            count = Regex.Replace(count, @"\s+", " ");
                            childasin = getsubstring("asin=\"", "\" sku", raw);
                            if (childasin.Contains("hasEcoupon"))
                            {
                                childasin = "CHECK_MANUALLY";
                            }
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");
                            mainimg = "http://c2.q-assets.com/images/products/p/" + alpha + "/" + jack + "_1z.jpg";
                            id = getsubstring("productId=\"", "\" p", raw);
                            checkid.Add(id);
                            string stock1 = getsubstring("IsOutOfStock = \"", "\" ", raw);
                            if (stock1 == "")
                            {
                                stock1 = getsubstring("IsOutOfStock = \"", "\"/>", str);
                            }
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            int st = str.IndexOf("id=\"skuHidden" + jack.Replace("-", "_"));
                            int xt = st - 200;
                            int ct = str.IndexOf("<input", xt);
                            string xst = str.Substring(xt, ct - xt);
                            if (xst != "")
                            {
                                string hummr = getsubstring("<span class=\"outOfStock\">", "</span>", xst);
                                if (hummr != "")
                                {
                                    stock = hummr;
                                }
                            }
                            stock = Regex.Replace(stock, @" ?\<.*?\>", string.Empty);
                            stock = Regex.Replace(stock, @"\s+", " ");
                            string auto = description(jack, id);
                            string[] desfi = Regex.Split(auto, "------------");
                            des = desfi[0];
                            features = desfi[1];
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (variation == "")
                            {
                                parentage = "Box_Child";
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, category, price, mainimg, varid, rating, review, childasin, variation, color, size, count, ordercount, stock, des, features, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        }
                        else if (str.IndexOf(",\"Sku\":\"" + jack + "\",") > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring(",\"Sku\":\"" + jack + "\",", "}", str);
                            name = getsubstring("\"SkuName\":\"", "\",", raw);
                            name = WebUtility.HtmlDecode(name);
                            Mname = getsubstring("\"Description\":\"", "\",", raw);
                            Mname = WebUtility.HtmlDecode(Mname);
                            price = getsubstring("\"DisplayPrice\":\"", "\",", raw);
                            string unit = getsubstring("\"UnitPrice\":", ",\"", raw);
                            if (price != "" && unit != "")
                            {
                                price = price + "($" + unit + ")";
                            }
                            childasin = getsubstring("\"Asin\":\"", "\",", raw);
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");
                            mainimg = "http://c2.q-assets.com/images/products/p/" + alpha + "/" + jack + "_1z.jpg";
                            string limit = getsubstring("\"LimitedQty\":", ",\"", raw);
                            if (limit != "0")
                            {
                                ordercount = limit;
                            }
                            string stock1 = getsubstring("\"IsOutOfStock\":\"", "\",", raw);
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            string stmsg = getsubstring("\"OutOfStockMessage\":", ",\"", raw);
                            if (stmsg != "null")
                            {
                                stock = stmsg;
                                stock = Regex.Replace(stock, @" ?\<.*?\>", string.Empty);
                                stock = WebUtility.HtmlDecode(stock);
                                stock = Regex.Replace(stock, @"\s+", " ");
                            }
                            string sc = getsubstring("\"PrimaryAttributeValue\":\"", "\",", raw);
                            if (sc != "")
                            {
                                string kon = getsubstring("id=\"" + sc, "</td>", str).Replace("<i >", "(").Replace("</i>", ")").Replace("<i  DiaperPackName=\"Y\" >", "(").Replace("<i  DiaperPackName=\"N\" >", "(").Replace("\" class=\"attributeOption\">", "");
                                c = str.IndexOf("id=\"" + sc);
                                v = str.IndexOf("attributeTitle\">");
                                string kis = "";
                                try
                                {
                                    kis = str.Substring(v, c - v);
                                }
                                catch { }
                                string check = getsubstring("attributeName=\"", "\">", kis);
                                kon = Regex.Replace(kon, @" ?\<.*?\>", string.Empty);
                                kon = WebUtility.HtmlDecode(kon);
                                kon = Regex.Replace(kon, @"\s+", " ");
                                if (check == "Count" || check == "Package Quantity")
                                {
                                    count = kon;
                                }
                                else if (check == "Size")
                                {
                                    size = kon;
                                }
                                else if (check == "Color" || check == "Scent")
                                {
                                    color = kon;
                                }
                                else
                                {
                                    color = "Check Manually";
                                }

                            }
                            string cc = getsubstring("SecondAttributeValue\":\"", "\",", raw);
                            if (cc != "")
                            {
                                string kon = getsubstring("id=\"" + cc, "</td>", str).Replace("<i >", "(").Replace("</i>", ")").Replace("<i  DiaperPackName=\"Y\" >", "(").Replace("<i  DiaperPackName=\"N\" >", "(").Replace("\" class=\"attributeOption\">", "");
                                c = str.IndexOf("id=\"" + cc);
                                v = str.LastIndexOf("attributeTitle\">");
                                string third = getsubstring("\"ThirdAttributeValue\":\"", "\",", raw);
                                if (third != "")
                                {
                                    count = "THREE VALUES PRESENT";
                                }
                                else
                                {
                                    string kis = "";
                                    try
                                    {
                                        kis = str.Substring(v, c - v);
                                    }
                                    catch { }
                                    string check = getsubstring("attributeName=\"", "\">", kis);
                                    kon = Regex.Replace(kon, @" ?\<.*?\>", string.Empty);
                                    kon = WebUtility.HtmlDecode(kon);
                                    kon = Regex.Replace(kon, @"\s+", " ");
                                    if (check == "Count" || check == "Package Quantity")
                                    {
                                        count = kon;
                                    }
                                    else if (check == "Size")
                                    {
                                        size = kon;
                                    }
                                    else if (check == "Color" || check == "Scent")
                                    {
                                        color = kon;
                                    }
                                    else
                                    {
                                        size = "check manually";
                                    }
                                }

                            }
                            int tr = str.IndexOf(",\"Sku\":\"" + jack + "\",");
                            int ct = tr - 30;
                            string pids = str.Substring(ct, tr + 10 - ct);
                            id = getsubstring("\"ProductId\":", ",\"", pids);
                            checkid.Add(id);
                            string auto = description(jack, id);
                            string[] desfi = Regex.Split(auto, "------------");
                            des = desfi[0];
                            features = desfi[1];
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, category, price, mainimg, varid, rating, review, childasin, variation, color, size, count, ordercount, stock, des, features, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        }

                    }
                }
                else
                {
                    qvcp.Rows.Add(id, parentage, name, Mname, category, price, mainimg, varid, rating, review, childasin, variation, color, size, count, ordercount, stock, des, features, rhon);
                    //  lab6show(qvcp);
                    WriteDataToFile(qvcp, dgwq);
                }
            psk:
                str = null;
            }
        }
        public static void stock(List<string> yogesh)
        {
            foreach (string rhonq in yogesh)
            {
                string rhon = "";
            jsk:
                try
                {
                    rhon = rhonq;
                    rhon = rhon.Replace("http://www.diapers.comhttp://www.diapers.com", "http://www.diapers.com");
                    str = Gethtml(rhon);
                }
                catch
                {
                    human.Add(rhon.Trim());
                    if (human.Count > 500)
                    {
                        human.Clear();
                        li3.Add(rhon.Trim());
                       // labunshow(li3);
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
                id = getsubstring("ProductId:\"", "\",", str);
                if (id == "")
                {
                    id = getsubstring("groupingASIN=", ",", str);
                }
                if (id == "")
                {
                    li3.Add("NO_ID" + rhon.Trim());
                   // labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                if (checkid.Contains(id))
                {
                    li3.Add("SAME_ID" + rhon.Trim());
                 //   labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                else
                {
                    checkid.Add(id);
                }
                nalu.Add("x");
                //lab6show(nalu);
                string name = "";
                string Mname = "";
                string count = "";
                name = getsubstring("<div class=\"productTitle\">", "</div>", str);
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                name = WebUtility.HtmlDecode(name);
                string price = "";
                price = getsubstring("<span class='singlePrice'>", "</span>", str);
                price = Regex.Replace(price, @"\s+", " ");
                string varid = "";
                string color = "";
                string size = "";
                string ordercount = "";
                string stock = "";
                string childasin = "";
                string variation = "";
                string stock12 = getsubstring("IsOutOfStock = \"", "\" ", str);
                if (stock12 == "N")
                {
                    stock = "In_Stock";
                }
                else if (stock12 == "Y")
                {
                    stock = "Out_Of_Stock";
                }
                if (str.IndexOf("Discontinued by vendor") > 0)
                {
                    stock = "Discontinued by vendor";
                }
                string parentage = "";
                parentage = "Individual";
                string sku = "";
                sku = getsubstring("NeedValidateSkuHidden:\"", ",\",", str);
                if (sku.Contains("DropShipSku"))
                {
                    sku = getsubstring("DropShipSkuHidden:\"", ",\",", str);
                }
                if (sku.Contains("ShipFreightSku"))
                {
                    sku = getsubstring("ShipFreightSkuHidden:\"", ",\",", str);
                }
                string[] skul = Regex.Split(sku, ",");
                if (skul.Count() >= 1)
                {

                    foreach (string jack in skul)
                    {
                        if (jack == "")
                        {

                            qvcp.Rows.Add(id, parentage, name, Mname, price, varid, childasin, variation, color, size, count, ordercount, stock, rhon);
                            //  lab6show(qvcp);
                            WriteDataToFile(qvcp, dgwq);
                        }
                        else if (str.IndexOf("id=\"" + jack.Replace("-", "_") + "SizeButton") > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring("id=\"" + jack.Replace("-", "_") + "SizeButton", "eCouponInfo" + jack.Replace("-", "_"), str);
                            id = getsubstring("productId=\"", "\" p", raw);
                            checkid.Add(id);
                            color = getsubstring("PrimaryAttributeValue=\"", "\" value", raw);
                            if (color == "")
                            {
                                color = getsubstring("value=\"", "\" canPers", raw);
                            }
                            color = WebUtility.HtmlDecode(color);
                            size = getsubstring("colorValue=\"", "\" c", raw);
                            if (size == "")
                            {
                                size = getsubstring("value=\"", "\" item", raw);
                            }
                            size = WebUtility.HtmlDecode(size);
                            name = getsubstring("skuName=\"", "\" after", raw);
                            name = WebUtility.HtmlDecode(name);
                            price = getsubstring("retailPrice=\"", "\" price", raw);
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" l", raw);
                            }
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" h", raw);

                            }
                            childasin = getsubstring("asin=\"", "\" sku", raw);
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");

                            ordercount = getsubstring("<span class=\"middle\">", "-<", raw);
                            ordercount = Regex.Replace(ordercount, @"\s+", " ");
                            string stock1 = getsubstring("IsOutOfStock = \"", "\" ", raw);
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, price, varid, childasin, variation, color, size, count, ordercount, stock, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }

                        }
                        else if (str.IndexOf("id=\"" + jack.Replace("-", "_") + "ColorButton") > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring("id=\"" + jack.Replace("-", "_") + "ColorButton", "eCouponInfo" + jack.Replace("-", "_"), str);
                            id = getsubstring("productId=\"", "\" p", raw);
                            checkid.Add(id);
                            color = getsubstring("PrimaryAttributeValue=\"", "\" value", raw);
                            if (color == "")
                            {
                                color = getsubstring("value=\"", "\" canPers", raw);
                            }
                            color = WebUtility.HtmlDecode(color);
                            size = getsubstring("colorValue=\"", "\" c", raw);
                            if (size == "")
                            {
                                size = getsubstring("value=\"", "\" item", raw);
                            }
                            size = WebUtility.HtmlDecode(size);
                            name = getsubstring("skuName=\"", "\" after", raw);
                            name = WebUtility.HtmlDecode(name);
                            price = getsubstring("retailPrice=\"", "\" price", raw);
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" l", raw);
                            }
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" h", raw);

                            }
                            childasin = getsubstring("asin=\"", "\" sku", raw);
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");

                            ordercount = getsubstring("<span class=\"middle\">", "-<", raw);
                            ordercount = Regex.Replace(ordercount, @"\s+", " ");
                            string stock1 = getsubstring("IsOutOfStock = \"", "\" ", raw);
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, price, varid, childasin, variation, color, size, count, ordercount, stock, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        }
                        else if (str.IndexOf("id=\"" + jack.Replace("-", "_")) > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring("id=\"" + jack.Replace("-", "_"), "</li>", str);
                            id = getsubstring("productId=\"", "\" p", raw);
                            checkid.Add(id);
                            color = getsubstring("PrimaryAttributeValue=\"", "\" value", raw);
                            size = getsubstring("value=\"", "\" item", raw);
                            name = getsubstring("skuName=\"", "\" after", raw);
                            name = WebUtility.HtmlDecode(name);
                            price = getsubstring("retailPrice=\"", "\" price", raw);
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" h", raw);

                            }
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" l", raw);
                            }
                            childasin = getsubstring("asin=\"", "\" sku", raw);
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");
                            ordercount = getsubstring("<span class=\"middle\">", "-<", raw);
                            ordercount = Regex.Replace(ordercount, @"\s+", " ");
                            string stock1 = getsubstring("IsOutOfStock = \"", "\" ", raw);
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, price, varid, childasin, variation, color, size, count, ordercount, stock, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        }
                        else if (str.IndexOf("id=\"skuHidden" + jack.Replace("-", "_")) > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring("id=\"skuHidden" + jack.Replace("-", "_") + "\"", "/>", str);
                            name = getsubstring("skuName=\"", "\" after", raw);
                            name = WebUtility.HtmlDecode(name);
                            int cxz = str.IndexOf("id=\"skuHidden" + jack.Replace("-", "_"));
                            int zx = cxz - 2050;
                            string rowdy = str.Substring(zx, cxz - zx);
                            rowdy = rowdy.Replace("<li class=\"itemSize\">SIZE</li>", "").Replace("<li class=\"unitPriceColumn\">UNIT PRICE</li>", "").Replace("<li class=\"itemSize\">COUNT</li>", "");
                            color = getsubstring("Color</span>", "<div", raw).Replace("<td>", "(").Replace("</td>", ")");
                            size = getsubstring("Size</span>", "<div", rowdy).Replace("<td>", "--");
                            if (size == "")
                            {
                                if (str.IndexOf("Size</th>") > 0)
                                {
                                    size = getsubstring("<span>", "</span>", rowdy);
                                }
                                if (size == "" && str.IndexOf("SIZE</li>") > 0)
                                {
                                    size = getsubstring("<li class=\"itemSize\">", "</li>", rowdy);
                                }
                                if (str.IndexOf("Color</th>") > 0 || str.IndexOf("Colors</th>") > 0)
                                {
                                    color = getsubstring("<td>", "</td>", rowdy);
                                    if (color.Contains("<span>") && color.Contains("</span>"))
                                    {
                                        color = "";
                                    }
                                    if (color == "")
                                    {
                                        color = getsubstring("<td class=\"elseDescription\">", "</td>", rowdy);
                                    }
                                }
                                if (color == "" && str.IndexOf("COLOR</li>") > 0)
                                {
                                    color = getsubstring("<li class=\"itemColor\">", "</li>", rowdy);
                                }
                            }
                            if (color == "")
                            {
                                color = getsubstring("primaryAttr=\"", "\"   i", rowdy);
                            }
                            if (str.IndexOf("Character</th>") > 0)
                            {
                                color = getsubstring("<td class=\"elseDescription\">", "</td>", rowdy);
                            }
                            size = Regex.Replace(size, @" ?\<.*?\>", string.Empty);
                            size = Regex.Replace(size, @"\s+", " ");
                            size = WebUtility.HtmlDecode(size);

                            color = Regex.Replace(color, @" ?\<.*?\>", string.Empty);
                            color = Regex.Replace(color, @"\s+", " ");
                            color = WebUtility.HtmlDecode(color);
                            price = getsubstring("retailPrice=\"", "\" price", raw);
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" l", raw);

                            }
                            if (price == "")
                            {
                                price = getsubstring("displayPrice = \"", "\" h", raw);

                            }
                            if (str.IndexOf("Price</th>") > 0)
                            {
                                string px = getsubstring("unitPrice\">", "</td>", rowdy);
                                px = Regex.Replace(px, @" ?\<.*?\>", string.Empty);
                                px = Regex.Replace(px, @"\s+", " ");
                                if (px != "")
                                {
                                    price = price + "(" + px + ")";
                                }
                            }
                            if (str.IndexOf("UNIT PRICE</li>") > 0)
                            {
                                string px = getsubstring("<li class=\"unitPriceColumn\">", "</li>", rowdy);
                                px = Regex.Replace(px, @" ?\<.*?\>", string.Empty);
                                px = Regex.Replace(px, @"\s+", " ");
                                if (px != "")
                                {
                                    price = price + "(" + px + ")";
                                }
                            }
                            if (str.IndexOf("Count</th>") > 0)
                            {
                                count = getsubstring("<td class=\"elseDescription\">", "</td>", rowdy);

                            }
                            if (str.IndexOf("COUNT</li>") > 0)
                            {

                                count = getsubstring("<li class=\"itemSize\">", "</li>", rowdy);
                            }
                            if (str.IndexOf("Content Weight</th>") > 0)
                            {
                                count = getsubstring("<td class=\"elseDescription\">", "</td>", rowdy);
                            }
                            count = Regex.Replace(count, @" ?\<.*?\>", string.Empty);
                            count = Regex.Replace(count, @"\s+", " ");
                            childasin = getsubstring("asin=\"", "\" sku", raw);
                            if (childasin.Contains("hasEcoupon"))
                            {
                                childasin = "CHECK_MANUALLY";
                            }
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");
                            id = getsubstring("productId=\"", "\" p", raw);
                            checkid.Add(id);
                            string stock1 = getsubstring("IsOutOfStock = \"", "\" ", raw);
                            if (stock1 == "")
                            {
                                stock1 = getsubstring("IsOutOfStock = \"", "\"/>", str);
                            }
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            int st = str.IndexOf("id=\"skuHidden" + jack.Replace("-", "_"));
                            int xt = st - 200;
                            int ct = str.IndexOf("<input", xt);
                            string xst = str.Substring(xt, ct - xt);
                            if (xst != "")
                            {
                                string hummr = getsubstring("<span class=\"outOfStock\">", "</span>", xst);
                                if (hummr != "")
                                {
                                    stock = hummr;
                                }
                            }
                            stock = Regex.Replace(stock, @" ?\<.*?\>", string.Empty);
                            stock = Regex.Replace(stock, @"\s+", " ");
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (variation == "")
                            {
                                parentage = "Box_Child";
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, price, varid, childasin, variation, color, size, count, ordercount, stock, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        }
                        else if (str.IndexOf(",\"Sku\":\"" + jack + "\",") > 0)
                        {
                            if (skul.Count() == 1)
                            {
                                parentage = "Individual";
                            }
                            else
                            {
                                parentage = "Child";
                            }
                            varid = jack;
                            string raw = getsubstring(",\"Sku\":\"" + jack + "\",", "}", str);
                            name = getsubstring("\"SkuName\":\"", "\",", raw);
                            name = WebUtility.HtmlDecode(name);
                            Mname = getsubstring("\"Description\":\"", "\",", raw);
                            Mname = WebUtility.HtmlDecode(Mname);
                            price = getsubstring("\"DisplayPrice\":\"", "\",", raw);
                            string unit = getsubstring("\"UnitPrice\":", ",\"", raw);
                            if (price != "" && unit != "")
                            {
                                price = price + "($" + unit + ")";
                            }
                            childasin = getsubstring("\"Asin\":\"", "\",", raw);
                            string alpha = jack.Remove(jack.IndexOf("-"));
                            alpha = Regex.Replace(alpha, @"\s+", " ");
                            string limit = getsubstring("\"LimitedQty\":", ",\"", raw);
                            if (limit != "0")
                            {
                                ordercount = limit;
                            }
                            string stock1 = getsubstring("\"IsOutOfStock\":\"", "\",", raw);
                            if (stock1 == "N")
                            {
                                stock = "In_Stock";
                            }
                            else if (stock1 == "Y")
                            {
                                stock = "Out_Of_Stock";
                            }
                            string stmsg = getsubstring("\"OutOfStockMessage\":", ",\"", raw);
                            if (stmsg != "null")
                            {
                                stock = stmsg;
                                stock = Regex.Replace(stock, @" ?\<.*?\>", string.Empty);
                                stock = WebUtility.HtmlDecode(stock);
                                stock = Regex.Replace(stock, @"\s+", " ");
                            }
                            string sc = getsubstring("\"PrimaryAttributeValue\":\"", "\",", raw);
                            if (sc != "")
                            {
                                string kon = getsubstring("id=\"" + sc, "</td>", str).Replace("<i >", "(").Replace("</i>", ")").Replace("<i  DiaperPackName=\"Y\" >", "(").Replace("<i  DiaperPackName=\"N\" >", "(").Replace("\" class=\"attributeOption\">", "");
                                c = str.IndexOf("id=\"" + sc);
                                v = str.IndexOf("attributeTitle\">");
                                string kis = "";
                                try
                                {
                                    kis = str.Substring(v, c - v);
                                }
                                catch { }
                                string check = getsubstring("attributeName=\"", "\">", kis);
                                kon = Regex.Replace(kon, @" ?\<.*?\>", string.Empty);
                                kon = WebUtility.HtmlDecode(kon);
                                kon = Regex.Replace(kon, @"\s+", " ");
                                if (check == "Count" || check == "Package Quantity")
                                {
                                    count = kon;
                                }
                                else if (check == "Size")
                                {
                                    size = kon;
                                }
                                else if (check == "Color" || check == "Scent")
                                {
                                    color = kon;
                                }
                                else
                                {
                                    color = "Check Manually";
                                }

                            }
                            string cc = getsubstring("SecondAttributeValue\":\"", "\",", raw);
                            if (cc != "")
                            {
                                string kon = getsubstring("id=\"" + cc, "</td>", str).Replace("<i >", "(").Replace("</i>", ")").Replace("<i  DiaperPackName=\"Y\" >", "(").Replace("<i  DiaperPackName=\"N\" >", "(").Replace("\" class=\"attributeOption\">", "");
                                c = str.IndexOf("id=\"" + cc);
                                v = str.LastIndexOf("attributeTitle\">");
                                string third = getsubstring("\"ThirdAttributeValue\":\"", "\",", raw);
                                if (third != "")
                                {
                                    count = "THREE VALUES PRESENT";
                                }
                                else
                                {
                                    string kis = "";
                                    try
                                    {
                                        kis = str.Substring(v, c - v);
                                    }
                                    catch { }
                                    string check = getsubstring("attributeName=\"", "\">", kis);
                                    kon = Regex.Replace(kon, @" ?\<.*?\>", string.Empty);
                                    kon = WebUtility.HtmlDecode(kon);
                                    kon = Regex.Replace(kon, @"\s+", " ");
                                    if (check == "Count" || check == "Package Quantity")
                                    {
                                        count = kon;
                                    }
                                    else if (check == "Size")
                                    {
                                        size = kon;
                                    }
                                    else if (check == "Color" || check == "Scent")
                                    {
                                        color = kon;
                                    }
                                    else
                                    {
                                        size = "check manually";
                                    }
                                }

                            }
                            int tr = str.IndexOf(",\"Sku\":\"" + jack + "\",");
                            int ct = tr - 30;
                            string pids = str.Substring(ct, tr + 10 - ct);
                            id = getsubstring("\"ProductId\":", ",\"", pids);
                            checkid.Add(id);
                            if (color != "" && size != "" && count != "")
                            {
                                variation = "Color|Size|Count";
                            }
                            else if (color != "" && size != "" && count == "")
                            {
                                variation = "Color|Size";
                            }
                            else if (color != "" && size == "" && count == "")
                            {
                                variation = "Color";
                            }
                            else if (color == "" && size != "" && count == "")
                            {
                                variation = "size";
                            }
                            else if (color == "" && size == "" && count != "")
                            {
                                variation = "count";
                            }
                            else if (color != "" && size == "" && count != "")
                            {
                                variation = "color|count";
                            }
                            else if (color == "" && size != "" && count != "")
                            {
                                variation = "Size|count";
                            }
                            if (color != "")
                            {
                                color = "#" + color;
                            }
                            if (size != "")
                            {
                                size = "#" + size;
                            }
                            if (id != "")
                            {
                                qvcp.Rows.Add(id, parentage, name, Mname, price, varid, childasin, variation, color, size, count, ordercount, stock, rhon);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                        }

                    }
                }
                else
                {
                    qvcp.Rows.Add(id, parentage, name, Mname, price, varid, childasin, variation, color, size, count, ordercount, stock, rhon);
                    //  lab6show(qvcp);
                    WriteDataToFile(qvcp, dgwq);
                }
            psk:
                str = null;
            }
        }
        public static string description(string varid, string id)
        {
            string dcp = "";
            string acp = "";
            string skdec = "";
            string aq = ";\" sku=\"" + varid + "\">";
            int za = str.LastIndexOf(aq);
            if (za != -1)
            {
                int xz = str.IndexOf("</div>", za);
                skdec = str.Substring(za + aq.Length, xz - za - aq.Length);
            }
            string opti = getsubstring("<li productid = \"" + id, "</li>", str);
            string head = getsubstring("<a id=\"", "\" c", opti).Replace("Header", "");
            string das = getsubstring(head + "DetailInfo\"  style=\"display", "</dd>", str).Replace(":block;\" >", "").Replace(":none;\" >", "");
            if (das.Contains("<p class=\"MsoNoSpacing"))
            {
                das = das.Replace("<p class=\"MsoNoSpacing", "<");
            }
            //string das = dex.Substring(za + aq.Length, xz - za - aq.Length);
            if (das.Contains(varid))
            {
                skdec = "";
            }
            if (das.IndexOf("' sku=\"" + varid + "\">") > 0)
            {
                skdec = getsubstring("' sku=\"" + varid + "\">", "</p>", das).Replace("&bull;", "|");
            }
            if (das.Contains("<p class="))
            {
                das = "<" + getsubstring("<div", "<p class=", das);
            }
            if (das.Contains(">Features"))
            {
                string cx = getsubstring("<p>", ">Features", das).Replace("&nbsp;", "") + ">";
                if (cx == ">")
                {
                    cx = getsubstring("<div class=\"pIdDesContent\">", ">Features", das).Replace("&nbsp;", "") + ">";
                }
                if (cx == ">")
                {
                    cx = getsubstring("descriptContentBox clearfix\">", ">Features", das).Replace("&nbsp;", "") + ">";
                }
                acp = cx + skdec;
                string cd = getsubstring(">Features", "</ul>", das);
                pattern = @"<li[^>]*?>(.*?)</li>";
                List<string> fes = new List<string>();
                fes.AddRange(matchkar(cd, pattern, ""));
                if (fes.Count < 1)
                {
                    pattern = @"<li[^>]*?>(.*?)</Il>";
                    fes.AddRange(matchkar(cd, pattern, ""));
                }
                if (fes.Count < 1)
                {
                    string fao = das.Substring(das.IndexOf(">Features")).Replace(">Features", "").Replace(":", "");
                    string[] desfi = Regex.Split(fao, "<br />");
                    fes.AddRange(desfi);
                }
                string imj = "|";
                dcp = string.Join(imj, fes.ToArray());
            }
            else
            {
                string wdes = getsubstring("\"><p>", "<li>", das);
                if (wdes != "")
                {
                    acp = wdes + skdec;
                    pattern = @"<li[^>]*?>(.*?)</li>";
                    List<string> fes = new List<string>();
                    fes.AddRange(matchkar(das, pattern, ""));
                    if (fes.Count < 1)
                    {
                        pattern = @"<li[^>]*?>(.*?)</Il>";
                        fes.AddRange(matchkar(das, pattern, ""));
                    }
                    string imj = "|";
                    dcp = string.Join(imj, fes.ToArray());
                    dcp = Regex.Replace(dcp, @" ?\<.*?\>", string.Empty);
                    dcp = Regex.Replace(dcp, @"\s+", " ");
                    dcp = WebUtility.HtmlDecode(dcp);
                }
                else
                {
                    List<string> fea = new List<string>();
                    acp = das + skdec;
                    if (acp.Contains("<ul>") || acp.Contains("<li>"))
                    {
                        pattern = @"<li[^>]*?>(.*?)</li>";
                        MatchCollection match = Regex.Matches(acp, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match matches in match)
                        {
                            string cx = matches.Groups[1].Value;
                            cx = cx.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                            cx = Regex.Replace(cx, @"\s+", " ");
                            if (cx != "")
                            {
                                fea.Add(cx);
                                acp = acp.Replace(cx, "");
                            }
                        }
                        if (fea.Count >= 1)
                        {
                            string image83 = "|";
                            dcp = string.Join(image83, fea.ToArray());
                        }
                    }
                    else if (acp.Contains("&bull;"))
                    {
                        pattern = @"&bull[^>]*?;(.*?)<";
                        MatchCollection match = Regex.Matches(acp, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match matches in match)
                        {
                            string cx = matches.Groups[1].Value;
                            cx = cx.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                            cx = Regex.Replace(cx, @"\s+", " ");
                            if (cx != "")
                            {
                                fea.Add(cx);
                                acp = acp.Replace(cx, "");
                            }
                        }
                        if (fea.Count >= 1)
                        {
                            acp = acp.Replace("&bull;", "");
                            string image83 = "|";
                            dcp = string.Join(image83, fea.ToArray());
                        }


                    }
                    else if (acp.Contains("<li class=\"feature\">"))
                    {
                        pattern = @"<li class=""feature""[^>]*?>(.*?)</li>";
                        MatchCollection match = Regex.Matches(acp, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match matches in match)
                        {
                            string cx = matches.Groups[1].Value;
                            cx = cx.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                            cx = Regex.Replace(cx, @"\s+", " ");
                            if (cx != "")
                            {
                                fea.Add(cx);
                                acp = acp.Replace(cx, "");
                            }
                        }
                        if (fea.Count >= 1)
                        {
                            acp = acp.Replace("&bull;", "");
                            string image83 = "|";
                            dcp = string.Join(image83, fea.ToArray());
                        }

                    }
                }
            }
            dcp = Regex.Replace(dcp, @" ?\<.*?\>", string.Empty);
            dcp = Regex.Replace(dcp, @"\s+", " ");
            dcp = WebUtility.HtmlDecode(dcp);
            acp = acp.Replace("</strong></p>", "--").Replace("</strong><br /></p>", "--");
            acp = Regex.Replace(acp, @" ?\<.*?\>", string.Empty);
            acp = Regex.Replace(acp, @"\s+", " ");
            acp = WebUtility.HtmlDecode(acp);
            string pc = acp + "------------" + dcp;
            return pc;
        }

    }
}
