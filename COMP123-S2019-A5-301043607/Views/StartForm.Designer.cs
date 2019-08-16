namespace COMP123_S2019_A5_301043607.Views
{
    partial class StartForm
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
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartNewButton = new System.Windows.Forms.Button();
            this.OpenSavedButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LogosPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogosPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartLabel.Location = new System.Drawing.Point(12, 55);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(756, 54);
            this.StartLabel.TabIndex = 0;
            this.StartLabel.Text = "Order Your Computer Today!";
            // 
            // StartNewButton
            // 
            this.StartNewButton.Location = new System.Drawing.Point(215, 185);
            this.StartNewButton.Name = "StartNewButton";
            this.StartNewButton.Size = new System.Drawing.Size(351, 50);
            this.StartNewButton.TabIndex = 1;
            this.StartNewButton.Text = "Start a New Order";
            this.StartNewButton.UseVisualStyleBackColor = true;
            this.StartNewButton.Click += new System.EventHandler(this.StartNewButton_Click);
            // 
            // OpenSavedButton
            // 
            this.OpenSavedButton.Location = new System.Drawing.Point(215, 272);
            this.OpenSavedButton.Name = "OpenSavedButton";
            this.OpenSavedButton.Size = new System.Drawing.Size(351, 50);
            this.OpenSavedButton.TabIndex = 2;
            this.OpenSavedButton.Text = "Open a saved Order";
            this.OpenSavedButton.UseVisualStyleBackColor = true;
            this.OpenSavedButton.Click += new System.EventHandler(this.OpenSavedButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(215, 363);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(351, 50);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::COMP123_S2019_A5_301043607.Properties.Resources.DollarComputerLogo;
            this.LogoPictureBox.Location = new System.Drawing.Point(41, 216);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(151, 155);
            this.LogoPictureBox.TabIndex = 4;
            this.LogoPictureBox.TabStop = false;
            // 
            // LogosPictureBox
            // 
            this.LogosPictureBox.Image = global::COMP123_S2019_A5_301043607.Properties.Resources.DollarComputerLogo;
            this.LogosPictureBox.Location = new System.Drawing.Point(601, 216);
            this.LogosPictureBox.Name = "LogosPictureBox";
            this.LogosPictureBox.Size = new System.Drawing.Size(151, 155);
            this.LogosPictureBox.TabIndex = 5;
            this.LogosPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.ControlBox = false;
            this.Controls.Add(this.LogosPictureBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenSavedButton);
            this.Controls.Add(this.StartNewButton);
            this.Controls.Add(this.StartLabel);
            this.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogosPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Button StartNewButton;
        private System.Windows.Forms.Button OpenSavedButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox LogosPictureBox;
    }
}

