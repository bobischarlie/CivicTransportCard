namespace CivicTransportCard.WinForms
{
    partial class frmReloadCard
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
            btnCancel = new Button();
            btnSubmit = new Button();
            txtCardNo = new TextBox();
            groupBox1 = new GroupBox();
            picLoading = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            numAmount = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.Location = new Point(299, 439);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 63);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 15F);
            btnSubmit.Location = new Point(483, 439);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(154, 63);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_ClickAsync;
            // 
            // txtCardNo
            // 
            txtCardNo.Font = new Font("Segoe UI", 11F);
            txtCardNo.Location = new Point(198, 73);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.PlaceholderText = "Card Number";
            txtCardNo.Size = new Size(290, 32);
            txtCardNo.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picLoading);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numAmount);
            groupBox1.Controls.Add(txtCardNo);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(55, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 398);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reload Card";
            // 
            // picLoading
            // 
            picLoading.Image = Properties.Resources.Spinner_3;
            picLoading.Location = new Point(267, 232);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(64, 64);
            picLoading.SizeMode = PictureBoxSizeMode.AutoSize;
            picLoading.TabIndex = 8;
            picLoading.TabStop = false;
            picLoading.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 68);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 7;
            label2.Text = "Card No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 130);
            label1.Name = "label1";
            label1.Size = new Size(109, 35);
            label1.TabIndex = 6;
            label1.Text = "Amount:";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(198, 128);
            numAmount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numAmount.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(290, 41);
            numAmount.TabIndex = 5;
            numAmount.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // frmReloadCard
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(684, 541);
            Controls.Add(groupBox1);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmReloadCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reload Card";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnSubmit;
        private TextBox txtCardNo;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private NumericUpDown numAmount;
        private PictureBox picLoading;
    }
}