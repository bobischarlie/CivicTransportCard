using CivicTransportCard.Core.Contracts;
using CivicTransportCard.WinForms.Handler;
using Newtonsoft.Json;
using System.Configuration;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace CivicTransportCard.UI
{
    public partial class frmRegisterCard : Form
    {
        public frmRegisterCard()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var transportCardData = new TransportCardRequestContract
                {
                    CardNo = txtCardNo.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    IsSeniorOrPwd = chkSeniorPwd.Checked,
                    IdNo = txtSeniorPwdIdNo.Text
                };
                var response = await ApiHandler.SendAPIPostRequestAsync("api/TransportCard", transportCardData);
                MessageBox.Show($"Card with CardNo: {transportCardData.CardNo} Successfully Saved.");
                foreach (var ctrl in this.Controls)
                {
                    if (ctrl is TextBox txtBox)
                    {
                        txtBox.Clear();
                    }
                }
            }
        }
        private void textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, string.Empty);
            }
        }


        private void chkSeniorPwd_CheckedChanged(object sender, EventArgs e)
        {
            lblSeniorPwdIdNo.Visible = chkSeniorPwd.Checked;
            txtSeniorPwdIdNo.Visible = chkSeniorPwd.Checked;
            if (chkSeniorPwd.Checked)
            {
                txtSeniorPwdIdNo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            }
            else
            {
                txtSeniorPwdIdNo.Validating -= new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }
    }
}
