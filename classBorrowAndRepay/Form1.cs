using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace classBorrowAndRepay
{
    public partial class Form1 : Form
    {
        ClassBorrowAndRepay i, Borrow;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(Borrow, 100);
            updataMoney();
        }

        private void repayBotton_Click(object sender, EventArgs e)
        {
            if (Borrow.Money > 0)
            {


                i.repay(Borrow, 100);
                updataMoney();
            }
        }
        private void updataMoney()
        {
            myMoneyLabel2.Text = " " + i.Money;
            borrowMoney2.Text = " " + Borrow.Money;
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            i = new ClassBorrowAndRepay(myNameTextBox.Text, 10000);
            Borrow = new ClassBorrowAndRepay(borrowNameTextBox.Text, 0);

            myNameTextBox.Enabled = false;
            borrowNameTextBox.Enabled = false;
            nameButton.Enabled = false;

            borrowButton.Text = this.Borrow.Name + " Borrow 100$ ";
            repayBotton.Text =  " Repay " + i.Name + " 100$ ";

            myNanmeLabel3.Text = this.i.Name;
            borrowNameLabel3.Text = this.Borrow.Name;

            borrowButton.Enabled = true;
            repayBotton.Enabled = true;
        }
    }
}
