﻿namespace COMP123_S2019_A5_301043607.Views
{
    partial class ProductInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductInfoFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CostTextLabel = new System.Windows.Forms.Label();
            this.ConditionTextLabel = new System.Windows.Forms.Label();
            this.ProductIDTextLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebcamTextLabel = new System.Windows.Forms.Label();
            this.GPUTypeTextLabel = new System.Windows.Forms.Label();
            this.HDDTextLabel = new System.Windows.Forms.Label();
            this.CPUSpeedTextLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextLabel = new System.Windows.Forms.Label();
            this.CPUBrandTextLabel = new System.Windows.Forms.Label();
            this.MemoryTextLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelTextLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextLabel = new System.Windows.Forms.Label();
            this.OSTextLabel = new System.Windows.Forms.Label();
            this.PlatformTextLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ProductInfoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoSaveFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoFormMenuStrip.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(24, 474);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(314, 43);
            this.SelectAnotherProductButton.TabIndex = 21;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(553, 474);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 43);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(663, 474);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(99, 43);
            this.NextButton.TabIndex = 23;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductInfoFormMenuStrip
            // 
            this.ProductInfoFormMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ProductInfoFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoFormMenuStrip.Name = "ProductInfoFormMenuStrip";
            this.ProductInfoFormMenuStrip.Size = new System.Drawing.Size(774, 40);
            this.ProductInfoFormMenuStrip.TabIndex = 37;
            this.ProductInfoFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(321, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(321, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(364, 38);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            // 
            // CostTextLabel
            // 
            this.CostTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextLabel.BackColor = System.Drawing.Color.White;
            this.CostTextLabel.Location = new System.Drawing.Point(591, 56);
            this.CostTextLabel.Name = "CostTextLabel";
            this.CostTextLabel.Size = new System.Drawing.Size(135, 37);
            this.CostTextLabel.TabIndex = 45;
            this.CostTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionTextLabel
            // 
            this.ConditionTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionTextLabel.BackColor = System.Drawing.Color.White;
            this.ConditionTextLabel.Location = new System.Drawing.Point(362, 56);
            this.ConditionTextLabel.Name = "ConditionTextLabel";
            this.ConditionTextLabel.Size = new System.Drawing.Size(135, 37);
            this.ConditionTextLabel.TabIndex = 44;
            this.ConditionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIDTextLabel
            // 
            this.ProductIDTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductIDTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductIDTextLabel.Location = new System.Drawing.Point(120, 56);
            this.ProductIDTextLabel.Name = "ProductIDTextLabel";
            this.ProductIDTextLabel.Size = new System.Drawing.Size(135, 37);
            this.ProductIDTextLabel.TabIndex = 43;
            this.ProductIDTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebcamTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(25, 263);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(731, 210);
            this.TechSpecsGroupBox.TabIndex = 42;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebcamTextLabel
            // 
            this.WebcamTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebcamTextLabel.BackColor = System.Drawing.Color.White;
            this.WebcamTextLabel.Location = new System.Drawing.Point(581, 151);
            this.WebcamTextLabel.Name = "WebcamTextLabel";
            this.WebcamTextLabel.Size = new System.Drawing.Size(100, 37);
            this.WebcamTextLabel.TabIndex = 29;
            this.WebcamTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPUTypeTextLabel
            // 
            this.GPUTypeTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypeTextLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeTextLabel.Location = new System.Drawing.Point(581, 95);
            this.GPUTypeTextLabel.Name = "GPUTypeTextLabel";
            this.GPUTypeTextLabel.Size = new System.Drawing.Size(100, 37);
            this.GPUTypeTextLabel.TabIndex = 28;
            this.GPUTypeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HDDTextLabel
            // 
            this.HDDTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDTextLabel.BackColor = System.Drawing.Color.White;
            this.HDDTextLabel.Location = new System.Drawing.Point(581, 48);
            this.HDDTextLabel.Name = "HDDTextLabel";
            this.HDDTextLabel.Size = new System.Drawing.Size(100, 37);
            this.HDDTextLabel.TabIndex = 27;
            this.HDDTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUSpeedTextLabel
            // 
            this.CPUSpeedTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedTextLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedTextLabel.Location = new System.Drawing.Point(374, 151);
            this.CPUSpeedTextLabel.Name = "CPUSpeedTextLabel";
            this.CPUSpeedTextLabel.Size = new System.Drawing.Size(100, 37);
            this.CPUSpeedTextLabel.TabIndex = 26;
            this.CPUSpeedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUNumberTextLabel
            // 
            this.CPUNumberTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNumberTextLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberTextLabel.Location = new System.Drawing.Point(374, 98);
            this.CPUNumberTextLabel.Name = "CPUNumberTextLabel";
            this.CPUNumberTextLabel.Size = new System.Drawing.Size(100, 37);
            this.CPUNumberTextLabel.TabIndex = 25;
            this.CPUNumberTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LCDSizeTextLabel
            // 
            this.LCDSizeTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDSizeTextLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeTextLabel.Location = new System.Drawing.Point(374, 51);
            this.LCDSizeTextLabel.Name = "LCDSizeTextLabel";
            this.LCDSizeTextLabel.Size = new System.Drawing.Size(100, 37);
            this.LCDSizeTextLabel.TabIndex = 24;
            this.LCDSizeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUTypeTextLabel
            // 
            this.CPUTypeTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeTextLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeTextLabel.Location = new System.Drawing.Point(131, 144);
            this.CPUTypeTextLabel.Name = "CPUTypeTextLabel";
            this.CPUTypeTextLabel.Size = new System.Drawing.Size(100, 37);
            this.CPUTypeTextLabel.TabIndex = 23;
            this.CPUTypeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUBrandTextLabel
            // 
            this.CPUBrandTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandTextLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandTextLabel.Location = new System.Drawing.Point(131, 95);
            this.CPUBrandTextLabel.Name = "CPUBrandTextLabel";
            this.CPUBrandTextLabel.Size = new System.Drawing.Size(100, 37);
            this.CPUBrandTextLabel.TabIndex = 22;
            this.CPUBrandTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryTextLabel
            // 
            this.MemoryTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryTextLabel.BackColor = System.Drawing.Color.White;
            this.MemoryTextLabel.Location = new System.Drawing.Point(131, 48);
            this.MemoryTextLabel.Name = "MemoryTextLabel";
            this.MemoryTextLabel.Size = new System.Drawing.Size(100, 37);
            this.MemoryTextLabel.TabIndex = 21;
            this.MemoryTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(495, 156);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(101, 24);
            this.WebCamLabel.TabIndex = 16;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(495, 100);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(116, 24);
            this.GPUTypeLabel.TabIndex = 14;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(495, 53);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(51, 24);
            this.HDDLabel.TabIndex = 12;
            this.HDDLabel.Text = "Hdd";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(260, 156);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(130, 24);
            this.CPUSpeedLabel.TabIndex = 10;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(260, 103);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(140, 24);
            this.CPUNumberLabel.TabIndex = 8;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(258, 56);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(114, 24);
            this.LCDSizeLabel.TabIndex = 6;
            this.LCDSizeLabel.Text = "Lcd1 Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(35, 149);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(115, 24);
            this.CPUTypeLabel.TabIndex = 4;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(35, 100);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(121, 24);
            this.CPUBrandLabel.TabIndex = 2;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(35, 53);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(92, 24);
            this.MemoryLabel.TabIndex = 0;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostLabel
            // 
            this.CostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(545, 64);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(58, 24);
            this.CostLabel.TabIndex = 41;
            this.CostLabel.Text = "Cost";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(283, 61);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(106, 24);
            this.ConditionLabel.TabIndex = 40;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(18, 61);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(119, 24);
            this.ProductIDLabel.TabIndex = 39;
            this.ProductIDLabel.Text = "Product ID";
            this.ProductIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(30, 116);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(726, 141);
            this.ProductInfoGroupBox.TabIndex = 38;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelTextLabel
            // 
            this.ModelTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelTextLabel.BackColor = System.Drawing.Color.White;
            this.ModelTextLabel.Location = new System.Drawing.Point(421, 87);
            this.ModelTextLabel.Name = "ModelTextLabel";
            this.ModelTextLabel.Size = new System.Drawing.Size(135, 37);
            this.ModelTextLabel.TabIndex = 20;
            this.ModelTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManufacturerTextLabel
            // 
            this.ManufacturerTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerTextLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerTextLabel.Location = new System.Drawing.Point(151, 87);
            this.ManufacturerTextLabel.Name = "ManufacturerTextLabel";
            this.ManufacturerTextLabel.Size = new System.Drawing.Size(135, 37);
            this.ManufacturerTextLabel.TabIndex = 19;
            this.ManufacturerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OSTextLabel
            // 
            this.OSTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OSTextLabel.BackColor = System.Drawing.Color.White;
            this.OSTextLabel.Location = new System.Drawing.Point(421, 39);
            this.OSTextLabel.Name = "OSTextLabel";
            this.OSTextLabel.Size = new System.Drawing.Size(135, 37);
            this.OSTextLabel.TabIndex = 18;
            this.OSTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatformTextLabel
            // 
            this.PlatformTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformTextLabel.BackColor = System.Drawing.Color.White;
            this.PlatformTextLabel.Location = new System.Drawing.Point(151, 39);
            this.PlatformTextLabel.Name = "PlatformTextLabel";
            this.PlatformTextLabel.Size = new System.Drawing.Size(135, 37);
            this.PlatformTextLabel.TabIndex = 17;
            this.PlatformTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(359, 95);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(72, 24);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(359, 44);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(42, 24);
            this.OSLabel.TabIndex = 4;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(23, 92);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(144, 24);
            this.ManufacturerLabel.TabIndex = 2;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(23, 44);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(96, 24);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductInfoOpenFileDialog
            // 
            this.ProductInfoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoSaveFileDialog
            // 
            this.ProductInfoSaveFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.CostTextLabel);
            this.Controls.Add(this.ConditionTextLabel);
            this.Controls.Add(this.ProductIDTextLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductInfoFormMenuStrip);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Name = "ProductInfoForm";
            this.Text = "ProductInfoForm";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load_1);
            this.ProductInfoFormMenuStrip.ResumeLayout(false);
            this.ProductInfoFormMenuStrip.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.MenuStrip ProductInfoFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label CostTextLabel;
        private System.Windows.Forms.Label ConditionTextLabel;
        private System.Windows.Forms.Label ProductIDTextLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label WebcamTextLabel;
        private System.Windows.Forms.Label GPUTypeTextLabel;
        private System.Windows.Forms.Label HDDTextLabel;
        private System.Windows.Forms.Label CPUSpeedTextLabel;
        private System.Windows.Forms.Label CPUNumberTextLabel;
        private System.Windows.Forms.Label LCDSizeTextLabel;
        private System.Windows.Forms.Label CPUTypeTextLabel;
        private System.Windows.Forms.Label CPUBrandTextLabel;
        private System.Windows.Forms.Label MemoryTextLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ModelTextLabel;
        private System.Windows.Forms.Label ManufacturerTextLabel;
        private System.Windows.Forms.Label OSTextLabel;
        private System.Windows.Forms.Label PlatformTextLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.OpenFileDialog ProductInfoOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog ProductInfoSaveFileDialog;
    }
}