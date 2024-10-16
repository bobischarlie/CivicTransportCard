using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Models;
using CivicTransportCard.WinForms.Handler;
using Newtonsoft.Json;

namespace CivicTransportCard.WinForms
{
    public partial class frmReloadCard : Form
    {
        public frmReloadCard()
        {
            InitializeComponent();
        }

        private async void btnSubmit_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                picLoading.Visible = true;
                btnSubmit.Enabled = false;
                btnCancel.Enabled = false;

                if (ValidateChildren())
                {
                    var reloadCardData = new ReloadCardRequestContract
                    {
                        CardNo = txtCardNo.Text,
                        LoadAmount = numAmount.Value
                    };

                    var response = await ApiHandler.SendAPIPutRequestAsync("api/TransportCard/ReloadCard", reloadCardData);
                    var result = JsonConvert.DeserializeObject<TransportCard>(response);
                    MessageBox.Show($"Card with CardNo: {reloadCardData.CardNo} " +
                        $"has been successfully loaded with {numAmount.Value}. New balance is {result.Balance}");

                    foreach (var ctrl in this.Controls)
                    {
                        if (ctrl is TextBox txtBox)
                        {
                            txtBox.Clear();
                        }
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                picLoading.Visible = false;
                btnSubmit.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }
    }
}
