using BalDemo;
using Meeting.Resources;
using ModelDemo;
using System.Globalization;

namespace Meeting
{
    public partial class frmMain : Form
    {
        private int _selectedItem = 0;

        private List<Conference> _conferences;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolConference.Text = EngDisplayResource.Conference;
            toolAttendees.Text = EngDisplayResource.Attendee;
            toolSpeakers.Text = EngDisplayResource.Speaker;
            toolTags.Text = EngDisplayResource.Tag;

            fileToolStripMenuItem.Text = EngDisplayResource.File;
            viewToolStripMenuItem.Text = EngDisplayResource.View;
            editToolStripMenuItem.Text = EngDisplayResource.Edit;   
            reportToolStripMenuItem.Text = EngDisplayResource.Report;
            languageToolStripMenuItem.Text = EngDisplayResource.Language;

            this.WindowState = FormWindowState.Maximized;
            LoadConference();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private async void LoadConference()
        {
            lblSelectedItem.Text = EngDisplayResource.Conference;
            btnAdd.Text = EngDisplayResource.AddConference;
            _selectedItem = 1;

            _conferences = await new BalConference().ListConferences();

            //dgvData.Rows.Clear();
            dgvData.DataSource = null;
            dgvData.AutoGenerateColumns = false;
            dgvData.ColumnCount = 2;
            dgvData.Columns[0].HeaderText = EngDisplayResource.Id;
            // dgvData.Columns[0].Width = 300;
            dgvData.Columns[0].DataPropertyName = "Id";
            dgvData.Columns[1].HeaderText = EngDisplayResource.Name;
            dgvData.Columns[1].DataPropertyName = "Name";
            //dgvData.Columns[1].Width = 500;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Text = EngDisplayResource.Edit;
            btnEdit.HeaderText = EngDisplayResource.Edit;
            btnEdit.FlatStyle = FlatStyle.Standard;
            btnEdit.UseColumnTextForButtonValue = true;
            // btnEdit.Width = 300;
            dgvData.Columns.Add(btnEdit);

            dgvData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.DataSource = _conferences;
        }

        private void toolConference_Click(object sender, EventArgs e)
        {
            LoadConference();
        }

        private void toolAttendes_Click(object sender, EventArgs e)
        {
            lblSelectedItem.Text = EngDisplayResource.Attendee;
            btnAdd.Text = EngDisplayResource.AddAttendee;
            _selectedItem = 2;
        }

        private void toolSpeakers_Click(object sender, EventArgs e)
        {
            lblSelectedItem.Text = EngDisplayResource.Speaker;
            btnAdd.Text = EngDisplayResource.AddSpeaker;
            _selectedItem = 3;
        }

        private void toolTags_Click(object sender, EventArgs e)
        {
            lblSelectedItem.Text = EngDisplayResource.Tag;
            btnAdd.Text = EngDisplayResource.AddTag;
            _selectedItem = 4;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    frmConference frmConference = new frmConference(_conferences.FirstOrDefault(x => x.Id == Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value)));
                    if (frmConference.ShowDialog() == DialogResult.OK)
                    {
                        //senderGrid.Rows[e.RowIndex].Cells[1].Value = frmConference.Conference.Name;
                        dgvData.DataSource = null;
                        dgvData.DataSource = _conferences;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, EngDisplayResource.ProjectCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_selectedItem)
            {
                case 1:
                    frmConference frmConference = new frmConference();
                    if (frmConference.ShowDialog() == DialogResult.OK)
                    {
                        _conferences.Add(frmConference.Conference);
                        dgvData.DataSource = null;
                        dgvData.DataSource = _conferences;
                        LoadConference();
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateLanguage(new CultureInfo("en-US"));
        }

        private void spansihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateLanguage(new CultureInfo("es-ES"));
        }

        private void portugeseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateLanguage(new CultureInfo("zh-CHT"));
        }


        private void updateLanguage(CultureInfo customCulture)
        {

            Thread.CurrentThread.CurrentCulture = customCulture;
            Thread.CurrentThread.CurrentUICulture = customCulture;

            this.Controls.Clear();
            InitializeComponent();
            frmMain_Load(null, null);
        }
    }
}
