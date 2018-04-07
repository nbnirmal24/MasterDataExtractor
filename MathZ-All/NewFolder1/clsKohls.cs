using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathZ_All.NewFolder1
{
   public class clsKohls
    {
        public List<string> Kohlscategory(List<string> hulk)
        {
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
                    if (human.Count > 50)
                    {
                        human.Clear();
                        li3.Add(thor.Trim());
                        labunshow(li3);
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

                if (str.IndexOf("<div class=\"product-info\">") > 0)
                {
                    List<string> tk = new List<string>();
                    pattern = @"<div class=""product-info""[^>]*?>(.*?)</a>";
                    tk.AddRange(matchkar(str, pattern));
                    if (tk.Count >= 1)
                    {
                        foreach (string cid in tk)
                        {
                            string ra = getsubstring("<a href=\"", "\">", cid);
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
                                    lab3show(ProductURL);
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
                        if (next != "")
                        {
                            if (!next.Contains("http://www.kohls.com"))
                            {

                                next = "http://www.kohls.com" + next;
                            }

                        }
                        str = null;
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
                        List<string> tkt = new List<string>();
                        pattern = @"<div class=""product-info""[^>]*?>(.*?)</a>";
                        tkt.AddRange(matchkar(str, pattern));
                        if (tkt.Count >= 1)
                        {
                            foreach (string cid in tkt)
                            {
                                string ra = getsubstring("<a href=\"", "\">", cid);
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
                                        lab3show(ProductURL);
                                    }
                                }
                            }

                        }
                        v = str.IndexOf("rel=\"next\" href=\"");
                        if (v < 0)
                        {
                            v = str.IndexOf("<a class=\"ir next-set\" href=\"");
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
            return iron;
        }
        public List<string> Kohlsproduct(List<string> yogesh)
        {
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
                        lab6show(nala);
                        qvcp.Rows.Add(id, rhon);
                        WriteDataToFile(qvcp, dgwq);
                        goto psk;
                    }
                    human.Add(rhon.Trim());
                    if (human.Count > 500)
                    {
                        human.Clear();
                        li3.Add(rhon.Trim());
                        labunshow(li3);
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
                    labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                if (potter.Contains(id))
                {
                    li3.Add("SAME_ID" + rhon.Trim());
                    labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                else
                {
                    potter.Add(id);
                }
                nala.Add("x");
                lab6show(nala);
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
                if (mainimg == "")
                {
                    string vcv = getsubstring("<li count=\"0\">", "</li>", str);
                    if (vcv != "")
                    {
                        mainimg = getsubstring("<a rel=\"", "\" href", str);
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
                string das = getsubstring("<div id=\"pdp_details_segment\">", "<div id=\"pdp_s", str);
                List<string> fea = new List<string>();
                if (das.Contains("FEATURES<") || das.Contains("Features:<"))
                {
                    string qa = getsubstring("FEATURES<", "</ul>", das);
                    if (qa == "")
                    {
                        qa = getsubstring("Features:<", "</ul>", das);
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
                das = das.Replace("<li>", "|").Replace("<ul>", ":").Replace("Features", "|").Replace("PRODUCT FEATURES", "").Replace("</ul>", "");
                das = Regex.Replace(das, @" ?\<.*?\>", string.Empty);
                das = WebUtility.HtmlDecode(das);
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
                                qvcp.Rows.Add(id, childsku, parantage, cate, rhon, name, typep, price, stock, mainimg, alterimg, vartype, color, size, das, features);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                            else
                            {
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

                                qvcp.Rows.Add(id, childsku, parantage, cate, rhon, name, typep, price, stock, mainimg, alterimg, vartype, color, size, das, features);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }


                        }

                    }


                }
                else
                {

                    qvcp.Rows.Add(id, childsku, parantage, cate, rhon, name, typep, price, stock, mainimg, alterimg, vartype, color, size, das, features);
                    //  lab6show(qvcp);
                    WriteDataToFile(qvcp, dgwq);
                }
            psk:
                str = null;
            }
            return li2;
        }
        public List<string> Kohlssstock(List<string> yogesh)
        {
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
                        lab6show(nala);
                        qvcp.Rows.Add(id, rhon);
                        WriteDataToFile(qvcp, dgwq);
                        goto psk;
                    }
                    human.Add(rhon.Trim());
                    if (human.Count > 500)
                    {
                        human.Clear();
                        li3.Add(rhon.Trim());
                        labunshow(li3);
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
                    labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                if (potter.Contains(id))
                {
                    li3.Add("SAME_ID" + rhon.Trim());
                    labunshow(li3);
                    System.IO.File.WriteAllLines(abcd, li3);
                    goto psk;
                }
                else
                {
                    potter.Add(id);
                }
                nala.Add("x");
                lab6show(nala);
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
                                qvcp.Rows.Add(id, childsku, parantage, rhon, name, typep, price, stock, vartype, color, size);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }
                            else
                            {
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

                                qvcp.Rows.Add(id, childsku, parantage, rhon, name, typep, price, stock, vartype, color, size);
                                //  lab6show(qvcp);
                                WriteDataToFile(qvcp, dgwq);
                            }


                        }

                    }


                }
                else
                {

                    qvcp.Rows.Add(id, childsku, parantage, rhon, name, typep, price, stock, vartype, color, size);
                    //  lab6show(qvcp);
                    WriteDataToFile(qvcp, dgwq);
                }
            psk:
                str = null;
            }
            return li2;
        }
        public void Kohlsdatetime()
        {
            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("Child_ID");
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
            if (checkBox1.Checked && textBox3.Text != "")
            {
                dgwq = dgwq + "\\" + "output data" + "\\" + "DATA" + filename + "-" + textBox3.Text + ".txt";
            }
            else
            {
                dgwq = dgwq + "\\" + "output data" + "\\" + "DATA" + filename + ".txt";
            }
            textBox16.Invoke(new Action(() => { textBox16.Text = dgwq; }));
        }
        public void Kohlsdatetime1()
        {

            qvcp.Columns.Add("Product_ID");
            qvcp.Columns.Add("Child_ID");
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
            if (checkBox1.Checked && textBox3.Text != "")
            {
                dgwq = dgwq + "\\" + "output data" + "\\" + "DATA" + filename + "-" + textBox3.Text + ".txt";
            }
            else
            {
                dgwq = dgwq + "\\" + "output data" + "\\" + "DATA" + filename + ".txt";
            }
            textBox16.Invoke(new Action(() => { textBox16.Text = dgwq; }));
        }
    }
}
