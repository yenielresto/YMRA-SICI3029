namespace YMRA_SICI3029
{
    partial class CalculatorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SeniorRadioButton = new System.Windows.Forms.RadioButton();
            this.StudentRadioButton = new System.Windows.Forms.RadioButton();
            this.ChildRadioButton = new System.Windows.Forms.RadioButton();
            this.saRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PersonalTrainingCheckBox = new System.Windows.Forms.CheckBox();
            this.KarateCheckBox = new System.Windows.Forms.CheckBox();
            this.PilatesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MonthsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.monthlyLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.MonthlyFeeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeniorRadioButton);
            this.groupBox1.Controls.Add(this.StudentRadioButton);
            this.groupBox1.Controls.Add(this.ChildRadioButton);
            this.groupBox1.Controls.Add(this.saRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Membership";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SeniorRadioButton
            // 
            this.SeniorRadioButton.AutoSize = true;
            this.SeniorRadioButton.Location = new System.Drawing.Point(37, 100);
            this.SeniorRadioButton.Name = "SeniorRadioButton";
            this.SeniorRadioButton.Size = new System.Drawing.Size(103, 17);
            this.SeniorRadioButton.TabIndex = 3;
            this.SeniorRadioButton.TabStop = true;
            this.SeniorRadioButton.Text = "S&enior Citizen";
            this.SeniorRadioButton.UseVisualStyleBackColor = true;
            this.SeniorRadioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // StudentRadioButton
            // 
            this.StudentRadioButton.AutoSize = true;
            this.StudentRadioButton.Location = new System.Drawing.Point(37, 77);
            this.StudentRadioButton.Name = "StudentRadioButton";
            this.StudentRadioButton.Size = new System.Drawing.Size(69, 17);
            this.StudentRadioButton.TabIndex = 2;
            this.StudentRadioButton.TabStop = true;
            this.StudentRadioButton.Text = "&Student";
            this.StudentRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChildRadioButton
            // 
            this.ChildRadioButton.AutoSize = true;
            this.ChildRadioButton.Location = new System.Drawing.Point(37, 54);
            this.ChildRadioButton.Name = "ChildRadioButton";
            this.ChildRadioButton.Size = new System.Drawing.Size(140, 17);
            this.ChildRadioButton.TabIndex = 1;
            this.ChildRadioButton.TabStop = true;
            this.ChildRadioButton.Text = "Chil&d (12 and under)";
            this.ChildRadioButton.UseVisualStyleBackColor = true;
            // 
            // saRadioButton
            // 
            this.saRadioButton.AutoSize = true;
            this.saRadioButton.Location = new System.Drawing.Point(37, 31);
            this.saRadioButton.Name = "saRadioButton";
            this.saRadioButton.Size = new System.Drawing.Size(109, 17);
            this.saRadioButton.TabIndex = 0;
            this.saRadioButton.TabStop = true;
            this.saRadioButton.Text = "Standard &Adult";
            this.saRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PersonalTrainingCheckBox);
            this.groupBox2.Controls.Add(this.KarateCheckBox);
            this.groupBox2.Controls.Add(this.PilatesCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(290, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // PersonalTrainingCheckBox
            // 
            this.PersonalTrainingCheckBox.AutoSize = true;
            this.PersonalTrainingCheckBox.Location = new System.Drawing.Point(31, 78);
            this.PersonalTrainingCheckBox.Name = "PersonalTrainingCheckBox";
            this.PersonalTrainingCheckBox.Size = new System.Drawing.Size(119, 17);
            this.PersonalTrainingCheckBox.TabIndex = 2;
            this.PersonalTrainingCheckBox.Text = "&Personal Trainer";
            this.PersonalTrainingCheckBox.UseVisualStyleBackColor = true;
            // 
            // KarateCheckBox
            // 
            this.KarateCheckBox.AutoSize = true;
            this.KarateCheckBox.Location = new System.Drawing.Point(31, 55);
            this.KarateCheckBox.Name = "KarateCheckBox";
            this.KarateCheckBox.Size = new System.Drawing.Size(63, 17);
            this.KarateCheckBox.TabIndex = 1;
            this.KarateCheckBox.Text = "&Karate";
            this.KarateCheckBox.UseVisualStyleBackColor = true;
            // 
            // PilatesCheckBox
            // 
            this.PilatesCheckBox.AutoSize = true;
            this.PilatesCheckBox.Location = new System.Drawing.Point(31, 28);
            this.PilatesCheckBox.Name = "PilatesCheckBox";
            this.PilatesCheckBox.Size = new System.Drawing.Size(64, 17);
            this.PilatesCheckBox.TabIndex = 0;
            this.PilatesCheckBox.Text = "&Pilates";
            this.PilatesCheckBox.UseVisualStyleBackColor = true;
            this.PilatesCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MonthsTextbox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 115);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Membership Length";
            // 
            // MonthsTextbox
            // 
            this.MonthsTextbox.Location = new System.Drawing.Point(37, 63);
            this.MonthsTextbox.Name = "MonthsTextbox";
            this.MonthsTextbox.Size = new System.Drawing.Size(140, 20);
            this.MonthsTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number of Months:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.monthlyLabel);
            this.groupBox4.Controls.Add(this.resultLabel);
            this.groupBox4.Controls.Add(this.TotalLabel);
            this.groupBox4.Controls.Add(this.MonthlyFeeLabel);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(290, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 115);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Membership Fees";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // monthlyLabel
            // 
            this.monthlyLabel.AutoSize = true;
            this.monthlyLabel.Location = new System.Drawing.Point(105, 34);
            this.monthlyLabel.Name = "monthlyLabel";
            this.monthlyLabel.Size = new System.Drawing.Size(0, 13);
            this.monthlyLabel.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(103, 68);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(99, 66);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalLabel.TabIndex = 4;
            // 
            // MonthlyFeeLabel
            // 
            this.MonthlyFeeLabel.AutoSize = true;
            this.MonthlyFeeLabel.Location = new System.Drawing.Point(99, 34);
            this.MonthlyFeeLabel.Name = "MonthlyFeeLabel";
            this.MonthlyFeeLabel.Size = new System.Drawing.Size(0, 13);
            this.MonthlyFeeLabel.TabIndex = 3;
            this.MonthlyFeeLabel.Click += new System.EventHandler(this.MonthlyFeeLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly Fee:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(96, 393);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(74, 29);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(234, 393);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 29);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(367, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 29);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(62, 37);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(71, 13);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "&First Name:";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTB.Location = new System.Drawing.Point(128, 34);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(98, 20);
            this.FirstNameTB.TabIndex = 6;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(311, 37);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(71, 13);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "&Last Name:";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTB.Location = new System.Drawing.Point(378, 37);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(98, 20);
            this.LastNameTB.TabIndex = 8;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalculatorForm";
            this.Text = "Membership Fee Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton SeniorRadioButton;
        private System.Windows.Forms.RadioButton StudentRadioButton;
        private System.Windows.Forms.RadioButton ChildRadioButton;
        private System.Windows.Forms.RadioButton saRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox PersonalTrainingCheckBox;
        private System.Windows.Forms.CheckBox KarateCheckBox;
        private System.Windows.Forms.CheckBox PilatesCheckBox;
        private System.Windows.Forms.TextBox MonthsTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label MonthlyFeeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label monthlyLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

