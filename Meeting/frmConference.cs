using BalDemo;
using Meeting.Resources;
using ModelDemo;

namespace Meeting
{
    public partial class frmConference : Form
    {
        readonly BalConference balConference;

        readonly Conference? _conference;

        public frmConference()
        {
            InitializeComponent();

            balConference = new BalConference();

            _conference = null;
        }

        public frmConference(Conference conference)
        {
            InitializeComponent();

            balConference = new BalConference();

            _conference = conference;
        }

        private void frmConference_Load(object sender, EventArgs e)
        {
            if (_conference != null)
            {
                txtName.Text = _conference.Name;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show(EngValidationResource.EnterConferenceName, EngDisplayResource.ProjectCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_conference != null)
                {
                    await balConference.UpdateConference(_conference.Id, txtName.Text);
                }
                else
                {
                    await balConference.AddConference(txtName.Text);
                }

                DialogResult = DialogResult.OK;
            }
        }

        public Conference Conference
        {
            get { return _conference; }
        }
    }
}
