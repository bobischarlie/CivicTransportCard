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
            chkSeniorPwd = new CheckBox();
            txtSeniorPwdIdNo = new TextBox();
            lblSeniorPwdIdNo = new Label();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(76, 52);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Card Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(76, 90);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(76, 125);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // txtCardNo
            // 
            txtCardNo.Font = new Font("Segoe UI", 11F);
            txtCardNo.Location = new Point(317, 45);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(248, 32);
            txtCardNo.TabIndex = 5;
            txtCardNo.Validating += textBox_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11F);
            txtFirstName.Location = new Point(317, 83);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(248, 32);
            txtFirstName.TabIndex = 6;
            txtFirstName.Validating += textBox_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11F);
            txtLastName.Location = new Point(317, 122);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(248, 32);
            txtLastName.TabIndex = 7;
            txtLastName.Validating += textBox_Validating;
            // 
            // chkSeniorPwd
            // 
            chkSeniorPwd.AutoSize = true;
            chkSeniorPwd.Font = new Font("Segoe UI", 11F);
            chkSeniorPwd.Location = new Point(76, 182);
            chkSeniorPwd.Name = "chkSeniorPwd";
            chkSeniorPwd.RightToLeft = RightToLeft.Yes;
            chkSeniorPwd.Size = new Size(146, 29);
            chkSeniorPwd.TabIndex = 8;
            chkSeniorPwd.Text = ": Senior/PWD";
            chkSeniorPwd.TextAlign = ContentAlignment.MiddleRight;
            chkSeniorPwd.UseVisualStyleBackColor = true;
            chkSeniorPwd.CheckedChanged += chkSeniorPwd_CheckedChanged;
            // 
            // txtSeniorPwdIdNo
            // 
            txtSeniorPwdIdNo.Font = new Font("Segoe UI", 11F);
            txtSeniorPwdIdNo.Location = new Point(317, 225);
            txtSeniorPwdIdNo.Name = "txtSeniorPwdIdNo";
            txtSeniorPwdIdNo.Size = new Size(248, 32);
            txtSeniorPwdIdNo.TabIndex = 10;
            txtSeniorPwdIdNo.Visible = false;
            // 
            // lblSeniorPwdIdNo
            // 
            lblSeniorPwdIdNo.AutoSize = true;
            lblSeniorPwdIdNo.Font = new Font("Segoe UI", 11F);
            lblSeniorPwdIdNo.Location = new Point(76, 232);
            lblSeniorPwdIdNo.Name = "lblSeniorPwdIdNo";
            lblSeniorPwdIdNo.Size = new Size(235, 25);
            lblSeniorPwdIdNo.TabIndex = 9;
            lblSeniorPwdIdNo.Text = "Senior Id/PWD Id Number:";
            lblSeniorPwdIdNo.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(337, 302);
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
            btnCancel.Location = new Point(89, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 62);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
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
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtSeniorPwdIdNo);
            Controls.Add(lblSeniorPwdIdNo);
            Controls.Add(chkSeniorPwd);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtCardNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmRegisterCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Card";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCardNo;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private CheckBox chkSeniorPwd;
        private TextBox txtSeniorPwdIdNo;
        private Label lblSeniorPwdIdNo;
        private Button btnSave;
        private ErrorProvider errorProvider1;
        private Button btnCancel;
    }
}