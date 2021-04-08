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
    public partial class DataListView : Form
    {
        private int formStyle;

        private const string DateForm = "yyyy.MM.dd";

        private const string HarwestFomrName = "Pergetésadatok";
        private const string SalesDataFormName = "Eladásadatok";
        private const string PresentDataFormName = "Ajándékadatok";

        private const string HoneyTypesText = "Méztípusok";
        private const string SalesAndInputNameText = "Regisztrált nevek";

        private const string HoneyHarwestColumn1HarwestedAmount = "Pergetett mennyiség";
        private const string HoneyHarwestColumn2HarwestPlace = "Pergetés helyszíne";
        private const string HoneyHarwestColumn3Date = "Pergetés időpontja";

        private const string SalesAndPresentColumn1Amount = "Mennyiség";
        private const string SalesAndPresentColumn2Price = "Eladási ár";
        private const string SalesAndPresentColumn3HoneyType = "Méztípus";
        private const string SalesAndPresentColumn4SellingDate = "Eladás dátuma";

        private const string AllOfTheSelectionPossibility = "Összes";

        private int SelectedYear
        {
            get
            {
                return comboBoxDate.SelectedIndex  > 0 ? (int)comboBoxDate.SelectedItem : comboBoxDate.SelectedIndex;
            }
        }

        private int SelectedHoneyTypeID
        {
            get
            {
                if (formStyle < 2)
                {
                    if(comboBoxHoneyTypes.SelectedIndex > 0)
                    {
                        HoneyType selectedHoneyType = (HoneyType)comboBoxHoneyTypes.SelectedItem;
                        return selectedHoneyType.HoneyTypeID;
                    }
                    else
                    {
                        return comboBoxHoneyTypes.SelectedIndex;
                    }
                }
                else
                {
                    if(comboBoxNames.SelectedIndex > 0)
                    {
                        HoneyType selectedHoneyType = (HoneyType)comboBoxNames.SelectedItem;
                        return selectedHoneyType.HoneyTypeID;
                    }
                    else
                    {
                        return comboBoxNames.SelectedIndex;
                    }
                }
            }
        }

        private int SelectedPersonID
        {
            get
            {            
                if(formStyle < 2)
                {
                    if (comboBoxNames.SelectedIndex > 0)
                    {
                        Person selectedPerson = (Person)comboBoxNames.SelectedItem;
                        return selectedPerson.PersonID;
                    }
                    else
                    {
                        return comboBoxNames.SelectedIndex;
                    }
                }
                else
                {
                    return SelectedHoneyTypeID;
                }
            }
        }

        private void SalesAndPresentDataFormStyle()
        {
            if (formStyle == 0)
            {
                this.Text = SalesDataFormName;
            }
            else if(formStyle == 1)
            {
                this.Text = PresentDataFormName;
            }

            comboBoxNames.Items.Add(AllOfTheSelectionPossibility);
            HoneyTypesUpload(false);
            NewYearsUpload();

            labelNamesText.Text = SalesAndInputNameText;

            listViewBasic.Columns.Add(SalesAndPresentColumn1Amount, 150, HorizontalAlignment.Left);
            listViewBasic.Columns.Add(SalesAndPresentColumn2Price, 150, HorizontalAlignment.Left);
            listViewBasic.Columns.Add(SalesAndPresentColumn3HoneyType, 150, HorizontalAlignment.Left);
            listViewBasic.Columns.Add(SalesAndPresentColumn4SellingDate, 150, HorizontalAlignment.Left);

            List<int> actualPayments = DataLoadAndSave.DataLoadAndSave.PersonIDBoughtHoneyList(formStyle);

            foreach (int aPersonID in actualPayments)
            {
                Person aPerson = DataLoadAndSave.DataLoadAndSave.PersonData.FirstOrDefault(x => x.PersonID == aPersonID);

                if (aPerson != null)
                {
                    comboBoxNames.Items.Add(aPerson);
                }
            }
        }

        private void HarwestedHoneyDataFormStyle()
        {
            this.Text = HarwestFomrName;

            labelNamesText.Text = HoneyTypesText;

            listViewBasic.Columns.Add(HoneyHarwestColumn1HarwestedAmount, 200, HorizontalAlignment.Left);
            listViewBasic.Columns.Add(HoneyHarwestColumn2HarwestPlace, 200, HorizontalAlignment.Left);
            listViewBasic.Columns.Add(HoneyHarwestColumn3Date, 200, HorizontalAlignment.Left);

            HoneyTypesUpload(true);
            NewYearsUpload();
        }

        private void HoneyTypesUpload(bool harwest)
        {
            List<int> actualHoneyIDs = new List<int>();

            if(harwest)
            {
                comboBoxNames.Items.Clear();
                comboBoxNames.Items.Add(AllOfTheSelectionPossibility);
                comboBoxNames.SelectedIndex = 0;

                DataLoadAndSave.DataLoadAndSave.HoneyTypesForHarwest(out actualHoneyIDs);

                HTypesForHUpload(true,  actualHoneyIDs);
            }
            else
            {
                comboBoxHoneyTypes.Items.Clear();
                comboBoxHoneyTypes.Items.Add(AllOfTheSelectionPossibility);
                comboBoxHoneyTypes.SelectedIndex = 0;

                DataLoadAndSave.DataLoadAndSave.HoneyTypesForSales(SelectedPersonID, formStyle, out actualHoneyIDs);

                HTypesForHUpload(false, actualHoneyIDs);
            }
        }

        private void HTypesForHUpload(bool comboboxNames, List<int> actualHoneyIDs)
        {
            foreach (int honeyTypeID in actualHoneyIDs)
            {
                HoneyType foundHoneyType = DataLoadAndSave.DataLoadAndSave.HoneyTypes.
                    FirstOrDefault(x => x.HoneyTypeID == honeyTypeID);

                if (foundHoneyType != null && !comboboxNames)
                {
                    comboBoxHoneyTypes.Items.Add(foundHoneyType);
                }
                else if (foundHoneyType != null && comboboxNames)
                {
                    comboBoxNames.Items.Add(foundHoneyType);
                }
            }
        }

        public DataListView(int FormStyle)
        {
            InitializeComponent();

            formStyle = FormStyle;

            if(formStyle != 2)
            {
                SalesAndPresentDataFormStyle();
            }
            else
            {
                HarwestedHoneyDataFormStyle();
                comboBoxHoneyTypes.Visible =
                labelHoneyTypes.Visible =
                labelAllPrice.Visible =
                labelAllPriceText.Visible = false;
            }

            comboBoxNames.SelectedIndex = 0;
            comboBoxHoneyTypes.SelectedIndex = 0;
            comboBoxDate.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            listViewBasic.Items.Clear();
            listViewBasic.View = View.Details;
            labelAllAmount.Text =
            labelAllPrice.Text = string.Empty;

            if (formStyle < 2)
            {
                List<HoneyPayment> actualPayments = new List<HoneyPayment>();
                DataLoadAndSave.DataLoadAndSave.HoneySalesAllTypesDownload(SelectedPersonID, SelectedHoneyTypeID, SelectedYear, formStyle, out actualPayments);

                foreach (HoneyPayment aHoneyPayment in actualPayments)
                {
                    HoneyType aHoneyType = DataLoadAndSave.DataLoadAndSave.HoneyTypes.FirstOrDefault(x => x.HoneyTypeID == aHoneyPayment.HoneyTypeID);

                    if (aHoneyType != null)
                    {
                        ListViewItem aSelectedHoneyPayment = new ListViewItem(aHoneyPayment.SellingAmount.ToString());
                        aSelectedHoneyPayment.SubItems.Add(aHoneyPayment.SellingPrice.ToString());
                        aSelectedHoneyPayment.SubItems.Add(aHoneyType.HoneyName);
                        aSelectedHoneyPayment.SubItems.Add(aHoneyPayment.SellingDate.ToString(DateForm));

                        listViewBasic.Items.Add(aSelectedHoneyPayment);
                    }
                }

                labelAllAmount.Text = actualPayments.Sum(x => x.SellingAmount).ToString();
                labelAllPrice.Text = actualPayments.Sum(x => x.SellingPrice).ToString();
            }
            else
            {
                List<HoneyHarwest> actualHOneyHarwest = new List<HoneyHarwest>();
                DataLoadAndSave.DataLoadAndSave.HoneyHarwestAllTypesDownload(SelectedHoneyTypeID, SelectedYear, out actualHOneyHarwest);

                foreach (HoneyHarwest aHarwest in actualHOneyHarwest)
                {
                    ListViewItem aHoneyHarwest = new ListViewItem(aHarwest.HoneyHarwestAmount.ToString());
                    aHoneyHarwest.SubItems.Add(aHarwest.HoneyHarwestLocation);
                    aHoneyHarwest.SubItems.Add(aHarwest.HoneyHarwestDateTime.ToString(DateForm));

                    listViewBasic.Items.Add(aHoneyHarwest);
                }

                labelAllAmount.Text = actualHOneyHarwest.Sum(x => x.HoneyHarwestAmount).ToString();
            }
        }

        private void NewYearsUpload()
        {
            comboBoxDate.Items.Clear();
            comboBoxDate.Items.Add(AllOfTheSelectionPossibility);
            List<int> actualYears = new List<int>();

            if (formStyle < 2)
            {
                DataLoadAndSave.DataLoadAndSave.ActualSalesYears(SelectedPersonID, SelectedHoneyTypeID, formStyle, out actualYears);
            }
            else
            {
                DataLoadAndSave.DataLoadAndSave.ActualHarwestYears(SelectedHoneyTypeID, out actualYears);
            }

            foreach (int aYear in actualYears)
            {
                comboBoxDate.Items.Add(aYear);
            }

            comboBoxDate.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewYearsUpload();
            HoneyTypesUpload(false);
        }

        private void comboBoxHoneyTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewYearsUpload();
        }

        private void DataListView_Load(object sender, EventArgs e)
        {

        }
    }
}
