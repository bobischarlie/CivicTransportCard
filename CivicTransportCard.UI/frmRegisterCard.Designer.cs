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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCardNo = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            chkSeniorPwd = new CheckBox();
            txtSeniorPwdIdNo = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 56);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Card Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 90);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 125);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // txtCardNo
            // 
            txtCardNo.Location = new Point(282, 53);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(248, 27);
            txtCardNo.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(282, 90);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(248, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(282, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(248, 27);
            txtLastName.TabIndex = 7;
            // 
            // chkSeniorPwd
            // 
            chkSeniorPwd.AutoSize = true;
            chkSeniorPwd.Location = new Point(76, 182);
            chkSeniorPwd.Name = "chkSeniorPwd";
            chkSeniorPwd.RightToLeft = RightToLeft.Yes;
            chkSeniorPwd.Size = new Size(119, 24);
            chkSeniorPwd.TabIndex = 8;
            chkSeniorPwd.Text = ": Senior/PWD";
            chkSeniorPwd.TextAlign = ContentAlignment.MiddleRight;
            chkSeniorPwd.UseVisualStyleBackColor = true;
            // 
            // txtSeniorPwdIdNo
            // 
            txtSeniorPwdIdNo.Location = new Point(282, 225);
            txtSeniorPwdIdNo.Name = "txtSeniorPwdIdNo";
            txtSeniorPwdIdNo.Size = new Size(248, 27);
            txtSeniorPwdIdNo.TabIndex = 10;
            txtSeniorPwdIdNo.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 232);
            label4.Name = "label4";
            label4.Size = new Size(185, 20);
            label4.TabIndex = 9;
            label4.Text = "Senior Id/PWD Id Number:";
            label4.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(282, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(248, 62);
            btnSave.TabIndex = 11;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmRegisterCard
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(645, 450);
            Controls.Add(btnSave);
            Controls.Add(txtSeniorPwdIdNo);
            Controls.Add(label4);
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
        private Label label4;
        private Button btnSave;
    }
}