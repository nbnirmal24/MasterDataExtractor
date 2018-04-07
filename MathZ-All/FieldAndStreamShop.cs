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
    class FieldAndStreamShop
    {
          Label lb = (Label)Application.OpenForms["Form1"].Controls.Find("cnverted", false).FirstOrDefault();
            Label Ulb = (Label)Application.OpenForms["Form1"].Controls.Find("unprocessed", false).FirstOrDefault();
            Label Plb = (Label)Application.OpenForms["Form1"].Controls.Find("Products", false).FirstOrDefault();
            Label clb = (Label)Application.OpenForms["Form1"].Controls.Find("Countnumber", false).FirstOrDefault();
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
        public static string PostHtml(string url,string data)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = data;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            // Display the status.
            // Console.WriteLine(response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
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
           
            qvcp.Columns.Add("ProductUrl");
            qvcp.Columns.Add("Product Id");
            qvcp.Columns.Add("Brand");
            qvcp.Columns.Add("Sku");
            qvcp.Columns.Add("Product Name");
            qvcp.Columns.Add("Category");
            qvcp.Columns.Add("Model_No");
            qvcp.Columns.Add("Manufacturer");
            qvcp.Columns.Add("Price");
            qvcp.Columns.Add("Sale price");
            qvcp.Columns.Add("Avg_Rating Out_of 5");
            qvcp.Columns.Add("Total_Reviews");
            qvcp.Columns.Add("Shipping");
            qvcp.Columns.Add("Avaiability");
            qvcp.Columns.Add("Image1");
            qvcp.Columns.Add("Image2");
            qvcp.Columns.Add("Image3");
            qvcp.Columns.Add("Image4");
            qvcp.Columns.Add("Image5");
            qvcp.Columns.Add("VariationInventory Id");
            qvcp.Columns.Add("SKUVariation Id");
            qvcp.Columns.Add("Color");
            qvcp.Columns.Add("Size");
            qvcp.Columns.Add("Variation");
            qvcp.Columns.Add("CountryOrgin");
            qvcp.Columns.Add("Description");
            qvcp.Columns.Add("Features");
            qvcp.Columns.Add("Specification");
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
            qvcp.Columns.Add("ProductUrl");
            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("StockStatus");
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
                int xl = str.IndexOf("<div itemprop=\"name\"");
                if (xl > 0)
                {
                    string catalogId = "";
                    string storeId = "";
                    string categoryId = "";
                    string productsUrl = "";
                    string productSource = "";
                    string strTotalProducts = getsubstring("productTotalCount.innerHTML = '", "';", str);
                   
                        catalogId = getsubstring("\"catalogId\":'", "',", str);
                        storeId = getsubstring("\"storeId\":'", "',", str);
                        categoryId = getsubstring("FamilyID : \"", "\",", str);
                        productsUrl = "http://www.fieldandstreamshop.com/CategoryNavigationResultsView?manufacturer=&searchType=&resultCatEntryType=&filterCollQuery=&catalogId=" + catalogId + "&categoryId=" + categoryId + "&langId=-1&storeId=" + storeId + "&sType=SimpleSearch&filterFacet=&metaData=&pageSize=" + strTotalProducts;
                    back:
                        try
                        {
                            productSource = Gethtml(productsUrl);
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
                            goto back;
                        }
                        if (human.Count >= 1)
                        {
                            human.Clear();
                        }
                    pattern = @"<div class=""product_name""[^>]*?>(.*?)<div itemprop=";
                    MatchCollection matches = Regex.Matches(productSource, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in matches)
                    {
                        string fg = match.Groups[1].Value;
                        string fbi = getsubstring("href=\"", "\" data", fg);
                            if (animal.Contains(fbi))
                            { }
                            else
                            {
                                animal.Add(fbi);
                                ProductURL.Add(fbi);
                                System.IO.File.WriteAllLines(abcd1, ProductURL);
                                Plb.Text = ProductURL.Count.ToString();
                            }
                    }
                }
                else if (str.IndexOf("<div class=\"cat_info\">") > 0)
                {
                    pattern = @"<div class=""cat_info[^>]*?"">(.*?)</div>";
                    MatchCollection matchu = Regex.Matches(str, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    foreach (Match veta in matchu)
                    {
                        string cat = veta.Groups[1].Value;
                        string finalUrl= getsubstring("\" href=\"", "\" data", cat);
                        if (!finalUrl.Contains("http"))
                        {
                            finalUrl = "http://www.fieldandstreamshop.com" + finalUrl;
                        }
                        if (potter.Contains(finalUrl))
                        { }
                        else
                        {
                            potter.Add(finalUrl);
                            iron.Add(finalUrl);
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
                if (abde1.Count() >= 1)
                {
                    rhon = abde1[0].Replace("http://www.dickssportinggoods.comhttp://www.dickssportinggoods.com", "http://www.dickssportinggoods.com");
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
                productsku = getsubstring("SKU:", "</span>", str);
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
                    string productId = "";
                    productId = getsubstring("Params({id: '", "',", str);
                    string model = "";
                    string estimate = "";
                    string name = "";
                    name = getsubstring("<h1", "</h1>", str);
                    if (!string.IsNullOrEmpty(name))
                    {
                        name = "<" + name;
                        name = RefineDesTags(name);
                    }
                    string price = "";
                    string wprice = "";
                    string sprice = "";
                    price = getsubstring("CurrentPrice : \"", "\",", str).Replace("&#036;", "$");
                    price = RefineDesTags(price);
                    wprice = getsubstring("ListPrice : \"", "\",", str).Replace("&#036;", "$").Replace("*", "");
                    wprice = RefineDesTags(wprice);
                    string brand = "";
                    brand = getsubstring("Brand:", "</li>", str);
                    if (string.IsNullOrEmpty(brand))
                    {
                        brand = getsubstring("by <", "</a>", str);
                    }
                    if (!string.IsNullOrEmpty(brand))
                    {
                        brand = RefineDesTags(brand).Replace(">}","");
                    }
                    string des = "";
                    des = getsubstring("class=\"productDescription\">", "</p>", str);
                    des = RefineDesTags(des);
                    string feature = "";
                    List<string> feat = new List<string>();
                    string fea = getsubstring("FEATURES:", "</UL>", str).Replace("<li>", "<LI>").Replace("</li>", "</LI>");
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
                    feature = RefineDesTags(feature);
                    string ground = "";
                    string origin = "";
                    string category = "";
                    origin = getsubstring("Country of Origin:", "</li>", str);
                    origin = RefineDesTags(origin);
                    category = getsubstring("class=\"widget_breadcrumb_position\">", "<li class", str).Replace(":", "|");
                    category = RefineDesTags(category);
                    if (!string.IsNullOrEmpty(category))
                    {
                        category = category + "}";
                        category = category.Replace(">}", "");
                    }
                    string ship = "";
                    ship = getsubstring("<ul class=\"promos\">", "</ul>", str);
                    ship = RefineDesTags(ship);
                    string spec = "";
                    List<string> specHeader = new List<string>();
                     pattern = @"data-breakpoints=""xs""[^>]*?>(.*?)</th>";
                    MatchCollection matches = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    foreach (Match match in matches)
                    {
                        string fg =match.Groups[1].Value;
                        specHeader.Add(fg);
                    }
                    string dataContainer = getsubstring("<tr data-expanded=\"true\">", "</tr>", str);
                    int count = 0;
                    if (!string.IsNullOrEmpty(dataContainer))
                    {
                        pattern = @"<td[^>]*?>(.*?)</td>";
                        MatchCollection matches1 = Regex.Matches(str, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        foreach (Match match in matches1)
                        {
                            if (specHeader.Count >= count)
                            {
                                 string fg = match.Groups[1].Value;
                                 spec = specHeader[count] + ":-" + fg;
                                 spec = spec + "|";
                            }
                        }
                    }
                    spec = spec.Replace("&reg;", "(R)").Replace("&trade;", "(TM)");
                    string image1 = "";
                    string image2 = "";
                    string image3 = "";
                    string image4 = "";
                    string mainimage = "";
                    string urlimg = getsubstring("imgPath='", "';", str);
                   List<string> imgUrlList=new List<string>(getImages(urlimg));
                    mainimage = imgUrlList.Count() >= 1 ? imgUrlList[0] : "";
                    image1 = imgUrlList.Count() >= 2 ? imgUrlList[1] : "";
                    image2 = imgUrlList.Count() >= 3 ? imgUrlList[2] : "";
                    image3 = imgUrlList.Count() >= 4 ? imgUrlList[3] : "";
                    image4 = imgUrlList.Count() >= 5 ? imgUrlList[4] : "";
                    string review = "";
                    string rate = "";
                    string rev = "";
                        rate = getsubstring("itemprop=\"ratingValue\">", "out of", str);
                        rev = getsubstring("itemprop=\"reviewCount\">", "</span>", str);
                    rate = Regex.Replace(rate, @" ?\<.*?\>", string.Empty);
                    rate = Regex.Replace(rate, @"\s+", " ");
                    rev = Regex.Replace(rev, @" ?\<.*?\>", string.Empty);
                    rev = Regex.Replace(rev, @"\s+", " ");
                    string stock = "";
                    stock = getsubstring("ProductAvailability : \"", "\",", str);
                    string promo = "";
                    promo = getsubstring("DisplayedPromoText : [\"", "\"],", str);
                    string manufacturer="";
                    manufacturer=getsubstring("manufacturer\" content=\"","\"/>",str);
                    string modelNumber=getsubstring(">Model:","<",str);
                    //variation
                    string varSource = "";
                    string storeId = "";
                    string catalogId = "";
                    string langId = "";
                    string itemId = "";
                    string color = "";
                    string size = "";
                    string othervar = "";
                    string varId = "";
                    string prodcutSkuList = getsubstring("ProductSKUList : [", "]", str).Replace("\"", "");
                    string[] visibleVar = prodcutSkuList.Split(',');
                   
                    varSource = getsubstring("InventoryStatusJS({", "<script", str);
                    if (!string.IsNullOrEmpty(varSource)) {
                        storeId = getsubstring("storeId: '", "',", varSource);
                        catalogId = getsubstring("catalogId: '", "',", varSource);
                        langId = getsubstring("langId: '", "'}", varSource);
                        itemId = getsubstring("[], '", "')", varSource);
                        string varSource2 = getsubstring("skus:", "</script>", varSource);
                        pattern = @"{i[^>]*?d(.*?)}}";
                        MatchCollection matches1 = Regex.Matches(varSource2, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        if (matches1.Count >= 1)
                        {
                            foreach (Match match in matches1)
                            {
                                string resultSource = match.Groups[1].Value + "}";
                                varId = getsubstring(": '", "',", resultSource);
                                string checkInv = getsubstring("\"catentry_id\" : \"" + varId, "{", str);
                                string checkId = "";
                                if (!string.IsNullOrEmpty(checkInv))
                                {
                                    checkId = getsubstring("\"partnumber\" : \"", "\",", checkInv);
                                }
                                if (!string.IsNullOrEmpty(checkId))
                                {
                                    if (prodcutSkuList.Contains(checkId))
                                    {
                                        string inventorySource = DefinateSourceCode(rhon + "/GetInventoryStatusByIDView",
                                           "storeId=" + storeId + "&catalogId=" + catalogId + "&langId=" + langId + "&itemId=" + varId);
                                        if (!string.IsNullOrEmpty(inventorySource))
                                        {
                                            stock = getsubstring("status: \"", "\",", inventorySource);
                                        }
                                    }
                                    else { stock = "Out Of Stock"; }
                                }
                                //foreach (string avail in visibleVar)
                                //{
                                //   string Favail = avail.Replace(" ", "");
                                //    int endIndex = str.IndexOf("partnumber\" : \"" + Favail);
                                //    int strtIndex = endIndex - 40;
                                //    string result = str.Substring(strtIndex, endIndex - strtIndex);
                                //    if (result.Contains(varId))
                                //    {
                                //        isDisplayVar = true;
                                //        break;

                                //    }
                                //    else { isDisplayVar = false; }
                                //}
                                string subSource = getsubstring("attributes: {", "}", resultSource);
                                if (!string.IsNullOrEmpty(subSource))
                                {
                                    string[] variations = subSource.Split(',');
                                    if (variations.Count() > 0)
                                    {
                                        foreach (string finalVar in variations)
                                        {
                                            string updatedVar = finalVar + "}";
                                            string varName = getsubstring("'", "':", finalVar);

                                            string varValue = getsubstring(": '", "'}", updatedVar);
                                            if (!string.IsNullOrEmpty(varValue))
                                            {
                                                string imgbackup = getsubstring("alt=\"" + varValue, "</div>", str);

                                                if (!string.IsNullOrEmpty(imgbackup))
                                                {
                                                    string imgsource = getsubstring("src=\"", "swatch", imgbackup);
                                                    if (!string.IsNullOrEmpty(imgsource))
                                                    {
                                                        imgsource = imgsource + "is";
                                                        List<string> imgUrlListV = new List<string>(getImages(imgsource));
                                                        mainimage = imgUrlListV.Count() >= 1 ? imgUrlListV[0] : "";
                                                        image1 = imgUrlListV.Count() >= 2 ? imgUrlListV[1] : "";
                                                        image2 = imgUrlListV.Count() >= 3 ? imgUrlListV[2] : "";
                                                        image3 = imgUrlListV.Count() >= 4 ? imgUrlListV[3] : "";
                                                        image4 = imgUrlListV.Count() >= 5 ? imgUrlListV[4] : "";
                                                    }
                                                }
                                            }
                                            if (varName.Contains("size") || varName.Contains("Size") || varName.Contains("SIZE"))
                                            {
                                                size = varValue;
                                            }
                                            else if (varName.Contains("color") || varName.Contains("Color") || varName.Contains("COLOR"))
                                            {
                                                color = varValue;
                                            }
                                            else
                                            {
                                                othervar = "|" + varName + ":" + varValue;
                                            }

                                        }

                                    }
                                }

                                string priceSource = DefinateSourceCode("http://www.fieldandstreamshop.com/GetCatalogEntryDetailsByIDView",
                                    "storeId=" + storeId + "&langId=" + langId + "&catalogId=" + catalogId + "&catalogEntryId=" + varId + "&productId=" + itemId);
                                if (!string.IsNullOrEmpty(priceSource))
                                {
                                    price = getsubstring("\"offerPrice\": \"", "\",", priceSource);
                                    wprice = getsubstring("\"listPrice\": \"", "\",", priceSource);
                                }
                                qvcp.Rows.Add(rhon, productsku, brand, productId, name, category, model, manufacturer, wprice, price, rate, rev, promo, stock, mainimage, image1, image2, image3
                                    , image4, varId, checkId, color, size, othervar, origin, des, feature, spec);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                                mainimage = ""; image1 = ""; image2 = ""; image3 = ""; image4 = "";

                            }
                        }
                        else
                        {
                            qvcp.Rows.Add(rhon, productsku, brand, productId, name, category, model, manufacturer, wprice, price, rate, rev, promo, stock, mainimage, image1, image2, image3
                                      , image4, varId,"", color, size, othervar, origin, des, feature, spec);
                            //  lab6show(qvcp);
                            WriteDataToFile(qvcp, dgwq);
                        }
                    
                    }

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
                                    string finalUrl = "";
                try
                {
                    string rhon = "";
                    string[] data = System.IO.File.ReadAllLines(Application.StartupPath + "\\IMPID.txt");
                    string[] abde1 = rhonq.Split('\t');
                    if (abde1.Count() >= 1)
                    {
                        rhon = abde1[0];
                        int end = rhon.LastIndexOf("/");
                        finalUrl = rhon.Substring(0, end);

                    }
                jsk:
                    try
                    {
                        str = Gethtml(rhon);//PostHtml(finalUrl + "/GetInventoryStatusByIDView", "storeId="+data[0]+"&catalogId="+data[1]+"&langId="+data[2]+"&itemId="+abde1[1]);
                    }
                    catch(Exception ex)
                    {
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
                    
                    string productsku = "";
                    productsku = abde1[1];
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
                        string status = "";
                        status = getsubstring("status: \"", "\",", str);
                        qvcp.Rows.Add(finalUrl, productsku,status);
                        WriteDataToFile(qvcp, dgwq);
                psk:
                    str = null;
                }
                catch
                {
                   string[] abde1 = rhonq.Split('\t');
                    if (abde1.Count() >= 1)
                    {
                    string productsku = "Exception";
                    qvcp.Rows.Add(finalUrl,abde1[1],productsku);
                    WriteDataToFile(qvcp, dgwq);
                    }
                }
            }
        }
        public static List<string> getImages(string urrl)
        {
            string imgURlSource = "";
            List<string> imgUrlList = new List<string>();
            string imgUrl = urrl;
            if (!string.IsNullOrEmpty(imgUrl))
            {
                imgUrl = "http:" + imgUrl + "?req=set,json,UTF-8&labelkey=label&handler=s7classics7sdkJSONResponse";
            }
        imgGT:
            try
            {
                imgURlSource = Gethtml(imgUrl);
            }
            catch
            {
                human.Add("1");
                if (human.Count > 500)
                {
                    human.Clear();
                  //  li3.Add(rhon.Trim());
                   // Ulb.Text = li3.Count.ToString();
                    System.IO.File.WriteAllLines(abcd, li3);
                  
                }
            }
            if (str == null || str == "")
            {

                goto imgGT;
            }
            if (human.Count >= 1)
            {
                human.Clear();
            }
            pattern = @"s"":{""n"":[^>]*?""(.*?)""},";
            MatchCollection matches2 = Regex.Matches(imgURlSource, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (matches2.Count == 0) {

                string sample = getsubstring(",\"item\":{", ")", imgURlSource);
                if (!string.IsNullOrEmpty(sample)) {
                    pattern = @"""n"":[^>]*?""(.*?)""}";
                    matches2 = Regex.Matches(sample, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                }
            }
           
            foreach (Match match in matches2)
            {
                string fg = "http://s7d2.scene7.com/is/image/" + match.Groups[1].Value;
                imgUrlList.Add(fg);
            }

            return imgUrlList.Distinct().ToList();
        }
        public static string DefinateSourceCode(string url,string postData)
        { 
            string source="";
         jsk:
                                try
                                {
                                    source = PostHtml(url, postData);
                                }
                                catch
                                {
                                    human.Add(url);
                                    if (human.Count > 500)
                                    {
                                        human.Clear();
                                        li3.Add(url);
                                      //  Ulb.Text = li3.Count.ToString();
                                        System.IO.File.WriteAllLines(abcd, li3);
                                        goto psk;
                                    }
                                }
                               if (source == null || source == "")
                                {

                                    goto jsk;
                                }
                                if (human.Count >= 1)
                                {
                                    human.Clear();
                                }
            psk:
                                return source;
        
        }
        public static string RefineDesTags(string input)
        {
            input = input.Trim();
            input = Regex.Replace(input, @" ?\<.*?\>", string.Empty);
            input = Regex.Replace(input, @"\s+", " ");
            input = input.Replace("&reg;", "(R)").Replace("&trade;", "(TM)").Replace("&amp;", "&").Replace("&#039;", "'").Replace("â€“", "-").Replace("-", "~");

         return input;
        }

    }
}
