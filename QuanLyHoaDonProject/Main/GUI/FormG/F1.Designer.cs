﻿namespace Main.GUI.FormG
{
    partial class F1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F1));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridUS1 = new Main.GUI.GridUS.GridUS();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(407, 305);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 31);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Select";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridUS1
            // 
            this.gridUS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUS1.IsSelected = false;
            this.gridUS1.Location = new System.Drawing.Point(0, 0);
            this.gridUS1.Name = "gridUS1";
            this.gridUS1.NumberRecord = 10;
            this.gridUS1.PageCurrent = 1;
            this.gridUS1.Size = new System.Drawing.Size(507, 336);
            this.gridUS1.Source = null;
            this.gridUS1.TabIndex = 0;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 129);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;

            this.gridUS1.ThongTinTimKiem = null;
            this.gridUS1.Load += new System.EventHandler(this.gridUS1_Load);

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.ClientSize = new System.Drawing.Size(464, 347);
            this.Controls.Add(this.button1);
            this.ClientSize = new System.Drawing.Size(507, 336);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridUS1);
            this.Name = "F1";
            this.Text = "F1";
            this.Load += new System.EventHandler(this.F1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridUS.GridUS gridUS1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}