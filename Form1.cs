using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RAD_CSharp_Role_Exercise
{
    public partial class frmGetPaymentsPerPortfolio : Form
    {
        public frmGetPaymentsPerPortfolio()
        {
            InitializeComponent();
        }

        private void frmGetPaymentsPerPortfolio_Load(object sender, EventArgs e)
        {
            //Load portfolios to form and assign default portfolio
            comboBoxPortfolios.Items.AddRange(Properties.Settings.Default.Portfolios.Split(','));
            comboBoxPortfolios.Text = Properties.Settings.Default.Portfolios.Split(',')[0];
        }

        private void  cmdGetPayments_Click(object sender, EventArgs e)
        {
            try
            {
                GetPaymentsClient getPaymentsClient = new GetPaymentsClient
                {
                    //Set up key properties
                    EndPoint = Properties.Settings.Default.EndPoint.ToString(),
                    SavePath = Properties.Settings.Default.SavePath.ToString(),
                    Portfolio = comboBoxPortfolios.SelectedItem.ToString()
                };

                //Get payments and write them to CSV file
                 Task t = getPaymentsClient.GetPayments();
                TimeSpan ts = TimeSpan.FromMilliseconds(150);
                if (!t.Wait(ts))
                    throw new Exception($"The attempt to retrieve payments for portfolio {getPaymentsClient.Portfolio} timed out.");

                // Inform user of task completion
                MessageBox.Show($"Payments retrieved for portfolio: {getPaymentsClient.Portfolio}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + '\n' + ex.Message.ToString());
            }
        }
    }
}
