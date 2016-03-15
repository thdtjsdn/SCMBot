﻿using System;
using System.Windows.Forms;

namespace SCMBot
{

    public partial class Dialog : Form
    {

        public string MailCode
        {
            get { return mailcodeBox.Text; }
            set { guardBox.Text = value; }
        }
        public string GuardDesc
        {
            get { return guardBox.Text; }
            set { guardBox.Text = value; }
        }

        public string CapchaText
        {
            get { return capchaBox.Text; }
            set { capchaBox.Text = value; }
        }

        public string TwoFactorCode
        {
            get { return factorTextBox.Text; }
            set { factorTextBox.Text = value;}
        }

        public bool codgroupEnab
        {
            get { return codgroupBox.Enabled; }
            set
            {
                codgroupBox.Visible = value;

                if (value)
                    mailcodeBox.Select();
            }
        }

        public bool capchgroupEnab
        {
            get { return capchgroupBox.Enabled; }
            set
            {
                capchgroupBox.Visible = value;

                if (value)
                    capchaBox.Select();
            }
        }

        public bool factorgroupEnab
        {
            get { return twoFactorGroup.Enabled; }
            set
            {
                twoFactorGroup.Visible = value;

                if (value)
                    factorTextBox.Select();
            }
        }

        public PictureBox capchImg
        {
            get { return capchapicBox; }
            set { capchapicBox = value; }
        }

       

        public Dialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            return;
        }

        private void factorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                okButton.PerformClick();
        }

    }
}
