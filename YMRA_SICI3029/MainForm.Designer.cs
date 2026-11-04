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
            this.staffFormButton = new System.Windows.Forms.Button();
            this.calculatorForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.calculatorForm);
            this.panel1.Controls.Add(this.staffFormButton);
            this.panel1.Location = new System.Drawing.Point(112, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 297);
            this.panel1.TabIndex = 1;
            // 
            // staffFormButton
            // 
            this.staffFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffFormButton.Location = new System.Drawing.Point(171, 58);
            this.staffFormButton.Name = "staffFormButton";
            this.staffFormButton.Size = new System.Drawing.Size(212, 73);
            this.staffFormButton.TabIndex = 0;
            this.staffFormButton.Text = "STAFF FORM";
            this.staffFormButton.UseVisualStyleBackColor = true;
            this.staffFormButton.Click += new System.EventHandler(this.staffFormButton_Click);
            // 
            // calculatorForm
            // 
            this.calculatorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorForm.Location = new System.Drawing.Point(171, 170);
            this.calculatorForm.Name = "calculatorForm";
            this.calculatorForm.Size = new System.Drawing.Size(212, 73);
            this.calculatorForm.TabIndex = 1;
            this.calculatorForm.Text = "MEMBERSHIP CALCULATOR FORM\r\n";
            this.calculatorForm.UseVisualStyleBackColor = true;
            this.calculatorForm.Click += new System.EventHandler(this.calculatorForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calculatorForm;
        private System.Windows.Forms.Button staffFormButton;
    }
}