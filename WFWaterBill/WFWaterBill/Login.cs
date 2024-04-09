namespace WFWaterBill
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to exit?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        string user = "son";
        string pass = "442005";
        bool Check (string user, string pass)
        {
            if(user == this.user && pass == this.pass)
            {
                return true;
            }
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Check(txbUsername.Text, txbPass.Text))
            {
                WaterBill waterBill = new WaterBill();
                waterBill.Show();
                this.Hide();
            }
            else
            {
                DialogResult error = MessageBox.Show("Invalid username or password!!!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
