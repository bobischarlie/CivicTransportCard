namespace CivicTransportCard.UI
{
    partial class frmRegisterCard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCardNo = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSeniorPwdIdNo = new TextBox();
            lblSeniorPwdIdNo = new Label();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnCancel = new Button();
            label4 = new Label();
            cboCardType = new ComboBox();
            cardTypeBindingSource = new BindingSource(components);
            picLoading = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(71, 38);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Card Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(71, 76);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(71, 115);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // txtCardNo
            // 
            txtCardNo.Font = new Font("Segoe UI", 11F);
            txtCardNo.Location = new Point(312, 35);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(248, 32);
            txtCardNo.TabIndex = 5;
            txtCardNo.Validating += textBox_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11F);
            txtFirstName.Location = new Point(312, 73);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(248, 32);
            txtFirstName.TabIndex = 6;
            txtFirstName.Validating += textBox_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11F);
            txtLastName.Location = new Point(312, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(248, 32);
            txtLastName.TabIndex = 7;
            txtLastName.Validating += textBox_Validating;
            // 
            // txtSeniorPwdIdNo
            // 
            txtSeniorPwdIdNo.Font = new Font("Segoe UI", 11F);
            txtSeniorPwdIdNo.Location = new Point(312, 215);
            txtSeniorPwdIdNo.MaxLength = 12;
            txtSeniorPwdIdNo.Name = "txtSeniorPwdIdNo";
            txtSeniorPwdIdNo.Size = new Size(248, 32);
            txtSeniorPwdIdNo.TabIndex = 10;
            txtSeniorPwdIdNo.Visible = false;
            txtSeniorPwdIdNo.KeyPress += txtSeniorPwdIdNo_KeyPress;
            txtSeniorPwdIdNo.Validating += txtSeniorPwdIdNo_Validating;
            // 
            // lblSeniorPwdIdNo
            // 
            lblSeniorPwdIdNo.AutoSize = true;
            lblSeniorPwdIdNo.Font = new Font("Segoe UI", 11F);
            lblSeniorPwdIdNo.Location = new Point(71, 222);
            lblSeniorPwdIdNo.Name = "lblSeniorPwdIdNo";
            lblSeniorPwdIdNo.Size = new Size(235, 25);
            lblSeniorPwdIdNo.TabIndex = 9;
            lblSeniorPwdIdNo.Text = "Senior Id/PWD Id Number:";
            lblSeniorPwdIdNo.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(343, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(193, 62);
            btnSave.TabIndex = 11;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(95, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 62);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(71, 153);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 13;
            label4.Text = "Card Type:";
            // 
            // cboCardType
            // 
            cboCardType.DataSource = cardTypeBindingSource;
            cboCardType.Font = new Font("Segoe UI", 11F);
            cboCardType.FormattingEnabled = true;
            cboCardType.Location = new Point(312, 150);
            cboCardType.Name = "cboCardType";
            cboCardType.Size = new Size(248, 33);
            cboCardType.TabIndex = 14;
            cboCardType.SelectedIndexChanged += cboCardType_SelectedIndexChanged;
            // 
            // cardTypeBindingSource
            // 
            cardTypeBindingSource.DataSource = typeof(Core.Enum.CardType);
            // 
            // picLoading
            // 
            picLoading.Image = WinForms.Properties.Resources.Spinner_3;
            picLoading.Location = new Point(291, 145);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(64, 64);
            picLoading.SizeMode = PictureBoxSizeMode.AutoSize;
            picLoading.TabIndex = 15;
            picLoading.TabStop = false;
            picLoading.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(picLoading);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboCardType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCardNo);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtSeniorPwdIdNo);
            groupBox1.Controls.Add(lblSeniorPwdIdNo);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 426);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register Card";
            // 
            // frmRegisterCard
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.Disable;
            CancelButton = btnCancel;
            ClientSize = new Size(645, 450);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "frmRegisterCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Card";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCardNo;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSeniorPwdIdNo;
        private Label lblSeniorPwdIdNo;
        private Button btnSave;
        private ErrorProvider errorProvider1;
        private Button btnCancel;
        private ComboBox cboCardType;
        private Label label4;
        private BindingSource cardTypeBindingSource;
        private PictureBox picLoading;
        private GroupBox groupBox1;
    }
}