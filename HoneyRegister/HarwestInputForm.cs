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
    public partial class HarwestInputForm : Form
    {
        private const string ChooseAHoneyType = "Nem választott mézfajtát!";
        private const string InputError = "Nem vitt be adatot vagy a formátuma nem megfelelő.";
        private const string HoneyHarwestDataSavedSuccessfully = "A pergetésadatok mentésre kerültek.";
        private readonly Color ErrorColor = Color.Red; 

        private HoneyType SelectedHoneyType
        {
            get
            {
                return (HoneyType)comboBoxHoneyTypes.SelectedItem;
            }
        }

        public HarwestInputForm()
        {
            InitializeComponent();

            foreach(HoneyType aHoneyType in DataLoadAndSave.DataLoadAndSave.HoneyTypes)
            {
                comboBoxHoneyTypes.Items.Add(aHoneyType);
            }
        }

        private bool ErrorSwitcher (object inputForm, Label errorLabel)//Ugyan ezt csinálja a Sale Input form ErrorSwitcher is...lehet hogy ez majd megy az Operationsba...
        {
            if (inputForm is ComboBox)
            {
                ComboBox aComboBox = (ComboBox)inputForm;
                aComboBox.BackColor = ErrorColor;
            }
            if (inputForm is TextBox)
            {
                TextBox aTextBox = (TextBox)inputForm;
                aTextBox.BackColor = ErrorColor;
                errorLabel.Text = InputError;
            }
            return true;
        }

        private void buttonSaveHarwestData_Click(object sender, EventArgs e)
        {
            int convertedHarwestAmountNumber;

            bool errorHappened = false;
            comboBoxHoneyTypes.BackColor =
            textBoxLocation.BackColor =
            textBoxAmount.BackColor = SystemColors.Window;
            labelErrorMessageHoneyType.Text =
            labelErrorMessageLocation.Text =
            labelErrorMessageHoneyHarwestAmount.Text = string.Empty;

            if(comboBoxHoneyTypes.SelectedItem == null)//Kiszervezni!!! mint a többit..lehet központilag!!!
            {
                labelErrorMessageHoneyType.Text = ChooseAHoneyType;
                errorHappened = ErrorSwitcher(comboBoxHoneyTypes, null);

            }
            if (String.IsNullOrEmpty(textBoxLocation.Text) || textBoxLocation.Text.Contains("  "))//!DataLoadAndSave.Operations.TextIsValid(textBoxLocation.Text)) //!String.IsNullOrEmpty(a) && !a.Contains("  ")
            {
                errorHappened = ErrorSwitcher(textBoxLocation, labelErrorMessageLocation);

            }
            if (!Int32.TryParse(textBoxAmount.Text, out convertedHarwestAmountNumber))
            {
                errorHappened = ErrorSwitcher(textBoxAmount, labelErrorMessageHoneyHarwestAmount);

            }
            if (!errorHappened)
            {
                Review rewiew = new Review();

                errorHappened = rewiew.ShowDialog() == DialogResult.Cancel ? true : false;

            }
            if (!errorHappened)
            {

                if(DataLoadAndSave.DataLoadAndSave.SQLHoneyHarwestSave(SelectedHoneyType.HoneyTypeID
                                , dateTimePickerHarwestDate.Value
                                , textBoxLocation.Text
                                , convertedHarwestAmountNumber))
                {
                    MessageBox.Show(HoneyHarwestDataSavedSuccessfully);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void buttonBackToTheSecondMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HarwestInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
