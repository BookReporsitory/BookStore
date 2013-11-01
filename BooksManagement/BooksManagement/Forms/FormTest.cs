using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using BooksManagement.DBOpreation;

namespace BooksManagement.Forms
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = DBInteraction.FindBooksByName("乌合之众");

            label1.Text = dt.Rows.Count.ToString();

            foreach (DataRow item in dt.Rows)
            {
                label1.Text += "   " + item[0] + "   " + item[1] + "   " + item[2] + "   " + item[3] + "   " + item[4];
            }

            dgvBooks.DataSource = DBInteraction.FindBooksByName("乌合之众");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = DBInteraction.UpdateBookName("乌合之众", "2").ToString();
        }
        WebBrowser webBrower = new WebBrowser();
        private void button3_Click(object sender, EventArgs e)
        {
            string pageUrl = "http://book.douban.com/subject_search?search_text=%E6%95%B0%E5%AD%A6%E4%B9%8B%E7%BE%8E&cat=1001";
            WebClient wc = new WebClient();
            byte[] pageSourceBytes = wc.DownloadData(new Uri(pageUrl));
            string pageSource = Encoding.GetEncoding("utf-8").GetString(pageSourceBytes);

            //webBrower.Navigate(pageUrl);
            //webBrower.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowserComplete);

            MatchCollection mc = Regex.Matches(pageSource, @"<\s?img[^>]+src=""([^""]+)""");//使用正则表达式进行匹配，因为所获的图片较多，所以常见一个List集合储存； 
            List<string> pic = new List<string>();
            foreach (Match m in mc)//进行遍历 
            {
                if (m.Success)//若是能够匹配的字符串放到pic集合中 
                {
                    pic.Add(m.Groups[1].Value.Trim());//获得图片 src="~~~"的形式；提取图片名称 
                }

            }
            foreach (string picture in pic)
            {
                listBox1.Items.Add(picture);
            }
           
        }

        public void WebBrowserComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = webBrower.Document;
            HtmlElementCollection list = doc.All;
            loop(list);
        }

        private int i;
        private void loop(HtmlElementCollection list)
        {
            foreach (HtmlElement item in list)
            {
                if (item.InnerText != null && item.InnerText == "思科九年")
                {
                    listBox1.Items.Add("Level:   " + i.ToString());
                    i++;
                    listBox1.Items.Add("#### ID: " + item.Id);
                    listBox1.Items.Add("#### Name: " + item.Name);
                    listBox1.Items.Add("#### TabIndex: " + item.TabIndex);
                    listBox1.Items.Add("#### TagName: " + item.TagName);
                    listBox1.Items.Add("#### CanHaveChildren: " + item.CanHaveChildren);
                    listBox1.Items.Add("#### OuterHtml: " + item.OuterHtml);
                    listBox1.Items.Add("#### OuterText: " + item.OuterText);
                    listBox1.Items.Add("#### GetAttribute(\"class\"): " + item.GetAttribute("class"));
                    listBox1.Items.Add("");


                }
                loop(item.Children);

            }
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("Complete!!!!!!!!!!!!!!!!!!!!!!");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
            //listBox1.Items.Add("");
        }
    }
}
