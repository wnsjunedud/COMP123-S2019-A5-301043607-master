﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name : Juneyeong Lee
 * Student Id : 301043697
 * Description : This is ProductInfoForm Class
 */

namespace COMP123_S2019_A5_301043607.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        public void ProductInfoFilled()
        {
            ProductIDTextLabel.Text = Program.product.productID.ToString();
            ConditionTextLabel.Text = Program.product.condition;
            CostTextLabel.Text = Program.product.cost.Value.ToString("C2");
            PlatformTextLabel.Text = Program.product.platform;
            OSTextLabel.Text = Program.product.OS;
            ManufacturerTextLabel.Text = Program.product.manufacturer;
            ModelTextLabel.Text = Program.product.model;
            MemoryTextLabel.Text = Program.product.RAM_size;
            LCDSizeTextLabel.Text = Program.product.screensize;
            HDDTextLabel.Text = Program.product.HDD_size;
            CPUBrandTextLabel.Text = Program.product.CPU_brand;
            CPUNumberTextLabel.Text = Program.product.CPU_number;
            GPUTypeTextLabel.Text = Program.product.GPU_Type;
            CPUTypeTextLabel.Text = Program.product.CPU_type;
            CPUSpeedTextLabel.Text = Program.product.CPU_speed;
            WebcamTextLabel.Text = Program.product.webcam;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialog.FileName = "Product.txt";
            ProductInfoOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            var result = ProductInfoOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamReader inputStream = new StreamReader(
                    File.Open(ProductInfoOpenFileDialog.FileName, FileMode.Open)))
                {
                    Program.product.productID = short.Parse(inputStream.ReadLine());
                    Program.product.cost = decimal.Parse(inputStream.ReadLine());
                    Program.product.manufacturer = inputStream.ReadLine();
                    Program.product.model = inputStream.ReadLine();
                    Program.product.RAM_type = inputStream.ReadLine();
                    Program.product.RAM_size = inputStream.ReadLine();
                    Program.product.displaytype = inputStream.ReadLine();
                    Program.product.screensize = inputStream.ReadLine();
                    Program.product.resolution = inputStream.ReadLine();
                    Program.product.CPU_Class = inputStream.ReadLine();
                    Program.product.CPU_brand = inputStream.ReadLine();
                    Program.product.CPU_type = inputStream.ReadLine();
                    Program.product.CPU_speed = inputStream.ReadLine();
                    Program.product.CPU_number = inputStream.ReadLine();
                    Program.product.condition = inputStream.ReadLine();
                    Program.product.OS = inputStream.ReadLine();
                    Program.product.platform = inputStream.ReadLine();
                    Program.product.HDD_size = inputStream.ReadLine();
                    Program.product.HDD_speed = inputStream.ReadLine();
                    Program.product.GPU_Type = inputStream.ReadLine();
                    Program.product.optical_drive = inputStream.ReadLine();
                    Program.product.Audio_type = inputStream.ReadLine();
                    Program.product.LAN = inputStream.ReadLine();
                    Program.product.WIFI = inputStream.ReadLine();
                    Program.product.width = inputStream.ReadLine();
                    Program.product.height = inputStream.ReadLine();
                    Program.product.depth = inputStream.ReadLine();
                    Program.product.weight = inputStream.ReadLine();
                    Program.product.moust_type = inputStream.ReadLine();
                    Program.product.power = inputStream.ReadLine();
                    Program.product.webcam = inputStream.ReadLine();

                    inputStream.Close();
                    inputStream.Dispose();

                    NextButton.Enabled = true;
                }
            }
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            if (Program.product.productID.ToString() != String.Empty)
            {
                NextButton.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialog.FileName = "Product.txt";
            ProductInfoSaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            var result = ProductInfoSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductInfoOpenFileDialog.FileName, FileMode.Create)))
                {
                    outputStream.WriteLine(Program.product.productID.ToString());
                    outputStream.WriteLine(Program.product.cost.ToString());
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_type);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.displaytype);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.resolution);
                    outputStream.WriteLine(Program.product.CPU_Class);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.HDD_speed);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.optical_drive);
                    outputStream.WriteLine(Program.product.Audio_type);
                    outputStream.WriteLine(Program.product.LAN);
                    outputStream.WriteLine(Program.product.WIFI);
                    outputStream.WriteLine(Program.product.width);
                    outputStream.WriteLine(Program.product.height);
                    outputStream.WriteLine(Program.product.depth);
                    outputStream.WriteLine(Program.product.weight);
                    outputStream.WriteLine(Program.product.moust_type);
                    outputStream.WriteLine(Program.product.power);
                    outputStream.WriteLine(Program.product.webcam);

                    outputStream.Close();
                    outputStream.Dispose();
                }

                MessageBox.Show("File Saved Successfully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Load_1(object sender, EventArgs e)
        {
            if (Program.product.productID.ToString() != String.Empty)
            {
                NextButton.Enabled = true;
            }

        }
    }
}
