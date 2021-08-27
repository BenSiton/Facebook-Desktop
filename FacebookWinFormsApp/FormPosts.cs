using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    public partial class FormPosts : FormGenericForFacebook, IFetchable
    {
        public FormPosts()
        {
            InitializeComponent();
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();
            try
            {
                foreach (Post post in SingletonUser.FacebookUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxPosts.Items.Add($"[{post.Type}]");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        public void Fetch()
        {
            if (listBoxPosts.Items.Count == 0)
            {
                fetchPosts();
            }
            else
            {
                throw new Exception("You are not allowed to fetch again!");
            }
        }
    }
}
