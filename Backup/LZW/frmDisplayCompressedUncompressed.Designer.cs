namespace LZW
{
    partial class frmDisplayCompressedUncompressed
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
            this.txtUncompressedSequence = new System.Windows.Forms.TextBox();
            this.txtCompressedSequence = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grdDisplay = new System.Windows.Forms.DataGridView();
            this.clIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShortNo = new System.Windows.Forms.Label();
            this.lblByteNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUncompressedSequence
            // 
            this.txtUncompressedSequence.Location = new System.Drawing.Point(467, 132);
            this.txtUncompressedSequence.Multiline = true;
            this.txtUncompressedSequence.Name = "txtUncompressedSequence";
            this.txtUncompressedSequence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUncompressedSequence.Size = new System.Drawing.Size(515, 159);
            this.txtUncompressedSequence.TabIndex = 0;
            // 
            // txtCompressedSequence
            // 
            this.txtCompressedSequence.Location = new System.Drawing.Point(467, 309);
            this.txtCompressedSequence.Multiline = true;
            this.txtCompressedSequence.Name = "txtCompressedSequence";
            this.txtCompressedSequence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCompressedSequence.Size = new System.Drawing.Size(515, 179);
            this.txtCompressedSequence.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(422, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grdDisplay
            // 
            this.grdDisplay.AllowUserToAddRows = false;
            this.grdDisplay.AllowUserToDeleteRows = false;
            this.grdDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIndex,
            this.clSequence});
            this.grdDisplay.Location = new System.Drawing.Point(24, 132);
            this.grdDisplay.Name = "grdDisplay";
            this.grdDisplay.ReadOnly = true;
            this.grdDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDisplay.Size = new System.Drawing.Size(408, 356);
            this.grdDisplay.TabIndex = 8;
            // 
            // clIndex
            // 
            this.clIndex.DataPropertyName = "Index";
            this.clIndex.HeaderText = "Index";
            this.clIndex.Name = "clIndex";
            this.clIndex.ReadOnly = true;
            // 
            // clSequence
            // 
            this.clSequence.DataPropertyName = "Sequence";
            this.clSequence.HeaderText = "Sequence";
            this.clSequence.Name = "clSequence";
            this.clSequence.ReadOnly = true;
            this.clSequence.Width = 400;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Code Book";
            // 
            // lblShortNo
            // 
            this.lblShortNo.ForeColor = System.Drawing.Color.Red;
            this.lblShortNo.Location = new System.Drawing.Point(575, 18);
            this.lblShortNo.Name = "lblShortNo";
            this.lblShortNo.Size = new System.Drawing.Size(144, 23);
            this.lblShortNo.TabIndex = 10;
            this.lblShortNo.Text = "||";
            // 
            // lblByteNo
            // 
            this.lblByteNo.ForeColor = System.Drawing.Color.Red;
            this.lblByteNo.Location = new System.Drawing.Point(247, 18);
            this.lblByteNo.Name = "lblByteNo";
            this.lblByteNo.Size = new System.Drawing.Size(138, 23);
            this.lblByteNo.TabIndex = 11;
            this.lblByteNo.Text = "||";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "IN";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(123, 103);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(100, 20);
            this.txtOut.TabIndex = 14;
            this.txtOut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOut_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Out";
            // 
            // txtIN
            // 
            this.txtIN.Location = new System.Drawing.Point(271, 103);
            this.txtIN.Name = "txtIN";
            this.txtIN.Size = new System.Drawing.Size(265, 20);
            this.txtIN.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "IN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Out";
            // 
            // frmDisplayCompressedUncompressed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 541);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblByteNo);
            this.Controls.Add(this.lblShortNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCompressedSequence);
            this.Controls.Add(this.txtUncompressedSequence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDisplayCompressedUncompressed";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Uncompresed Byte Sqequence & Compressed Short Sequence";
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUncompressedSequence;
        private System.Windows.Forms.TextBox txtCompressedSequence;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView grdDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSequence;
        private System.Windows.Forms.Label lblShortNo;
        private System.Windows.Forms.Label lblByteNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}