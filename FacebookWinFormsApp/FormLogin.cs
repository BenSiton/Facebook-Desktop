using System;
using System.Windows.Forms;
using FacebookWrapper;
using Logic;
using Logic.Observer;

namespace FacebookApp
{
    public partial class FormLogin : Form, IObserverUserLogin
    {
        private LoginResult m_LoginResult;
        private AppSettings m_AppSettings;
        private FormMain m_FormMain;

        public bool UserLoggedIn
        {
            get => checkIfUserLoggedIn();
            set { }
        }

        public FormLogin()
        {
            InitializeComponent();
            SingletonUser.UserSubject.Attach(this);
        }

        public void Update(object sender, EventArgs e)
        {
            user_LoggedIn(sender, e);
        }

        private void user_LoggedIn(object sender, EventArgs e)
        {
            UserLoggedIn = true;
            buttonExitAndLogout.Enabled = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(UserLoggedIn == false)
            {
                if(loginAndInit())
                {
                    showMainForm();
                }
            }
            else
            {
                showMainForm();
            }
        }

        private void showMainForm()
        {
            m_FormMain = new FormMain();
            this.Hide();
            m_FormMain.ShowDialog();
            this.Show();
        }

        private void deleteUserData()
        {
            FacebookLogic.DeleteUserData(ref m_AppSettings);
        }

        private bool loginAndInit()
        {
            bool isSuccess = false;
            m_LoginResult = FacebookService.Login(
                "4379835208715154",
                "email",
                "pages_read_engagement",
                "pages_manage_posts",
                "publish_to_groups",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                SingletonUser.FacebookUser = m_LoginResult.LoggedInUser;
                isSuccess = true;
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }

            return isSuccess;
        }

        private bool checkIfUserLoggedIn()
        {
            return FacebookLogic.CheckIfUserLoggedIn(ref m_AppSettings);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
            if (m_AppSettings != null)
            {
                if (m_LoginResult != null)
                {
                    m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                }

                m_AppSettings.SaveToFile();
            }
        }

        private void buttonExitAndLogout_Click(object sender, EventArgs e)
        {
            if(m_AppSettings != null)
            {
                deleteUserData();
                m_AppSettings.SaveToFile();
            }

            Close();
        }


    }
}
