using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookApp.PanelsFactory;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    public partial class FormMostInCommon : Form
    {
        private readonly Dictionary<User, int> r_FriendsFriendshipLevel = new Dictionary<User, int>();

        private PanelCustom PanelCustomDefault { get; set; }

        public FormMostInCommon()
        {
            InitializeComponent();

            tempMethodForPanel();
        }

        private void tempMethodForPanel()
        {
            PanelCustomDefault = PanelFactoryMethod.Create(this);
            PanelCustomDefault.Location = panel1.Location;
            PanelCustomDefault.ClientSize = panel1.Size;
            PanelCustomDefault.AutoSize = false;
            Controls.Add(PanelCustomDefault);
        }

        public Dictionary<User, int> FriendsFriendshipLevel => r_FriendsFriendshipLevel;

        private void buttonCheckFriends_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (User friend in SingletonUser.FacebookUser.Friends)
                {
                    int result = 0;

                    result += FacebookLogic.AmountOfSimilarLikedPages(friend);
                    result += FacebookLogic.AmountOfSimilarGroups(friend);

                    FriendsFriendshipLevel.Add(friend, 0);
                    FriendsFriendshipLevel[friend] = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (FriendsFriendshipLevel.Count == 0)
            {
                MessageBox.Show("You have no friends :(");
            }
            else
            {
                sortAndAddCloseFriends(FriendsFriendshipLevel);
            }
        }

        private void sortAndAddCloseFriends(Dictionary<User, int> i_MatchResult)
        {
            foreach (KeyValuePair<User, int> match in i_MatchResult.OrderByDescending(key => key.Value))
            {
                if (match.Value == 0)
                {
                    listBoxNothingInCommon.Items.Add(match.Key);
                }
                else
                {
                    listBoxMostInCommon.Items.Add(match.Key);
                }
            }
        }

        private void displaySelectedMatch(ListBox i_ListBox)
        {
            //// the reason that we used ref to listbox is we wanted to choose which list box to add to

            try
            {
                if (i_ListBox.SelectedItems.Count == 1)
                {
                    User selectedFriend = i_ListBox.SelectedItem as User;
                    PanelCustomDefault.UserBindingSource.DataSource = selectedFriend;
                    PanelCustomDefault.CityBindingSource.DataSource = selectedFriend.Location;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void listBoxNothingInCommon_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedMatch(listBoxNothingInCommon);
        }

        private void listBoxMostInCommon_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedMatch(listBoxMostInCommon);
        }
    }
}