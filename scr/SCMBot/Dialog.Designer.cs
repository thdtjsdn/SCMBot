﻿namespace SCMBot
{
    partial class Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
            this.okButton = new System.Windows.Forms.Button();
            this.codgroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardBox = new System.Windows.Forms.TextBox();
            this.mailcodeBox = new System.Windows.Forms.TextBox();
            this.capchgroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capchaBox = new System.Windows.Forms.TextBox();
            this.capchapicBox = new System.Windows.Forms.PictureBox();
            this.twoFactorGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.factorTextBox = new System.Windows.Forms.TextBox();
            this.codgroupBox.SuspendLayout();
            this.capchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capchapicBox)).BeginInit();
            this.twoFactorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // codgroupBox
            // 
            this.codgroupBox.Controls.Add(this.label2);
            this.codgroupBox.Controls.Add(this.label1);
            this.codgroupBox.Controls.Add(this.guardBox);
            this.codgroupBox.Controls.Add(this.mailcodeBox);
            resources.ApplyResources(this.codgroupBox, "codgroupBox");
            this.codgroupBox.Name = "codgroupBox";
            this.codgroupBox.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // guardBox
            // 
            resources.ApplyResources(this.guardBox, "guardBox");
            this.guardBox.Name = "guardBox";
            // 
            // mailcodeBox
            // 
            resources.ApplyResources(this.mailcodeBox, "mailcodeBox");
            this.mailcodeBox.Name = "mailcodeBox";
            this.mailcodeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.factorTextBox_KeyDown);
            // 
            // capchgroupBox
            // 
            this.capchgroupBox.Controls.Add(this.label3);
            this.capchgroupBox.Controls.Add(this.capchaBox);
            this.capchgroupBox.Controls.Add(this.capchapicBox);
            resources.ApplyResources(this.capchgroupBox, "capchgroupBox");
            this.capchgroupBox.Name = "capchgroupBox";
            this.capchgroupBox.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // capchaBox
            // 
            resources.ApplyResources(this.capchaBox, "capchaBox");
            this.capchaBox.Name = "capchaBox";
            this.capchaBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.factorTextBox_KeyDown);
            // 
            // capchapicBox
            // 
            this.capchapicBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.capchapicBox, "capchapicBox");
            this.capchapicBox.Name = "capchapicBox";
            this.capchapicBox.TabStop = false;
            // 
            // twoFactorGroup
            // 
            this.twoFactorGroup.Controls.Add(this.label5);
            this.twoFactorGroup.Controls.Add(this.factorTextBox);
            resources.ApplyResources(this.twoFactorGroup, "twoFactorGroup");
            this.twoFactorGroup.Name = "twoFactorGroup";
            this.twoFactorGroup.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // factorTextBox
            // 
            this.factorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.factorTextBox, "factorTextBox");
            this.factorTextBox.Name = "factorTextBox";
            this.factorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.factorTextBox_KeyDown);
            // 
            // Dialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.capchgroupBox);
            this.Controls.Add(this.codgroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.twoFactorGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dialog";
            this.codgroupBox.ResumeLayout(false);
            this.codgroupBox.PerformLayout();
            this.capchgroupBox.ResumeLayout(false);
            this.capchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capchapicBox)).EndInit();
            this.twoFactorGroup.ResumeLayout(false);
            this.twoFactorGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox codgroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guardBox;
        private System.Windows.Forms.TextBox mailcodeBox;
        private System.Windows.Forms.GroupBox capchgroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capchaBox;
        private System.Windows.Forms.PictureBox capchapicBox;
        private System.Windows.Forms.GroupBox twoFactorGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox factorTextBox;
    }
}