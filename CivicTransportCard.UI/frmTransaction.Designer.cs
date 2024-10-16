namespace CivicTransportCard.WinForms
{
    partial class frmTransaction
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
            cboLocations = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtCardNo = new TextBox();
            groupBox1 = new GroupBox();
            picLoading = new PictureBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            SuspendLayout();
            // 
            // cboLocations
            // 
            cboLocations.Font = new Font("Microsoft Sans Serif", 12F);
            cboLocations.FormattingEnabled = true;
            cboLocations.Location = new Point(158, 64);
            cboLocations.Name = "cboLocations";
            cboLocations.Size = new Size(400, 33);
            cboLocations.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(15, 67);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Location:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(15, 147);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Card No:";
            // 
            // txtCardNo
            // 
            txtCardNo.Font = new Font("Microsoft Sans Serif", 12F);
            txtCardNo.Location = new Point(158, 147);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(399, 30);
            txtCardNo.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picLoading);
            groupBox1.Controls.Add(cboLocations);
            groupBox1.Controls.Add(txtCardNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(671, 208);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction";
            // 
            // picLoading
            // 
            picLoading.Image = Properties.Resources.Spinner_3;
            picLoading.Location = new Point(303, 103);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(64, 64);
            picLoading.SizeMode = PictureBoxSizeMode.AutoSize;
            picLoading.TabIndex = 4;
            picLoading.TabStop = false;
            picLoading.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(508, 246);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(175, 59);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(327, 246);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(175, 59);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmTransaction
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(693, 312);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transact";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboLocations;
        private Label label1;
        private Label label2;
        private TextBox txtCardNo;
        private GroupBox groupBox1;
        private Button btnSubmit;
        private Button btnCancel;
        private PictureBox picLoading;
    }
}