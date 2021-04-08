using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLoadAndSave;

namespace MéhészPróbálkozás1
{
    public partial class SecondMenuInput : Form
    {
        public SecondMenuInput()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHarwestInput_Click(object sender, EventArgs e)
        {
            HarwestInputForm harwestInputForm = new HarwestInputForm();

            harwestInputForm.ShowDialog();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            SaleInputForm saleInputForm = new SaleInputForm();

            saleInputForm.ShowDialog();
        }

        private void SecondMenuInput_Load(object sender, EventArgs e)
        {

        }
    }
}
