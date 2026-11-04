namespace YMRA_SICI3029
{
    partial class StaffForm
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
            this.PilatesStaffButton = new System.Windows.Forms.Button();
            this.KarateStaffButton = new System.Windows.Forms.Button();
            this.LeftManLabel = new System.Windows.Forms.Label();
            this.RightManLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titan Staff Form\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PilatesStaffButton
            // 
            this.PilatesStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PilatesStaffButton.Location = new System.Drawing.Point(400, 104);
            this.PilatesStaffButton.Name = "PilatesStaffButton";
            this.PilatesStaffButton.Size = new System.Drawing.Size(121, 35);
            this.PilatesStaffButton.TabIndex = 2;
            this.PilatesStaffButton.Text = "Pilates Staff";
            this.PilatesStaffButton.UseVisualStyleBackColor = true;
            this.PilatesStaffButton.Click += new System.EventHandler(this.PilatesStaffButton_Click);
            // 
            // KarateStaffButton
            // 
            this.KarateStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KarateStaffButton.Location = new System.Drawing.Point(400, 177);
            this.KarateStaffButton.Name = "KarateStaffButton";
            this.KarateStaffButton.Size = new System.Drawing.Size(121, 35);
            this.KarateStaffButton.TabIndex = 3;
            this.KarateStaffButton.Text = "Karate Staff";
            this.KarateStaffButton.UseVisualStyleBackColor = true;
            this.KarateStaffButton.Click += new System.EventHandler(this.KarateStaffButton_Click);
            // 
            // LeftManLabel
            // 
            this.LeftManLabel.AutoSize = true;
            this.LeftManLabel.Location = new System.Drawing.Point(157, 250);
            this.LeftManLabel.Name = "LeftManLabel";
            this.LeftManLabel.Size = new System.Drawing.Size(173, 39);
            this.LeftManLabel.TabIndex = 4;
            this.LeftManLabel.Text = "Name: Marcus Lamine\r\nYears of Experience: 25\r\nTraining Hours: 3:00 pm to 8:00 pm\r" +
    "\n";
            // 
            // RightManLabel
            // 
            this.RightManLabel.AutoSize = true;
            this.RightManLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightManLabel.Location = new System.Drawing.Point(145, 250);
            this.RightManLabel.Name = "RightManLabel";
            this.RightManLabel.Size = new System.Drawing.Size(200, 45);
            this.RightManLabel.TabIndex = 5;
            this.RightManLabel.Text = "Name: Christopher Thompson\r\nYears of Experience: 12\r\nTraining Hours: 7:00 am to 3" +
    ":00 pm\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::YMRA_SICI3029.Properties.Resources.Screenshot_2026_11_04_123924;
            this.pictureBox1.Location = new System.Drawing.Point(92, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YMRA_SICI3029.Properties.Resources.LOGO;
            this.pictureBox2.Location = new System.Drawing.Point(425, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(543, 336);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RightManLabel);
            this.Controls.Add(this.LeftManLabel);
            this.Controls.Add(this.KarateStaffButton);
            this.Controls.Add(this.PilatesStaffButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PilatesStaffButton;
        private System.Windows.Forms.Button KarateStaffButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LeftManLabel;
        private System.Windows.Forms.Label RightManLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}