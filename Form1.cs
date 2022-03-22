using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace menu_Strip_Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
    {
            txtEditor.Paste();
        }
    }
}
