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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
           
        }
        public static void lab3(List<string> bj)
        { 
        
        }
        public  void lab3show(List<string> jd)
        {

            Products.Text = jd.Count.ToString(); 
            //  Products.Update();
           // Application.DoEvents();
        }
        public void labunshow(List<string> tb)
        {
            unprocessed.Text =tb.Count.ToString(); 
          //  Application.DoEvents();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            openFileDialog1.Filter = "Text |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;//open file diloge for browse

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) && textBox1.Text == "")
            {
                errorProvider2.Clear();
                errorProvider2.SetError(textBox1, "Please Provide the Path of Input Data");
            }
            else if ((!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked) && textBox1.Text != "")
            {

                errorProvider2.Clear();
                errorProvider2.SetError(radioButton4, "Please Select the Input Type");

            }
            else if ((!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked) && textBox1.Text == "")
            {
                errorProvider2.Clear();
                errorProvider2.SetError(button2, "Please Select the Input Type and Input Path");
            }
            else if ((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) && textBox1.Text != "")
            {
                if (textBox1.Text.Contains(":\\"))
                {

                    errorProvider2.Clear();
                }
                else
                {

                    errorProvider2.SetError(textBox1, "Please Enter the Valid Path");
                }

            }
            if ((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) && textBox1.Text != "")
            {
               
                if (comboBox1.SelectedIndex<0)
                {
                    errorProvider2.Clear();
                    errorProvider2.SetError(comboBox1, "Please Select the Website");
                    return;
                }
                    else
                    {
                        errorProvider2.Clear();
                        errorProvider1.Clear();
                       // errorProvider1.SetError(button2, " ");
                        button2.Enabled = false;
                        button1.Enabled = false;
                        textBox1.ReadOnly = true;
                       // checkBox1.Enabled = false;
                        textBox16.ReadOnly = true;
                backgroundWorker1.RunWorkerAsync();
                    }
            }
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                Common.CreateBaseFolder();
                int x = comboBox1.SelectedIndex;
                if (comboBox1.SelectedIndex == 0)
                {
                    Common.CreateWebsiteBaseFolder("Bed_Bath_Beyond");
                    finalexam(BBB.category, BBB.product, BBB.stock, BBB.datetime, BBB.datetime1, BBB.passpro,false);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    Common.CreateWebsiteBaseFolder("Diapers");
                    finalexam(diapers.categoryNew, diapers.product, diapers.stock, diapers.datetime, diapers.datetime1, diapers.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    Common.CreateWebsiteBaseFolder("DSG");
                    finalexam(DSG.category, DSG.product, DSG.stock, DSG.datetime, DSG.datetime1, DSG.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    Common.CreateWebsiteBaseFolder("Fanatics");
                    finalexam(fanatics.category, fanatics.product, fanatics.stock, fanatics.datetime, fanatics.datetime1, fanatics.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    Common.CreateWebsiteBaseFolder("Kohls");
                    finalexam(kohls.category, kohls.product, kohls.stock, kohls.datetime, kohls.datetime1, kohls.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    Common.CreateWebsiteBaseFolder("Argos");
                    finalexam(argos.category, argos.product, argos.stock, argos.datetime, argos.datetime1, argos.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    Common.CreateWebsiteBaseFolder("Oreintl");
                    finalexam(oreintl.category, oreintl.product, oreintl.stock, oreintl.datetime, oreintl.datetime1, oreintl.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    Common.CreateWebsiteBaseFolder("HomeBargains");
                    finalexam(homebargains.category, homebargains.product, homebargains.stock, homebargains.datetime, homebargains.datetime1, homebargains.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    Common.CreateWebsiteBaseFolder("HollandBarrett");
                    finalexam(hollandandbarrett.category, hollandandbarrett.product, hollandandbarrett.stock, hollandandbarrett.datetime, hollandandbarrett.datetime1, hollandandbarrett.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 9)
                {
                    Common.CreateWebsiteBaseFolder("Boots");
                    finalexam(boots.category, boots.product, boots.stock, boots.datetime, boots.datetime1, boots.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 10)
                {
                    Common.CreateWebsiteBaseFolder("FieldAndStreamShop");
                    finalexam(FieldAndStreamShop.category, FieldAndStreamShop.product, FieldAndStreamShop.stock, FieldAndStreamShop.datetime, FieldAndStreamShop.datetime1, FieldAndStreamShop.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 11)
                {
                    Common.CreateWebsiteBaseFolder("Stuller");
                    finalexam(null, Stuller.stock, Stuller.stock, Stuller.datetime, Stuller.datetime1, Stuller.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 12)
                {
                    Common.CreateWebsiteBaseFolder("CbcChurchSupply");
                    finalexam(null, CbcChurchSupply.producta, CbcChurchSupply.stock, CbcChurchSupply.datetime, CbcChurchSupply.datetime1, CbcChurchSupply.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 13)
                {
                    Common.CreateWebsiteBaseFolder("CafePress");
                    finalexam(cafepress.category, cafepress.product, cafepress.stock, cafepress.datetime, cafepress.datetime1, cafepress.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 14)
                {
                    Common.CreateWebsiteBaseFolder("Modells");
                    finalexam(Modells.category, Modells.product, Modells.stock, Modells.datetime, Modells.datetime1, Modells.passpro, false);
                }
                else if (comboBox1.SelectedIndex == 15)
                {
                    Common.CreateWebsiteBaseFolder("holabirdsports");
                    finalexam(holabirdsports.category, holabirdsports.product, holabirdsports.stock, holabirdsports.datetime, holabirdsports.datetime1, holabirdsports.passpro, true);
                }
                    
            }
            catch (Exception ex) {
                MessageBox.Show("Exception Ocuured..Contact Nirmal");
            }
        }

        //private void finalexam(List<string> list, List<string> list_2, List<string> list_3, object p, object p_2)
        //{
        //    throw new NotImplementedException();
        //}

       

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = comboBox1.FindStringExact(comboBox1.Text);
            try
            {
                comboBox1.GetItemText(comboBox1.Items[comboBox1.SelectedIndex]);
            }
            catch { }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "CbcChurchSupply")
            {
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Text = "OldUStock";
                radioButton4.Text = "NewUStock";
            }
            else
            {
                radioButton2.Visible = true;
                radioButton1.Visible = true;
                radioButton4.Text = "StockStatus";
                radioButton3.Text = "ProductURL";
            }
            //comboBox1.SelectedIndex = comboBox1.FindStringExact(comboBox1.Text);
            //try
            //{
            //    comboBox1.SelectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            //}
            //catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void finalexam(Func<List<string>, List<string>> cat, Action<List<string>> prod, Action<List<string>> stoc, Action date, Action date1,Func<List<string>, List<string>>Pro,bool productProcessingRepeat)
        {
           
            List<string> ProductURL = new List<string>();
            this.Invoke(new Action(() => { this.Text = "Processing Your Request..Please Wait!!"; }));
          
            if (radioButton1.Checked)
            {

                     List<string> ab = new List<string>();
                try
                {
                    string[] wer = File.ReadAllLines(textBox1.Text);
                    ab.AddRange(wer);
                }
                catch
                {
                    MessageBox.Show("such path or directory doesn t exist");
                    button1.Invoke(new Action(() => { button1.Enabled = true; }));
                    textBox1.Invoke(new Action(() => { textBox1.Enabled = true; }));
                    textBox3.Invoke(new Action(() => { textBox3.ReadOnly = false; }));
                    textBox1.Invoke(new Action(() => { textBox1.ReadOnly = false; }));
                    button2.Invoke(new Action(() => { button2.Enabled = true; }));
                    Invoke(new MethodInvoker(() => errorProvider1.Clear()));
                    this.Invoke(new Action(() => { this.Text = ""; }));
                    return;
                }
              
                //foreach (string d in ab)
                //{
                //    string vb = getsubstring("sku:", "/", d);
                //    nala.Add("#" + vb);

                //}
                //System.IO.File.WriteAllLines(dgwq, nala);
                List<string> abde = new List<string>();
                List<string> cd = new List<string>();
                List<string> bd = new List<string>();
                List<string> bd1 = new List<string>();
                List<string> bd2 = new List<string>();
                List<string> bd3 = new List<string>();
                List<string> bd4 = new List<string>();
                List<string> bd5 = new List<string>();
                List<string> bd6 = new List<string>();
                List<string> bd7 = new List<string>();
                cd.AddRange(cat(ab));

                if (cd.Contains("ab_de_be_eb"))
                {
                    cd.RemoveAt(cd.Count - 1);
                    ProductURL.AddRange(cd);
                }
                else
                {
                    bd.AddRange(cat(cd));
                }
                if (bd.Contains("ab_de_be_eb"))
                {
                    bd.RemoveAt(bd.Count - 1);
                    ProductURL.AddRange(bd);
                }
                else
                {
                    bd1.AddRange(cat(bd));
                }
                if (bd1.Contains("ab_de_be_eb"))
                {
                    bd1.RemoveAt(bd1.Count - 1);
                    ProductURL.AddRange(bd1);
                }
                else
                {
                    bd2.AddRange(cat(bd1));
                }
                
                if (bd2.Contains("ab_de_be_eb"))
                {
                    bd2.RemoveAt(bd2.Count - 1);
                    ProductURL.AddRange(bd2);
                }
                else
                {
                    bd3.AddRange(cat(bd2));
                }
                if (bd3.Contains("ab_de_be_eb"))
                {
                    bd3.RemoveAt(bd3.Count - 1);
                    ProductURL.AddRange(bd3);
                }
                else
                {
                    bd4.AddRange(cat(bd3));
                }
                if (bd4.Contains("ab_de_be_eb"))
                {
                    bd4.RemoveAt(bd4.Count - 1);
                    ProductURL.AddRange(bd4);
                }
                else
                {
                    bd5.AddRange(cat(bd4));
                }
                if (bd5.Contains("ab_de_be_eb"))
                {
                    bd5.RemoveAt(bd5.Count - 1);
                    ProductURL.AddRange(bd5);
                }
                else
                {
                    bd6.AddRange(cat(bd5));
                }
                if (bd6.Contains("ab_de_be_eb"))
                {
                    bd6.RemoveAt(bd6.Count - 1);
                    ProductURL.AddRange(bd6);
                }
                else
                {
                    bd7.AddRange(cat(bd6));
                }
                if (bd7.Contains("ab_de_be_eb"))
                {
                    bd7.RemoveAt(bd7.Count - 1);
                    ProductURL.AddRange(bd7);
                }
                else
                {
                    cat(bd7);
                }
                date();
               ProductURL.AddRange(Pro(ProductURL));
               ProductURL= ProductURL.Distinct().ToList();
                if (ProductURL.Contains("ab_de_be_eb"))
                {
                    ProductURL.RemoveAll(x => x.ToString().Equals("ab_de_be_eb"));
                }

                prod(ProductURL);
                if (productProcessingRepeat) {
                    ProductURL.Clear();
                    ProductURL.AddRange(Pro(ProductURL));
                    ProductURL = ProductURL.Distinct().ToList();
                    prod(ProductURL);
                }

            }
            if (radioButton2.Checked)
            {

                List<string> ab = new List<string>();
                try
                {
                    string[] wer = File.ReadAllLines(textBox1.Text);
                    ab.AddRange(wer);
                }
                catch
                {
                    MessageBox.Show("such path or directory doesn t exist");
                    button1.Invoke(new Action(() => { button1.Enabled = true; }));
                    textBox1.Invoke(new Action(() => { textBox1.Enabled = true; }));
                    textBox3.Invoke(new Action(() => { textBox3.ReadOnly = false; }));
                    textBox1.Invoke(new Action(() => { textBox1.ReadOnly = false; }));
                    button2.Invoke(new Action(() => { button2.Enabled = true; }));
                    Invoke(new MethodInvoker(() => errorProvider1.Clear()));
                    this.Invoke(new Action(() => { this.Text = ""; }));
                    return;
                }
                
                List<string> abde = new List<string>();
                List<string> cd = new List<string>();
                List<string> bd = new List<string>();
                cd.AddRange(cat(ab));
                if (cd.Contains("ab_de_be_eb"))
                {
                    cd.RemoveAt(cd.Count - 1);
                    ProductURL.AddRange(cd);
                }
                else
                {
                    bd.AddRange(cat(cd));
                }
              
               // System.IO.File.WriteAllLines(abcd1, ProductURL);
                date();
              ProductURL.AddRange( Pro(ProductURL));
              ProductURL = ProductURL.Distinct().ToList();
              if (ProductURL.Contains("ab_de_be_eb"))
              {
                 ProductURL.RemoveAll(x => x.ToString().Equals("ab_de_be_eb"));
              }
                prod(ProductURL);
                if (productProcessingRepeat)
                {
                    ProductURL.Clear();
                    ProductURL.AddRange(Pro(ProductURL));
                    ProductURL = ProductURL.Distinct().ToList();
                    prod(ProductURL);
                }

            }
            if (radioButton3.Checked)
            {

                List<string> ab = new List<string>();
                try
                {
                    string[] wer = File.ReadAllLines(textBox1.Text);
                    ab.AddRange(wer);
                }
                catch
                {
                    MessageBox.Show("such path or directory doesn t exist");
                    button1.Invoke(new Action(() => { button1.Enabled = true; }));
                    textBox1.Invoke(new Action(() => { textBox1.Enabled = true; }));
                    textBox3.Invoke(new Action(() => { textBox3.ReadOnly = false; }));
                    textBox1.Invoke(new Action(() => { textBox1.ReadOnly = false; }));
                    button2.Invoke(new Action(() => { button2.Enabled = true; }));
                    Invoke(new MethodInvoker(() => errorProvider1.Clear()));
                    this.Invoke(new Action(() => { this.Text = ""; }));
                    return;
                }
                lab3show(ab);
               date();
                prod(ab);
                if (productProcessingRepeat)
                {
                    ProductURL.Clear();
                    ProductURL.AddRange(Pro(ProductURL));
                    ProductURL = ProductURL.Distinct().ToList();
                    prod(ProductURL);
                }

            }
            if (radioButton4.Checked)
            {

                List<string> ab = new List<string>();
                try
                {
                    string[] wer = File.ReadAllLines(textBox1.Text);
                    ab.AddRange(wer);
                }
                catch
                {
                    MessageBox.Show("such path or directory doesn t exist");
                    button1.Invoke(new Action(() => { button1.Enabled = true; }));
                    textBox1.Invoke(new Action(() => { textBox1.Enabled = true; }));
                    textBox3.Invoke(new Action(() => { textBox3.ReadOnly = false; }));
                    textBox1.Invoke(new Action(() => { textBox1.ReadOnly = false; }));
                    button2.Invoke(new Action(() => { button2.Enabled = true; }));
                    Invoke(new MethodInvoker(() => errorProvider1.Clear()));
                    this.Invoke(new Action(() => { this.Text = ""; }));
                    return;
                }
                lab3show(ab);
                date1();
                stoc(ab);
                if (productProcessingRepeat)
                {
                    ProductURL.Clear();
                    ProductURL.AddRange(Pro(ProductURL));
                    ProductURL = ProductURL.Distinct().ToList();
                    stoc(ProductURL);
                }
            }
            MessageBox.Show("COMPLETED");
            this.Invoke(new Action(() => { this.Text = "Completed"; }));
        
        }
        //public static string abcde()
        //{
        //    string abcd = "";
        //    string abcd1 = "";
        //    abcd = Application.StartupPath;
        //    string fil = "";
        //    fil = DateTime.Now.ToString("ddMMyyyyThhmmss"); //string filename = DateTime.Now.ToString("ddMMyyyyThhmmss");
        //    TextBox tb1 = (TextBox)Application.OpenForms["Form1"].Controls.Find("textBox3", false).FirstOrDefault();
        //    if (tb1.Text == "")
        //    {
        //        abcd = abcd + "\\" + "unprocessed data" + "\\" + "DATA" + fil + ".txt";
        //    }
        //    else
        //    {

        //        string[] fileArray = Directory.GetFiles(abcd + "\\" + "unprocessed data", "*.txt");
        //        if (fileArray.Contains(tb1.Text))
        //        {
        //            if (tb1.Text.Contains("_("))
        //            {
        //                int num = 0;
        //                string name = getsubstring("", "_(", tb1.Text.ToString());
        //                string number = getsubstring("_(", ")", tb1.Text);
        //                if (number != "")
        //                {
        //                    num = Convert.ToInt32(number);
        //                    num++;
        //                }
        //                tb1.Text = name + "_(" + num + ")";
        //            }
        //            else
        //            {
        //                tb1.Text = tb1.Text + "_(1)";
        //            }
        //        }
        //        abcd = abcd + "\\" + "unprocessed data" + "\\" + tb1.Text + ".txt";
        //    }
        //    abcd1 = Application.StartupPath;
        //    string fil1 = "";
        //    fil1 = DateTime.Now.ToString("ddMMyyyyThhmmss"); //string filename = DateTime.Now.ToString("ddMMyyyyThhmmss");
        //    if (tb1.Text == "")
        //    {
        //        abcd1 = abcd1 + "\\" + "ProductURL" + "\\" + "DATA" + fil1 + ".txt";
        //    }
        //    else
        //    {
        //        string[] fileArray = Directory.GetFiles(abcd1 + "\\" + "ProductURL" + "\\", "*.txt");
        //        List<string>namearray =new List<string>();
        //        string title = "";
        //        foreach (string fb in fileArray)
        //        {
        //            string sb = Path.GetFileName(fb);
        //            if (sb.Contains(tb1.Text))
        //            {
        //                tb1.Text = sb.Replace(".txt","");
        //                if (tb1.Text.Contains("_("))
        //                {
        //                    tb1.Text = getsubstring("", "(", tb1.Text);
                           
        //                }
        //                title = sb.Replace(".txt", "");
        //            }
        //            namearray.Add(sb);
        //        }
        //        if (namearray.Contains(title + ".txt"))
        //        {
        //            if (title.Contains("_("))
        //            {
        //                int num = 0;
        //                string name = getsubstring("", "_(", title.ToString());
        //                string number = getsubstring("_(", ")", title);
        //                if (number != "")
        //                {
        //                    num = Convert.ToInt32(number);
        //                    num++;
        //                }
        //                tb1.Text = name + "_(" + num + ")";
        //            }
        //            else
        //            {

        //                tb1.Text = title + "_(1)";
        //            }
        //        }
        //        abcd1 = abcd1 + "\\" + "ProductURL" + "\\" + tb1.Text+ ".txt";
        //    }
        //    string combine = abcd + "---" + abcd1;
        //    return combine;
        //}
    }
}
