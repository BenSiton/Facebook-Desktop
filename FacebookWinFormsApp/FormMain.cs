using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;
using FacebookApp.PanelsFactory;
using FacebookApp.ThreadsComposite;

namespace FacebookApp
{
    public partial class FormMain : Form
    {
        private readonly IThread r_ThreadComposite = new ThreadComposite();
        private Form m_FormAlbums;
        private Form m_FormEvents;
        private Form m_FormGroups;
        private Form m_FormLikedPages;
        private Form m_FormPosts;
        private Form m_FormFriends;
        private Form m_FormMostInCommon;
        private Form m_FormFacebookMatch;
        private bool m_ToContinue = true;
        private PanelCustom m_PanelCustom;

        public FormMain()
        {
            InitializeComponent();
            tempMethodForPanel();
            createNewFormsWithThreads();
            FacebookService.s_CollectionLimit = 200;
        }

        private void tempMethodForPanel()
        {
            m_PanelCustom = PanelFactoryMethod.Create(this);
            m_PanelCustom.Location = panel1.Location;
            Controls.Add(m_PanelCustom);
        }

        private void createNewFormsWithThreads()
        {
            m_FormAlbums = new FormAlbums();
            m_FormEvents = new FormEvents();
            m_FormFacebookMatch = new FormFacebookMatch();
            m_FormFriends = new FormFriends();
            m_FormGroups = new FormGroups();
            m_FormLikedPages = new FormLikedPages();
            m_FormPosts = new FormPosts();
            m_FormMostInCommon = new FormMostInCommon();

            createFormsInThreadComposite();
        }

        private void createFormsInThreadComposite()
        {
            ThreadComponent threadComponentAlbums = new ThreadComponent(fetchThread(m_FormAlbums, buttonAlbums));
            ThreadComponent threadComponentEvents = new ThreadComponent(fetchThread(m_FormEvents, buttonEvents));
            ThreadComponent threadComponentGroups = new ThreadComponent(fetchThread(m_FormGroups, buttonGropus));
            ThreadComponent threadComponentPages = new ThreadComponent(fetchThread(m_FormLikedPages, buttonPages));
            ThreadComponent threadComponentPosts = new ThreadComponent(fetchThread(m_FormPosts, buttonPosts));
            ThreadComponent threadComponentFriends = new ThreadComponent(fetchThread(m_FormFriends, buttonFriends));
            
            r_ThreadComposite.Add(threadComponentAlbums);
            r_ThreadComposite.Add(threadComponentEvents);
            r_ThreadComposite.Add(threadComponentGroups);
            r_ThreadComposite.Add(threadComponentPages);
            r_ThreadComposite.Add(threadComponentPosts);
            r_ThreadComposite.Add(threadComponentFriends);

            r_ThreadComposite.Start();
        }

        private Thread fetchThread(object i_Fetchable, Control i_Btn)
        {
            if (i_Fetchable is IFetchable)
            {
                return new Thread(
                () =>
                    {
                        (i_Fetchable as IFetchable)?.Fetch();
                        if (m_ToContinue)
                        {
                            i_Btn.Invoke(new Action(() => i_Btn.Enabled = true));
                        }
                    });
            }

            throw new Exception();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = SingletonUser.FacebookUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            m_FormAlbums.ShowDialog();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            m_FormEvents.ShowDialog();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            m_FormGroups.ShowDialog();
        }

        private void buttonPages_Click(object sender, EventArgs e)
        {
            m_FormLikedPages.ShowDialog();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            m_FormPosts.ShowDialog();
        }

        private void buttonPostPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                string pictureUrl;
                openFileUploadPicture = new OpenFileDialog();
                openFileUploadPicture.InitialDirectory = "c:\\";
                openFileUploadPicture.ShowDialog();
                pictureUrl = openFileUploadPicture.FileName;
                SingletonUser.FacebookUser.PostPhoto(pictureUrl, "MIC CHECK");
            }
            catch (Exception)
            {
                MessageBox.Show("Posting picture error!");
            }
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            m_FormFriends.ShowDialog();
        }

        private void buttonMostInCommon_Click(object sender, EventArgs e)
        {
            m_FormMostInCommon.ShowDialog();
        }

        private void buttonFacebookMatch_Click(object sender, EventArgs e)
        {
            m_FormFacebookMatch.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_ToContinue = false;
            r_ThreadComposite.Abort();
        }
    }
}
