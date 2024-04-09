using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFWaterBill
{
    public partial class WaterBill : Form
    {
        public WaterBill()
        {
            InitializeComponent();
        }

        private void btnShut_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Do you want to shutdown program??", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            if (listView1.SelectedIndices.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                string Name = item.SubItems[0].Text;
                string Type = item.SubItems[1].Text;
                int Last = int.Parse(item.SubItems[2].Text);
                int This = int.Parse(item.SubItems[3].Text);

                // Push data to form

                txbName.Text = Name;
                cbbType.Text = Type;
                txbLast.Text = Last.ToString();
                txbThis.Text = This.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int Last = int.Parse(txbLast.Text);
                int This = int.Parse(txbThis.Text);
                int Consumption = 0;
                double WaterFee = 0;
                double Tax = 0;
                double Fee = 0;
                double TaxFee = 0;
                double Total = 0;

                ListViewItem item = new ListViewItem();

                item.Text = txbName.Text;
                item.SubItems.Add(cbbType.Text);
                item.SubItems.Add(Last.ToString());
                item.SubItems.Add(This.ToString());
                
                //Check and calculate water consumed
                if (This < Last)
                {
                    DialogResult consumption = MessageBox.Show("Last month's water meter must be less than this month's water meter", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Consumption = This - Last;
                }

                item.SubItems.Add(Consumption.ToString());

                //Calculate water charges for each type of customer
                if (cbbType.SelectedIndex == 0)
                {
                    if (Consumption > 0 && Consumption <= 10)
                    {
                        WaterFee = Consumption * 5973;
                    }
                    else if (Consumption > 10 && Consumption <= 20)
                    {
                        WaterFee = (Consumption - 10) * 7052 + 59730;
                    }
                    else if (Consumption > 20 && Consumption <= 30)
                    {
                        WaterFee = (Consumption - 20) * 8699 + 59730 + 70520;
                    }
                    else
                    {
                        WaterFee = (Consumption - 30) * 15929 + 86990 + 59730 + 70520;
                    }
                }
                else if (cbbType.SelectedIndex == 1)
                {
                    WaterFee = Consumption * 9955;
                }
                else if (cbbType.SelectedIndex == 2)
                {
                    WaterFee = Consumption * 11615;
                }
                else
                {
                    WaterFee = Consumption * 22068;
                }
                item.SubItems.Add(WaterFee.ToString());

                //Calculate taxes and fees
                Tax = WaterFee / 10;
                Fee = WaterFee / 10;
                TaxFee = Tax + Fee;

                //Calculate total bill
                Total = WaterFee + TaxFee;


                item.SubItems.Add(TaxFee.ToString());
                item.SubItems.Add(Total.ToString());

                //Add data to listView
                listView1.Items.Add(item);
                //Remove selected row
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                DialogResult edit = MessageBox.Show("Pls choose to edit!!!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnEdit.Enabled = false;

            //Delete data in txb,cbb
            txbName.Text = null;
            cbbType.SelectedIndex = -1;
            txbLast.Text = null;
            txbThis.Text = null;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txbName.Text;
            string Type = cbbType.Text;
            int Last = int.Parse(txbLast.Text);
            int This = int.Parse(txbThis.Text);
            int Consumption = 0;
            double WaterFee = 0;
            double Tax = 0;
            double Fee = 0;
            double TaxFee = 0;
            double Total = 0;

            ListViewItem item1 = new ListViewItem();
            item1.Text = Name;
            item1.SubItems.Add(Type);
            item1.SubItems.Add(Last.ToString());
            item1.SubItems.Add(This.ToString());

            //Check and calculate water consumed
            if (This < Last)
            {
                DialogResult consumption = MessageBox.Show("Last month's water meter must be less than this month's water meter", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Consumption = This - Last;
            }

            item1.SubItems.Add(Consumption.ToString());

            //Calculate water charges for each type of customer
            if (cbbType.SelectedIndex == 0)
            {
                if (Consumption > 0 && Consumption <= 10)
                {
                    WaterFee = Consumption * 5973;
                }
                else if (Consumption > 10 && Consumption <= 20)
                {
                    WaterFee = (Consumption - 10) * 7052 + 59730;
                }
                else if (Consumption > 20 && Consumption <= 30)
                {
                    WaterFee = (Consumption - 20) * 8699 + 59730 + 70520;
                }
                else
                {
                    WaterFee = (Consumption - 30) * 15929 + 86990 + 59730 + 70520;
                }
            }
            else if (cbbType.SelectedIndex == 1)
            {
                WaterFee = Consumption * 9955;
            }
            else if (cbbType.SelectedIndex == 2)
            {
                WaterFee = Consumption * 11615;
            }
            else
            {
                WaterFee = Consumption * 22068;
            }
            item1.SubItems.Add(WaterFee.ToString());

            //Calculate taxes and fees
            Tax = WaterFee / 10;
            Fee = WaterFee / 10;
            TaxFee = Tax + Fee;

            //Calculate total bill
            Total = WaterFee + TaxFee;


            item1.SubItems.Add(TaxFee.ToString());
            item1.SubItems.Add(Total.ToString());

            //Add data to listView
            listView1.Items.Add(item1);

            //Delete data in form
            txbName.Text = null;
            txbLast.Text = null;
            txbThis.Text = null;
            cbbType.SelectedIndex = -1;
            txbName.Focus();


        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult del = MessageBox.Show("Do u want to delete?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Pls choose row to delete!!!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
