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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PilatesStaffButton = new System.Windows.Forms.Button();
            this.KarateStaffButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Club Staff Form\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YMRA_SICI3029.Properties.Resources.pngtree_health_club_health_motion_healthcare_photo_image_904761;
            this.pictureBox1.Location = new System.Drawing.Point(103, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PilatesStaffButton
            // 
            this.PilatesStaffButton.Location = new System.Drawing.Point(127, 272);
            this.PilatesStaffButton.Name = "PilatesStaffButton";
            this.PilatesStaffButton.Size = new System.Drawing.Size(121, 35);
            this.PilatesStaffButton.TabIndex = 2;
            this.PilatesStaffButton.Text = "Pilates Staff";
            this.PilatesStaffButton.UseVisualStyleBackColor = true;
            // 
            // KarateStaffButton
            // 
            this.KarateStaffButton.Location = new System.Drawing.Point(337, 272);
            this.KarateStaffButton.Name = "KarateStaffButton";
            this.KarateStaffButton.Size = new System.Drawing.Size(121, 35);
            this.KarateStaffButton.TabIndex = 3;
            this.KarateStaffButton.Text = "Karate Staff";
            this.KarateStaffButton.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 336);
            this.Controls.Add(this.KarateStaffButton);
            this.Controls.Add(this.PilatesStaffButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PilatesStaffButton;
        private System.Windows.Forms.Button KarateStaffButton;
    }
}