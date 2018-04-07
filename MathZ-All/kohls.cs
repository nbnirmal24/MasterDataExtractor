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
    class kohls
    {
        public static String Gethtml(string URL)
        {
            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create(URL);
            request1.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.89 Safari/537.36";
            //  request1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            // request1.Proxy = null;
            //  ServicePointManager.Expect100Continue = false;
            //  ServicePointManager.DefaultConnectionLimit = 5;
            //   ServicePointManager.MaxServicePointIdleTime = 2000;
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
        static int x, y, c, v, cg;
        static string cat = "";
        static bool access = true;
        public static void datetime()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("Child_ID");
            qvcp.Columns.Add("UPC");
            qvcp.Columns.Add("Parantage");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("Product_URL");
            qvcp.Columns.Add("Title");
            qvcp.Columns.Add("Type_Of_Price");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Stock_Status");
            qvcp.Columns.Add("Main_Image");
            qvcp.Columns.Add("Alternate_Image");
            qvcp.Columns.Add("Variation_Type");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("Description");
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
                    if (human.Count > 50)
                    {
                        human.Clear();
                        li3.Add(thor.Trim());
                        Ulb.Text = li3.Count.ToString();
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
                str = str.Replace("®", "").Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");
                if (str.IndexOf("\"prodSeoURL\": \"") > 0)
                {
                    //<div class=\"product-info\">
                    // @"<div class=""product-info""[^>]*?>(.*?)</a>";
                    List<string> tk = new List<string>();
                    pattern = @"""prodSeoURL"": [^>]*?""(.*?)"",";
                    tk.AddRange(matchkar(str, pattern));
                    if (tk.Count >= 1)
                    {
                        foreach (string cid in tk)
                        {
                            string ra = cid; //getsubstring("<a href=\"", "\">", cid);
                            if (ra != "")
                            {
                                if (!ra.Contains("http://www.kohls.com"))
                                {
                                    ra = "http://www.kohls.com" + ra;
                                }
                                if (potter.Contains(ra))
                                { }
                                else
                                {
                                    potter.Add(ra);
                                    ProductURL.Add(ra);
                                    System.IO.File.WriteAllLines(abcd1, ProductURL);
                                    Plb.Text = ProductURL.Count.ToString();
                                }
                            }
                        }

                    }
                    v = str.IndexOf("rel=\"next\" href=\"");
                    while (v > 0)
                    {
                        string next = getsubstring("rel=\"next\" href=\"", "\" />", str);
                        if (next == "")
                        {
                            next = getsubstring("rel=\"next\" href=\"", "\">", str);
                        }
                        if (next == "")
                        {
                            next = getsubstring("<a class=\"ir next-set\" href=\"", "\">", str);
                        }
                        if (next == "")
                        {
                            next = getsubstring("nextArw fr\" href=\"", "\" title=\"Next", str);
                        }
                        if (next != "")
                        {
                            if (!next.Contains("http://www.kohls.com"))
                            {

                                next = "http://www.kohls.com" + next;
                            }

                        }
                        str = null;
                        if (next == "")
                        {
                            break;
                        }
                    jsxk:
                        try
                        {
                            str = Gethtml(next);
                        }
                        catch
                        {
                        }
                        if (str == null || str == "")
                        {

                            goto jsxk;
                        }
                        str = str.Replace("®", "").Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");
                        List<string> tkt = new List<string>();
                        pattern = @"""prodSeoURL"": [^>]*?""(.*?)"",";
                        tkt.AddRange(matchkar(str, pattern));
                        if (tkt.Count >= 1)
                        {
                            foreach (string cid in tkt)
                            {
                                string ra = cid; //getsubstring("<a href=\"", "\">", cid);
                                if (ra != "")
                                {
                                    if (!ra.Contains("http://www.kohls.com"))
                                    {
                                        ra = "http://www.kohls.com" + ra;
                                    }
                                    if (potter.Contains(ra))
                                    { }
                                    else
                                    {
                                        potter.Add(ra);
                                        ProductURL.Add(ra);
                                        System.IO.File.WriteAllLines(abcd1, ProductURL);
                                        Plb.Text = ProductURL.Count.ToString();
                                    }
                                }
                            }

                        }
                        else
                        {
                            break;
                        }
                        v = str.IndexOf("rel=\"next\" href=\"");
                        if (v < 0)
                        {
                            v = str.IndexOf("<a class=\"ir next-set\" href=\"");
                        }
                        if (v < 0)
                        {
                            v = str.IndexOf("\" title=\"Next Page");
                        }
                    }
                }
                else if (str.IndexOf("<div class=\"grid-box ") > 0)
                {
                    List<string> jk = new List<string>();
                    pattern = @"<div class=""grid-bo[^>]*?x (.*?)</div>";
                    jk.AddRange(matchkar(str, pattern));
                    if (jk.Count >= 1)
                    {
                        foreach (string abde in jk)
                        {
                            string fcb = getsubstring("\" href=\"", "\">", abde);
                            if (fcb == "")
                            {
                                fcb = getsubstring("<a href=\"", "\">", abde);
                            }
                            if (fcb != "" && !abde.Contains("Shop All"))
                            {
                                if (fcb.Contains("http://www.kohls.com"))
                                {
                                    iron.Add(fcb);
                                }
                                else
                                {
                                    iron.Add("http://www.kohls.com" + fcb);
                                }
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
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
            clb.Visible = true;
            foreach (string rhon in yogesh)
            {
                string id = "";
            jsk:
                try
                {

                    str = Gethtml(rhon);
                }
                catch (Exception e)
                {
                    string vb = e.ToString();
                    if (vb.Contains("(404) Not Found"))
                    {
                        id = "Not_Available";
                        nala.Add("x");
                        lb.Text = nala.Count.ToString();
                        qvcp.Rows.Add(id, rhon);
                        WriteDataToFile(qvcp, dgwq);
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
                str = str.Replace("®", "").Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");
                id = getsubstring("\"itemProductID\":\"", "\",", str);
                if (id == "")
                {
                    id = getsubstring("br_data.prod_id = \"", "\";", str);
                }
                if (id == "")
                {
                    li3.Add("NO_ID" + rhon.Trim());
                    Ulb.Text = li3.Count.ToString();
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                if (potter.Contains(id))
                {
                    li3.Add("SAME_ID" + rhon.Trim());
                    Ulb.Text = li3.Count.ToString();
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                else
                {
                    potter.Add(id);
                }
                nala.Add("x");
                lb.Text = nala.Count.ToString();
                id = Regex.Replace(id, @" ?\<.*?\>", string.Empty);
                id = Regex.Replace(id, @"\s+", "");
                string name = "";
                name = getsubstring("<h1 class=\"title productTitleName\">", "</h1>", str);
                if (name == "")
                {
                    name = getsubstring("\"itemName\":\"", "\",", str);
                }
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                string price = "";
                string typep = "";
                price = getsubstring("br_data.sale_price = \"", "\";", str);
                if (price == "")
                {
                    price = getsubstring("<span class=\"price_label\">", "</div>", str).Replace("Regular", "").Replace("Sale", "");
                }
                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                price = Regex.Replace(price, @"\s+", " ");
                if (str.IndexOf("<span class=\"price_label\">Sale") > 0)
                {
                    typep = "SALE";
                }
                else if (str.IndexOf("<span class=\"price_label\">Regular") > 0)
                {
                    typep = "REGULAR";
                }
                string mainimg = "";
                string raw = getsubstring("<div id=\"easyzoom_wrap\">", "</div>", str);
                if (raw != "")
                {
                    mainimg = getsubstring("<a href=\"", "\">", raw);
                    if (mainimg == "")
                    {
                        mainimg = getsubstring("<img src=\"", "\" a", raw);
                    }
                }
                if (mainimg == "" || mainimg.Contains("/catalog/v2/fragments/"))
                {
                    string vcv = getsubstring("<li count=\"0\">", "</li>", str);
                    if (vcv != "")
                    {
                        mainimg = getsubstring("<a rel=\"", "\" href", str).Replace("500&", "1000&");
                    }
                }
                mainimg = Regex.Replace(mainimg, @" ?\<.*?\>", string.Empty);
                mainimg = Regex.Replace(mainimg, @"\s+", " ");
                string alterimg = "";
                string acp = getsubstring("<li count=\"1\">", "</li>", str);
                if (acp != "")
                {
                    alterimg = getsubstring("<a rel=\"", "\" href", str).Replace("500&", "1000&");
                }
                alterimg = Regex.Replace(alterimg, @" ?\<.*?\>", string.Empty);
                alterimg = Regex.Replace(alterimg, @"\s+", " ");
                string des = "";
                string features = "";
                string upc = "";
                upc = getsubstring("UpcCode\" value=\"", "\"/>", str);
                if (upc != "")
                {
                    upc = "#" + upc;
                }
                string das = getsubstring("<div id=\"pdp_details_segment\">", "<div id=\"pdp_s", str);
                if (das != "")
                {
                    string abcd = getsubstring("<p><a href=\"", "</a></p>", das);
                    if (abcd != "")
                    {
                        das = das.Replace(abcd, "").Replace("<p><a href=\"", "").Replace("</a></p>", "");
                    }
                }
                List<string> fea = new List<string>();
                if (das.Contains("FEATURES<") || das.Contains("Features:<") || das.Contains("Product Features<"))
                {
                    string qa = getsubstring("FEATURES<", "</ul>", das);
                    if (qa == "")
                    {
                        qa = getsubstring("Features:<", "</ul>", das);
                    }
                    if (qa == "")
                    {
                        qa = getsubstring("Product Features<", "</ul>", das);
                    }
                    if (qa != "")
                    {
                        pattern = @"<li[^>]*?>(.*?)</li>";
                        MatchCollection match = Regex.Matches(qa, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match matches in match)
                        {
                            string cx = matches.Groups[1].Value;
                            cx = cx.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                            cx = Regex.Replace(cx, @"\s+", " ");
                            fea.Add(cx);
                            das = das.Replace(cx, "");
                        }
                        if (fea.Count >= 1)
                        {
                            das = das.Replace("&bull;", "");
                            string image83 = "|";
                            features = string.Join(image83, fea.ToArray());
                        }

                    }

                }
                das = das.Replace("<li>", "|").Replace("<ul>", ":").Replace("PRODUCT FEATURES", "").Replace("</ul>", "").Replace("Product Features", "").Replace("Features", "|");
                das = Regex.Replace(das, @" ?\<.*?\>", string.Empty);
                if (das != "")
                {
                    das = WebUtility.HtmlDecode(das);
                }
                das = Regex.Replace(das, @"\s+", " ");
                features = Regex.Replace(features, @" ?\<.*?\>", string.Empty);
                features = WebUtility.HtmlDecode(features);
                features = Regex.Replace(features, @"\s+", " ");
                string cate = "";
                cate = getsubstring("googletag.defineSlot(\"/17763952", "\",", str);
                string parantage = "";
                string color = "";
                string size = "";
                string childsku = "";
                string stock = "";
                string vartype = "";
                string cv = getsubstring("\"itemIsInStock\":\"", "}", str).Replace("\"", "");
                cv = Regex.Replace(cv, @" ?\<.*?\>", string.Empty);
                cv = Regex.Replace(cv, @"\s+", " ");
                if (cv != "")
                {
                    if (cv.Contains("true"))
                    {
                        stock = "In_Stock";
                    }
                    else if (cv.Contains("false"))
                    {
                        stock = "Out_Of_Stock";
                    }
                }
                parantage = "Individual";
                string SKU = getsubstring("\"variants\" : [", "]", str);
                SKU = Regex.Replace(SKU, @"\s+", " ");
                if (SKU != "")
                {
                    string[] skul = Regex.Split(SKU, "},");
                    if (skul.Count() >= 1)
                    {
                        skul = skul.Take(skul.Count() - 1).ToArray();
                        if (skul.Count() == 1)
                        {
                            parantage = "Individual";
                        }
                        else
                        {
                            parantage = "Child";
                        }
                        foreach (string jack in skul)
                        {
                            if (jack == "")
                            {
                                if (str.IndexOf("FOR PRICE,</span> ADD TO BAG") > 0)
                                {
                                    price = "For_Price_Add_To_Bag";
                                }
                                if (!price.Contains("-"))
                                {
                                    qvcp.Rows.Add(id, childsku, upc, parantage, cate, rhon, name, typep, price, stock, mainimg, alterimg, vartype, color, size, das, features);
                                    //  lab6show(qvcp);
                                    WriteDataToFile(qvcp, dgwq);
                                }
                            }
                            else
                            {
                                upc = getsubstring("\"skuUpcCode\":\"", "\",", jack);
                                upc = Regex.Replace(upc, @" ?\<.*?\>", string.Empty);
                                upc = Regex.Replace(upc, @"\s+", " ");
                                if (upc != "")
                                {
                                    upc = "#" + upc;
                                }
                                if (str.IndexOf("<div class=\"colorblock\">") > 0)
                                {
                                    color = getsubstring("\"color\":\"T" + id + "_", "\",", jack);
                                }
                                if (str.IndexOf("<div class=\"size-holder\">") > 0)
                                {
                                    size = getsubstring("\"size2\":\"T" + id + "_", "\",", jack).Replace("_waist", "");
                                }
                                if (color != "")
                                {
                                    string raws = getsubstring("<a id=\"" + color, "</div>", str);
                                    if (raws != "")
                                    {
                                        string goku = getsubstring("rel=\"", "\" href", raws);
                                        if (goku != "" && goku.Contains("http:"))
                                        {
                                            mainimg = goku.Replace("500&", "1000&");
                                        }
                                    }
                                }
                                childsku = getsubstring("\"skuId\":\"", "\",", jack);
                                string inven = getsubstring("\"inventoryStatus\":\"", "\",", jack);
                                if (inven == "true")
                                {
                                    stock = "In_Stock";
                                }
                                else
                                {
                                    stock = "Check_manually";
                                }
                                string pp = getsubstring("\"SkuSalePrice\":\"", "\",", jack);
                                if (pp != "")
                                {
                                    typep = "SALE";
                                }
                                if (pp.Contains("|"))
                                {
                                    pp = getsubstring("\"SkuSalePrice\":\"", "|", jack);
                                }
                                if (pp == "")
                                {
                                    pp = getsubstring("\"SkuRegularPrice\":\"", "\",", jack);
                                    if (pp != "")
                                    {
                                        typep = "REGULAR";
                                    }
                                }
                                if (pp.Contains("|"))
                                {
                                    pp = getsubstring("\"SkuRegularPrice\":\"", "|", jack);
                                }
                                if (pp != "")
                                {
                                    price = pp;
                                }
                                if (color != "" && size != "")
                                {
                                    color = "#" + color;
                                    size = "#" + size;
                                    vartype = "Color|Size";
                                }
                                else if (color != "" && size == "")
                                {
                                    color = "#" + color;
                                    vartype = "Color";
                                }
                                else if (color == "" && size != "")
                                {
                                    size = "#" + size;
                                    vartype = "Size";
                                }
                                if (!price.Contains("-") || (mainimg != "" && alterimg != "" && vartype != "" && color != "" && size != ""))
                                {
                                    qvcp.Rows.Add(id, childsku, upc, parantage, cate, rhon, name, typep, price, stock, mainimg, alterimg, vartype, color, size, das, features);
                                    //  lab6show(qvcp);
                                    WriteDataToFile(qvcp, dgwq);
                                }
                            }


                        }

                    }


                }
                else
                {

                    qvcp.Rows.Add(id, childsku, upc, parantage, cate, rhon, name, typep, price, stock, mainimg, alterimg, vartype, color, size, das, features);
                    //  lab6show(qvcp);
                    WriteDataToFile(qvcp, dgwq);
                }
            psk:
                str = null;
            }
        }
        public static void stock(List<string> yogesh)
        {
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
            foreach (string rhon in yogesh)
            {
                string id = "";

            jsk:
                try
                {

                    str = Gethtml(rhon);
                }
                catch (Exception e)
                {
                    string vb = e.ToString();
                    if (vb.Contains("(404) Not Found"))
                    {
                        id = "Not_Available";
                        nala.Add("x");
                        Plb.Text = nala.Count.ToString();
                        qvcp.Rows.Add(id, rhon);
                        WriteDataToFile(qvcp, dgwq);
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
                id = getsubstring("\"itemProductID\":\"", "\",", str);
                if (id == "")
                {
                    id = getsubstring("br_data.prod_id = \"", "\";", str);
                }
                if (id == "")
                {
                    li3.Add("NO_ID" + rhon.Trim());
                    Ulb.Text = li3.Count.ToString();
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                if (potter.Contains(id))
                {
                    li3.Add("SAME_ID" + rhon.Trim());
                    Ulb.Text = li3.Count.ToString();
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                else
                {
                    potter.Add(id);
                }
                nala.Add("x");
                lb.Text = nala.Count.ToString();
                id = Regex.Replace(id, @" ?\<.*?\>", string.Empty);
                id = Regex.Replace(id, @"\s+", "");
                string name = "";
                name = getsubstring("<h1 class=\"title productTitleName\">", "</h1>", str);
                if (name == "")
                {
                    name = getsubstring("\"itemName\":\"", "\",", str);
                }
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                string price = "";
                string typep = "";
                price = getsubstring("br_data.sale_price = \"", "\";", str);
                if (price == "")
                {
                    price = getsubstring("<span class=\"price_label\">", "</div>", str).Replace("Regular", "").Replace("Sale", "");
                }
                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                price = Regex.Replace(price, @"\s+", " ");
                if (str.IndexOf("<span class=\"price_label\">Sale") > 0)
                {
                    typep = "SALE";
                }
                else if (str.IndexOf("<span class=\"price_label\">Regular") > 0)
                {
                    typep = "REGULAR";
                }
                string upc = "";
                upc = getsubstring("UpcCode\" value=\"", "\"/>", str);
                if (upc != "")
                {
                    upc = "#" + upc;
                }
                string parantage = "";
                string color = "";
                string size = "";
                string childsku = "";
                string stock = "";
                string vartype = "";
                string cv = getsubstring("\"itemIsInStock\":\"", "}", str).Replace("\"", "");
                cv = Regex.Replace(cv, @" ?\<.*?\>", string.Empty);
                cv = Regex.Replace(cv, @"\s+", " ");
                if (cv != "")
                {
                    if (cv.Contains("true"))
                    {
                        stock = "In_Stock";
                    }
                    else if (cv.Contains("false"))
                    {
                        stock = "Out_Of_Stock";
                    }
                }
                parantage = "Individual";
                string SKU = getsubstring("\"variants\" : [", "]", str);
                SKU = Regex.Replace(SKU, @"\s+", " ");
                if (SKU != "")
                {
                    string[] skul = Regex.Split(SKU, "},");
                    if (skul.Count() >= 1)
                    {
                        skul = skul.Take(skul.Count() - 1).ToArray();
                        if (skul.Count() == 1)
                        {
                            parantage = "Individual";
                        }
                        else
                        {
                            parantage = "Child";
                        }
                        foreach (string jack in skul)
                        {
                            if (jack == "")
                            {
                                if (str.IndexOf("<div id=\"suppressed_message_default\" class=\"suppressed defaultsuppressed\"") > 0)
                                {
                                    price = "For_Price_Add_To_Bag";
                                }
                                qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                            else
                            {
                                upc = getsubstring("\"skuUpcCode\":\"", "\",", jack);
                                upc = Regex.Replace(upc, @" ?\<.*?\>", string.Empty);
                                upc = Regex.Replace(upc, @"\s+", " ");
                                if (upc != "")
                                {
                                    upc = "#" + upc;
                                }
                                if (str.IndexOf("<div class=\"colorblock\">") > 0)
                                {
                                    color = getsubstring("\"color\":\"T" + id + "_", "\",", jack);
                                }
                                if (str.IndexOf("<div class=\"size-holder\">") > 0)
                                {
                                    size = getsubstring("\"size2\":\"T" + id + "_", "\",", jack).Replace("_waist", "");
                                }

                                childsku = getsubstring("\"skuId\":\"", "\",", jack);
                                string inven = getsubstring("\"inventoryStatus\":\"", "\",", jack);
                                if (inven == "true")
                                {
                                    stock = "In_Stock";
                                }
                                else
                                {
                                    stock = "Check_manually";
                                }
                                string pp = getsubstring("\"SkuSalePrice\":\"", "\",", jack);
                                if (pp != "")
                                {
                                    typep = "SALE";
                                }
                                if (pp.Contains("|"))
                                {
                                    pp = getsubstring("\"SkuSalePrice\":\"", "|", jack);
                                }
                                if (pp == "")
                                {
                                    pp = getsubstring("\"SkuRegularPrice\":\"", "\",", jack);
                                    if (pp != "")
                                    {
                                        typep = "REGULAR";
                                    }
                                }
                                if (pp.Contains("|"))
                                {
                                    pp = getsubstring("\"SkuRegularPrice\":\"", "|", jack);
                                }
                                if (pp != "")
                                {
                                    price = pp;
                                }
                                if (color != "" && size != "")
                                {
                                    color = "#" + color;
                                    size = "#" + size;
                                    vartype = "Color|Size";
                                }
                                else if (color != "" && size == "")
                                {
                                    color = "#" + color;
                                    vartype = "Color";
                                }
                                else if (color == "" && size != "")
                                {
                                    size = "#" + size;
                                    vartype = "Size";
                                }

                                qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }


                        }

                    }


                }
                else
                {

                    qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
                    //  lab6show(qvcp);
                    WriteDataToFile(qvcp, dgwq);
                }
            psk:
                str = null;
            }
        }
    }
}
