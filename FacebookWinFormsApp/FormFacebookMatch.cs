using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    public partial class FormFacebookMatch : Form
    {
        private User.eGender m_GenderOfMatch;
        private bool m_ToFilterByGender = false;

        public User.eGender GenderOfMatch { get => m_GenderOfMatch; set => m_GenderOfMatch = value; }

        public int MinAge => (int)numericUpDownMinAge.Value;

        public int MaxAge => (int)numericUpDownMaxAge.Value;

        public bool ToFilterByGender
        {
            get => m_ToFilterByGender;
            set => m_ToFilterByGender = value;
        }

        public FormFacebookMatch()
        {
            InitializeComponent();
        }

        private void buttonFindMatch_Click(object sender, EventArgs e)
        {
            fetchMatch();
        }

        private void fetchMatch()
        {
            listBoxMatches.Items.Clear();
            try
            {
                foreach (User friend in SingletonUser.FacebookUser.Friends)
                {
                    if (FacebookLogic.IsUserAGoodMatch(friend, MinAge, MaxAge, ToFilterByGender, GenderOfMatch))
                    {
                        listBoxMatches.Items.Add(friend);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxMatches.Items.Count == 0)
            {
                MessageBox.Show("There is no match for you at this time :(");
                buttonMatchUs.Enabled = false;
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonMatchUs.Enabled = true;
            displaySelectedMatch();
        }

        private void displaySelectedMatch()
        {
            try
            {
                if (listBoxMatches.SelectedItems.Count == 1)
                {
                    User selectedFriend = listBoxMatches.SelectedItem as User;
                    if (selectedFriend.PictureNormalURL != null)
                    {
                        pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            m_GenderOfMatch = User.eGender.male;
            radioButtonControl(true);
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            m_GenderOfMatch = User.eGender.female;
            radioButtonControl(true);
        }

        private void radioButtonBoth_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonControl(false);
        }

        private void radioButtonControl(bool i_GenderFilter)
        {
            ToFilterByGender = i_GenderFilter;

            if (buttonFindMatch.Enabled == false)
            {
                buttonFindMatch.Enabled = true;
            }
        }

        private void buttonMatchUs_Click(object sender, EventArgs e)
        {
            User matchUser = listBoxMatches.SelectedItem as User;
            MessageBox.Show($"Email: {matchUser.Email}");
            buttonMatchUs.Enabled = false;
        }
    }
}
