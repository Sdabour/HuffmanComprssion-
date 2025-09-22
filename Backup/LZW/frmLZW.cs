using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;
using System.Threading;
namespace LZW
{
    delegate void ControlHandeler();
    public partial class frmLZW : Form
    {
        #region Private data
        string _UncompressedPath;
        string _DistPath;
        string _CompressedPath;
        string _DirectoryPath;
        MemoryStream _Ms;
        LZWSymbolCol _LzwSymbolCol;
        #endregion
        #region Private Method
        public static bool ConvertImageToByteArray(string strImagePath, ref byte[] OutByte)
        {
            bool blRerturned = false;
            try
            {
                Image tempImage = Image.FromFile(strImagePath);
                MemoryStream tempMs = new MemoryStream();
                tempImage.Save(tempMs, ImageFormat.Jpeg);
                OutByte = tempMs.ToArray();
                blRerturned = true;
            }
            catch
            {

            }
            return blRerturned;

        }
        void CompressFile()
        {

            byte[] arrByte = new byte[0];
            ConvertImageToByteArray(_UncompressedPath, ref arrByte);
            
            _LzwSymbolCol = new LZWSymbolCol(arrByte);
            LZWCompressedFile objLZWFile = new LZWCompressedFile(1, _LzwSymbolCol.CodeTable, _LzwSymbolCol.OutArr);
            FileStream Fs = new FileStream(_DistPath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter Bf = new BinaryFormatter();
            Bf.Serialize(Fs, objLZWFile);
            Fs.Close();
            btnProcess.Invoke(new ControlHandeler(EnableProcessBtn));

        }
        void DecompressFile()
        {
            FileStream Fs = new FileStream(_CompressedPath, FileMode.Open, FileAccess.Read);
            BinaryFormatter Bf = new BinaryFormatter();
            LZWCompressedFile objFile = (LZWCompressedFile)Bf.Deserialize(Fs);
            
            Fs.Close();
            _Ms = new MemoryStream(objFile.GetImageByteArray());
            
            imgResultPic.Image = Image.FromStream(_Ms);
            btnProcess.Invoke(new ControlHandeler(EnableProcessBtn));
            imgResultPic.Invoke(new ControlHandeler(DisplayDecompressedImage));
          


        }
        void EnableProcessBtn()
        {
            btnProcess.Enabled = true;
        }
        void DisplayDecompressedImage()
        {
            imgResultPic.Image = Image.FromStream(_Ms);
        }

        #endregion
        public frmLZW()
        {
            InitializeComponent();
            _DirectoryPath = Directory.GetCurrentDirectory();
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            string strStartDirectory = _DirectoryPath+ @"\" + "UncompressedPath"; 
            if (!Directory.Exists(strStartDirectory))
                Directory.CreateDirectory(strStartDirectory);
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = strStartDirectory;
           dlg.Filter = "All files (*.*)|*.*| BMP files (*.BMP)|*.BMP";
           DialogResult dlgResult = dlg.ShowDialog();
           if (dlgResult == DialogResult.OK)
           {
               _UncompressedPath = dlg.FileName;
               try
               {
                   imgSrcPic.Image = Image.FromFile(_UncompressedPath);
                   lblUncompressedPath.Text = _UncompressedPath;
               }
               catch { }
               
           }
           else
           {
               _UncompressedPath = "";
               lblUncompressedPath.Text = "||";
               imgSrcPic.Image = null;
           }
           btnCancelCompressedPath_Click(sender, e);
           btnCancelDistPath_Click(sender, e);

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (_DistPath == null || _DistPath == "")
            {
                MessageBox.Show("Plz Decide The Distination");
                return;
            }
            if ((_CompressedPath == null || _CompressedPath == "")
                && (_UncompressedPath == null || _UncompressedPath == ""))
            {
                MessageBox.Show("Plz Decide Path of The file To Be Compressed Or Decompressed");
                return;
            }
           
            btnProcess.Enabled = false;
            ThreadStart objHandler;
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

        private void btnGetCompressedImage_Click(object sender, EventArgs e)
        {
            string strStartDirectory = _DirectoryPath + @"\" + "CompressedPath";
            if (!Directory.Exists(strStartDirectory))
                Directory.CreateDirectory(strStartDirectory);
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = strStartDirectory;
            dlg.Filter = "GIF files (*.GIF)|*.GIF";
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                _CompressedPath = dlg.FileName;
               // imgResultPic.Image = Image.FromFile(_CompressedPath);
                lblCompressedPath.Text = _CompressedPath;

            }
            else
            {
                _CompressedPath = "";
                lblCompressedPath.Text = "||";
                imgResultPic.Image = null;
            }
            btnCancelUnCompressedPath_Click(sender, e);
            btnCancelDistPath_Click(sender, e);
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
            SaveFileDialog dlgSaveDlg = new SaveFileDialog();
            if (_UncompressedPath != null && _UncompressedPath != "")
                dlgSaveDlg.Filter = "Gif files (*.gif)|*.gif";
            else if (_CompressedPath != null || _CompressedPath != "")
                dlgSaveDlg.Filter = "Bmp files (*.Bmp)|*.Bmp";
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

        private void btnDisplayResult_Click(object sender, EventArgs e)
        {
            if (_LzwSymbolCol == null)
                return;
            frmDisplayCompressedUncompressed Frm = new frmDisplayCompressedUncompressed(_LzwSymbolCol);
            Frm.ShowDialog();
        }
    }
}