using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    public partial class FormLikedPages : FormGenericForFacebook, IFetchable
    {
        public FormLikedPages()
        {
            InitializeComponent();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in SingletonUser.FacebookUser.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        public void Fetch()
        {
            if (listBoxLikedPages.Items.Count == 0)
            {
                fetchLikedPages();
            }
            else
            {
                throw new Exception("You are not allowed to fetch again!");
            }
        }
    }
}
