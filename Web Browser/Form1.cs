using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewTab();
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoBack)
                    browser.GoBack();
            }
        }

        private void mlNext_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoForward)
                    browser.GoForward();
            }
        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                browser.Navigate(txtPageURL.Text);
            }
        }

        private void mbtnNewTab_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void NewTab()
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            metroTabControl.Controls.Add(tab);
            metroTabControl.SelectTab(metroTabControl.TabCount - 1);
            WebBrowser browser = new WebBrowser() { ScriptErrorsSuppressed = true };
            browser.Parent = tab;
            browser.Dock = DockStyle.Fill;
            browser.Navigate("https://www.google.com");
            txtPageURL.Text = "https://www.google.com";
            browser.DocumentCompleted += Browser_DocumentCompleted;
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if(browser != null)
            {
                metroTabControl.SelectedTab.Text = browser.DocumentTitle;
            }
        }
    }
}
