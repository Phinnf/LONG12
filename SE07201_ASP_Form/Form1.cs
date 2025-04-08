using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE07201_ASP_Form
{
    public partial class frmWaterBill : Form
    {
        List<Customer> listCustomers = new List<Customer>();
        public frmWaterBill()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
            {
                cboNumberOfPeople.Items.Add(i);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomerType.Text == "1 - Household customer")
                cboNumberOfPeople.Enabled = true;
            else
            {
                cboNumberOfPeople.Enabled = false;
                cboNumberOfPeople.Text = string.Empty;
            }
        }

        private void cboNumerOfPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmWaterBill_Load(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastMonthWater_Click(object sender, EventArgs e)
        {

        }

        private void lblThisMonthWater_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerType_Click(object sender, EventArgs e)
        {

        }
        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            int lastMonthWater = Convert.ToInt32(txtLastMonthWater.Text);
            int thisMonthWater = Convert.ToInt32(txtThisMonthWater.Text);
            int numberOfPeople = 0;
            int customerType = Convert.ToInt32(cboCustomerType.Text.Substring(0, 1));
            if (customerType == 1)
                numberOfPeople = Convert.ToInt32(cboNumberOfPeople.Text);
            listCustomers.Add(new Customer(name, lastMonthWater, thisMonthWater, customerType, numberOfPeople));
            CreateMyListView();
        }

        private void CreateMyListView()
        {
            lvCustomer.Items.Clear();
            List<ListViewItem> listItems = new List<ListViewItem>();
            foreach (Customer customer in listCustomers)
            {
                ListViewItem item = new ListViewItem(customer.Name);
                item.SubItems.Add(customer.LastMonthWater.ToString());
                item.SubItems.Add(customer.ThisMonthWater.ToString());
                item.SubItems.Add((customer.ThisMonthWater - customer.LastMonthWater).ToString());
                item.SubItems.Add(customer.totalWaterBill().ToString());
                listItems.Add(item);
            }
            lvCustomer.Items.AddRange(listItems.ToArray());
            Reset();
        }

        private void Reset()
        {
            txtCustomerName.Text = string.Empty;
            txtLastMonthWater.Text = string.Empty;
            txtThisMonthWater.Text = string.Empty;
            cboCustomerType.Text = string.Empty;
            cboNumberOfPeople.Text = string.Empty;
            cboNumberOfPeople.Enabled = false;
            txtCustomerName.Focus();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            listCustomers.Sort();
            CreateMyListView();
        }
    }
}
