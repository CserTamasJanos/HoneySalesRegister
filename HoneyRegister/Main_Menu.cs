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
    public partial class MainMenu : Form
    {
        const string DatabaseNotExists = "Az adatbázis nem létezik. Adatbázis nélkül a program nem működik." +
            "Vegye fel a kapcsolatot a fejlesztővel.";
        const string OneOfTheTablesNotExists = "Valamelyik adat tábla nem létezik." +
            "Adatbázistáblák nélkül a program nem működik. Vegye fel a kapcsolatot a fejlesztővel.";

        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDataInput_Click(object sender, EventArgs e)
        {
            SecondMenuInput secondMenuInput = new SecondMenuInput();
            secondMenuInput.ShowDialog();
        }

        private void button_Data_Output_Click(object sender, EventArgs e)
        {
            SecondMenuDataVisualising dataVisualising = new SecondMenuDataVisualising();
            dataVisualising.ShowDialog();
        }

        public void DownloadErrorAndClose(string message)
        {
            MessageBox.Show(message);
            this.Close();
        }

        public void ErrorMessagePopUp (string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            int databaseExists = DataLoadAndSave.DataLoadAndSave.DatabaseCheck();
            int[] tablesExists = new int[4];            
           
            if (databaseExists < 1)
            {
                if (databaseExists == 0)
                {
                    MessageBox.Show(DatabaseNotExists);
                }
                this.Close();
            }
            else
            {
                for(int i = 0; i < 4; i++)
                {
                    tablesExists[i] = DataLoadAndSave.DataLoadAndSave.TableCheck(i);
                }

                if(tablesExists.Sum()/4 != 1)
                {
                    MessageBox.Show(OneOfTheTablesNotExists);
                    this.Close();
                }
                else
                {
                    DataLoadAndSave.DataLoadAndSave.SQLHoneyTypesDownload();
                }
            }
        }
    }
}
