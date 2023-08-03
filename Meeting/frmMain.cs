using BalDemo;
using Meeting.Resources;
using ModelDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting
{
    public partial class frmMain : Form
    {
        private int _seletedItem = 0;
        private List<Confrence> _confrences;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadConference();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private async void LoadConference()
        {
            lblSelectedItem.Text = EngDisplayResource.Confrence;
            btnAdd.Text = EngDisplayResource.AddConfrence;
            _seletedItem = 1;

            _confrences = await new BalConference().Confrences();

            //dgvData.Rows.Clear();
            dgvData.DataSource = null;
            dgvData.AutoGenerateColumns = false;
            dgvData.ColumnCount = 2;
            dgvData.Columns[0].HeaderText = "ID";
            // dgvData.Columns[0].Width = 300;
            dgvData.Columns[0].DataPropertyName = "Id";
            dgvData.Columns[1].HeaderText = "Name";
            dgvData.Columns[1].DataPropertyName = "Name";
            //dgvData.Columns[1].Width = 500;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Text = "Edit";
            btnEdit.HeaderText = "Edit";
            btnEdit.FlatStyle = FlatStyle.Standard;
            btnEdit.UseColumnTextForButtonValue = true;
            // btnEdit.Width = 300;
            dgvData.Columns.Add(btnEdit);

            dgvData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.DataSource = _confrences;
        }
        private void toolConfrence_Click(object sender, EventArgs e)
        {
            LoadConference();
        }

        private void toolAttendes_Click(object sender, EventArgs e)
        {
            lblSelectedItem.Text = EngDisplayResource.Attende;
            btnAdd.Text = EngDisplayResource.AddAttende;
            _seletedItem = 2;
        }

        private void toolSpeakers_Click(object sender, EventArgs e)
        {
            lblSelectedItem.Text = EngDisplayResource.Speaker;
            btnAdd.Text = EngDisplayResource.AddSpeaker;
            _seletedItem = 3;
        }

        private void toolTags_Click(object sender, EventArgs e)
        {
            lblSelectedItem.Text = EngDisplayResource.Tag;
            btnAdd.Text = EngDisplayResource.AddTag;
            _seletedItem = 4;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                frmConference frmConfrence = new frmConference(_confrences.FirstOrDefault(x => x.Id == Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value)));
                if (frmConfrence.ShowDialog() == DialogResult.OK)
                {
                    //senderGrid.Rows[e.RowIndex].Cells[1].Value = frmConfrence.Confrence.Name;
                    dgvData.DataSource = null;
                    dgvData.DataSource = _confrences;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_seletedItem)
            {
                case 1:
                    frmConference frmConfrence = new frmConference(null);
                    if (frmConfrence.ShowDialog() == DialogResult.OK)
                    {
                        _confrences.Add(frmConfrence.Confrence);
                        dgvData.DataSource = null;
                        dgvData.DataSource = _confrences;
                        LoadConference();
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
