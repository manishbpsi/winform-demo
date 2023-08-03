﻿namespace Meeting
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
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolConfrence = new ToolStripButton();
            toolAttendes = new ToolStripButton();
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
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, reportToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(800, 28);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(68, 24);
            reportToolStripMenuItem.Text = "Report";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 422);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolConfrence, toolAttendes, toolSpeakers, toolTags });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(151, 422);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolConfrence
            // 
            toolConfrence.AutoSize = false;
            toolConfrence.BackColor = SystemColors.ActiveCaption;
            toolConfrence.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolConfrence.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolConfrence.Image = (Image)resources.GetObject("toolConfrence.Image");
            toolConfrence.ImageTransparentColor = Color.Magenta;
            toolConfrence.Name = "toolConfrence";
            toolConfrence.Size = new Size(150, 50);
            toolConfrence.Text = "Conference";
            toolConfrence.Click += toolConfrence_Click;
            // 
            // toolAttendes
            // 
            toolAttendes.AutoSize = false;
            toolAttendes.BackColor = SystemColors.ActiveCaption;
            toolAttendes.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolAttendes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolAttendes.Image = (Image)resources.GetObject("toolAttendes.Image");
            toolAttendes.ImageTransparentColor = Color.Magenta;
            toolAttendes.Name = "toolAttendes";
            toolAttendes.Size = new Size(150, 50);
            toolAttendes.Text = "Attendees";
            toolAttendes.Click += toolAttendes_Click;
            // 
            // toolSpeakers
            // 
            toolSpeakers.AutoSize = false;
            toolSpeakers.BackColor = SystemColors.ActiveCaption;
            toolSpeakers.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolSpeakers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolSpeakers.Image = (Image)resources.GetObject("toolSpeakers.Image");
            toolSpeakers.ImageTransparentColor = Color.Magenta;
            toolSpeakers.Name = "toolSpeakers";
            toolSpeakers.Size = new Size(150, 50);
            toolSpeakers.Text = "Speakers";
            toolSpeakers.Click += toolSpeakers_Click;
            // 
            // toolTags
            // 
            toolTags.AutoSize = false;
            toolTags.BackColor = SystemColors.ActiveCaption;
            toolTags.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolTags.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolTags.Image = (Image)resources.GetObject("toolTags.Image");
            toolTags.ImageTransparentColor = Color.Magenta;
            toolTags.Name = "toolTags";
            toolTags.Size = new Size(150, 50);
            toolTags.Text = "Tags";
            toolTags.Click += toolTags_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvData, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(163, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.Size = new Size(634, 416);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnAdd, 3, 0);
            tableLayoutPanel3.Controls.Add(lblSelectedItem, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(628, 35);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(474, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblSelectedItem
            // 
            lblSelectedItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSelectedItem.AutoSize = true;
            lblSelectedItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedItem.Location = new Point(3, 0);
            lblSelectedItem.Name = "lblSelectedItem";
            lblSelectedItem.Size = new Size(151, 20);
            lblSelectedItem.TabIndex = 1;
            lblSelectedItem.Text = "Selected Item";
            lblSelectedItem.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(3, 44);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(628, 369);
            dgvData.TabIndex = 1;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "frmMain";
            Text = "Demo WinForms";
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
        private ToolStripButton toolConfrence;
        private ToolStripButton toolAttendes;
        private ToolStripButton toolSpeakers;
        private ToolStripButton toolTags;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnAdd;
        private Label lblSelectedItem;
        private DataGridView dgvData;
    }
}