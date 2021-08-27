namespace FacebookApp
{
    public partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonGropus = new System.Windows.Forms.Button();
            this.buttonPages = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonPostPhoto = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonMostInCommon = new System.Windows.Forms.Button();
            this.buttonFacebookMatch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(11, 6);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(268, 35);
            this.buttonBack.TabIndex = 52;
            this.buttonBack.Text = "Back To Login Form";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Enabled = false;
            this.buttonAlbums.Location = new System.Drawing.Point(506, 13);
            this.buttonAlbums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(197, 52);
            this.buttonAlbums.TabIndex = 60;
            this.buttonAlbums.Text = "My Albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Enabled = false;
            this.buttonEvents.Location = new System.Drawing.Point(506, 73);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(197, 52);
            this.buttonEvents.TabIndex = 60;
            this.buttonEvents.Text = "My Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonGropus
            // 
            this.buttonGropus.Enabled = false;
            this.buttonGropus.Location = new System.Drawing.Point(505, 133);
            this.buttonGropus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGropus.Name = "buttonGropus";
            this.buttonGropus.Size = new System.Drawing.Size(197, 52);
            this.buttonGropus.TabIndex = 60;
            this.buttonGropus.Text = "My Groups";
            this.buttonGropus.UseVisualStyleBackColor = true;
            this.buttonGropus.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonPages
            // 
            this.buttonPages.Enabled = false;
            this.buttonPages.Location = new System.Drawing.Point(505, 193);
            this.buttonPages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPages.Name = "buttonPages";
            this.buttonPages.Size = new System.Drawing.Size(197, 52);
            this.buttonPages.TabIndex = 60;
            this.buttonPages.Text = "My Liked Pages";
            this.buttonPages.UseVisualStyleBackColor = true;
            this.buttonPages.Click += new System.EventHandler(this.buttonPages_Click);
            // 
            // buttonPosts
            // 
            this.buttonPosts.Enabled = false;
            this.buttonPosts.Location = new System.Drawing.Point(505, 253);
            this.buttonPosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(197, 52);
            this.buttonPosts.TabIndex = 60;
            this.buttonPosts.Text = "My Posts";
            this.buttonPosts.UseVisualStyleBackColor = true;
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // buttonPostPhoto
            // 
            this.buttonPostPhoto.Location = new System.Drawing.Point(505, 373);
            this.buttonPostPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPostPhoto.Name = "buttonPostPhoto";
            this.buttonPostPhoto.Size = new System.Drawing.Size(197, 52);
            this.buttonPostPhoto.TabIndex = 60;
            this.buttonPostPhoto.Text = "Post Photo";
            this.buttonPostPhoto.UseVisualStyleBackColor = true;
            this.buttonPostPhoto.Click += new System.EventHandler(this.buttonPostPhoto_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Enabled = false;
            this.buttonFriends.Location = new System.Drawing.Point(505, 313);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(197, 52);
            this.buttonFriends.TabIndex = 60;
            this.buttonFriends.Text = "My Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonMostInCommon
            // 
            this.buttonMostInCommon.Location = new System.Drawing.Point(17, 444);
            this.buttonMostInCommon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMostInCommon.Name = "buttonMostInCommon";
            this.buttonMostInCommon.Size = new System.Drawing.Size(98, 52);
            this.buttonMostInCommon.TabIndex = 70;
            this.buttonMostInCommon.Text = "Most in common";
            this.buttonMostInCommon.UseVisualStyleBackColor = true;
            this.buttonMostInCommon.Click += new System.EventHandler(this.buttonMostInCommon_Click);
            // 
            // buttonFacebookMatch
            // 
            this.buttonFacebookMatch.Location = new System.Drawing.Point(128, 444);
            this.buttonFacebookMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFacebookMatch.Name = "buttonFacebookMatch";
            this.buttonFacebookMatch.Size = new System.Drawing.Size(98, 52);
            this.buttonFacebookMatch.TabIndex = 70;
            this.buttonFacebookMatch.Text = "Facebook Match";
            this.buttonFacebookMatch.UseVisualStyleBackColor = true;
            this.buttonFacebookMatch.Click += new System.EventHandler(this.buttonFacebookMatch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 526);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Post Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(199, 522);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(241, 26);
            this.textBoxStatus.TabIndex = 63;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Location = new System.Drawing.Point(450, 518);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(93, 44);
            this.buttonSetStatus.TabIndex = 64;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Location);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 362);
            this.panel1.TabIndex = 71;
            this.panel1.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonFacebookMatch);
            this.Controls.Add(this.buttonMostInCommon);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPostPhoto);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonPosts);
            this.Controls.Add(this.buttonPages);
            this.Controls.Add(this.buttonGropus);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.buttonAlbums);
            this.Controls.Add(this.buttonBack);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceBook Desktop C21";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonGropus;
        private System.Windows.Forms.Button buttonPages;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Button buttonPostPhoto;
        private System.Windows.Forms.OpenFileDialog openFileUploadPicture;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonMostInCommon;
        private System.Windows.Forms.Button buttonFacebookMatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}