﻿namespace WinformTester
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnNormal = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMain
            // 
            this.dtgMain.AccessibleName = "dtgMain";
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Location = new System.Drawing.Point(12, 110);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.RowHeadersWidth = 51;
            this.dtgMain.RowTemplate.Height = 29;
            this.dtgMain.Size = new System.Drawing.Size(1394, 705);
            this.dtgMain.TabIndex = 0;
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(366, 23);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(94, 29);
            this.btnToUpper.TabIndex = 1;
            this.btnToUpper.Text = "ToUpper";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(503, 23);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(94, 29);
            this.btnLower.TabIndex = 2;
            this.btnLower.Text = "ToLower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(1228, 25);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(49, 20);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Time: ";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(154, 22);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(94, 29);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(23, 22);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 27);
            this.txtQuantity.TabIndex = 5;
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(637, 23);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(94, 29);
            this.btnNormal.TabIndex = 6;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(23, 70);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(1254, 29);
            this.pb1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 777);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.dtgMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgMain;
        private Button btnToUpper;
        private Button btnLower;
        private Label lbTime;
        private Button btnInit;
        private TextBox txtQuantity;
        private Button btnNormal;
        private ProgressBar pb1;
    }
}