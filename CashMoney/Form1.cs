using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace CashMoney
    /* 
     * Jayden Roddick 
     * Cash Rigister 
     * 10/07/19
     */ 
{
    public partial class cashMoney : Form
    {
        //global
       const  double strawberryjamPrice = 3;
        const double bananajamPrice = 7.50;
        const double coconutjamPrice = 10;

        int numberofstwaberryjamInput;
        int numberofbananaofjamInput;
        int numberofcoconutjamInput;

        double subTotalInput;
       const double taxTotal = 0.13; 
        double totalPrice;
        double taxtotalDisplay; 
        public cashMoney()
        {
            InitializeComponent();
        }

        private void calculateValue_Click(object sender, EventArgs e)
        {
            numberofstwaberryjamInput = Convert.ToInt16(strawberryjamInput.Text);
            numberofbananaofjamInput = Convert.ToInt16(bananajamInput.Text);
            numberofcoconutjamInput = Convert.ToInt16(coconutjamInput.Text);

            subTotalInput = numberofstwaberryjamInput * strawberryjamPrice + numberofbananaofjamInput * bananajamPrice + numberofcoconutjamInput * coconutjamPrice;
            taxtotalDisplay = numberofbananaofjamInput * taxTotal + numberofcoconutjamInput * taxTotal + numberofstwaberryjamInput * taxTotal; 
            totalPrice = subTotalInput + taxtotalDisplay;
            subtotalOutput.Text = subTotalInput.ToString("C");
            taxOutput.Text = taxtotalDisplay.ToString("C");
            totalOutput.Text = totalPrice.ToString("C");  
                 

        }

        private void printRecipt_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Font drawFont = new Font("Arial", 12, FontStyle.Bold);
            SolidBrush drawBr= new SolidBrush(Color.Black);
            drawBrush.Color = Color.Red;
            g.FillRectangle(drawBrush, 500, 90, 220, 330);
            g.DrawString("Jayden's Jams", drawFont, drawBr, 500, 90);
            Thread.Sleep(1000);
            g.DrawString("10/15/19", drawFont, drawBr, 500, 110);
            Thread.Sleep(1000);
            g.DrawString("Strawberry Jam x " + numberofstwaberryjamInput, drawFont, drawBr, 500, 130);
            Thread.Sleep(1000);
            g.DrawString("Banana Jam x " + numberofbananaofjamInput, drawFont, drawBr, 500, 150);
            Thread.Sleep(1000);
            g.DrawString("Coconut Jam x " + numberofcoconutjamInput, drawFont, drawBr, 500, 170);
            Thread.Sleep(1000);
            g.DrawString("SubTotal " + subTotalInput.ToString("C"), drawFont, drawBr, 500, 220);
            Thread.Sleep(1000);
            g.DrawString("Tax " + taxtotalDisplay.ToString("C"), drawFont, drawBr, 500, 240);
            Thread.Sleep(1000);
            g.DrawString("Total " + totalPrice.ToString("C"), drawFont, drawBr, 500, 260);
            Thread.Sleep(1000);
            g.DrawString("Have a nice day", drawFont, drawBr, 500, 280);

        }
    }
}


