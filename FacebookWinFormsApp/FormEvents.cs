using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    public partial class FormEvents : FormGenericForFacebook, IFetchable
    {
        public FormEvents()
        {
            InitializeComponent();
        }

        private void fetchEvents()
        {
            try
            {
                listBoxEvents.Items.Clear();
                listBoxEvents.DisplayMember = "Name";
                foreach (Event fbEvent in SingletonUser.FacebookUser.Events)
                {
                    listBoxEvents.Items.Add(fbEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            checkIfThereAreItemsToDisplay();
        }

        private void checkIfThereAreItemsToDisplay()
        {
            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
                Close();
            }
        }

        public void Fetch()
        {
            if (listBoxEvents.Items.Count == 0)
            {
                fetchEvents();
            }
            else
            {
                throw new Exception("You are not allowed to fetch again!");
            }
        }
    }
}
