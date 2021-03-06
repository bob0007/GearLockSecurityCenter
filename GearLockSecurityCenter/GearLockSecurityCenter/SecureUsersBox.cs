﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GearLockSecurityCenter
{
    public partial class SearchUserDirsBox : Form
    {
        private GearLockSecurityCenter.MainForm.Navigator navigate;
        public SearchUserDirsBox(GearLockSecurityCenter.MainForm.Navigator nav)
        {
            this.navigate = nav;
            InitializeComponent();
            include.Checked = true;
            exclude.Checked = false;
            textBox1.Text = @"C:\Users";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowser.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileSearcher sf = new FileSearcher();
            sf.SearchFiles(textBox1.Text, textBox2.Text, excludedUser.Text, (s) =>
            {
                textBox3.Text = s;
                textBox3.Update();

            }, !exclude.Checked);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowser.SelectedPath;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            navigate();
        }


    }
}
