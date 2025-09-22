using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LZW
{
    public partial class frmDisplayParameters : Form
    {
        public frmDisplayParameters(LZWDisplayedCol objCol)
        {
            InitializeComponent();
            grdDisplay.DataSource = objCol;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}