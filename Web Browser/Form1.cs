using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the Form to fit the User Screen 
            this.WindowState = FormWindowState.Maximized;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string inputValue = this.urlInput.Text.ToString();
            webBrowser1.Navigate(new Uri(inputValue)); 
            

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void goForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }



        private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about AboutForm = new about();
            AboutForm.Show(); 
        }

        private void urlInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void facebook_Click(object sender, EventArgs e)
        {
            string FacebookUrl = "http://www.facebook.com";
            webBrowser1.Navigate(new Uri(FacebookUrl)); 

        }

        private void twitter_Click(object sender, EventArgs e)
        {
            string TwitterUrl = "http://www.twitter.com";
            webBrowser1.Navigate(new Uri(TwitterUrl)); 
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            string YoutubeUrl = "http://www.youtube.com";
            webBrowser1.Navigate(new Uri(YoutubeUrl)); 
        }

        

        private void home_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoHome(); 
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // the print Dialog 
            webBrowser1.ShowPrintDialog();
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Document != null)
            {
                
                source sourceCodeDialog = new source();
                string src = sourceCodeDialog.srccode; 
                sourceCodeDialog.srccode = webBrowser1.DocumentText.ToString();
                sourceCodeDialog.Show();

            }

        }

      

    }
}
