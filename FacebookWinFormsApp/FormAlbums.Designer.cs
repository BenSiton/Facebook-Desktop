namespace FacebookApp
{
    public partial class FormAlbums
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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonFetchPhoto = new System.Windows.Forms.Button();
            this.buttonSetComment = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.HorizontalScrollbar = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(27, 27);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(360, 364);
            this.listBoxAlbums.TabIndex = 3;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.HorizontalScrollbar = true;
            this.listBoxPhotos.ItemHeight = 20;
            this.listBoxPhotos.Location = new System.Drawing.Point(407, 27);
            this.listBoxPhotos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(360, 364);
            this.listBoxPhotos.TabIndex = 3;
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(27, 398);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(360, 200);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 4;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(407, 398);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(360, 200);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 4;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonFetchPhoto
            // 
            this.buttonFetchPhoto.Enabled = false;
            this.buttonFetchPhoto.Location = new System.Drawing.Point(123, 604);
            this.buttonFetchPhoto.Name = "buttonFetchPhoto";
            this.buttonFetchPhoto.Size = new System.Drawing.Size(165, 56);
            this.buttonFetchPhoto.TabIndex = 5;
            this.buttonFetchPhoto.Text = "Fetch albums Photos";
            this.buttonFetchPhoto.UseVisualStyleBackColor = true;
            this.buttonFetchPhoto.Click += new System.EventHandler(this.buttonFetchPhoto_Click);
            // 
            // buttonSetComment
            // 
            this.buttonSetComment.Location = new System.Drawing.Point(674, 616);
            this.buttonSetComment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSetComment.Name = "buttonSetComment";
            this.buttonSetComment.Size = new System.Drawing.Size(93, 44);
            this.buttonSetComment.TabIndex = 70;
            this.buttonSetComment.Text = "Comment";
            this.buttonSetComment.UseVisualStyleBackColor = true;
            this.buttonSetComment.Visible = false;
            this.buttonSetComment.Click += new System.EventHandler(this.buttonSetComment_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(423, 620);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(241, 26);
            this.textBoxComment.TabIndex = 69;
            this.textBoxComment.Visible = false;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(333, 623);
            this.labelComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(82, 20);
            this.labelComment.TabIndex = 68;
            this.labelComment.Text = "Comment:";
            this.labelComment.Visible = false;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 690);
            this.Controls.Add(this.buttonSetComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.buttonFetchPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.listBoxPhotos);
            this.Controls.Add(this.listBoxAlbums);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonFetchPhoto;
        private System.Windows.Forms.Button buttonSetComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
    }
}