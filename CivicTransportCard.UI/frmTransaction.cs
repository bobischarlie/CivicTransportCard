using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Models;
using CivicTransportCard.WinForms.Handler;
using Newtonsoft.Json;

namespace CivicTransportCard.WinForms
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
            LoadLocations();

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                picLoading.Visible = true;
                btnSubmit.Enabled = false;
                btnCancel.Enabled = false;

                if (ValidateChildren())
                {
                    var createTripData = new UpsertTripRequestContract
                    {
                        CardNo = txtCardNo.Text,
                        LocationId = (Guid)cboLocations.SelectedValue
                    };

                    var response = await ApiHandler.SendAPIPostRequestAsync("api/Transaction/Trip", createTripData);
                    var result = JsonConvert.DeserializeObject<Transaction>(response);
                    MessageBox.Show($"Card with CardNo: {createTripData.CardNo} " +
                        $"has created a transaction. Remaining balance is {result.EndingBalance}");

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
                btnSubmit.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private async void LoadLocations()
        {
            try
            {
                picLoading.Visible = true;
                btnSubmit.Enabled = false;
                btnCancel.Enabled = false;
                var response = await ApiHandler.SendAPIGetRequestAsync("api/Location");
                var result = JsonConvert.DeserializeObject<List<Location>>(response);
                result = result.OrderBy(l => l.LocationName).ToList();
                cboLocations.DataSource = result;
                cboLocations.DisplayMember = "LocationName";
                cboLocations.ValueMember = "Id";
            }
            catch(ArgumentException ex)
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
