using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Enum;
using CivicTransportCard.WinForms;
using CivicTransportCard.WinForms.Handler;

namespace CivicTransportCard.UI
{
    public partial class frmRegisterCard : Form
    {
        public frmRegisterCard()
        {
            InitializeComponent();
            cboCardType.DataSource = Enum.GetValues(typeof(CardType));
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                picLoading.Visible = true;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                if (ValidateChildren())
                {
                    var transportCardData = new TransportCardRequestContract
                    {
                        CardNo = txtCardNo.Text,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        IdNo = txtSeniorPwdIdNo.Text,
                        CardType = (CardType)cboCardType.SelectedIndex
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                picLoading.Visible = false;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void cboCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var showSeniorPwdFields = cboCardType.SelectedIndex == 1;
            lblSeniorPwdIdNo.Visible = showSeniorPwdFields;
            txtSeniorPwdIdNo.Visible = showSeniorPwdFields;
        }

        private void txtSeniorPwdIdNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit and not a control key (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void txtSeniorPwdIdNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int length = textBox.Text.Length;

            if (length != 10 && length != 12 && cboCardType.SelectedIndex == (int)CardType.Civic_Discounted_Transport)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This must be exactly 10 or 12 characters long.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, string.Empty);
            }
        }
    }
}
