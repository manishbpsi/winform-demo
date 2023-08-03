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
    public partial class frmConference : Form
    {
        BalConference balconfrence;
        Confrence _confrence = null;
        public frmConference(Confrence confrence)
        {
            InitializeComponent();
            //balconfrence = new BalConfrence();
            //confrence = balconfrence.Confrence(id);
            if (confrence != null)
            {
                _confrence = confrence;
            }
            else
            {
                _confrence = new Confrence { Id = 5 };
            }

        }

        private void frmConfrence_Load(object sender, EventArgs e)
        {
            if (_confrence != null)
            {
                txtName.Text = _confrence.Name;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show(EngValidationResource.EnterConfrenceName, EngDisplayResource.ProjectCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _confrence.Name = txtName.Text;
                btnAdd.DialogResult = DialogResult.OK;
            }
        }
        public Confrence Confrence
        {
            get { return _confrence; }
        }
    }
}
