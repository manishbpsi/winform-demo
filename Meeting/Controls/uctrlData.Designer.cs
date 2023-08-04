namespace Meeting.Controls
{
    partial class uctrlData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbllayoutMain = new TableLayoutPanel();
            dgvData = new DataGridView();
            tbllayoutTitle = new TableLayoutPanel();
            lblSelectedItem = new Label();
            btnAdd = new Button();
            tbllayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            tbllayoutTitle.SuspendLayout();
            SuspendLayout();
            // 
            // tbllayoutMain
            // 
            tbllayoutMain.ColumnCount = 1;
            tbllayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbllayoutMain.Controls.Add(dgvData, 0, 1);
            tbllayoutMain.Controls.Add(tbllayoutTitle, 0, 0);
            tbllayoutMain.Dock = DockStyle.Fill;
            tbllayoutMain.Location = new Point(0, 0);
            tbllayoutMain.Name = "tbllayoutMain";
            tbllayoutMain.RowCount = 2;
            tbllayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2591944F));
            tbllayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 87.74081F));
            tbllayoutMain.Size = new Size(694, 571);
            tbllayoutMain.TabIndex = 0;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(3, 73);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(688, 495);
            dgvData.TabIndex = 1;
            // 
            // tbllayoutTitle
            // 
            tbllayoutTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbllayoutTitle.ColumnCount = 4;
            tbllayoutTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbllayoutTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbllayoutTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbllayoutTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tbllayoutTitle.Controls.Add(lblSelectedItem, 0, 0);
            tbllayoutTitle.Controls.Add(btnAdd, 3, 0);
            tbllayoutTitle.Location = new Point(3, 3);
            tbllayoutTitle.Name = "tbllayoutTitle";
            tbllayoutTitle.RowCount = 1;
            tbllayoutTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbllayoutTitle.Size = new Size(688, 64);
            tbllayoutTitle.TabIndex = 2;
            // 
            // lblSelectedItem
            // 
            lblSelectedItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSelectedItem.AutoSize = true;
            tbllayoutTitle.SetColumnSpan(lblSelectedItem, 2);
            lblSelectedItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedItem.Location = new Point(3, 18);
            lblSelectedItem.Name = "lblSelectedItem";
            lblSelectedItem.Size = new Size(338, 28);
            lblSelectedItem.TabIndex = 0;
            lblSelectedItem.Text = "Selected Item";
            lblSelectedItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(519, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // uctrlData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbllayoutMain);
            Name = "uctrlData";
            Size = new Size(694, 571);
            tbllayoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            tbllayoutTitle.ResumeLayout(false);
            tbllayoutTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tbllayoutMain;
        private DataGridView dgvData;
        private TableLayoutPanel tbllayoutTitle;
        private Label lblSelectedItem;
        private Button btnAdd;
    }
}
