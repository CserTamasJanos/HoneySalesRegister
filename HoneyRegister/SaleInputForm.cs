using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataLoadAndSave;

namespace MéhészPróbálkozás1
{
    public partial class SaleInputForm : Form
    {
        private const string ChooseAHoneyType = "Nem választott méztípust!";
        private const string ChooseAName = "Nem választott nevet!";
        private const string InputError = "Nem számot adott meg vagy a mező üres!";
        private const string HoneyPaymentSavedSuccessfully = "Az eladásadatok mentésre kerültek!";
        private readonly Color ErrorColor= Color.Red;

        public HoneyType SelectedHoneyType
        {
            get
            {
                return (HoneyType)comboBoxHoneyTypes.SelectedItem;
            }
        }

        public Person SelectedPerson
        {
            get
            {
                return (Person)comboBoxPersonNames.SelectedItem;
            }
        }

        private void ComboBoxRefresh()
        {
            comboBoxPersonNames.Items.Clear();

            if (DataLoadAndSave.DataLoadAndSave.SQLPersonDownload())
            {
                foreach (Person aPerson in DataLoadAndSave.DataLoadAndSave.PersonData)
                {
                    comboBoxPersonNames.Items.Add(aPerson);
                }
            }
        }

        public SaleInputForm()
        {
            InitializeComponent();

            foreach(HoneyType aHoneyType in DataLoadAndSave.DataLoadAndSave.HoneyTypes)
            {
                comboBoxHoneyTypes.Items.Add(aHoneyType);
            }

            ComboBoxRefresh();
        }

        private void buttonBackToSecondMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ErrorSwitcher (object inputForm, Label errorLabel)
        {
            if(inputForm is ComboBox)
            {
                ComboBox aComboBox = (ComboBox)inputForm;
                aComboBox.BackColor = ErrorColor;
            }
            if(inputForm is TextBox)
            {
                TextBox aTextBox = (TextBox)inputForm;
                aTextBox.BackColor = ErrorColor;
                errorLabel.Text = InputError;
            }
            return true;
        }

        private void buttonSaleDataSave_Click(object sender, EventArgs e)
        {
            int convertedTextBoxPrice;
            int convertedTextBoxAmount;
            int checkboxPresentStatus = 0;

            bool errorHappened = false;

            comboBoxHoneyTypes.BackColor =
            comboBoxPersonNames.BackColor =
            textBoxAmount.BackColor =
            textBoxPrice.BackColor = SystemColors.Window;
            labelErrorMessageComboboxHoneyType.Text =
            labelErrorMessageComboboxPersonName.Text =
            labelErrorMessageTextBoxAmount.Text =
            labelErrorMessageTexBoxPrice.Text = string.Empty;

            if (comboBoxHoneyTypes.SelectedItem == null)
            {
                labelErrorMessageComboboxHoneyType.Text = ChooseAHoneyType;
                errorHappened = ErrorSwitcher(comboBoxHoneyTypes, null);
            }
            if(comboBoxPersonNames.SelectedItem == null)
            {
                labelErrorMessageComboboxPersonName.Text = ChooseAName;
                errorHappened = ErrorSwitcher(comboBoxPersonNames, null);
            }
            if(checkBoxPresent.Checked)
            {
                checkboxPresentStatus = 1;
            }
            if(textBoxPrice.Text == null)
            {
                errorHappened = ErrorSwitcher(textBoxPrice, labelErrorMessageTexBoxPrice);
            }
            else if (!Int32.TryParse(textBoxPrice.Text, out convertedTextBoxPrice))
            {
                errorHappened = ErrorSwitcher(textBoxPrice, labelErrorMessageTexBoxPrice);
            }
            if(textBoxAmount.Text == null)
            {
                errorHappened = ErrorSwitcher(textBoxAmount, labelErrorMessageTextBoxAmount);
            }
            else if (!Int32.TryParse(textBoxAmount.Text, out convertedTextBoxAmount))
            {
                errorHappened = ErrorSwitcher(textBoxAmount, labelErrorMessageTextBoxAmount);
            }
            if (!errorHappened)
            {
                Review rewiew = new Review();

                errorHappened = rewiew.ShowDialog() == DialogResult.Cancel ? true : false;
            }
            if(!errorHappened)
            {
                if(DataLoadAndSave.DataLoadAndSave.SQLHoneyPaymentSave(SelectedPerson.PersonID,
                                                                        SelectedHoneyType.HoneyTypeID,
                                                                        Convert.ToInt32(textBoxAmount.Text),
                                                                        Convert.ToInt32(labelSumOfTheSellingPrices.Text),
                                                                        dateTimePicker_For_Sale.Value,
                                                                        checkboxPresentStatus))
                {
                    MessageBox.Show(HoneyPaymentSavedSuccessfully);

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void buttonAddANewPerson_Click(object sender, EventArgs e)
        {
            NewPersonWindow newPersonWindow = new NewPersonWindow(this.Location.X, this.Location.Y);

            if(newPersonWindow.ShowDialog() == DialogResult.OK)
            {
                ComboBoxRefresh();
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            int convertedTextBoxPrice = 0;
            int convertedTextBoxAmount = 0;
            bool errorHappened = false;

            textBoxPrice.BackColor = 
            textBoxAmount.BackColor = SystemColors.Window;
            labelErrorMessageTexBoxPrice.Text =
            labelErrorMessageTextBoxAmount.Text = string.Empty;

            if(!Int32.TryParse(textBoxPrice.Text, out convertedTextBoxPrice))
            {
                errorHappened = ErrorSwitcher(textBoxPrice, labelErrorMessageTexBoxPrice);
            }
            if(!Int32.TryParse(textBoxAmount.Text, out convertedTextBoxAmount))
            {
                errorHappened = ErrorSwitcher(textBoxAmount, labelErrorMessageTextBoxAmount);
            }
            if(!errorHappened)
            {
                labelSumOfTheSellingPrices.Text = (convertedTextBoxAmount * convertedTextBoxPrice).ToString();
            }
        }

        private void SaleInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}

