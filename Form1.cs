using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace Test
{
    public partial class Form1 : Form
    {
        WebView webView;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webView = new WebView("http://www.google.com", new BrowserSettings());
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);
            
        }
    }
}
