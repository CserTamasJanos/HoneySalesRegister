using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MéhészPróbálkozás1
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonTheDataIsOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Review_Load(object sender, EventArgs e)
        {

        }
    }
}
