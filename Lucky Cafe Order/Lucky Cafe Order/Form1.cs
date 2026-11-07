using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lucky_Cafe_Order
{
    public partial class Form1 : Form
    {
        Random Rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNameTxt.Text == "")
            {
                MessageBox.Show("please Enter Customer name");
                return;
            }

            int Quantity;

            if (!int.TryParse(QuantityTxt.Text, out Quantity) || Quantity < 1)
            {
                MessageBox.Show("Please Enter A valid Quantity");
                return;
            }

            double DrinkPrice = 0;
            String DrinkName = "";

            if (TeaRadioBtn.Checked)
            {
                DrinkPrice = 1;
                DrinkName = "Tea";
            }
            else if (CoffeRadioBtn.Checked)
            {
                DrinkPrice = 2;
                DrinkName = "Coffe";
            }
            else if (JuiceRadioBtn.Checked)
            {
                DrinkPrice = 3;
                DrinkName = "Juice";
            }
            else
            {
                MessageBox.Show("Please Select a Drink!");
                return;
            }

            Order_List.Items.Clear();

            double TotalBeforeDiscount = DrinkPrice * Quantity;

            double MemberDiscount = 0;

            if (StudentMemberCheckbox.Checked)
            {
                MemberDiscount = TotalBeforeDiscount * 0.10;
            }

            double TotalAfterDiscount = TotalBeforeDiscount - MemberDiscount;

            bool hasprize = false;

            int WinningLuckyNumber = 0;

            for (int i = 1; i <= Quantity; i++)
            {
                int LuckyNumber = Rand.Next(1, 51);

                String Order = i + ") " + CustomerNameTxt.Text + " - " + DrinkName + " - Lucky: " + LuckyNumber + " - $" + DrinkPrice.ToString("0.00");

                OrderList.Items.Add(Order);

                if (LuckyNumber == 7 || LuckyNumber == 17)
                {
                    hasprize = true;

                    WinningLuckyNumber = LuckyNumber;
                }
            }

            String LuckyMessage;
            String ListLuckyMessage;

            if (hasprize)
            {
                LuckyMessage = "You got a Free Cookie!";

                ListLuckyMessage = "You get a Free Cookie! (Lucky " + WinningLuckyNumber + ")";


            }
            else
            {
                LuckyMessage = "No Prize this time.";

                ListLuckyMessage = "No Prize this time.";
            }

            OrderList.Items.Add(" ");

            if (StudentMemberCheckbox.Checked)
            {
                OrderList.Items.Add("Member Discount: 10%");
            }

            OrderList.Items.Add("Total Before Discount: $" + TotalBeforeDiscount.ToString("0.00"));

            OrderList.Items.Add("Total After Discount: $" + TotalAfterDiscount.ToString("0.00"));

            OrderList.Items.Add("Lucky Message: " + ListLuckyMessage);


            TotalPriceLbl.Text = "Total Price: $" + TotalAfterDiscount.ToString("0.00");

            LuckyMessageLbl.Text = "Lucky Message: " + LuckyMessage;

        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (OrderList.Items.Count == 0)
            {
                MessageBox.Show("No Order To Save!");
                return;
            }

            StreamWriter writer = File.AppendText("orders.txt");

            for (int i = 0; i < OrderList.Items.Count; i++)
            {
                writer.WriteLine(OrderList.Items[i].ToString());

            }

            writer.WriteLine(TotalPriceLbl.Text);
            writer.WriteLine(LuckyMessageLbl.Text);
            writer.WriteLine("  ");

            writer.Close();

            MessageBox.Show("Order Saved!");
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found!");
                return;
            }

            OrderList.Items.Clear();

            StreamReader reader = File.OpenText("orders.txt");

            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();

                OrderList.Items.Add(line);

            }
            reader.Close();

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CustomerNameTxt.Clear();
            QuantityTxt.Clear();

            OrderList.Items.Clear();

            TotalPriceLbl.Text = "Total Price:";
            LuckyMessageLbl.Text = "Lucky Message:";

            StudentMemberCheckbox.Checked = false;

            TeaRadioBtn.Checked = false;
            CoffeRadioBtn.Checked = false;
            JuiceRadioBtn.Checked = false;
        }
    }
}