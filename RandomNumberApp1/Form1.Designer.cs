namespace RandomNumberApp1
{
    partial class Form1
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
            this.lblWinnerNumber = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.numBeginNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numEndNumber = new System.Windows.Forms.NumericUpDown();
            this.lstWinnerNumbers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numBeginNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWinnerNumber
            // 
            this.lblWinnerNumber.AutoSize = true;
            this.lblWinnerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 300F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerNumber.ForeColor = System.Drawing.Color.White;
            this.lblWinnerNumber.Location = new System.Drawing.Point(325, 73);
            this.lblWinnerNumber.Name = "lblWinnerNumber";
            this.lblWinnerNumber.Size = new System.Drawing.Size(859, 453);
            this.lblWinnerNumber.TabIndex = 0;
            this.lblWinnerNumber.Text = "000";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(464, 507);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(410, 151);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "START";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // numBeginNumber
            // 
            this.numBeginNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBeginNumber.Location = new System.Drawing.Point(100, 9);
            this.numBeginNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBeginNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBeginNumber.Name = "numBeginNumber";
            this.numBeginNumber.Size = new System.Drawing.Size(64, 26);
            this.numBeginNumber.TabIndex = 2;
            this.numBeginNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Эхний №";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Эцсийн №";
            // 
            // numEndNumber
            // 
            this.numEndNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEndNumber.Location = new System.Drawing.Point(100, 41);
            this.numEndNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numEndNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndNumber.Name = "numEndNumber";
            this.numEndNumber.Size = new System.Drawing.Size(64, 26);
            this.numEndNumber.TabIndex = 2;
            this.numEndNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lstWinnerNumbers
            // 
            this.lstWinnerNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWinnerNumbers.FormattingEnabled = true;
            this.lstWinnerNumbers.ItemHeight = 20;
            this.lstWinnerNumbers.Location = new System.Drawing.Point(100, 73);
            this.lstWinnerNumbers.Name = "lstWinnerNumbers";
            this.lstWinnerNumbers.Size = new System.Drawing.Size(64, 124);
            this.lstWinnerNumbers.TabIndex = 4;
            this.lstWinnerNumbers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstWinnerNumbers_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ялагчид";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1130, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(170, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(335, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/broject/RandomNumberForm";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstWinnerNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numEndNumber);
            this.Controls.Add(this.numBeginNumber);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblWinnerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "АЗТАН";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numBeginNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinnerNumber;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.NumericUpDown numBeginNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numEndNumber;
        private System.Windows.Forms.ListBox lstWinnerNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

