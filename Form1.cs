using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FortniteLauncha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://rebrand.ly/authcode");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FNExePath = System.IO.Path.Combine(this.PathTextBox.Text, "FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe");
            string auth = "exchange.Text";
            System.Diagnostics.Process.Start(FNExePath, auth);
        }
    }
}
