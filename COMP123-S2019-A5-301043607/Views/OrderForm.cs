using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name : Juneyeong Lee
 * Student Id : 301043697
 * Description : This is OrderForm Class
 */

namespace COMP123_S2019_A5_301043607.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing~...");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!\n It will take 7 business days");
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionTextLabel.Text = Program.product.condition;
            PlatformTextLabel.Text = Program.product.platform;
            ManufacturerTextLabel.Text = Program.product.manufacturer;
            ModelTextLabel.Text = Program.product.model;
            LCDSizeDataLabel.Text = Program.product.screensize;
            MemoryDataLabel.Text = Program.product.RAM_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            HDDDataLabel.Text = Program.product.HDD_size;
            GPUDataLabel.Text = Program.product.CPU_type;
            WebCamDataLabel.Text = Program.product.webcam;
            OSDataLabel.Text = Program.product.OS;
            PriceTextLabel.Text = Program.product.cost.Value.ToString("C2");
            TaxTextLabel.Text = (Program.product.cost * 13 / 100).Value.ToString("C2");
            TotalTextLabel.Text = (Program.product.cost * 113 / 100).Value.ToString("C2");
        }
    }
}
