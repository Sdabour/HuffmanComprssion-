namespace Huffman
{
    partial class frmHuffman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dlgFile = new System.Windows.Forms.OpenFileDialog();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.lblUncompressedPath = new System.Windows.Forms.Label();
            this.btnSetDestPath = new System.Windows.Forms.Button();
            this.lblDist = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCompressedPath = new System.Windows.Forms.Label();
            this.btnGetCompressedFile = new System.Windows.Forms.Button();
            this.dlgDistPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancelUnCompressedPath = new System.Windows.Forms.Button();
            this.btnCancelCompressedPath = new System.Windows.Forms.Button();
            this.btnCancelDistPath = new System.Windows.Forms.Button();
            this.dlgSaveDlg = new System.Windows.Forms.SaveFileDialog();
            this.txtCompressedStr = new System.Windows.Forms.TextBox();
            this.txtDeCompressedStr = new System.Windows.Forms.TextBox();
            this.lblAvgLen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultLen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEtropy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dlgFile
            // 
            this.dlgFile.FileName = "openFileDialog1";
            // 
            // btnGetFile
            // 
            this.btnGetFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFile.Location = new System.Drawing.Point(6, 27);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(171, 43);
            this.btnGetFile.TabIndex = 0;
            this.btnGetFile.Text = "Un Compressed File";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // lblUncompressedPath
            // 
            this.lblUncompressedPath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUncompressedPath.ForeColor = System.Drawing.Color.Red;
            this.lblUncompressedPath.Location = new System.Drawing.Point(191, 34);
            this.lblUncompressedPath.Name = "lblUncompressedPath";
            this.lblUncompressedPath.Size = new System.Drawing.Size(573, 23);
            this.lblUncompressedPath.TabIndex = 1;
            this.lblUncompressedPath.Text = "||";
            // 
            // btnSetDestPath
            // 
            this.btnSetDestPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDestPath.Location = new System.Drawing.Point(20, 160);
            this.btnSetDestPath.Name = "btnSetDestPath";
            this.btnSetDestPath.Size = new System.Drawing.Size(141, 35);
            this.btnSetDestPath.TabIndex = 2;
            this.btnSetDestPath.Text = "Destination Path";
            this.btnSetDestPath.UseVisualStyleBackColor = true;
            this.btnSetDestPath.Click += new System.EventHandler(this.btnSetDistPath_Click);
            // 
            // lblDist
            // 
            this.lblDist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDist.ForeColor = System.Drawing.Color.Red;
            this.lblDist.Location = new System.Drawing.Point(191, 167);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(573, 23);
            this.lblDist.TabIndex = 3;
            this.lblDist.Text = "||";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(218, 493);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(112, 35);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(557, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCompressedPath
            // 
            this.lblCompressedPath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressedPath.ForeColor = System.Drawing.Color.Red;
            this.lblCompressedPath.Location = new System.Drawing.Point(191, 98);
            this.lblCompressedPath.Name = "lblCompressedPath";
            this.lblCompressedPath.Size = new System.Drawing.Size(573, 23);
            this.lblCompressedPath.TabIndex = 7;
            this.lblCompressedPath.Text = "||";
            // 
            // btnGetCompressedFile
            // 
            this.btnGetCompressedFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCompressedFile.Location = new System.Drawing.Point(6, 91);
            this.btnGetCompressedFile.Name = "btnGetCompressedFile";
            this.btnGetCompressedFile.Size = new System.Drawing.Size(171, 43);
            this.btnGetCompressedFile.TabIndex = 6;
            this.btnGetCompressedFile.Text = "Compressed File";
            this.btnGetCompressedFile.UseVisualStyleBackColor = true;
            this.btnGetCompressedFile.Click += new System.EventHandler(this.btnGetCompressedFile_Click);
            // 
            // btnCancelUnCompressedPath
            // 
            this.btnCancelUnCompressedPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUnCompressedPath.Location = new System.Drawing.Point(779, 27);
            this.btnCancelUnCompressedPath.Name = "btnCancelUnCompressedPath";
            this.btnCancelUnCompressedPath.Size = new System.Drawing.Size(92, 35);
            this.btnCancelUnCompressedPath.TabIndex = 8;
            this.btnCancelUnCompressedPath.Text = "Cancel";
            this.btnCancelUnCompressedPath.UseVisualStyleBackColor = true;
            this.btnCancelUnCompressedPath.Click += new System.EventHandler(this.btnCancelUnCompressedPath_Click);
            // 
            // btnCancelCompressedPath
            // 
            this.btnCancelCompressedPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCompressedPath.Location = new System.Drawing.Point(779, 86);
            this.btnCancelCompressedPath.Name = "btnCancelCompressedPath";
            this.btnCancelCompressedPath.Size = new System.Drawing.Size(92, 35);
            this.btnCancelCompressedPath.TabIndex = 9;
            this.btnCancelCompressedPath.Text = "Cancel";
            this.btnCancelCompressedPath.UseVisualStyleBackColor = true;
            this.btnCancelCompressedPath.Click += new System.EventHandler(this.btnCancelCompressedPath_Click);
            // 
            // btnCancelDistPath
            // 
            this.btnCancelDistPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDistPath.Location = new System.Drawing.Point(779, 160);
            this.btnCancelDistPath.Name = "btnCancelDistPath";
            this.btnCancelDistPath.Size = new System.Drawing.Size(92, 35);
            this.btnCancelDistPath.TabIndex = 10;
            this.btnCancelDistPath.Text = "Cancel";
            this.btnCancelDistPath.UseVisualStyleBackColor = true;
            this.btnCancelDistPath.Click += new System.EventHandler(this.btnCancelDistPath_Click);
            // 
            // txtCompressedStr
            // 
            this.txtCompressedStr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCompressedStr.Location = new System.Drawing.Point(101, 373);
            this.txtCompressedStr.Multiline = true;
            this.txtCompressedStr.Name = "txtCompressedStr";
            this.txtCompressedStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCompressedStr.Size = new System.Drawing.Size(733, 39);
            this.txtCompressedStr.TabIndex = 11;
            // 
            // txtDeCompressedStr
            // 
            this.txtDeCompressedStr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDeCompressedStr.Location = new System.Drawing.Point(101, 439);
            this.txtDeCompressedStr.Multiline = true;
            this.txtDeCompressedStr.Name = "txtDeCompressedStr";
            this.txtDeCompressedStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeCompressedStr.Size = new System.Drawing.Size(733, 48);
            this.txtDeCompressedStr.TabIndex = 12;
            // 
            // lblAvgLen
            // 
            this.lblAvgLen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgLen.ForeColor = System.Drawing.Color.Red;
            this.lblAvgLen.Location = new System.Drawing.Point(296, 229);
            this.lblAvgLen.Name = "lblAvgLen";
            this.lblAvgLen.Size = new System.Drawing.Size(234, 23);
            this.lblAvgLen.TabIndex = 13;
            this.lblAvgLen.Text = "||";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Result Avg Len";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Length Without Compression";
            // 
            // lblLen
            // 
            this.lblLen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLen.ForeColor = System.Drawing.Color.Red;
            this.lblLen.Location = new System.Drawing.Point(296, 270);
            this.lblLen.Name = "lblLen";
            this.lblLen.Size = new System.Drawing.Size(234, 23);
            this.lblLen.TabIndex = 15;
            this.lblLen.Text = "||";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Result Len";
            // 
            // lblResultLen
            // 
            this.lblResultLen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultLen.ForeColor = System.Drawing.Color.Red;
            this.lblResultLen.Location = new System.Drawing.Point(296, 317);
            this.lblResultLen.Name = "lblResultLen";
            this.lblResultLen.Size = new System.Drawing.Size(234, 23);
            this.lblResultLen.TabIndex = 17;
            this.lblResultLen.Text = "||";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Compressed Stream";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Uncompressed Stream";
            // 
            // lblEtropy
            // 
            this.lblEtropy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtropy.ForeColor = System.Drawing.Color.Red;
            this.lblEtropy.Location = new System.Drawing.Point(674, 229);
            this.lblEtropy.Name = "lblEtropy";
            this.lblEtropy.Size = new System.Drawing.Size(178, 23);
            this.lblEtropy.TabIndex = 21;
            this.lblEtropy.Text = "||";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(554, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Entropy";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(388, 493);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(112, 35);
            this.btnDisplay.TabIndex = 23;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // frmHuffman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 540);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEtropy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultLen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAvgLen);
            this.Controls.Add(this.txtDeCompressedStr);
            this.Controls.Add(this.txtCompressedStr);
            this.Controls.Add(this.btnCancelDistPath);
            this.Controls.Add(this.btnCancelCompressedPath);
            this.Controls.Add(this.btnCancelUnCompressedPath);
            this.Controls.Add(this.lblCompressedPath);
            this.Controls.Add(this.btnGetCompressedFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.btnSetDestPath);
            this.Controls.Add(this.lblUncompressedPath);
            this.Controls.Add(this.btnGetFile);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmHuffman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huffman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgFile;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Label lblUncompressedPath;
        private System.Windows.Forms.Button btnSetDestPath;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCompressedPath;
        private System.Windows.Forms.Button btnGetCompressedFile;
        private System.Windows.Forms.FolderBrowserDialog dlgDistPath;
        private System.Windows.Forms.Button btnCancelUnCompressedPath;
        private System.Windows.Forms.Button btnCancelCompressedPath;
        private System.Windows.Forms.Button btnCancelDistPath;
        private System.Windows.Forms.SaveFileDialog dlgSaveDlg;
        private System.Windows.Forms.TextBox txtCompressedStr;
        private System.Windows.Forms.TextBox txtDeCompressedStr;
        private System.Windows.Forms.Label lblAvgLen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultLen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEtropy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDisplay;
    }
}

