namespace FacebookApp
{
    public partial class FormMostInCommon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostInCommon));
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.listBoxNothingInCommon = new System.Windows.Forms.ListBox();
            this.listBoxMostInCommon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCheckFriends = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(322, 271);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 7;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(322, 308);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 20);
            this.labelGender.TabIndex = 9;
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(322, 345);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(0, 20);
            this.labelBirthDay.TabIndex = 12;
            // 
            // listBoxNothingInCommon
            // 
            this.listBoxNothingInCommon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxNothingInCommon.FormattingEnabled = true;
            this.listBoxNothingInCommon.ItemHeight = 20;
            this.listBoxNothingInCommon.Location = new System.Drawing.Point(14, 85);
            this.listBoxNothingInCommon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxNothingInCommon.Name = "listBoxNothingInCommon";
            this.listBoxNothingInCommon.Size = new System.Drawing.Size(187, 164);
            this.listBoxNothingInCommon.TabIndex = 13;
            this.listBoxNothingInCommon.SelectedIndexChanged += new System.EventHandler(this.listBoxNothingInCommon_SelectedIndexChanged);
            // 
            // listBoxMostInCommon
            // 
            this.listBoxMostInCommon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxMostInCommon.FormattingEnabled = true;
            this.listBoxMostInCommon.ItemHeight = 20;
            this.listBoxMostInCommon.Location = new System.Drawing.Point(288, 85);
            this.listBoxMostInCommon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxMostInCommon.Name = "listBoxMostInCommon";
            this.listBoxMostInCommon.Size = new System.Drawing.Size(187, 164);
            this.listBoxMostInCommon.TabIndex = 14;
            this.listBoxMostInCommon.SelectedIndexChanged += new System.EventHandler(this.listBoxMostInCommon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Friends with \r\nmost in common:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(285, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 40);
            this.label5.TabIndex = 16;
            this.label5.Text = "Friends with\r\nnothing in common:";
            // 
            // buttonCheckFriends
            // 
            this.buttonCheckFriends.Location = new System.Drawing.Point(158, 257);
            this.buttonCheckFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCheckFriends.Name = "buttonCheckFriends";
            this.buttonCheckFriends.Size = new System.Drawing.Size(188, 68);
            this.buttonCheckFriends.TabIndex = 17;
            this.buttonCheckFriends.Text = "Check Friends!";
            this.buttonCheckFriends.UseVisualStyleBackColor = true;
            this.buttonCheckFriends.Click += new System.EventHandler(this.buttonCheckFriends_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(14, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 150);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // FormMostInCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(494, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCheckFriends);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMostInCommon);
            this.Controls.Add(this.listBoxNothingInCommon);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMostInCommon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFeature1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.ListBox listBoxNothingInCommon;
        private System.Windows.Forms.ListBox listBoxMostInCommon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheckFriends;
        private System.Windows.Forms.Panel panel1;
    }
}