using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
namespace Huffman
{
    public delegate void HandleControlEvent();
    /// <summary>
    /// developed by Eng.Sameh Mohamed Dabour 
    /// www.algorithmat.com
    /// </summary>
    public partial class frmHuffman : Form
    {
        /// <summary>
        /// The main Form
        /// </summary>
        #region Private Data
        string _DistPath;
        string _UncompressedPath;
        string _CompressedPath;
        string _DirectoryPath;
       
        HuffmanSymbolCol _HuffmanSymbolCol;
        #endregion
        public frmHuffman()
        {
            InitializeComponent();
            _DirectoryPath = Directory.GetCurrentDirectory();

        }
        #region Private Method
       void  CompressFile()
        {
            
            FileStream Fs = new FileStream(_UncompressedPath, FileMode.Open, FileAccess.Read);
            StreamReader Sr = new StreamReader(Fs);
           char [] arrBuffer= new char[30000];
           Sr.Read(arrBuffer, 0, 30000);
           Sr.Close();
           Fs.Close();
           string strContent = new string(arrBuffer);
           strContent = strContent.Trim();
           strContent = strContent.Replace("\0", "");
          _HuffmanSymbolCol = new HuffmanSymbolCol(strContent);
          lblAvgLen.Invoke(new HandleControlEvent(SetLblControl));
          txtCompressedStr.Invoke(new HandleControlEvent(SetCompressionText));
           byte [] arrByte = HuffmanCompressedFile.ConvertToBinary(_HuffmanSymbolCol.CompressedMsg);
        
           HuffmanCompressedFile objFile = new HuffmanCompressedFile(arrByte, _HuffmanSymbolCol.CodeTable);
           Fs = new FileStream(_DistPath, FileMode.OpenOrCreate, FileAccess.Write);
           BinaryFormatter Bf = new BinaryFormatter();
           Bf.Serialize(Fs, objFile);
           Fs.Close();
           btnProcess.Invoke(new HandleControlEvent(EnableProcessBtn));

        }
        void DecompressFile()
        {
            FileStream Fs = new FileStream(_CompressedPath, FileMode.Open, FileAccess.Read);
            //StreamReader Sr = new StreamReader(Fs);
            //char[] arrBuffer = new char[1024];
            BinaryFormatter Bf = new BinaryFormatter();
            HuffmanCompressedFile objFile = (HuffmanCompressedFile)Bf.Deserialize(Fs);
            string strContent = HuffmanCompressedFile.ConvertToString(objFile.ByteArr);

            Fs.Close();

            string strResult = HuffmanCompressedFile.DecompressString(strContent, objFile.CodeTable);
            Fs = new FileStream(_DistPath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter Sw = new StreamWriter(Fs);
            Sw.Write(strResult);
            Sw.Close();
            Fs.Close();
            btnProcess.Invoke(new HandleControlEvent(EnableProcessBtn));


 
        }
        void SetLblControl()
        {
            lblAvgLen.Text = _HuffmanSymbolCol.AvgLen.ToString();
            lblEtropy.Text = _HuffmanSymbolCol.Entropy.ToString();
            lblLen.Text = _HuffmanSymbolCol.Len.ToString();
            lblResultLen.Text = _HuffmanSymbolCol.ResultLen.ToString();
        }
        void SetCompressionText()
        {
            txtCompressedStr.Text = _HuffmanSymbolCol.CompressedMsg;
            txtDeCompressedStr.Text = HuffmanCompressedFile.DecompressString(_HuffmanSymbolCol.CompressedMsg, _HuffmanSymbolCol.CodeTable);
        }
        void EnableProcessBtn()
        {
            btnProcess.Enabled = true;
        }
        #endregion

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            string strStartDirectory = _DirectoryPath + @"\" + "UncompressedPath";
            if (!Directory.Exists(strStartDirectory))
                Directory.CreateDirectory(strStartDirectory);
            dlgFile = new OpenFileDialog();
            dlgFile.InitialDirectory = strStartDirectory;
            dlgFile.Filter = "Text files (*.txt)|*.txt";
            DialogResult objDlg = dlgFile.ShowDialog();
            if (objDlg == DialogResult.OK)
            {
                lblUncompressedPath.Text = dlgFile.FileName;
                _UncompressedPath = dlgFile.FileName;
            }
            btnCancelDistPath_Click(sender, e);
            btnCancelCompressedPath_Click(sender, e);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(_DistPath == null || _DistPath == "")
            {
                MessageBox.Show("Plz Decide The Distination");
                return;
            }
            if((_CompressedPath==null ||_CompressedPath=="")
                && (_UncompressedPath == null|| _UncompressedPath ==""))
            {
                MessageBox.Show("Plz Decide Path of The file To Be Compressed Or Decompressed");
                return;
            }
            btnProcess.Enabled = false;
            ThreadStart  objHandler;
            if (_UncompressedPath != null && _UncompressedPath != "")
            {
                objHandler = new ThreadStart(CompressFile);
            }
            else
            {
                objHandler = new ThreadStart(DecompressFile);
            }
            Thread Th = new Thread(objHandler);
            Th.IsBackground = true;
            Th.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetDistPath_Click(object sender, EventArgs e)
        {

            string strStartDirectory = "";
            if (_UncompressedPath != null && _UncompressedPath != "")
                strStartDirectory = _DirectoryPath + @"\" + "UnCompressedPath";
            else if (_CompressedPath != null || _CompressedPath != "")
                strStartDirectory = _DirectoryPath + @"\" + "CompressedPath";
            else
                return;
            if (!Directory.Exists(strStartDirectory))
                Directory.CreateDirectory(strStartDirectory);
            dlgSaveDlg = new SaveFileDialog();
            if (_UncompressedPath != null && _UncompressedPath != "")
                dlgSaveDlg.Filter = "dat files (*.dat)|*.dat";
            else if (_CompressedPath != null || _CompressedPath != "")
                dlgSaveDlg.Filter = "Text files (*.txt)|*.txt";
            else
                return;
            dlgSaveDlg.InitialDirectory = strStartDirectory;
            DialogResult dlgResult = dlgSaveDlg.ShowDialog();
           
            if (dlgResult == DialogResult.OK)
            {
                _DistPath = dlgSaveDlg.FileName;
                lblDist.Text = _DistPath;
            }
           
            

        }

        private void btnCancelUnCompressedPath_Click(object sender, EventArgs e)
        {
            _UncompressedPath = "";
            lblUncompressedPath.Text = "||";

        }

        private void btnCancelCompressedPath_Click(object sender, EventArgs e)
        {
            _CompressedPath = "";
            lblCompressedPath.Text = "||";
        }

        private void btnCancelDistPath_Click(object sender, EventArgs e)
        {
            _DistPath = "";
            lblDist.Text = "||";
        }

        private void btnGetCompressedFile_Click(object sender, EventArgs e)
        {
            string strStartDirectory = _DirectoryPath + @"\" + "CompressedPath";
            if (!Directory.Exists(strStartDirectory))
                Directory.CreateDirectory(strStartDirectory);
            dlgFile = new OpenFileDialog();
            dlgFile.InitialDirectory = strStartDirectory;
            dlgFile.Filter = "Dat files (*.dat)|*.dat";
            DialogResult objDlg = dlgFile.ShowDialog();
            if (objDlg == DialogResult.OK)
            {
                lblCompressedPath.Text = dlgFile.FileName;
                _CompressedPath = dlgFile.FileName;
            }
            btnCancelDistPath_Click(sender, e);
            btnCancelUnCompressedPath_Click(sender, e);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (_HuffmanSymbolCol == null || _HuffmanSymbolCol.Count == 0)
                return;
            frmDisplayParameters Frm = new frmDisplayParameters(new HuffmanDisplayedCol(_HuffmanSymbolCol.LetterTable));
            Frm.ShowDialog();
        }

       

       
    }
}