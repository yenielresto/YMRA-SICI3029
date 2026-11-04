using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMRA_SICI3029
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void staffFormButton_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.Show();
        }

        private void calculatorForm_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }
    }
}
