namespace Meeting
{
    partial class frmConference
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
            components = new System.ComponentModel.Container();
            lblConfrenceName = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblConfrenceName
            // 
            lblConfrenceName.AutoSize = true;
            lblConfrenceName.Location = new Point(40, 40);
            lblConfrenceName.Name = "lblConfrenceName";
            lblConfrenceName.Size = new Size(120, 20);
            lblConfrenceName.TabIndex = 0;
            lblConfrenceName.Text = "Confrence Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(285, 27);
            txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(203, 81);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Submit";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmConfrence
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 143);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(lblConfrenceName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfrence";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Confrence";
            Load += frmConfrence_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfrenceName;
        private TextBox txtName;
        private Button btnAdd;
        private ErrorProvider errorProvider1;
    }
}