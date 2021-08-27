using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    public partial class FormGroups : FormGenericForFacebook, IFetchable
    {
        public FormGroups()
        {
            InitializeComponent();
        }

        private void fetchGroups()
        {
            try
            {
                listBoxGroups.Items.Clear();
                listBoxGroups.DisplayMember = "Name";
                foreach (Group fbGroup in SingletonUser.FacebookUser.Groups)
                {
                    listBoxGroups.Items.Add(fbGroup);
                }

                if (listBoxGroups.Items.Count == 0)
                {
                    MessageBox.Show("No Groups to retrieve :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Fetch()
        {
            if (listBoxGroups.Items.Count == 0)
            {
                fetchGroups();
            }
            else
            {
                throw new Exception("You are not allowed to fetch again!");
            }
        }
    }
}
