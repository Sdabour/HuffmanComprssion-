namespace LZW
{
    partial class frmLZW
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
            this.lblUncompressedPath = new System.Windows.Forms.Label();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.imgSrcPic = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgResultPic = new System.Windows.Forms.PictureBox();
            this.btnGetCompressedImage = new System.Windows.Forms.Button();
            this.lblCompressedPath = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancelDistPath = new System.Windows.Forms.Button();
            this.lblDist = new System.Windows.Forms.Label();
            this.btnSetDistPath = new System.Windows.Forms.Button();
            this.btnCancelUnCompressedPath = new System.Windows.Forms.Button();
            this.btnCancelCompressedPath = new System.Windows.Forms.Button();
            this.btnDisplayResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSrcPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUncompressedPath
            // 
            this.lblUncompressedPath.ForeColor = System.Drawing.Color.Red;
            this.lblUncompressedPath.Location = new System.Drawing.Point(307, 364);
            this.lblUncompressedPath.Name = "lblUncompressedPath";
            this.lblUncompressedPath.Size = new System.Drawing.Size(612, 32);
            this.lblUncompressedPath.TabIndex = 0;
            this.lblUncompressedPath.Text = "||";
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(91, 354);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(160, 32);
            this.btnGetImage.TabIndex = 1;
            this.btnGetImage.Text = "Get Uncompressed  Image";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // imgSrcPic
            // 
            this.imgSrcPic.Location = new System.Drawing.Point(6, 8);
            this.imgSrcPic.Name = "imgSrcPic";
            this.imgSrcPic.Size = new System.Drawing.Size(479, 323);
            this.imgSrcPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSrcPic.TabIndex = 2;
            this.imgSrcPic.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.imgSrcPic);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(387, 503);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(116, 45);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.imgResultPic);
            this.groupBox2.Location = new System.Drawing.Point(564, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 340);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // imgResultPic
            // 
            this.imgResultPic.Location = new System.Drawing.Point(6, 8);
            this.imgResultPic.Name = "imgResultPic";
            this.imgResultPic.Size = new System.Drawing.Size(479, 323);
            this.imgResultPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgResultPic.TabIndex = 2;
            this.imgResultPic.TabStop = false;
            // 
            // btnGetCompressedImage
            // 
            this.btnGetCompressedImage.Location = new System.Drawing.Point(91, 388);
            this.btnGetCompressedImage.Name = "btnGetCompressedImage";
            this.btnGetCompressedImage.Size = new System.Drawing.Size(160, 32);
            this.btnGetCompressedImage.TabIndex = 7;
            this.btnGetCompressedImage.Text = "Get  Compressed Image";
            this.btnGetCompressedImage.UseVisualStyleBackColor = true;
            this.btnGetCompressedImage.Click += new System.EventHandler(this.btnGetCompressedImage_Click);
            // 
            // lblCompressedPath
            // 
            this.lblCompressedPath.ForeColor = System.Drawing.Color.Red;
            this.lblCompressedPath.Location = new System.Drawing.Point(307, 398);
            this.lblCompressedPath.Name = "lblCompressedPath";
            this.lblCompressedPath.Size = new System.Drawing.Size(612, 32);
            this.lblCompressedPath.TabIndex = 6;
            this.lblCompressedPath.Text = "||";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(570, 503);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancelDistPath
            // 
            this.btnCancelDistPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDistPath.Location = new System.Drawing.Point(925, 450);
            this.btnCancelDistPath.Name = "btnCancelDistPath";
            this.btnCancelDistPath.Size = new System.Drawing.Size(79, 35);
            this.btnCancelDistPath.TabIndex = 13;
            this.btnCancelDistPath.Text = "Cancel";
            this.btnCancelDistPath.UseVisualStyleBackColor = true;
            this.btnCancelDistPath.Click += new System.EventHandler(this.btnCancelDistPath_Click);
            // 
            // lblDist
            // 
            this.lblDist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDist.ForeColor = System.Drawing.Color.Red;
            this.lblDist.Location = new System.Drawing.Point(306, 457);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(613, 23);
            this.lblDist.TabIndex = 12;
            this.lblDist.Text = "||";
            // 
            // btnSetDistPath
            // 
            this.btnSetDistPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDistPath.Location = new System.Drawing.Point(103, 450);
            this.btnSetDistPath.Name = "btnSetDistPath";
            this.btnSetDistPath.Size = new System.Drawing.Size(121, 35);
            this.btnSetDistPath.TabIndex = 11;
            this.btnSetDistPath.Text = "Distination Path";
            this.btnSetDistPath.UseVisualStyleBackColor = true;
            this.btnSetDistPath.Click += new System.EventHandler(this.btnSetDistPath_Click);
            // 
            // btnCancelUnCompressedPath
            // 
            this.btnCancelUnCompressedPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUnCompressedPath.Location = new System.Drawing.Point(925, 354);
            this.btnCancelUnCompressedPath.Name = "btnCancelUnCompressedPath";
            this.btnCancelUnCompressedPath.Size = new System.Drawing.Size(79, 35);
            this.btnCancelUnCompressedPath.TabIndex = 14;
            this.btnCancelUnCompressedPath.Text = "Cancel";
            this.btnCancelUnCompressedPath.UseVisualStyleBackColor = true;
            this.btnCancelUnCompressedPath.Click += new System.EventHandler(this.btnCancelUnCompressedPath_Click);
            // 
            // btnCancelCompressedPath
            // 
            this.btnCancelCompressedPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCompressedPath.Location = new System.Drawing.Point(925, 395);
            this.btnCancelCompressedPath.Name = "btnCancelCompressedPath";
            this.btnCancelCompressedPath.Size = new System.Drawing.Size(79, 35);
            this.btnCancelCompressedPath.TabIndex = 15;
            this.btnCancelCompressedPath.Text = "Cancel";
            this.btnCancelCompressedPath.UseVisualStyleBackColor = true;
            this.btnCancelCompressedPath.Click += new System.EventHandler(this.btnCancelCompressedPath_Click);
            // 
            // btnDisplayResult
            // 
            this.btnDisplayResult.Location = new System.Drawing.Point(185, 503);
            this.btnDisplayResult.Name = "btnDisplayResult";
            this.btnDisplayResult.Size = new System.Drawing.Size(116, 45);
            this.btnDisplayResult.TabIndex = 16;
            this.btnDisplayResult.Text = "Display Result";
            this.btnDisplayResult.UseVisualStyleBackColor = true;
            this.btnDisplayResult.Click += new System.EventHandler(this.btnDisplayResult_Click);
            // 
            // frmLZW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 560);
            this.Controls.Add(this.btnDisplayResult);
            this.Controls.Add(this.btnCancelCompressedPath);
            this.Controls.Add(this.btnCancelUnCompressedPath);
            this.Controls.Add(this.btnCancelDistPath);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.btnSetDistPath);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetCompressedImage);
            this.Controls.Add(this.lblCompressedPath);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetImage);
            this.Controls.Add(this.lblUncompressedPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLZW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lZW";
            ((System.ComponentModel.ISupportInitialize)(this.imgSrcPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgResultPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUncompressedPath;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.PictureBox imgSrcPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgResultPic;
        private System.Windows.Forms.Button btnGetCompressedImage;
        private System.Windows.Forms.Label lblCompressedPath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancelDistPath;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Button btnSetDistPath;
        private System.Windows.Forms.Button btnCancelUnCompressedPath;
        private System.Windows.Forms.Button btnCancelCompressedPath;
        private System.Windows.Forms.Button btnDisplayResult;
    }
}

