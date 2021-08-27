using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class FormFacebookMatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebookMatch));
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonBoth = new System.Windows.Forms.RadioButton();
            this.buttonMatchUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFindMatch
            // 
            this.buttonFindMatch.AutoSize = true;
            this.buttonFindMatch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindMatch.Enabled = false;
            this.buttonFindMatch.Location = new System.Drawing.Point(143, 254);
            this.buttonFindMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindMatch.Name = "buttonFindMatch";
            this.buttonFindMatch.Size = new System.Drawing.Size(190, 48);
            this.buttonFindMatch.TabIndex = 13;
            this.buttonFindMatch.Text = "Find me a Match!";
            this.buttonFindMatch.UseVisualStyleBackColor = false;
            this.buttonFindMatch.Click += new System.EventHandler(this.buttonFindMatch_Click);
            // 
            // numericUpDownMaxAge
            // 
            this.numericUpDownMaxAge.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(382, 208);
            this.numericUpDownMaxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMaxAge.Maximum = new decimal(new int[] {
            102,
            0,
            0,
            0});
            this.numericUpDownMaxAge.Minimum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownMaxAge.TabIndex = 11;
            this.numericUpDownMaxAge.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numericUpDownMinAge.Location = new System.Drawing.Point(243, 208);
            this.numericUpDownMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMinAge.Maximum = new decimal(new int[] {
            102,
            0,
            0,
            0});
            this.numericUpDownMinAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownMinAge.TabIndex = 12;
            this.numericUpDownMinAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(330, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(11, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "My prefferd age range:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "I\'m interested in:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(137, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Facebook Dating";
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBoxFriend.Location = new System.Drawing.Point(260, 310);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(200, 144);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 64;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMatches.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxMatches.DisplayMember = "name";
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 20;
            this.listBoxMatches.Location = new System.Drawing.Point(21, 309);
            this.listBoxMatches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(188, 144);
            this.listBoxMatches.TabIndex = 63;
            this.listBoxMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonMale.Location = new System.Drawing.Point(206, 69);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 65;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonFemale.Location = new System.Drawing.Point(206, 102);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(87, 24);
            this.radioButtonFemale.TabIndex = 66;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonBoth
            // 
            this.radioButtonBoth.AutoSize = true;
            this.radioButtonBoth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonBoth.Location = new System.Drawing.Point(206, 136);
            this.radioButtonBoth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonBoth.Name = "radioButtonBoth";
            this.radioButtonBoth.Size = new System.Drawing.Size(68, 24);
            this.radioButtonBoth.TabIndex = 67;
            this.radioButtonBoth.TabStop = true;
            this.radioButtonBoth.Text = "Both";
            this.radioButtonBoth.UseVisualStyleBackColor = false;
            this.radioButtonBoth.CheckedChanged += new System.EventHandler(this.radioButtonBoth_CheckedChanged);
            // 
            // buttonMatchUs
            // 
            this.buttonMatchUs.AutoSize = true;
            this.buttonMatchUs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonMatchUs.Enabled = false;
            this.buttonMatchUs.Location = new System.Drawing.Point(143, 480);
            this.buttonMatchUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMatchUs.Name = "buttonMatchUs";
            this.buttonMatchUs.Size = new System.Drawing.Size(190, 48);
            this.buttonMatchUs.TabIndex = 68;
            this.buttonMatchUs.Text = "Match us!";
            this.buttonMatchUs.UseVisualStyleBackColor = false;
            this.buttonMatchUs.Click += new System.EventHandler(this.buttonMatchUs_Click);
            // 
            // FormFacebookMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(475, 541);
            this.Controls.Add(this.buttonMatchUs);
            this.Controls.Add(this.radioButtonBoth);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.buttonFindMatch);
            this.Controls.Add(this.numericUpDownMaxAge);
            this.Controls.Add(this.numericUpDownMinAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFacebookMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFeature2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonFindMatch;
        private NumericUpDown numericUpDownMaxAge;
        private NumericUpDown numericUpDownMinAge;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBoxFriend;
        private ListBox listBoxMatches;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonBoth;
        private Button buttonMatchUs;
    }
}