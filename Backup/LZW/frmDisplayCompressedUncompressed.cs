using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LZW
{
    public partial class frmDisplayCompressedUncompressed : Form
    {
        LZWDisplayedCol _DisplayCol;
        public frmDisplayCompressedUncompressed(LZWSymbolCol objCol)
        {
            InitializeComponent();
            txtUncompressedSequence.Text = objCol.ByteArrStr;
            txtCompressedSequence.Text = objCol.OutShortArrStr;
            lblByteNo.Text = objCol.MainArrayLen.ToString();
            lblShortNo.Text = objCol.OutArr.Length.ToString();
            _DisplayCol = new LZWDisplayedCol(objCol.CodeTable);
            grdDisplay.DataSource = _DisplayCol;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOut_KeyUp(object sender, KeyEventArgs e)
        {
            txtIN.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOut.Text != "")
                {
                    string strIN = _DisplayCol.GetInArr(txtOut.Text);
                    if (strIN != "")
                        txtIN.Text = strIN;
                }
 
            }
        }

      
    }
}