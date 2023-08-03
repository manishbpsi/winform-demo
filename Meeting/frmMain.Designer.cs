namespace Meeting
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            spansihToolStripMenuItem = new ToolStripMenuItem();
            portugeseToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolConference = new ToolStripButton();
            toolAttendees = new ToolStripButton();
            toolSpeakers = new ToolStripButton();
            toolTags = new ToolStripButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAdd = new Button();
            lblSelectedItem = new Label();
            dgvData = new DataGridView();
            mainMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, reportToolStripMenuItem, languageToolStripMenuItem });
            resources.ApplyResources(mainMenu, "mainMenu");
            mainMenu.Name = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            resources.ApplyResources(reportToolStripMenuItem, "reportToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, spansihToolStripMenuItem, portugeseToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(englishToolStripMenuItem, "englishToolStripMenuItem");
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // spansihToolStripMenuItem
            // 
            spansihToolStripMenuItem.Name = "spansihToolStripMenuItem";
            resources.ApplyResources(spansihToolStripMenuItem, "spansihToolStripMenuItem");
            spansihToolStripMenuItem.Click += spansihToolStripMenuItem_Click;
            // 
            // portugeseToolStripMenuItem
            // 
            portugeseToolStripMenuItem.Name = "portugeseToolStripMenuItem";
            resources.ApplyResources(portugeseToolStripMenuItem, "portugeseToolStripMenuItem");
            portugeseToolStripMenuItem.Click += portugeseToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolConference, toolAttendees, toolSpeakers, toolTags });
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolConference
            // 
            resources.ApplyResources(toolConference, "toolConference");
            toolConference.BackColor = SystemColors.GradientActiveCaption;
            toolConference.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolConference.Name = "toolConference";
            toolConference.Click += toolConference_Click;
            // 
            // toolAttendees
            // 
            resources.ApplyResources(toolAttendees, "toolAttendees");
            toolAttendees.BackColor = SystemColors.GradientActiveCaption;
            toolAttendees.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolAttendees.Name = "toolAttendees";
            toolAttendees.Click += toolAttendes_Click;
            // 
            // toolSpeakers
            // 
            resources.ApplyResources(toolSpeakers, "toolSpeakers");
            toolSpeakers.BackColor = SystemColors.GradientActiveCaption;
            toolSpeakers.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolSpeakers.Name = "toolSpeakers";
            toolSpeakers.Click += toolSpeakers_Click;
            // 
            // toolTags
            // 
            resources.ApplyResources(toolTags, "toolTags");
            toolTags.BackColor = SystemColors.GradientActiveCaption;
            toolTags.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolTags.Name = "toolTags";
            toolTags.Click += toolTags_Click;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvData, 0, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(btnAdd, 3, 0);
            tableLayoutPanel3.Controls.Add(lblSelectedItem, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblSelectedItem
            // 
            resources.ApplyResources(lblSelectedItem, "lblSelectedItem");
            lblSelectedItem.Name = "lblSelectedItem";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dgvData, "dgvData");
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 29;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "frmMain";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolConference;
        private ToolStripButton toolAttendees;
        private ToolStripButton toolSpeakers;
        private ToolStripButton toolTags;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnAdd;
        private Label lblSelectedItem;
        private DataGridView dgvData;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem spansihToolStripMenuItem;
        private ToolStripMenuItem portugeseToolStripMenuItem;
    }
}