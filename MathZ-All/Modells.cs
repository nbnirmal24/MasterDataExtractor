using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MathZ_All
{
    class Modells : Common
    {

        static List<string> isIdNotRepeated = new List<string>();
        static List<string> productURL = new List<string>();
        static List<string> unprocessedUrl = new List<string>();
        static List<string> rawData = new List<string>();
        static List<string> outputData = new List<string>();
        static List<string> sizeList = new List<string>();
        static List<string> colorList = new List<string>();
        static string image1 = "";
        static string image2 = "";
        static string image3 = "";
        static string image4 = "";
        static string image5 = "";
        static string Stockquantity = "";
        static int checkResult = 0;
        public static List<string> passpro(List<string> produt)
        {
            produt = productURL;
            return produt;
        }
        static string str = null;
        static DataTable qvcp = new DataTable();
        static string pattern = "";
        static string rawDataString = "";
        static string fileName = "DATA" + DateTime.Now.ToString("ddMMyyyyThhmmss") + ".txt";
        static string outputPath = Path.Combine(GetOutputPath("Modells"), fileName);
        static string unprocessedPath = Path.Combine(GetUnprocessedPath("Modells"), fileName);
        static string productPath = Path.Combine(GetProductPath("Modells"), fileName);
        public static void datetime()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            qvcp.Columns.Add("Product_URL");
            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("SKU");
            qvcp.Columns.Add("Brand");
            qvcp.Columns.Add("Title");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("wasPrice");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("MainImage");
            qvcp.Columns.Add("AltImage");
            qvcp.Columns.Add("AltImage1");
            qvcp.Columns.Add("AltImage2");
            qvcp.Columns.Add("Features");
            qvcp.Columns.Add("Stock");
            qvcp.Columns.Add("Stock_Quantity");
            qvcp.Columns.Add("Color_Code");
            qvcp.Columns.Add("Size_Code");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            tb1.Text = outputPath;
        }
        public static void datetime1()
        {
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            // qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
            qvcp.Columns.Add("Product_Url");
            qvcp.Columns.Add("Product_ID");
            //qvcp.Columns.Add("UPC");
            //qvcp.Columns.Add("Parantage");
            //qvcp.Columns.Add("Product_URL");
            //qvcp.Columns.Add("Title");
            //qvcp.Columns.Add("Type_Of_Price");
            //qvcp.Columns.Add("Price");
            //qvcp.Columns.Add("Stock_Status");
            //qvcp.Columns.Add("Variation_Type");
            //qvcp.Columns.Add("Color");
            //qvcp.Columns.Add("Size");
            tb1.Text = outputPath;
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


                    str = GetHtml(thor);
                }
                catch
                {
                    checkResult++;
                    if (checkResult > 50)
                    {
                        checkResult = 0;
                        unprocessedUrl.Add(thor.Trim());
                        Ulb.Text = unprocessedUrl.Count.ToString();
                        //  labunshow(li3);
                        System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
                        goto psk;
                    }
                }
                if (str == null || str == "")
                {

                    goto jsk;
                }
                if (checkResult >= 1)
                {
                    checkResult = 0;
                }
                str = str.Replace("®", "").Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");
                if (str.IndexOf("product-tile__link\" href=\"") > 0)
                {
                    //<div class=\"product-info\">
                    // @"<div class=""product-info""[^>]*?>(.*?)</a>";  
                    List<string> tk = new List<string>();
                    pattern = @"product-tile__link"" href=[^>]*?""(.*?)"" title";
                    tk.AddRange(MatchPattern(str, pattern));
                    if (tk.Count >= 1)
                    {
                        foreach (string cid in tk)
                        {
                            string ra = cid; //GetSubString("<a href=\"", "\">", cid);
                            if (ra != "")
                            {
                                if (!ra.Contains("https://www.modells.com"))
                                {
                                    ra = "https://www.modells.com" + ra;
                                }
                                if (!productURL.Contains(ra))
                                {
                                    productURL.Add(ra);
                                    System.IO.File.WriteAllLines(productPath, productURL);
                                    Plb.Text = productURL.Count.ToString();
                                }
                            }
                        }

                    }
                    int v = str.IndexOf("Go to next page\" href=\"");
                    while (v > 0)
                    {
                        string next = GetSubString("Go to next page\" href=\"", "\">", str);
                        if (next == "")
                        {
                            break;
                        }
                        //else if (next.Contains("<input type=\"submit\"") || next.Contains("ml-paging-mini ml-paging-index"))
                        //{
                        //    next = GetSubString("\" ml-paging-default\"><a href=\"", "class=\"", str).Replace("\"", "");
                        //    next = Regex.Replace(next, @"\s+", "");
                        //    if (string.IsNullOrEmpty(next))
                        //    {
                        //        break;
                        //    }
                        //}
                        //else
                        //{

                        //    next = GetSubString("a href='", "'>", next);
                        //}
                        if (next != "")
                        {
                            if (!next.Contains("https://www.modells.com"))
                            {

                                next = "https://www.modells.com" + next;
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
                            str = GetHtml(next);
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
                        pattern = @"product-tile__link"" href=[^>]*?""(.*?)"" title";
                        tkt.AddRange(MatchPattern(str, pattern));
                        if (tkt.Count >= 1)
                        {
                            foreach (string cid in tkt)
                            {
                                string ra = cid; //GetSubString("<a href=\"", "\">", cid);
                                if (ra != "")
                                {
                                    if (!ra.Contains("https://www.modells.com"))
                                    {
                                        ra = "https://www.modells.com" + ra;
                                    }
                                    if (!productURL.Contains(ra))
                                    {
                                        productURL.Add(ra);
                                        System.IO.File.WriteAllLines(productPath, productURL);
                                        Plb.Text = productURL.Count.ToString();
                                    }
                                }
                            }

                        }
                        else
                        {
                            break;
                        }

                    }
                }
                else if (str.IndexOf("item--xs-2 \" href=\"") > 0||str.IndexOf("item--xs-full \" href=\"")>0)
                {
                    List<string> jk = new List<string>();
                    pattern = @"item--xs-2 "" href=[^>]*?""(.*?)"" title";
                    jk.AddRange(MatchPattern(str, pattern));
                    pattern = @"item--xs-full "" href=[^>]*?""(.*?)"" title";
                    jk.AddRange(MatchPattern(str, pattern));
                    if (jk.Count >= 1)
                    {
                        foreach (string abde in jk)
                        {
                            string fcb = abde;//GetSubString("href=\"", "\">", abde);
                            //if (fcb == "")
                            //{
                            //    fcb = GetSubString("<a href=\"", "\">", abde);
                            //}
                            if (fcb != "")
                            {
                                if (fcb.Contains("https://www.modells.com"))
                                {
                                    iron.Add(fcb);
                                }
                                else
                                {
                                    iron.Add("https://www.modells.com" + fcb);
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
                productURL.Add("ab_de_be_eb");
                return productURL;
            }
        }
        public static void product(List<string> yogesh)
        {
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
            clb.Visible = true;
            // uris.Add(new Uri("http://www.bing.com"));

            //  try
            //{




            //}
            //catch (AggregateException exc)
            //{
            //  exc.InnerExceptions.ToList().ForEach(ez =>
            //{
            //  Console.WriteLine(ez.Message);
            //});
            //}
            foreach (string potter in yogesh)
            {
                string rhon = Regex.Replace(potter, @"\t|\n|\r", "");

                //  WebRequest webR = HttpWebRequest.Create(u);
                //.HttpWebResponse webResponse = webR.GetResponse() as HttpWebResponse;
                string id = "";
                jsk:
                try
                {

                    str = GetHtml(rhon);
                }
                catch (Exception e)
                {
                    string vb = e.ToString();
                    if (vb.Contains("(404) Not Found"))
                    {
                        id = "Not_Available";
                        isIdNotRepeated.Add(id);
                        lb.Text = isIdNotRepeated.Count.ToString();
                        qvcp.Rows.Add(rhon,id);
                        WriteDataToFile(qvcp, outputPath);
                        goto psk;
                    }
                    if (vb.Contains("The connection was closed unexpectedly"))
                    {
                        id = "Not_Available";
                        isIdNotRepeated.Add(id);
                        lb.Text = isIdNotRepeated.Count.ToString();
                        qvcp.Rows.Add(rhon,id);
                        WriteDataToFile(qvcp, outputPath);
                        goto psk;
                    }
                    checkResult++;
                    if (checkResult > 500)
                    {
                        checkResult = 0;
                        unprocessedUrl.Add(rhon.Trim());
                        Ulb.Text = unprocessedUrl.Count.ToString();
                        System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
                        goto psk;
                    }
                }
                if (str == null || str == "")
                {

                    goto jsk;
                }
                if (checkResult >= 1)
                {
                    checkResult = 0;
                }
                str = str.Replace("®", "").Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");
                id = GetSubString("data-masterid=\"", "\">", str).Replace("Item #", "#");
                id = Regex.Replace(id, @" ?\<.*?\>", string.Empty);
                id = Regex.Replace(id, @"\s+", "");
                if (id == "")
                {
                    id = GetSubString("page_id: '", "',", str);
                }
                if (id == "")
                {
                    unprocessedUrl.Add("NO_ID" + rhon.Trim());
                    Ulb.Text = unprocessedUrl.Count.ToString();
                    System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
                    goto psk;
                }
                if (isIdNotRepeated.Contains(id))
                {
                    unprocessedUrl.Add("SAME_ID" + rhon.Trim());
                    Ulb.Text = unprocessedUrl.Count.ToString();
                    System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
                    goto psk;
                }
                else
                {
                    isIdNotRepeated.Add(id);
                }
                lb.Text = isIdNotRepeated.Count.ToString();
                string sku = "";
                sku = GetSubString("sku: '", "',", str);
                sku = Regex.Replace(sku, @" ?\<.*?\>", string.Empty);
                sku = Regex.Replace(sku, @"\s+", " ");
                string brand = GetSubString("\"brand\": \"", "\",", str);
                if (string.IsNullOrEmpty(brand)) {
                    // brand = GetSubString("desc-short\">", "</div>", str);
                }
                brand = Regex.Replace(brand, @" ?\<.*?\>", string.Empty);
                brand = Regex.Replace(brand, @"\s+", " ");
                string name = "";
                name = GetSubString("itemprop=\"name\">", "</div>", str);
                if (name == "")
                {
                    name = GetSubString("\"name\":\"", "\",", str);
                }
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                string price = "";
                string wasPrice = "";
                string typep = "";
                string rawPrice = GetSubString("<div class=\"product-price\">", "</div>", str);
                if (!string.IsNullOrEmpty(rawPrice))
                {
                    price = GetSubString("price-sales\">", "<", rawPrice);
                    wasPrice = GetSubString("txt--strike\">", "<", rawPrice);
                    wasPrice = Regex.Replace(wasPrice, @" ?\<.*?\>", string.Empty);
                    wasPrice = Regex.Replace(wasPrice, @"\s+", " ");
                }
                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                price = Regex.Replace(price, @"\s+", " ");
                string category = "";
                category = GetSubString("breadcrumb-list\">", "</div>", str).Replace("</a>", "::");
                category = Regex.Replace(category, @" ?\<.*?\>", string.Empty);
                category = Regex.Replace(category, @"\s+", " ");
                #region Old image Code
                //string rawImage = GetSubString("objDetailImageSwatchView", "</script>", str);
                //string mainImage = "";
                //string altImage = "";
                //string altImage1 = "";
                //string altImage2 = "";
                //if (!string.IsNullOrEmpty(rawImage))
                //{
                //    pattern = @"1"":[^>]*?""(.*?)""}";
                //    MatchCollection matches = Regex.Matches(rawImage, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //    foreach (Match match in matches)
                //    {
                //        if (match.Groups[1].Value.Contains("wid=1000"))
                //        {
                //            mainImage = match.Groups[1].Value;
                //        }
                //    }
                //    if (mainImage == "") {
                //        foreach (Match match in matches)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=480"))
                //            {
                //                mainImage = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    if (mainImage == "") {
                //        foreach (Match match in matches)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=446"))
                //            {
                //                mainImage = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    mainImage = Regex.Replace(mainImage, @" ?\<.*?\>", string.Empty);
                //    mainImage = Regex.Replace(mainImage, @"\s+", " ");
                //    pattern = @"2"":[^>]*?""(.*?)""}";
                //    MatchCollection matches2 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //    foreach (Match match in matches2)
                //    {
                //        if (match.Groups[1].Value.Contains("wid=1000"))
                //        {
                //            altImage = match.Groups[1].Value;
                //        }
                //    }
                //    if (altImage == "")
                //    {
                //        foreach (Match match in matches2)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=480"))
                //            {
                //                altImage = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    if (altImage == "")
                //    {
                //        foreach (Match match in matches2)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=446"))
                //            {
                //                altImage = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    altImage = Regex.Replace(altImage, @" ?\<.*?\>", string.Empty);
                //    altImage = Regex.Replace(altImage, @"\s+", " ");
                //    pattern = @"3"":[^>]*?""(.*?)""}";
                //    MatchCollection matches3 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //    foreach (Match match in matches3)
                //    {
                //        if (match.Groups[1].Value.Contains("wid=1000"))
                //        {
                //            altImage1 = match.Groups[1].Value;
                //        }
                //    }
                //    if (altImage1 == "")
                //    {
                //        foreach (Match match in matches3)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=480"))
                //            {
                //                altImage1 = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    if (altImage1 == "")
                //    {
                //        foreach (Match match in matches3)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=446"))
                //            {
                //                altImage1 = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    mainImage = Regex.Replace(mainImage, @" ?\<.*?\>", string.Empty);
                //    mainImage = Regex.Replace(mainImage, @"\s+", " ");
                //    pattern = @"4"":[^>]*?""(.*?)""}";
                //    MatchCollection matches4 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //    foreach (Match match in matches4)
                //    {
                //        if (match.Groups[1].Value.Contains("wid=1000"))
                //        {
                //            altImage2 = match.Groups[1].Value;
                //        }
                //    }
                //    if (altImage2 == "")
                //    {
                //        foreach (Match match in matches4)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=480"))
                //            {
                //                altImage2 = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    if (altImage2 == "")
                //    {
                //        foreach (Match match in matches4)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=446"))
                //            {
                //                altImage2 = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    altImage2 = Regex.Replace(altImage2, @" ?\<.*?\>", string.Empty);
                //    altImage2 = Regex.Replace(altImage2, @"\s+", " ");

                //}
                //if (string.IsNullOrEmpty(mainImage)) {
                //    string[] mainstr = Regex.Split(rawImage, "{\"");
                //    foreach (string sampu in mainstr) {
                //        if (!sampu.Contains("DetailImageSwatchView")) {
                //            if (sampu.Contains("wid=1000"))
                //            {
                //                mainImage = GetSubString("\":\"", "\"}", sampu);
                //            }
                //            else if (sampu.Contains("wid=480"))
                //            {
                //                mainImage = GetSubString("\":\"", "\"}", sampu);
                //            }
                //            else if (sampu.Contains("wid=446")) {
                //                mainImage = GetSubString("\":\"", "\"}", sampu);
                //            }
                //        }
                //    }
                //}
                #endregion
                string features = "";
                string description = "";
                description = GetSubString("description-content p--2\">", "</div>", str);
                features = GetSubString("<UL>", "</ul>", description).Replace("<li>", "|");
                features = Regex.Replace(features, @" ?\<.*?\>", string.Empty);
                features = WebUtility.HtmlDecode(features);
                features = Regex.Replace(features, @"\s+", " ");
                description = Regex.Replace(description, @" ?\<.*?\>", string.Empty);
                description = WebUtility.HtmlDecode(description);
                description = Regex.Replace(description, @"\s+", " ");
                #region old variation code
                //List<string> colorList = new List<string>();
                //List<string> sizeList = new List<string>();
                //List<string> AllSkusList = new List<string>();
                //string colorStr = GetSubString("Color\",\"options\":", "}}", str);
                //if (!string.IsNullOrEmpty(colorStr)) {
                //    pattern = @"iOptionPk"":[^>]*?""(.*?)"",";
                //    colorList.AddRange(MatchPattern(colorStr, pattern));
                //}
                //string sizeStr = GetSubString("sOptionTypeName\":\"Size", "}}", str);
                //if (!string.IsNullOrEmpty(sizeStr))
                //{
                //    pattern = @"iOptionPk"":[^>]*?""(.*?)"",";
                //    sizeList.AddRange(MatchPattern(sizeStr, pattern));
                //}
                //string allSkuStr = GetSubString("OptionSkus", "bDoMsgAvailNoSk", str);
                //if (!string.IsNullOrEmpty(allSkuStr))
                //{
                //    string[] allSkuList = Regex.Split(allSkuStr, "iSkuPk");
                //    foreach (string data in allSkuList) {
                //        if (data.Contains("skuOptions")) {
                //            AllSkusList.Add(data);
                //        }
                //    }
                //}
                //for (int i = 0; i < colorList.Count; i++) {

                //    if (str.IndexOf("data-mlcode=") > 0) {
                //        string rawcol = GetSubString("title='" + colorList[i], "mlkey", str);
                //        string colcode = GetSubString("mlcode=\"", "data", rawcol).Replace("\"", "");
                //        colcode = Regex.Replace(colcode, @"\s+", "");
                //        if (!string.IsNullOrEmpty(rawImage))
                //        {
                //            pattern = @"1"":[^>]*?""(.*?)"",""";
                //            pattern = "\""+colcode + ":" + pattern;
                //            MatchCollection matches = Regex.Matches(rawImage, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //            foreach (Match match in matches)
                //            {
                //                if (match.Groups[1].Value.Contains("wid=1000"))
                //                {
                //                    mainImage = match.Groups[1].Value;
                //                }
                //            }
                //            if (mainImage == "")
                //            {
                //                foreach (Match match in matches)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=480"))
                //                    {
                //                        mainImage = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            if (mainImage == "")
                //            {
                //                foreach (Match match in matches)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=446"))
                //                    {
                //                        mainImage = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            mainImage = Regex.Replace(mainImage, @" ?\<.*?\>", string.Empty);
                //            mainImage = Regex.Replace(mainImage, @"\s+", " ");
                //            pattern = @"alternative2"":[^>]*?""(.*?)"",""";
                //            pattern = "\"" + colcode + ":" + pattern;
                //            MatchCollection matches2 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //            foreach (Match match in matches2)
                //            {
                //                if (match.Groups[1].Value.Contains("wid=1000"))
                //                {
                //                    altImage = match.Groups[1].Value;
                //                }
                //            }
                //            if (altImage == "")
                //            {
                //                foreach (Match match in matches2)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=480"))
                //                    {
                //                        altImage = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            if (altImage == "")
                //            {
                //                foreach (Match match in matches2)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=446"))
                //                    {
                //                        altImage = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            altImage = Regex.Replace(altImage, @" ?\<.*?\>", string.Empty);
                //            altImage = Regex.Replace(altImage, @"\s+", " ");
                //            pattern = @"alternative3"":[^>]*?""(.*?)"",""";
                //            pattern = "\"" + colcode + ":" + pattern;
                //            MatchCollection matches3 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //            foreach (Match match in matches3)
                //            {
                //                if (match.Groups[1].Value.Contains("wid=1000"))
                //                {
                //                    altImage1 = match.Groups[1].Value;
                //                }
                //            }
                //            if (altImage1 == "")
                //            {
                //                foreach (Match match in matches3)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=480"))
                //                    {
                //                        altImage1 = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            if (altImage1 == "")
                //            {
                //                foreach (Match match in matches3)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=446"))
                //                    {
                //                        altImage1 = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            mainImage = Regex.Replace(mainImage, @" ?\<.*?\>", string.Empty);
                //            mainImage = Regex.Replace(mainImage, @"\s+", " ");
                //            pattern = @"alternative4"":[^>]*?""(.*?)"",""";
                //            pattern = "\"" + colcode + ":" + pattern;
                //            MatchCollection matches4 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //            foreach (Match match in matches4)
                //            {
                //                if (match.Groups[1].Value.Contains("wid=1000"))
                //                {
                //                    altImage2 = match.Groups[1].Value;
                //                }
                //            }
                //            if (altImage2 == "")
                //            {
                //                foreach (Match match in matches4)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=480"))
                //                    {
                //                        altImage2 = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            if (altImage2 == "")
                //            {
                //                foreach (Match match in matches4)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=446"))
                //                    {
                //                        altImage2 = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            altImage2 = Regex.Replace(altImage2, @" ?\<.*?\>", string.Empty);
                //            altImage2 = Regex.Replace(altImage2, @"\s+", " ");

                //        }

                //    }

                //    for (int j = 0; j < sizeList.Count; j++)
                //    {

                //        bool IsFound = false;
                //        string stck = "";
                //        string prc = "";
                //        string varSKu = "";
                //        string siz = GetSubString(sizeList[j] + "\",\"sOptionName\":\"", "\",\"sShown", str);
                //        string col = GetSubString(colorList[i] + "\",\"sOptionName\":\"", "\",\"sShown", str);
                //        foreach (string sample in AllSkusList) {

                //            if (sample.Contains(colorList[i]) && sample.Contains(sizeList[j]))
                //            {
                //                IsFound = true;
                //                varSKu = GetSubString("\":\"", "\",", sample);
                //                stck = GetSubString("\"inStock\":", ",\"", sample);
                //                if (stck == "true")
                //                {
                //                    stck = "In Stock";
                //                }
                //                else if (stck == "false") {
                //                    stck = "Out Of Stock";
                //                }
                //                prc = GetSubString("skuPrice\":\"", "\"}", sample);
                //                qvcp.Rows.Add(rhon,id, sku, brand, name,string.IsNullOrEmpty(prc)?price:prc, wasPrice, category, mainImage, altImage, altImage1, altImage2, features, varSKu, colorList[i],sizeList[j],stck, col, siz);
                //                WriteDataToFile(qvcp,outputPath);
                //                break;
                //            }
                //        }
                //        if (!IsFound) {
                //            stck = "Out Of Stock";
                //            qvcp.Rows.Add(rhon,id, sku, brand, name, string.IsNullOrEmpty(prc) ? price : prc, wasPrice, category, mainImage, altImage, altImage1, altImage2, features, varSKu,colorList[i],sizeList[j],stck, col, siz);
                //            WriteDataToFile(qvcp,outputPath);

                //        }
                //    }
                //}
                #endregion
                int varCount = 0;
                string stock = "";
                string color = "";
                string size = "";
                string colorCode = "";
                string sizeCode = "";
                bool sizeIndex = str.IndexOf("Select Size") > 0;
                bool colorIndex = str.IndexOf("Select Color") > 0;
                colorList.Clear();
                sizeList.Clear();
                clearRaw();
                colorList.AddRange(extractColors(str));
                sizeList.AddRange(extractSizes(str));
                if (sizeIndex && colorIndex)
                {
                    if (sizeList.Count == 1 && colorList.Count == 1)
                    {
                        getImages(str);
                        color = GetSubString("Select Color:", "\"", str);
                        size = GetSubString(">Select Size", "</select>", str);
                        size = Regex.Replace(size, @"\s+", " ");
                        size = Regex.Replace(size, @" ?\<.*?\>", string.Empty);
                        size = Regex.Replace(size, @"\s+", " ");
                        stock = getStock(str);
                    }
                    else
                    {
                        foreach (string colordata in colorList)
                        {
                            string[] colorinfo = colordata.Split('_');
                            foreach (string sizedata in sizeList)
                            {
                                string[] sizeinfo = sizedata.Split('_');
                                string varStr = GetHtml(getajaxUrl(id, colorinfo[0], sizeinfo[0]));
                                sku = GetSubString("pid\" value=\"", "\" />", varStr);
                                rawPrice = GetSubString("<div class=\"product-price\">", "</div>", varStr);
                                if (!string.IsNullOrEmpty(rawPrice))
                                {
                                    price = GetSubString("price-sales\">", "<", rawPrice);
                                    wasPrice = GetSubString("txt--strike\">", "<", rawPrice);
                                    wasPrice = Regex.Replace(wasPrice, @" ?\<.*?\>", string.Empty);
                                    wasPrice = Regex.Replace(wasPrice, @"\s+", " ");
                                }
                                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                                price = Regex.Replace(price, @"\s+", " ");
                                stock = getStock(varStr);
                                color = colorinfo[1];
                                size = sizeinfo[1];
                                colorCode = colorinfo[0];
                                sizeCode = sizeinfo[0];
                                getImages(varStr);
                                qvcp.Rows.Add(rhon,id,string.IsNullOrEmpty(sku) ? "" :"#"+sku, brand, name, price, wasPrice, category, image1, image2, image3, image4, features, stock, Stockquantity,colorCode,sizeCode,color, size);
                                WriteDataToFile(qvcp, outputPath);
                                varCount++;
                                clb.Text = varCount.ToString();
                            }
                        }
                        goto psk;
                    }
                }
                else if (sizeIndex)
                {
                    if (sizeList.Count == 1)
                    {
                        size = GetSubString(">Select Size", "</select>", str);
                        size = Regex.Replace(size, @"\s+", " ");
                        size = Regex.Replace(size, @" ?\<.*?\>", string.Empty);
                        size = Regex.Replace(size, @"\s+", " ");
                        sizeCode = GetSubString("_size=", "&dwvar_", str);
                        sizeCode = Regex.Replace(sizeCode, @"\s+", " ");
                        sizeCode = Regex.Replace(sizeCode, @" ?\<.*?\>", string.Empty);
                        sizeCode = Regex.Replace(sizeCode, @"\s+", " ");
                        stock = getStock(str);
                        
                    }
                    else
                    {
                        stock = "Multiple Sizes";
                    }
                }
                else if (colorIndex)
                {
                    if (colorList.Count == 1)
                    {
                        getImages(str);
                        color = GetSubString("Select Color:", "\"", str);
                        colorCode = GetSubString("_color=", "&dwvar_", str);
                        colorCode = Regex.Replace(colorCode, @" ?\<.*?\>", string.Empty);
                        colorCode = Regex.Replace(colorCode, @"\s+", " ");
                        stock = getStock(str);
                    }
                    else
                    {
                        stock = "Multiple Colors";
                    }
                }
                else
                {
                    getImages(str);
                    stock = getStock(str);
                }
                qvcp.Rows.Add(rhon,id, string.IsNullOrEmpty(sku) ? "" : "#" + sku, brand, name,price, wasPrice, category, image1, image2, image3, image4, features,stock,Stockquantity,colorCode,sizeCode,color, size);
                WriteDataToFile(qvcp,outputPath);
                varCount++;
                clb.Text = varCount.ToString();
                psk:
                str = null;
            };

        }
        public static void stock(List<string> yogesh)
        {
            Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
            clb.Visible = true;
            // uris.Add(new Uri("http://www.bing.com"));

            //  try
            //{




            //}
            //catch (AggregateException exc)
            //{
            //  exc.InnerExceptions.ToList().ForEach(ez =>
            //{
            //  Console.WriteLine(ez.Message);
            //});
            //}
            foreach (string potter in yogesh)
            {
                string rhon = Regex.Replace("https://www.modells.com/search?q=" + potter + "&lang=default", @"\t|\n|\r", "");

                //  WebRequest webR = HttpWebRequest.Create(u);
                //.HttpWebResponse webResponse = webR.GetResponse() as HttpWebResponse;
                string id = "";
                jsk:
                try
                {

                    str = GetHtml(rhon);
                    string url1 = GetSubString("productURL = \"", "\";", str);

                    id = "Not_Available";
                    isIdNotRepeated.Add(id);
                    lb.Text = isIdNotRepeated.Count.ToString();
                    qvcp.Rows.Add(url1, potter);
                    WriteDataToFile(qvcp, outputPath);
                    goto psk;
                }
                catch (Exception e)
                {
                    string vb = e.ToString();
                    if (vb.Contains("(404) Not Found"))
                    {
                        id = "Not_Available";
                        isIdNotRepeated.Add(id);
                        lb.Text = isIdNotRepeated.Count.ToString();
                        qvcp.Rows.Add(rhon, id);
                        WriteDataToFile(qvcp, outputPath);
                        goto psk;
                    }
                    if (vb.Contains("The connection was closed unexpectedly"))
                    {
                        id = "Not_Available";
                        isIdNotRepeated.Add(id);
                        lb.Text = isIdNotRepeated.Count.ToString();
                        qvcp.Rows.Add(rhon, id);
                        WriteDataToFile(qvcp, outputPath);
                        goto psk;
                    }
                    checkResult++;
                    if (checkResult > 500)
                    {
                        checkResult = 0;
                        unprocessedUrl.Add(rhon.Trim());
                        Ulb.Text = unprocessedUrl.Count.ToString();
                        System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
                        goto psk;
                    }
                }
                if (str == null || str == "")
                {

                    goto jsk;
                }
                if (checkResult >= 1)
                {
                    checkResult = 0;
                }
                str = str.Replace("®", "").Replace("\\u0026", "&").Replace("\\u0027", "").Replace("&quot;", "\"").Replace("&amp;", "&").Replace("&nbsp;", "").Replace("â€“", "-").Replace("#x09;", "");
                id = GetSubString("data-masterid=\"", "\">", str).Replace("Item #", "#");
                id = Regex.Replace(id, @" ?\<.*?\>", string.Empty);
                id = Regex.Replace(id, @"\s+", "");
                if (id == "")
                {
                    id = GetSubString("page_id: '", "',", str);
                }
                if (id == "")
                {
                    unprocessedUrl.Add("NO_ID" + rhon.Trim());
                    Ulb.Text = unprocessedUrl.Count.ToString();
                    System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
                    goto psk;
                }
                if (isIdNotRepeated.Contains(id))
                {
                    unprocessedUrl.Add("SAME_ID" + rhon.Trim());
                    Ulb.Text = unprocessedUrl.Count.ToString();
                    System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
                    goto psk;
                }
                else
                {
                    isIdNotRepeated.Add(id);
                }
                lb.Text = isIdNotRepeated.Count.ToString();
                string sku = "";
                sku = GetSubString("sku: '", "',", str);
                sku = Regex.Replace(sku, @" ?\<.*?\>", string.Empty);
                sku = Regex.Replace(sku, @"\s+", " ");
                string brand = GetSubString("\"brand\": \"", "\",", str);
                if (string.IsNullOrEmpty(brand))
                {
                    // brand = GetSubString("desc-short\">", "</div>", str);
                }
                brand = Regex.Replace(brand, @" ?\<.*?\>", string.Empty);
                brand = Regex.Replace(brand, @"\s+", " ");
                string name = "";
                name = GetSubString("itemprop=\"name\">", "</div>", str);
                if (name == "")
                {
                    name = GetSubString("\"name\":\"", "\",", str);
                }
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                string price = "";
                string wasPrice = "";
                string typep = "";
                string rawPrice = GetSubString("<div class=\"product-price\">", "</div>", str);
                if (!string.IsNullOrEmpty(rawPrice))
                {
                    price = GetSubString("price-sales\">", "<", rawPrice);
                    wasPrice = GetSubString("txt--strike\">", "<", rawPrice);
                    wasPrice = Regex.Replace(wasPrice, @" ?\<.*?\>", string.Empty);
                    wasPrice = Regex.Replace(wasPrice, @"\s+", " ");
                }
                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                price = Regex.Replace(price, @"\s+", " ");
                string category = "";
                category = GetSubString("breadcrumb-list\">", "</div>", str).Replace("</a>", "::");
                category = Regex.Replace(category, @" ?\<.*?\>", string.Empty);
                category = Regex.Replace(category, @"\s+", " ");
                #region Old image Code
                //string rawImage = GetSubString("objDetailImageSwatchView", "</script>", str);
                //string mainImage = "";
                //string altImage = "";
                //string altImage1 = "";
                //string altImage2 = "";
                //if (!string.IsNullOrEmpty(rawImage))
                //{
                //    pattern = @"1"":[^>]*?""(.*?)""}";
                //    MatchCollection matches = Regex.Matches(rawImage, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //    foreach (Match match in matches)
                //    {
                //        if (match.Groups[1].Value.Contains("wid=1000"))
                //        {
                //            mainImage = match.Groups[1].Value;
                //        }
                //    }
                //    if (mainImage == "") {
                //        foreach (Match match in matches)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=480"))
                //            {
                //                mainImage = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    if (mainImage == "") {
                //        foreach (Match match in matches)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=446"))
                //            {
                //                mainImage = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    mainImage = Regex.Replace(mainImage, @" ?\<.*?\>", string.Empty);
                //    mainImage = Regex.Replace(mainImage, @"\s+", " ");
                //    pattern = @"2"":[^>]*?""(.*?)""}";
                //    MatchCollection matches2 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //    foreach (Match match in matches2)
                //    {
                //        if (match.Groups[1].Value.Contains("wid=1000"))
                //        {
                //            altImage = match.Groups[1].Value;
                //        }
                //    }
                //    if (altImage == "")
                //    {
                //        foreach (Match match in matches2)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=480"))
                //            {
                //                altImage = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    if (altImage == "")
                //    {
                //        foreach (Match match in matches2)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=446"))
                //            {
                //                altImage = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    altImage = Regex.Replace(altImage, @" ?\<.*?\>", string.Empty);
                //    altImage = Regex.Replace(altImage, @"\s+", " ");
                //    pattern = @"3"":[^>]*?""(.*?)""}";
                //    MatchCollection matches3 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //    foreach (Match match in matches3)
                //    {
                //        if (match.Groups[1].Value.Contains("wid=1000"))
                //        {
                //            altImage1 = match.Groups[1].Value;
                //        }
                //    }
                //    if (altImage1 == "")
                //    {
                //        foreach (Match match in matches3)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=480"))
                //            {
                //                altImage1 = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    if (altImage1 == "")
                //    {
                //        foreach (Match match in matches3)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=446"))
                //            {
                //                altImage1 = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    mainImage = Regex.Replace(mainImage, @" ?\<.*?\>", string.Empty);
                //    mainImage = Regex.Replace(mainImage, @"\s+", " ");
                //    pattern = @"4"":[^>]*?""(.*?)""}";
                //    MatchCollection matches4 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //    foreach (Match match in matches4)
                //    {
                //        if (match.Groups[1].Value.Contains("wid=1000"))
                //        {
                //            altImage2 = match.Groups[1].Value;
                //        }
                //    }
                //    if (altImage2 == "")
                //    {
                //        foreach (Match match in matches4)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=480"))
                //            {
                //                altImage2 = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    if (altImage2 == "")
                //    {
                //        foreach (Match match in matches4)
                //        {
                //            if (match.Groups[1].Value.Contains("wid=446"))
                //            {
                //                altImage2 = match.Groups[1].Value;
                //            }
                //        }
                //    }
                //    altImage2 = Regex.Replace(altImage2, @" ?\<.*?\>", string.Empty);
                //    altImage2 = Regex.Replace(altImage2, @"\s+", " ");

                //}
                //if (string.IsNullOrEmpty(mainImage)) {
                //    string[] mainstr = Regex.Split(rawImage, "{\"");
                //    foreach (string sampu in mainstr) {
                //        if (!sampu.Contains("DetailImageSwatchView")) {
                //            if (sampu.Contains("wid=1000"))
                //            {
                //                mainImage = GetSubString("\":\"", "\"}", sampu);
                //            }
                //            else if (sampu.Contains("wid=480"))
                //            {
                //                mainImage = GetSubString("\":\"", "\"}", sampu);
                //            }
                //            else if (sampu.Contains("wid=446")) {
                //                mainImage = GetSubString("\":\"", "\"}", sampu);
                //            }
                //        }
                //    }
                //}
                #endregion
                string features = "";
                string description = "";
                description = GetSubString("description-content p--2\">", "</div>", str);
                features = GetSubString("<UL>", "</ul>", description).Replace("<li>", "|");
                features = Regex.Replace(features, @" ?\<.*?\>", string.Empty);
                features = WebUtility.HtmlDecode(features);
                features = Regex.Replace(features, @"\s+", " ");
                description = Regex.Replace(description, @" ?\<.*?\>", string.Empty);
                description = WebUtility.HtmlDecode(description);
                description = Regex.Replace(description, @"\s+", " ");
                #region old variation code
                //List<string> colorList = new List<string>();
                //List<string> sizeList = new List<string>();
                //List<string> AllSkusList = new List<string>();
                //string colorStr = GetSubString("Color\",\"options\":", "}}", str);
                //if (!string.IsNullOrEmpty(colorStr)) {
                //    pattern = @"iOptionPk"":[^>]*?""(.*?)"",";
                //    colorList.AddRange(MatchPattern(colorStr, pattern));
                //}
                //string sizeStr = GetSubString("sOptionTypeName\":\"Size", "}}", str);
                //if (!string.IsNullOrEmpty(sizeStr))
                //{
                //    pattern = @"iOptionPk"":[^>]*?""(.*?)"",";
                //    sizeList.AddRange(MatchPattern(sizeStr, pattern));
                //}
                //string allSkuStr = GetSubString("OptionSkus", "bDoMsgAvailNoSk", str);
                //if (!string.IsNullOrEmpty(allSkuStr))
                //{
                //    string[] allSkuList = Regex.Split(allSkuStr, "iSkuPk");
                //    foreach (string data in allSkuList) {
                //        if (data.Contains("skuOptions")) {
                //            AllSkusList.Add(data);
                //        }
                //    }
                //}
                //for (int i = 0; i < colorList.Count; i++) {

                //    if (str.IndexOf("data-mlcode=") > 0) {
                //        string rawcol = GetSubString("title='" + colorList[i], "mlkey", str);
                //        string colcode = GetSubString("mlcode=\"", "data", rawcol).Replace("\"", "");
                //        colcode = Regex.Replace(colcode, @"\s+", "");
                //        if (!string.IsNullOrEmpty(rawImage))
                //        {
                //            pattern = @"1"":[^>]*?""(.*?)"",""";
                //            pattern = "\""+colcode + ":" + pattern;
                //            MatchCollection matches = Regex.Matches(rawImage, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //            foreach (Match match in matches)
                //            {
                //                if (match.Groups[1].Value.Contains("wid=1000"))
                //                {
                //                    mainImage = match.Groups[1].Value;
                //                }
                //            }
                //            if (mainImage == "")
                //            {
                //                foreach (Match match in matches)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=480"))
                //                    {
                //                        mainImage = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            if (mainImage == "")
                //            {
                //                foreach (Match match in matches)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=446"))
                //                    {
                //                        mainImage = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            mainImage = Regex.Replace(mainImage, @" ?\<.*?\>", string.Empty);
                //            mainImage = Regex.Replace(mainImage, @"\s+", " ");
                //            pattern = @"alternative2"":[^>]*?""(.*?)"",""";
                //            pattern = "\"" + colcode + ":" + pattern;
                //            MatchCollection matches2 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //            foreach (Match match in matches2)
                //            {
                //                if (match.Groups[1].Value.Contains("wid=1000"))
                //                {
                //                    altImage = match.Groups[1].Value;
                //                }
                //            }
                //            if (altImage == "")
                //            {
                //                foreach (Match match in matches2)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=480"))
                //                    {
                //                        altImage = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            if (altImage == "")
                //            {
                //                foreach (Match match in matches2)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=446"))
                //                    {
                //                        altImage = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            altImage = Regex.Replace(altImage, @" ?\<.*?\>", string.Empty);
                //            altImage = Regex.Replace(altImage, @"\s+", " ");
                //            pattern = @"alternative3"":[^>]*?""(.*?)"",""";
                //            pattern = "\"" + colcode + ":" + pattern;
                //            MatchCollection matches3 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //            foreach (Match match in matches3)
                //            {
                //                if (match.Groups[1].Value.Contains("wid=1000"))
                //                {
                //                    altImage1 = match.Groups[1].Value;
                //                }
                //            }
                //            if (altImage1 == "")
                //            {
                //                foreach (Match match in matches3)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=480"))
                //                    {
                //                        altImage1 = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            if (altImage1 == "")
                //            {
                //                foreach (Match match in matches3)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=446"))
                //                    {
                //                        altImage1 = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            mainImage = Regex.Replace(mainImage, @" ?\<.*?\>", string.Empty);
                //            mainImage = Regex.Replace(mainImage, @"\s+", " ");
                //            pattern = @"alternative4"":[^>]*?""(.*?)"",""";
                //            pattern = "\"" + colcode + ":" + pattern;
                //            MatchCollection matches4 = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                //            foreach (Match match in matches4)
                //            {
                //                if (match.Groups[1].Value.Contains("wid=1000"))
                //                {
                //                    altImage2 = match.Groups[1].Value;
                //                }
                //            }
                //            if (altImage2 == "")
                //            {
                //                foreach (Match match in matches4)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=480"))
                //                    {
                //                        altImage2 = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            if (altImage2 == "")
                //            {
                //                foreach (Match match in matches4)
                //                {
                //                    if (match.Groups[1].Value.Contains("wid=446"))
                //                    {
                //                        altImage2 = match.Groups[1].Value;
                //                    }
                //                }
                //            }
                //            altImage2 = Regex.Replace(altImage2, @" ?\<.*?\>", string.Empty);
                //            altImage2 = Regex.Replace(altImage2, @"\s+", " ");

                //        }

                //    }

                //    for (int j = 0; j < sizeList.Count; j++)
                //    {

                //        bool IsFound = false;
                //        string stck = "";
                //        string prc = "";
                //        string varSKu = "";
                //        string siz = GetSubString(sizeList[j] + "\",\"sOptionName\":\"", "\",\"sShown", str);
                //        string col = GetSubString(colorList[i] + "\",\"sOptionName\":\"", "\",\"sShown", str);
                //        foreach (string sample in AllSkusList) {

                //            if (sample.Contains(colorList[i]) && sample.Contains(sizeList[j]))
                //            {
                //                IsFound = true;
                //                varSKu = GetSubString("\":\"", "\",", sample);
                //                stck = GetSubString("\"inStock\":", ",\"", sample);
                //                if (stck == "true")
                //                {
                //                    stck = "In Stock";
                //                }
                //                else if (stck == "false") {
                //                    stck = "Out Of Stock";
                //                }
                //                prc = GetSubString("skuPrice\":\"", "\"}", sample);
                //                qvcp.Rows.Add(rhon,id, sku, brand, name,string.IsNullOrEmpty(prc)?price:prc, wasPrice, category, mainImage, altImage, altImage1, altImage2, features, varSKu, colorList[i],sizeList[j],stck, col, siz);
                //                WriteDataToFile(qvcp,outputPath);
                //                break;
                //            }
                //        }
                //        if (!IsFound) {
                //            stck = "Out Of Stock";
                //            qvcp.Rows.Add(rhon,id, sku, brand, name, string.IsNullOrEmpty(prc) ? price : prc, wasPrice, category, mainImage, altImage, altImage1, altImage2, features, varSKu,colorList[i],sizeList[j],stck, col, siz);
                //            WriteDataToFile(qvcp,outputPath);

                //        }
                //    }
                //}
                #endregion
                int varCount = 0;
                string stock = "";
                string color = "";
                string size = "";
                string colorCode = "";
                string sizeCode = "";
                bool sizeIndex = str.IndexOf("Select Size") > 0;
                bool colorIndex = str.IndexOf("Select Color") > 0;
                colorList.Clear();
                sizeList.Clear();
                clearRaw();
                colorList.AddRange(extractColors(str));
                sizeList.AddRange(extractSizes(str));
                if (sizeIndex && colorIndex)
                {
                    if (sizeList.Count == 1 && colorList.Count == 1)
                    {
                        getImages(str);
                        color = GetSubString("Select Color:", "\"", str);
                        size = GetSubString(">Select Size", "</select>", str);
                        size = Regex.Replace(size, @"\s+", " ");
                        size = Regex.Replace(size, @" ?\<.*?\>", string.Empty);
                        size = Regex.Replace(size, @"\s+", " ");
                        stock = getStock(str);
                    }
                    else
                    {
                        foreach (string colordata in colorList)
                        {
                            string[] colorinfo = colordata.Split('_');
                            foreach (string sizedata in sizeList)
                            {
                                string[] sizeinfo = sizedata.Split('_');
                                string varStr = GetHtml(getajaxUrl(id, colorinfo[0], sizeinfo[0]));
                                sku = GetSubString("pid\" value=\"", "\" />", varStr);
                                rawPrice = GetSubString("<div class=\"product-price\">", "</div>", varStr);
                                if (!string.IsNullOrEmpty(rawPrice))
                                {
                                    price = GetSubString("price-sales\">", "<", rawPrice);
                                    wasPrice = GetSubString("txt--strike\">", "<", rawPrice);
                                    wasPrice = Regex.Replace(wasPrice, @" ?\<.*?\>", string.Empty);
                                    wasPrice = Regex.Replace(wasPrice, @"\s+", " ");
                                }
                                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                                price = Regex.Replace(price, @"\s+", " ");
                                stock = getStock(varStr);
                                color = colorinfo[1];
                                size = sizeinfo[1];
                                colorCode = colorinfo[0];
                                sizeCode = sizeinfo[0];
                                getImages(varStr);
                                qvcp.Rows.Add(rhon, id, string.IsNullOrEmpty(sku) ? "" : "#" + sku, brand, name, price, wasPrice, category, image1, image2, image3, image4, features, stock, Stockquantity, colorCode, sizeCode, color, size);
                                WriteDataToFile(qvcp, outputPath);
                                varCount++;
                                clb.Text = varCount.ToString();
                            }
                        }
                        goto psk;
                    }
                }
                else if (sizeIndex)
                {
                    if (sizeList.Count == 1)
                    {
                        size = GetSubString(">Select Size", "</select>", str);
                        size = Regex.Replace(size, @"\s+", " ");
                        size = Regex.Replace(size, @" ?\<.*?\>", string.Empty);
                        size = Regex.Replace(size, @"\s+", " ");
                        sizeCode = GetSubString("_size=", "&dwvar_", str);
                        sizeCode = Regex.Replace(sizeCode, @"\s+", " ");
                        sizeCode = Regex.Replace(sizeCode, @" ?\<.*?\>", string.Empty);
                        sizeCode = Regex.Replace(sizeCode, @"\s+", " ");
                        stock = getStock(str);

                    }
                    else
                    {
                        stock = "Multiple Sizes";
                    }
                }
                else if (colorIndex)
                {
                    if (colorList.Count == 1)
                    {
                        getImages(str);
                        color = GetSubString("Select Color:", "\"", str);
                        colorCode = GetSubString("_color=", "&dwvar_", str);
                        colorCode = Regex.Replace(colorCode, @" ?\<.*?\>", string.Empty);
                        colorCode = Regex.Replace(colorCode, @"\s+", " ");
                        stock = getStock(str);
                    }
                    else
                    {
                        stock = "Multiple Colors";
                    }
                }
                else
                {
                    getImages(str);
                    stock = getStock(str);
                }
                qvcp.Rows.Add(rhon, id, string.IsNullOrEmpty(sku) ? "" : "#" + sku, brand, name, price, wasPrice, category, image1, image2, image3, image4, features, stock, Stockquantity, colorCode, sizeCode, color, size);
                WriteDataToFile(qvcp, outputPath);
                varCount++;
                clb.Text = varCount.ToString();
                psk:
                str = null;
            };

        }
        //public static void stock(List<string> yogesh)
        //{
        //    Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
        //    Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
        //    Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
        //    Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();

        //    foreach (string rhon in yogesh)
        //    {
        //        string id = "";

        //        jsk:
        //        try
        //        {

        //            str = GetHtml(rhon);
        //        }
        //        catch (Exception e)
        //        {
        //            string vb = e.ToString();
        //            if (vb.Contains("(404) Not Found"))
        //            {
        //                id = "Not_Available";
        //                unprocessedUrl.Add("x");
        //                Plb.Text = unprocessedUrl.Count.ToString();
        //                qvcp.Rows.Add(id, rhon);
        //                WriteDataToFile(qvcp, outputPath);
        //                goto psk;
        //            }
        //            checkResult++;
        //            if (checkResult > 500)
        //            {
        //                checkResult = 0;
        //                unprocessedUrl.Add(rhon.Trim());
        //                Ulb.Text = unprocessedUrl.Count.ToString();
        //                System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
        //                goto psk;
        //            }
        //        }
        //        if (str == null || str == "")
        //        {

        //            goto jsk;
        //        }
        //        if (checkResult >= 1)
        //        {
        //            checkResult = 0;
        //        }
        //        id = GetSubString("\"itemProductID\":\"", "\",", str);
        //        if (id == "")
        //        {
        //            id = GetSubString("br_data.prod_id = \"", "\";", str);
        //        }
        //        if (id == "")
        //        {
        //            unprocessedUrl.Add("NO_ID" + rhon.Trim());
        //            Ulb.Text = unprocessedUrl.Count.ToString();
        //            System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
        //            goto psk;
        //        }
        //        if (isIdNotRepeated.Contains(id))
        //        {
        //            unprocessedUrl.Add("SAME_ID" + rhon.Trim());
        //            Ulb.Text = unprocessedUrl.Count.ToString();
        //            System.IO.File.WriteAllLines(unprocessedPath, unprocessedUrl);
        //            goto psk;
        //        }
        //        else
        //        {
        //            isIdNotRepeated.Add(id);
        //        }
        //        lb.Text = isIdNotRepeated.Count.ToString();
        //        id = Regex.Replace(id, @" ?\<.*?\>", string.Empty);
        //        id = Regex.Replace(id, @"\s+", "");
        //        string name = "";
        //        name = GetSubString("<h1 class=\"title productTitleName\">", "</h1>", str);
        //        if (name == "")
        //        {
        //            name = GetSubString("\"itemName\":\"", "\",", str);
        //        }
        //        name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
        //        name = Regex.Replace(name, @"\s+", " ");
        //        string price = "";
        //        string typep = "";
        //        price = GetSubString("br_data.sale_price = \"", "\";", str);
        //        if (price == "")
        //        {
        //            price = GetSubString("<span class=\"price_label\">", "</div>", str).Replace("Regular", "").Replace("Sale", "");
        //        }
        //        price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
        //        price = Regex.Replace(price, @"\s+", " ");
        //        if (str.IndexOf("<span class=\"price_label\">Sale") > 0)
        //        {
        //            typep = "SALE";
        //        }
        //        else if (str.IndexOf("<span class=\"price_label\">Regular") > 0)
        //        {
        //            typep = "REGULAR";
        //        }
        //        string upc = "";
        //        upc = GetSubString("UpcCode\" value=\"", "\"/>", str);
        //        if (upc != "")
        //        {
        //            upc = "#" + upc;
        //        }
        //        string parantage = "";
        //        string color = "";
        //        string size = "";
        //        string childsku = "";
        //        string stock = "";
        //        string vartype = "";
        //        string cv = GetSubString("\"itemIsInStock\":\"", "}", str).Replace("\"", "");
        //        cv = Regex.Replace(cv, @" ?\<.*?\>", string.Empty);
        //        cv = Regex.Replace(cv, @"\s+", " ");
        //        if (cv != "")
        //        {
        //            if (cv.Contains("true"))
        //            {
        //                stock = "In_Stock";
        //            }
        //            else if (cv.Contains("false"))
        //            {
        //                stock = "Out_Of_Stock";
        //            }
        //        }
        //        parantage = "Individual";
        //        string SKU = GetSubString("\"variants\" : [", "]", str);
        //        SKU = Regex.Replace(SKU, @"\s+", " ");
        //        if (SKU != "")
        //        {
        //            string[] skul = Regex.Split(SKU, "},");
        //            if (skul.Count() >= 1)
        //            {
        //                skul = skul.Take(skul.Count() - 1).ToArray();
        //                if (skul.Count() == 1)
        //                {
        //                    parantage = "Individual";
        //                }
        //                else
        //                {
        //                    parantage = "Child";
        //                }
        //                foreach (string jack in skul)
        //                {
        //                    if (jack == "")
        //                    {
        //                        if (str.IndexOf("<div id=\"suppressed_message_default\" class=\"suppressed defaultsuppressed\"") > 0)
        //                        {
        //                            price = "For_Price_Add_To_Bag";
        //                        }
        //                        qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
        //                        //  lab6show(qvcp);
        //                        WriteDataToFile(qvcp, outputPath);
        //                    }
        //                    else
        //                    {
        //                        upc = GetSubString("\"skuUpcCode\":\"", "\",", jack);
        //                        upc = Regex.Replace(upc, @" ?\<.*?\>", string.Empty);
        //                        upc = Regex.Replace(upc, @"\s+", " ");
        //                        if (upc != "")
        //                        {
        //                            upc = "#" + upc;
        //                        }
        //                        if (str.IndexOf("<div class=\"colorblock\">") > 0)
        //                        {
        //                            color = GetSubString("\"color\":\"T" + id + "_", "\",", jack);
        //                        }
        //                        if (str.IndexOf("<div class=\"size-holder\">") > 0)
        //                        {
        //                            size = GetSubString("\"size2\":\"T" + id + "_", "\",", jack).Replace("_waist", "");
        //                        }

        //                        childsku = GetSubString("\"skuId\":\"", "\",", jack);
        //                        string inven = GetSubString("\"inventoryStatus\":\"", "\",", jack);
        //                        if (inven == "true")
        //                        {
        //                            stock = "In_Stock";
        //                        }
        //                        else
        //                        {
        //                            stock = "Check_manually";
        //                        }
        //                        string pp = GetSubString("\"SkuSalePrice\":\"", "\",", jack);
        //                        if (pp != "")
        //                        {
        //                            typep = "SALE";
        //                        }
        //                        if (pp.Contains("|"))
        //                        {
        //                            pp = GetSubString("\"SkuSalePrice\":\"", "|", jack);
        //                        }
        //                        if (pp == "")
        //                        {
        //                            pp = GetSubString("\"SkuRegularPrice\":\"", "\",", jack);
        //                            if (pp != "")
        //                            {
        //                                typep = "REGULAR";
        //                            }
        //                        }
        //                        if (pp.Contains("|"))
        //                        {
        //                            pp = GetSubString("\"SkuRegularPrice\":\"", "|", jack);
        //                        }
        //                        if (pp != "")
        //                        {
        //                            price = pp;
        //                        }
        //                        if (color != "" && size != "")
        //                        {
        //                            color = "#" + color;
        //                            size = "#" + size;
        //                            vartype = "Color|Size";
        //                        }
        //                        else if (color != "" && size == "")
        //                        {
        //                            color = "#" + color;
        //                            vartype = "Color";
        //                        }
        //                        else if (color == "" && size != "")
        //                        {
        //                            size = "#" + size;
        //                            vartype = "Size";
        //                        }

        //                        qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
        //                        //  lab6show(qvcp);
        //                        WriteDataToFile(qvcp, outputPath);
        //                    }


        //                }

        //            }


        //        }
        //        else
        //        {

        //            qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
        //            //  lab6show(qvcp);
        //            WriteDataToFile(qvcp, outputPath);
        //        }
        //        psk:
        //        str = null;
        //    }
        //}
        public static List<string> extractColors(string str)
        {
            string pattern = @"<a class=""swatchanchor[^>]*?""(.*?)</div>";
            rawData.AddRange(Common.MatchPattern(str, pattern));
            foreach (string data in rawData) {
                string colorCode = GetSubString("_color=", "\"", data);
                string colorValue = GetSubString("Color:", "\"", data);
                outputData.Add(colorCode + "_" + colorValue);
            }
            return outputData;

        }
        public static List<string> extractSizes(string str)
        {
            clearRaw();
            rawDataString = GetSubString(">Select Size", "</div>", str);
            pattern = @"<optio[^>]*?n(.*?)</option>";
            rawData.AddRange(Common.MatchPattern(rawDataString, pattern));
            foreach (string data in rawData)
            {
                string sizeCode = GetSubString("_size=", "&source", data);
                string sizeValue = "<" + data;
                sizeValue = Regex.Replace(sizeValue, @" ?\<.*?\>", string.Empty);
                sizeValue = Regex.Replace(sizeValue, @"\s+", " ");
                outputData.Add(sizeCode + "_" + sizeValue);
            }
            return outputData;
        }
        public static void clearRaw() {
            rawData.Clear();
            outputData.Clear();
            rawDataString = "";
        }
        public static string getajaxUrl(string id, string color, string size) {
            return "https://www.modells.com/on/demandware.store/Sites-Modells-Site/default/Product-Variation?pid=" + id + "&dwvar_" + id +
                               "_color=" + color + "&dwvar_" + id + "_size=" + size + "&source=detail&Quantity=1&format=ajax&productlistid=undefined";
        }
        public static void getImages(string str) {
            clearRaw();
            string pattern = @"pdp__thumb-item"" tabindex=""0""[^>]*?>(.*?)</div>";
            rawData.AddRange(Common.MatchPattern(str, pattern));
            foreach (string data in rawData)
            {
                string img = GetSubString("src=\"", "\" alt", data);
                img = str.IndexOf(">Zoom<") > 0 ? img.Replace("sw=51", "sw=975").Replace("sh=51", "sh=990") : img.Replace("sw=51", "sw=500").Replace("sh=51", "sh=500");
                outputData.Add(img);
            }
            getImages(outputData);
        }
        public static void getImages(List<string> imageurls)
        {
            clearImages();
            if (imageurls.Count > 0)
            {
                image1 = imageurls[0];
            }
            if (imageurls.Count > 1)
            {
                image2 = imageurls[1];
            }
            if (imageurls.Count > 2)
            {
                image3 = imageurls[2];
            }
            if (imageurls.Count > 3)
            {
                image4 = imageurls[3];
            }
            if (imageurls.Count > 4)
            {
                image5 = imageurls[4];
            }
        }
        public static void clearImages()
        {
            image1 = ""; image2 = ""; image3 = ""; image4 = ""; image5 = "";
        }
        public static string getStock(string str)
        {
            Stockquantity = "";
            string stock = GetSubString("data-available=\"", "\"/>", str);
            if (stock == "0")
            {
                return "OutOfStock";
            }
            else
            {
                Stockquantity = stock;
                return "InStock";
            }
        }
    }

}
