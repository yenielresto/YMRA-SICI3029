namespace YMRA_SICI3029
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculatorForm = new System.Windows.Forms.Button();
            this.staffFormButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImage = global::YMRA_SICI3029.Properties.Resources.pngtree_health_club_health_motion_healthcare_photo_image_904761;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.calculatorForm);
            this.panel1.Controls.Add(this.staffFormButton);
            this.panel1.Location = new System.Drawing.Point(139, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 269);
            this.panel1.TabIndex = 1;
            // 
            // calculatorForm
            // 
            this.calculatorForm.BackColor = System.Drawing.Color.MistyRose;
            this.calculatorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorForm.Location = new System.Drawing.Point(127, 152);
            this.calculatorForm.Name = "calculatorForm";
            this.calculatorForm.Size = new System.Drawing.Size(212, 73);
            this.calculatorForm.TabIndex = 1;
            this.calculatorForm.Text = "MEMBERSHIP CALCULATOR FORM\r\n";
            this.calculatorForm.UseVisualStyleBackColor = false;
            this.calculatorForm.Click += new System.EventHandler(this.calculatorForm_Click);
            // 
            // staffFormButton
            // 
            this.staffFormButton.BackColor = System.Drawing.Color.MistyRose;
            this.staffFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffFormButton.Location = new System.Drawing.Point(127, 32);
            this.staffFormButton.Name = "staffFormButton";
            this.staffFormButton.Size = new System.Drawing.Size(212, 73);
            this.staffFormButton.TabIndex = 0;
            this.staffFormButton.Text = "STAFF FORM";
            this.staffFormButton.UseVisualStyleBackColor = false;
            this.staffFormButton.Click += new System.EventHandler(this.staffFormButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YMRA_SICI3029.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(599, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YMRA_SICI3029.Properties.Resources.LOGO;
            this.pictureBox2.Location = new System.Drawing.Point(30, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Titan Gym";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calculatorForm;
        private System.Windows.Forms.Button staffFormButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}