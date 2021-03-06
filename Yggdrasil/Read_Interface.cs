﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Yggdrasil.Model;
using System.IO;

namespace Yggdrasil
{
    
    public partial class Read_Interface : Form
    {
        
        public static int pageNumber = 1;
        static int totalPage = 2;
        int head = 0;
        private string bookURL;
        public Read_Interface(string bookurl)
        {
            InitializeComponent();
            bookURL = bookurl;
            ChapterName.Text = string.Format(@"Chapter"+Book_Interface.chapNo.ToString());
            if (IsInternetAvailable())
            {
                WebClient wc = new WebClient();
                Stream FirstPage = wc.OpenRead(bookURL);
                StreamReader sr = new StreamReader(FirstPage, Encoding.UTF8);
                String content = sr.ReadToEnd();
                content = content.Replace("\n", "\r\n");
                totalPage = Convert.ToInt32(content.Length / 500) + 1;
                head = (pageNumber - 1) * 500;
                if (content.Length >= 500)
                {
                    BookContents.Text = content.Substring(head, 500);
                }
                else
                {
                    BookContents.Text = content.Substring(head, content.Length - head - 1);
                }
                FirstPage.Close();
                sr.Close();
                wc.Dispose();
            }
            else
            {
                MessageBox.Show("Please check your network");
            }
        }

        private void ChapterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            if (IsInternetAvailable())
            {
                pageNumber--;
                if (pageNumber <= 0)
                {
                    pageNumber = 0;
                    BookContents.Text = "Sorry! This is the first page of current chapter";
                }
                else
                {
                    WebClient wc = new WebClient();
                    Stream CurrentPage = wc.OpenRead(bookURL);
                    StreamReader sr = new StreamReader(CurrentPage, Encoding.UTF8);
                    String content = sr.ReadToEnd();
                    content = content.Replace("\n", "\r\n");
                    head = (pageNumber - 1) * 500;
                    if (content.Length - head >= 500)
                    {
                        BookContents.Text = content.Substring(head, 500);
                    }
                    else
                    {
                        BookContents.Text = content.Substring(head, content.Length - head - 1);
                    }
                    CurrentPage.Close();
                    sr.Close();
                    wc.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please check your network");
            }
        }

        private void NextButton_Click(object sender, EventArgs e)      
        {
            if (IsInternetAvailable())
            {
                pageNumber++;
                if (pageNumber > totalPage)
                {
                    pageNumber = totalPage + 1;
                    BookContents.Text = "Sorry! This is the last page of current chapter";
                }
                else
                {
                    WebClient wc = new WebClient();
                    Stream CurrentPage = wc.OpenRead(bookURL);
                    StreamReader sr = new StreamReader(CurrentPage, Encoding.UTF8);
                    String content = sr.ReadToEnd();
                    content = content.Replace("\n", "\r\n");
                    head = (pageNumber - 1) * 500;
                    if (content.Length - head >= 500)
                    {
                        BookContents.Text = content.Substring(head, 500);
                    }
                    else
                    {
                        BookContents.Text = content.Substring(head, content.Length - head - 1);
                    }
                    CurrentPage.Close();
                    sr.Close();
                    wc.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please check your network");
            }

        }

        //function used to check network
        private bool IsInternetAvailable()
        {
            try
            {
                Dns.GetHostEntry("www.baidu.com");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void Contents_TextChanged(object sender, EventArgs e)
        {

        }

        private void Read_Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
