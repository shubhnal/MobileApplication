﻿
using SHA3.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileApplication
{
    public partial class MainForm : Form
    {
       
        Sha3 sha;
        public MainForm()
        {

            InitializeComponent();
        }

        static byte[] ComputeHash(string input)
        {
            byte[] byteArray = Encoding.UTF32.GetBytes(input);
            MemoryStream stream = new MemoryStream(byteArray);
            var hash = Sha3.Sha3256().ComputeHash(stream);

            stream = new MemoryStream(hash);
            StreamReader rdr = new StreamReader(stream);
            string tst = rdr.ReadToEnd();
            return hash;
        }

        //tmp button for testing MakeInvoicePage. Later, should be deleted.
        private void Button1_Click(object sender, EventArgs e)
        {
            MakeInvoicePage mkf = new MakeInvoicePage();
            mkf.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CustomersPage page = new CustomersPage();
            page.ShowDialog();
        }
    }
}
