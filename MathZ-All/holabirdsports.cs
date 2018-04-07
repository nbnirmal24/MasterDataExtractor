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
    class holabirdsports : Common
    {

        static List<string> isIdNotRepeated = new List<string>();
        static List<string> productURL = new List<string>();
        static List<string> SecondProductUrl = new List<string>();
        static List<string> unprocessedUrl = new List<string>();
        static string image1 = "";
        static string image2 = "";
        static string image3 = "";
        static string image4 = "";
        static string image5 = "";
        static int checkResult = 0;
        public static List<string> passpro(List<string> produt)
        {
            produt = SecondProductUrl.Count>0 ? SecondProductUrl : productURL;
            return produt;
        }
        static string str = null;
        static DataTable qvcp = new DataTable();
        static string pattern = "";
        static string fileName = "DATA" + DateTime.Now.ToString("ddMMyyyyThhmmss") + ".txt";
        static string outputPath = Path.Combine(GetOutputPath("holabirdsports"), fileName);
        static string unprocessedPath = Path.Combine(GetUnprocessedPath("holabirdsports"), fileName);
        static string productPath = Path.Combine(GetProductPath("holabirdsports"), fileName);
        public static void datetime()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            TextBox tb = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
            TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox16", false).FirstOrDefault();
            qvcp.Columns.Add("Product_URL");
            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("SKU");
            qvcp.Columns.Add("Brand");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("Title");
            qvcp.Columns.Add("wasPrice");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Stock");
            qvcp.Columns.Add("Sizing");
            qvcp.Columns.Add("ReviewStar");
            qvcp.Columns.Add("ReviewCount");
            qvcp.Columns.Add("MainImage");
            qvcp.Columns.Add("AltImage1");
            qvcp.Columns.Add("AltImage2");
            qvcp.Columns.Add("AltImage3");
            qvcp.Columns.Add("AltImage4");
            qvcp.Columns.Add("Offer");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("Width");
            qvcp.Columns.Add("Variation");
            qvcp.Columns.Add("Description");
            qvcp.Columns.Add("Features");
            qvcp.Columns.Add("Specifications");
            tb1.Text = outputPath;
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
                if (str.IndexOf("<h2 class=\"product-name\"><a href=\"") > 0)
                {
                    //<div class=\"product-info\">
                    // @"<div class=""product-info""[^>]*?>(.*?)</a>";  
                    List<string> tk = new List<string>();
                    pattern = @"<h2 class=""product-name""><a href=[^>]*?""(.*?)"" title";
                    tk.AddRange(MatchPattern(str, pattern));
                    if (tk.Count >= 1)
                    {
                        foreach (string cid in tk)
                        {
                            string ra = cid;
                            if (ra != "")
                            {
                                if (!ra.Contains("http://www.holabirdsports.com"))
                                {
                                    ra = "http://www.holabirdsports.com" + ra;
                                }
                                if (!productURL.Contains(ra)) {
                                    productURL.Add(ra);
                                    System.IO.File.WriteAllLines(productPath, productURL);
                                    Plb.Text = productURL.Count.ToString();
                                }
                            }
                        }

                    }
                    int v = str.IndexOf("class=\"next\" href=\"");
                    while (v > 0)
                    {
                        string next = GetSubString("lass=\"next\" href=\"", "\" title", str);
                        if (next == "")
                        {
                            break;
                        }
                        if (next != "")
                        {
                            if (!next.Contains("http://www.holabirdsports.com"))
                            {

                                next = "http://www.holabirdsports.com" + next;
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
                        pattern = @"<h2 class=""product-name""><a href=[^>]*?""(.*?)"" title";
                        tkt.AddRange(MatchPattern(str, pattern));
                        if (tkt.Count >= 1)
                        {
                            foreach (string cid in tkt)
                            {
                                string ra = cid;
                                if (ra != "")
                                {
                                    if (!ra.Contains("http://www.holabirdsports.com"))
                                    {
                                        ra = "http://www.holabirdsports.com" + ra;
                                    }
                                    if (!productURL.Contains(ra)) {
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
            foreach (string rhon in yogesh)
            {
            //    if (rhon != "ab_de_be_eb")
            //    {
            //        uris.Add(new Uri(rhon));
            //    }
            //}
           
            //Parallel.ForEach(uris, u =>
            //{
            //    string rhon = u.ToString();
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
                        unprocessedUrl.Add(rhon.Trim());
                        lb.Text = unprocessedUrl.Count.ToString();
                        qvcp.Rows.Add(id, rhon);
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
                id = GetSubString("ProdId : '", "',", str).Replace("Item #", "#");
                id = Regex.Replace(id, @" ?\<.*?\>", string.Empty);
                id = Regex.Replace(id, @"\s+", "");
                if (id == "")
                {
                    id = GetSubString("data-sku=\"", "\">", str);
                }
                if (id == "")
                {
                    unprocessedUrl.Add("NO_ID" + rhon.Trim());
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
                sku = GetSubString("product\" value = \"", "\" />", str);
                sku = Regex.Replace(sku, @" ?\<.*?\>", string.Empty);
                sku = Regex.Replace(sku, @"\s+", " ");
                if (string.IsNullOrEmpty(sku)) {
                    sku = GetSubString("pid:'", "',", str);
                    sku = Regex.Replace(sku, @" ?\<.*?\>", string.Empty);
                    sku = Regex.Replace(sku, @"\s+", " ");
                }

                string brand = GetSubString("Brand : '", "',", str);
                brand = Regex.Replace(brand, @" ?\<.*?\>", string.Empty);
                brand = Regex.Replace(brand, @"\s+", " ");

                string name = "";
                name = GetSubString("<div class=\"product-name\" >", "</div>", str);
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");

                string price = "";
                string wasPrice = "";

                wasPrice = GetSubString("special-price-add\">", "</div>", str).Replace("MSRP", "");
                wasPrice = Regex.Replace(wasPrice, @" ?\<.*?\>", string.Empty);
                wasPrice = Regex.Replace(wasPrice, @"\s+", " ");

                price = GetSubString("class=\"add-to-cart-price\">", "</div>", str).Replace("Our Price:", "");
                price = Regex.Replace(price, @" ?\<.*?\>", string.Empty);
                price = Regex.Replace(price, @"\s+", " ");

                string category = "";
                category = GetSubString("Pcat : '", "',", str);
                if (!string.IsNullOrEmpty(category)) {
                    category = "Home > " + category;
                }
                category = Regex.Replace(category, @" ?\<.*?\>", string.Empty);
                category = Regex.Replace(category, @"\s+", " ");
               
                string description = "";
                description = GetSubString("id=\"panel_description\">", "</p>", str);
                description = Regex.Replace(description, @" ?\<.*?\>", string.Empty);
                description = Regex.Replace(description, @"\s+", " ");

                string rawFeature = "";
                string features = "";
                rawFeature = GetSubString("id=\"panel_description\">", "</div>", str);
                if (!string.IsNullOrEmpty(rawFeature))
                {
                    features = GetSubString("<ul>", "</ul>", rawFeature).Replace("<li>", "|").Replace("Description", "");
                    features = Regex.Replace(features, @" ?\<.*?\>", string.Empty);
                    features = WebUtility.HtmlDecode(features);
                    features = Regex.Replace(features, @"\s+", " ");
                }

                string specifications = "";
                specifications = GetSubString("id=\"panel_specs\">", "</div>", str).Replace("<br />", "|");
                specifications = Regex.Replace(specifications, @" ?\<.*?\>", string.Empty);
                specifications = Regex.Replace(specifications, @"\s+", " ");

                string sizing = "";
                sizing = GetSubString("id=\"panel_sizing\">", "</div>", str).Replace("<br />", "|").Replace("<i>", "|(").Replace("</i>", ")");
                sizing = Regex.Replace(sizing, @" ?\<.*?\>", string.Empty);
                sizing = Regex.Replace(sizing, @"\s+", " ");

                string reviewStar = "";
                reviewStar = GetSubString("average\">", "<", str);
                reviewStar = Regex.Replace(reviewStar, @" ?\<.*?\>", string.Empty);
                reviewStar = Regex.Replace(reviewStar, @"\s+", " ");

                string reviewCount = "";
                reviewCount = GetSubString("class=\"count\">", "<", str);
                reviewCount = Regex.Replace(reviewCount, @" ?\<.*?\>", string.Empty);
                reviewCount = Regex.Replace(reviewCount, @"\s+", " ");

              

                if (str.IndexOf("<div class=\"other-colors\">") > 0) {
                    List<string> colorData = new List<string>();
                    string rawData = GetSubString("<div class=\"other-colors\">", "</ul>", str);
                    if (!string.IsNullOrEmpty(rawData)) {
                        pattern = @"<li><a href""[^>]*?=(.*?)"" title";
                        colorData.AddRange(Common.MatchPattern(rawData,pattern));
                        foreach (string data in colorData) {
                            if (!yogesh.Contains(data)) {
                                SecondProductUrl.Add(data);
                            }
                        }
                    }
                }

                string offer = "";
                if (str.IndexOf("<div class=\"gc-alert-box\">") > 0) {
                    offer = GetSubString("<div class=\"gc-alert-box-middle\">", "</div>", str);
                    offer += " | ";
                    
                }
                if (str.IndexOf("free_returns_icon") > 0) {
                    offer += "Free Returns on this item.";
                    offer += " | ";
                }
                if (str.IndexOf("free_ground_icon") > 0) {
                    offer += "Free door-to-door ground shipping on this product.";
                    offer += " | ";
                }
                if (str.IndexOf("free_2nd_icon") > 0) {
                    offer += "Free door-to - door 2nd Day Shipping.";
                    offer += " | ";
                    
                }
                if (str.IndexOf("special_icon") > 0) {
                    offer = GetSubString("Holabird Special", "<div class", str).Replace("//-->", "");
                }
                offer = Regex.Replace(offer, @" ?\<.*?\>", string.Empty);
                offer = Regex.Replace(offer, @"\s+", " ");

                string color = "";
                string size = "";
                string width = "";
                string stock = "";
                string variation = "";
                List<string> colorList = new List<string>();
                List<string> stockList = new List<string>();
                List<string> widthist = new List<string>();
                List<string> variationlist = new List<string>();
                List<string> colorItemList = new List<string>();
                List<string> sizeItemList = new List<string>();
                List<string> widthItemList = new List<string>();
                List<string> variationItemList = new List<string>();
                List<string> sizeList = new List<string>();
                List<string> AllSkusList = new List<string>();
                int colorIndex = str.IndexOf("\"label\":\"Color\"");
                int sizeIndex = str.IndexOf("\"label\":\"Size\"");
                int widthIndex = str.IndexOf("\"label\":\"Width\"");
                int variationIndex = str.IndexOf("\"label\":\"Flavor\"");
                

                stockList.AddRange(getVariationList(str, 3));

                if (colorIndex > 0 && sizeIndex > 0)
                {
                    colorList.AddRange(getVariationList(str, 1));
                    sizeList.AddRange(getVariationList(str, 2));
                    if (colorList.Count > 0 && sizeList.Count > 0)
                    {
                        foreach (string colordata in colorList)
                        {
                            colorItemList.Clear();
                            colorItemList.AddRange(getVariationIdList(colordata));
                            foreach (string colId in colorItemList)
                            {
                                getImageUrls(str, colId);
                                foreach (string sizedata in sizeList)
                                {
                                    if (sizedata.Contains(colId))
                                    {
                                        color = getVariationName(colordata);
                                        size = getVariationName(sizedata);
                                        foreach (string stkdata in stockList)
                                        {
                                            if (stkdata.Contains(colId))
                                            {
                                                stock = getStock(stkdata);
                                                PrintData(rhon, id, sku, brand, name, wasPrice, price, category, description, features, specifications, sizing, reviewStar,reviewCount
                                                          , offer, color, size, width, stock, variation, image1, image2, image3, image4, image5, outputPath);
                                                
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                }
                            }

                        }
                    }

                }
                else if (widthIndex > 0 && sizeIndex > 0)
                {
                    widthist.AddRange(getVariationList(str, 4));
                    sizeList.AddRange(getVariationList(str, 2));
                    if (widthist.Count > 0 && sizeList.Count > 0)
                    {
                        foreach (string widthdata in widthist)
                        {
                            widthItemList.Clear();
                            widthItemList.AddRange(getVariationIdList(widthdata));
                            foreach (string widId in widthItemList)
                            {
                                getImageUrls(str, widId);
                                foreach (string sizedata in sizeList)
                                {
                                    if (sizedata.Contains(widId))
                                    {
                                        width = getVariationName(widthdata);
                                        size = getVariationName(sizedata);
                                        foreach (string stkdata in stockList)
                                        {
                                            if (stkdata.Contains(widId))
                                            {
                                                stock = getStock(stkdata);
                                                PrintData(rhon, id, sku, brand, name, wasPrice, price, category, description, features, specifications, sizing, reviewStar, reviewCount
                                                          , offer, color, size, width, stock, variation, image1, image2, image3, image4, image5, outputPath);
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                }
                            }

                        }
                    }

                }
                else if (sizeIndex > 0)
                {
                    sizeList.AddRange(getVariationList(str, 2));
                    if (sizeList.Count > 0)
                    {
                        foreach (string sizedata in sizeList)
                        {
                            size = getVariationName(sizedata);
                            sizeItemList.Clear();
                            sizeItemList.AddRange(getVariationIdList(sizedata));
                            foreach (string sizeId in sizeItemList)
                            {
                                getImageUrls(str, sizeId);
                                foreach (string stkdata in stockList)
                                {
                                    if (stkdata.Contains(sizeId))
                                    {
                                        stock = getStock(stkdata);
                                        PrintData(rhon, id, sku, brand, name, wasPrice, price, category, description, features, specifications, sizing, reviewStar, reviewCount
                                                  , offer, color, size, width, stock, variation, image1, image2, image3, image4, image5, outputPath);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (variationIndex > 0)
                {
                    variationlist.AddRange(getVariationList(str, 5));
                    if (variationlist.Count > 0)
                    {
                        foreach (string vardata in variationlist)
                        {
                            variation = getVariationName(vardata);
                            variationItemList.Clear();
                            variationItemList.AddRange(getVariationIdList(vardata));
                            foreach (string varId in variationItemList)
                            {
                                getImageUrls(str, varId);
                                foreach (string stkdata in stockList)
                                {
                                    if (stkdata.Contains(varId))
                                    {
                                        stock = getStock(stkdata);
                                        PrintData(rhon, id, sku, brand, name, wasPrice, price, category, description, features, specifications, sizing, reviewStar, reviewCount
                                                          , offer, color, size, width, stock, variation, image1, image2, image3, image4, image5, outputPath);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (colorIndex > 0)
                {
                    colorList.AddRange(getVariationList(str, 1));
                    if (colorList.Count > 0)
                    {
                        foreach (string colordata in colorList)
                        {
                            color = getVariationName(colordata);
                            colorItemList.Clear();
                            colorItemList.AddRange(getVariationIdList(colordata));
                            foreach (string colorId in colorItemList)
                            {
                                getImageUrls(str, colorId);
                                foreach (string stkdata in stockList)
                                {
                                    if (stkdata.Contains(colorId))
                                    {
                                        stock = getStock(stkdata);
                                        PrintData(rhon, id, sku, brand, name, wasPrice, price, category, description, features, specifications, sizing, reviewStar, reviewCount
                                                          , offer, color, size, width, stock, variation, image1, image2, image3, image4, image5, outputPath);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    getNormalImageUrls(str);
                    stock = "@_In_Stock";
                    PrintData(rhon, id, sku, brand, name, wasPrice, price, category, description, features, specifications, sizing, reviewStar, reviewCount
                                                          , offer, color, size, width, stock, variation, image1, image2, image3, image4, image5, outputPath);
                }
                psk:
                str = null;
            };

        }
        public static List<string> getVariationList(string str, int type) {   ///1-color  2-size   3-stock
            string rawdata = "";
            List<string> output = new List<string>();
            if (type == 1)
            {
                rawdata = GetSubString("\"Color\",\"options\":[", "]}]", str);
            }
            else if (type == 2)
            {
                rawdata = GetSubString("Size\",\"options\":[", "]}]", str);
            }
            else if (type == 3)
            {
                rawdata = GetSubString("StockStatus(", ");", str);
            }
            else if (type == 4) {

                rawdata = GetSubString("Width\",\"options\":[", "]}]", str);
            }
            else if (type == 5)
            {
                rawdata = GetSubString("Flavor\",\"options\":[", "]}]", str);
            }
            if (!string.IsNullOrEmpty(rawdata)) {
                rawdata += "]}";
            }
            string pattern = @"{[^>]*?(.*?)}";
            output.AddRange(Common.MatchPattern(rawdata,pattern));
            return output;
        }
        public static List<string> getVariationIdList(string str) {
            List<string> output = new List<string>();
            string rawdata = GetSubString("[", "]", str).Replace("\"","");
            if (!string.IsNullOrEmpty(rawdata))
            {
                string[] idurls = rawdata.Split(',');
                output.AddRange(idurls);
            }
                return output;
        }
        public static string getVariationName(string str)
        {
            return GetSubString("\"label\":\"", "\",", str);
    }
        public static string getStock(string str) {
            string output = "OutOfStock";
            string data = GetSubString("is_in_stock\":\"", "\",", str);
            if (data == "1") {
                output = "InStock";
            }
            return output;
        }
        public static void getImageUrls(string str, string id) { 
            string rawdata = GetSubString(id + "\":", "prestrung_with\":", str);
            if (!string.IsNullOrEmpty(rawdata)) {
                string rawimagedata = GetSubString("galleryImgUrl\":[", "]", rawdata).Replace("\"", "").Replace("\\/", "/");
                if (!string.IsNullOrEmpty(rawimagedata)) {
                    string[] imageurls = rawimagedata.Split(',');
                    List<string> output = new List<string>();
                    output.AddRange(imageurls);
                    getImages(output);
                }
            }
        }
        public static void getNormalImageUrls(string str) {
            List<string> output = new List<string>();
            string rawStr = GetSubString("ig_lightbox_main_img=", "});", str);
            string pattern = "img_sequence.push\\([^>]*?'(.*?)'\\)";
            output.AddRange(Common.MatchPattern(rawStr, pattern));
            getImages(output);

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

                    str =GetHtml(rhon);
                }
                catch (Exception e)
                {
                    string vb = e.ToString();
                    if (vb.Contains("(404) Not Found"))
                    {
                        id = "Not_Available";
                        unprocessedUrl.Add("x");
                        Plb.Text = unprocessedUrl.Count.ToString();
                        qvcp.Rows.Add(id, rhon);
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
                id = GetSubString("\"itemProductID\":\"", "\",", str);
                if (id == "")
                {
                    id = GetSubString("br_data.prod_id = \"", "\";", str);
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
                id = Regex.Replace(id, @" ?\<.*?\>", string.Empty);
                id = Regex.Replace(id, @"\s+", "");
                string name = "";
                name = GetSubString("<h1 class=\"title productTitleName\">", "</h1>", str);
                if (name == "")
                {
                    name = GetSubString("\"itemName\":\"", "\",", str);
                }
                name = Regex.Replace(name, @" ?\<.*?\>", string.Empty);
                name = Regex.Replace(name, @"\s+", " ");
                string price = "";
                string typep = "";
                price = GetSubString("br_data.sale_price = \"", "\";", str);
                if (price == "")
                {
                    price = GetSubString("<span class=\"price_label\">", "</div>", str).Replace("Regular", "").Replace("Sale", "");
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
                upc = GetSubString("UpcCode\" value=\"", "\"/>", str);
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
                string cv = GetSubString("\"itemIsInStock\":\"", "}", str).Replace("\"", "");
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
                string SKU = GetSubString("\"variants\" : [", "]", str);
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
                                WriteDataToFile(qvcp, outputPath);
                            }
                            else
                            {
                                upc = GetSubString("\"skuUpcCode\":\"", "\",", jack);
                                upc = Regex.Replace(upc, @" ?\<.*?\>", string.Empty);
                                upc = Regex.Replace(upc, @"\s+", " ");
                                if (upc != "")
                                {
                                    upc = "#" + upc;
                                }
                                if (str.IndexOf("<div class=\"colorblock\">") > 0)
                                {
                                    color = GetSubString("\"color\":\"T" + id + "_", "\",", jack);
                                }
                                if (str.IndexOf("<div class=\"size-holder\">") > 0)
                                {
                                    size = GetSubString("\"size2\":\"T" + id + "_", "\",", jack).Replace("_waist", "");
                                }

                                childsku = GetSubString("\"skuId\":\"", "\",", jack);
                                string inven = GetSubString("\"inventoryStatus\":\"", "\",", jack);
                                if (inven == "true")
                                {
                                    stock = "In_Stock";
                                }
                                else
                                {
                                    stock = "Check_manually";
                                }
                                string pp = GetSubString("\"SkuSalePrice\":\"", "\",", jack);
                                if (pp != "")
                                {
                                    typep = "SALE";
                                }
                                if (pp.Contains("|"))
                                {
                                    pp = GetSubString("\"SkuSalePrice\":\"", "|", jack);
                                }
                                if (pp == "")
                                {
                                    pp = GetSubString("\"SkuRegularPrice\":\"", "\",", jack);
                                    if (pp != "")
                                    {
                                        typep = "REGULAR";
                                    }
                                }
                                if (pp.Contains("|"))
                                {
                                    pp = GetSubString("\"SkuRegularPrice\":\"", "|", jack);
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
                                WriteDataToFile(qvcp,outputPath);
                            }


                        }

                    }


                }
                else
                {

                    qvcp.Rows.Add(id, childsku, upc, parantage, rhon, name, typep, price, stock, vartype, color, size);
                    //  lab6show(qvcp);
                    WriteDataToFile(qvcp, outputPath);
                }
                psk:
                str = null;
            }
        }
        public static void getImages(List<string> imageurls) {
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
        public static void PrintData(string productUrl,string id,string sku,string brand,string name,string wasPrice,string price,string category,string description,string feature
        ,string specification,string sizing,string reviewStar,string reviewCount,string offer,string color,string size,string width,string stock,string variation,
         string image1,string image2,string image3,string image4,string image5,string filePath) {
            qvcp.Rows.Add(productUrl,id, sku, brand, category,name, wasPrice, price,stock,sizing,reviewStar,reviewCount,image1,image2,image3,image4,image5,offer,color,
                          size,width,variation,description,feature,specification);
            WriteDataToFile(qvcp, filePath);
        }
        public static void clearImages() {
            image1 = "";image2 = "";image3 = "";image4 = "";image5 = "";
        }
    }
}
