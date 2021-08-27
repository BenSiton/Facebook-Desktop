using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    public partial class FormAlbums : FormGenericForFacebook, IFetchable
    {
        public FormAlbums()
        {
            InitializeComponent();
        }

        private void fetchAlbums()
        {
            try
            {
                listBoxAlbums.Items.Clear();
                listBoxAlbums.DisplayMember = "Name";
                if (SingletonUser.FacebookUser.Albums.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve.");
                }
                else
                {
                    foreach (Album album in SingletonUser.FacebookUser.Albums)
                    {
                        listBoxAlbums.Items.Add(album);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error occured");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
            buttonFetchPhoto.Enabled = true;
        }

        private void displaySelectedAlbum()
        {
            try
            {
                if (listBoxAlbums.SelectedItems.Count == 1)
                {
                    Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                    if (selectedAlbum.PictureAlbumURL != null)
                    {
                        pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void buttonFetchPhoto_Click(object sender, EventArgs e)
        {
            fetchPhotos(listBoxAlbums.SelectedItem);
        }

        private void fetchPhotos(object i_SelectedItem)
        {
            try
            {
                Album selectedAlbum = i_SelectedItem as Album;
                listBoxPhotos.Items.Clear();
                listBoxPhotos.DisplayMember = "Name";
                if (selectedAlbum.Photos.Count == 0)
                {
                    MessageBox.Show("No Photos to retrieve.");
                }
                else
                {
                    foreach (Photo photo in selectedAlbum.Photos)
                    {
                        listBoxPhotos.Items.Add(photo);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error occured");
            }
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPhoto();
        }

        private void displaySelectedPhoto()
        {
            try
            {
                if (listBoxPhotos.SelectedItems.Count == 1)
                {
                    visibleComment();
                    Photo selectedPhoto = listBoxPhotos.SelectedItem as Photo;
                    if (selectedPhoto.ImageNormal != null)
                    {
                        pictureBoxPhoto.LoadAsync(selectedPhoto.PictureAlbumURL);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void visibleComment()
        {
            textBoxComment.Visible = true;
            labelComment.Visible = true;
            buttonSetComment.Visible = true;
        }

        private void buttonSetComment_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxPhotos.SelectedItem is Photo post)
                {
                    post.Comment(textBoxComment.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Fetch()
        {
            if(listBoxAlbums.Items.Count == 0)
            {
                fetchAlbums();
            }
            else
            {
                throw new Exception("You are not aloowed to fetch again!");
            }
        }
    }
}
