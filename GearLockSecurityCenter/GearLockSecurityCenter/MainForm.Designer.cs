﻿namespace GearLockSecurityCenter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.gpedit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GearLock Security Center";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpedit
            // 
            this.gpedit.Location = new System.Drawing.Point(16, 91);
            this.gpedit.Name = "gpedit";
            this.gpedit.Size = new System.Drawing.Size(129, 135);
            this.gpedit.TabIndex = 1;
            this.gpedit.Text = "Secure Group Policies";
            this.gpedit.UseVisualStyleBackColor = true;
            this.gpedit.Click += new System.EventHandler(this.gpedit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 135);
            this.button2.TabIndex = 2;
            this.button2.Text = "Secure Users";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 135);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clean User Directories";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 314);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gpedit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GearLock Security Center";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gpedit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
