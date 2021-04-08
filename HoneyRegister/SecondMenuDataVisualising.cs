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
    public partial class SecondMenuDataVisualising : Form
    {
        private const int SalesFormStyle = 0;
        private const int PresentFormStyle = 1;
        private const int HarwestedHoneyFormStyle = 2;

        public SecondMenuDataVisualising()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPresentData_Click(object sender, EventArgs e)
        {
            DataListView presentListView = new DataListView(PresentFormStyle);

            presentListView.ShowDialog();
        }

        private void buttonSellingData_Click(object sender, EventArgs e)
        {
            DataListView sellingDataListView = new DataListView(SalesFormStyle);

            sellingDataListView.ShowDialog();
        }

        private void buttonHarwestingData_Click(object sender, EventArgs e)
        {
            DataListView harwestedHoneyData = new DataListView(HarwestedHoneyFormStyle);

            harwestedHoneyData.ShowDialog();
        }

        private void DataVisualising_Load(object sender, EventArgs e)
        {
            DataLoadAndSave.DataLoadAndSave.SQLPersonDownload();
        }
    }
}
