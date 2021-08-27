using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    public partial class FormFriends : FormGenericForFacebook, IFetchable
    {
        public FormFriends()
        {
            InitializeComponent();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            try
            {
                foreach (User friend in SingletonUser.FacebookUser.Friends)
                {
                    listBoxFriends.Items.Add(friend);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show("No friends to retrieve :(");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            try
            {
                if (listBoxFriends.SelectedItems.Count == 1)
                {
                    User selectedFriend = listBoxFriends.SelectedItem as User;
                    if (selectedFriend.PictureNormalURL != null)
                    {
                        pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                        List<string> listOfInfo = FacebookLogic.FromUserToUserInfoStringCollection(selectedFriend);

                        labelName.Text = listOfInfo[0];
                        labelEmail.Text = listOfInfo[1];
                        labelGender.Text = listOfInfo[2];
                        labelBirthDate.Text = listOfInfo[3];
                        labelLocation.Text = listOfInfo[4];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Fetch()
        {
            if (listBoxFriends.Items.Count == 0)
            {
                fetchFriends();
            }
            else
            {
                throw new Exception("You are not allowed to fetch again!");
            }
        }
    }
}