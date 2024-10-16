namespace CivicTransportCard.UI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void registerCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmRegisterCard = new frmRegisterCard();
            openForm(frmRegisterCard);
        }

        private void openForm(Form formToOpen)
        {
            // Check if the form is already open
            var openForm = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(f => f.GetType() == formToOpen.GetType());

            if (openForm == null)
            {
                formToOpen.MdiParent = this;
                formToOpen.Show();
            }
            else
            {
                if (openForm.WindowState == FormWindowState.Minimized)
                {
                    openForm.WindowState = FormWindowState.Normal;
                }
                openForm.BringToFront();
                openForm.Focus();
            }
        }

    }
}
