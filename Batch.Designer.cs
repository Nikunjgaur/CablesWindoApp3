﻿
namespace CablesWindoApp3
{
    partial class Batch
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
            this.GetReportNotxtbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OKBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetReportNotxtbox
            // 
            this.GetReportNotxtbox.Location = new System.Drawing.Point(24, 41);
            this.GetReportNotxtbox.Name = "GetReportNotxtbox";
            this.GetReportNotxtbox.Size = new System.Drawing.Size(127, 20);
            this.GetReportNotxtbox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ENTER REPORTS NO";
            // 
            // OKBTN
            // 
            this.OKBTN.Location = new System.Drawing.Point(12, 89);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(68, 31);
            this.OKBTN.TabIndex = 4;
            this.OKBTN.Text = "OK";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 135);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GetReportNotxtbox);
            this.Name = "Batch";
            this.Text = "Batch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GetReportNotxtbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKBTN;
    }
}