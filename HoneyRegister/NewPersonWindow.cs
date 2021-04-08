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
    public partial class NewPersonWindow : Form
    {
        private const string InputError = "Nem írt be semmit vagy túl sok space-t nyomott!";
        private const string SpaceGap = " ";
        private const string InputNameIsAlreadyExists = "A megadott név már létezik, írjon be másik nevet!";
        private const string CustomerDataSaved = "A vásárló adatai mentésre kerültek.";
        private readonly Color ErrorColor = Color.Red;

        private const int DistanceFromBorder = 385;
        private const int SaleInputFormSizeWidth = 370;
        private const int DistanceFromSaleInputForm = 25;

        public NewPersonWindow(int SalesInputFormX, int SaleInputFormY)
        {
            InitializeComponent();

            if(SalesInputFormX < DistanceFromBorder)
            {
                this.Location = new Point((SalesInputFormX + SaleInputFormSizeWidth + DistanceFromSaleInputForm), SaleInputFormY);
            }
            else
            {
                this.Location = new Point((SalesInputFormX - (DistanceFromSaleInputForm + this.Width)), SaleInputFormY);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ErrorSwitcher (TextBox inspectedTextBox, Label errorLabel)
        {
            inspectedTextBox.BackColor = ErrorColor;
            errorLabel.Text = InputError;
            return true;
        }

        private void buttonSaveNewPersonName_Click(object sender, EventArgs e)
        {
            bool errorHappened = false;
            textBoxFirstName.BackColor =
            textBoxSecondName.BackColor =
            textBoxPersonLocation.BackColor = SystemColors.Window;
            labelTextBoxFirstnameError.Text =
            labelTextBoxSecondNameError.Text =
            labelTextBoxLocationError.Text = string.Empty;

            if(String.IsNullOrEmpty(textBoxFirstName.Text) || textBoxFirstName.Text.Contains("  "))
            {
                errorHappened = ErrorSwitcher(textBoxFirstName, labelTextBoxFirstnameError);

            }
            if(String.IsNullOrEmpty(textBoxSecondName.Text) || textBoxSecondName.Text.Contains("  "))
            {
                errorHappened = ErrorSwitcher(textBoxSecondName, labelTextBoxSecondNameError);

            }
            if(String.IsNullOrEmpty(textBoxPersonLocation.Text) || textBoxPersonLocation.Text.Contains("  "))
            {
                errorHappened = ErrorSwitcher(textBoxPersonLocation, labelTextBoxLocationError);

            }
            else if((DataLoadAndSave.DataLoadAndSave.PersonData.FirstOrDefault
                                            (x => x.FirstName.ToLower().Replace(SpaceGap, String.Empty) + 
                                             x.SecondName.ToLower().Replace(SpaceGap, String.Empty) +
                                             x.PersonLocation.ToLower().Replace(SpaceGap, String.Empty) ==
                                             textBoxFirstName.Text.ToLower().Replace(SpaceGap, String.Empty) +
                                             textBoxSecondName.Text.ToLower().Replace(SpaceGap, String.Empty) +
                                             textBoxPersonLocation.Text.ToLower().Replace(SpaceGap, String.Empty))) != null)
            {

                MessageBox.Show(InputNameIsAlreadyExists);
                errorHappened = true;
            }
            if(!errorHappened)
            {
                Review review = new Review();

                errorHappened = review.ShowDialog() == DialogResult.Cancel ? true : false;
            }
            if(!errorHappened)
            {
                if(DataLoadAndSave.DataLoadAndSave.SQLPersonSave(textBoxFirstName.Text,
                                              textBoxSecondName.Text,
                                              textBoxPersonLocation.Text))
                {
                    MessageBox.Show(CustomerDataSaved);

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void NewPersonWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
