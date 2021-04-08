namespace MéhészPróbálkozás1
{
    partial class SaleInputForm
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
            this.dateTimePicker_For_Sale = new System.Windows.Forms.DateTimePicker();
            this.comboBoxHoneyTypes = new System.Windows.Forms.ComboBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.checkBoxPresent = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label_Sale_Date = new System.Windows.Forms.Label();
            this.label_Honey_Type = new System.Windows.Forms.Label();
            this.label_Customer_Name = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.labelOneAmountPrice = new System.Windows.Forms.Label();
            this.button_Sale_Data_Save = new System.Windows.Forms.Button();
            this.button_Back_To_Second_Menu = new System.Windows.Forms.Button();
            this.comboBoxPersonNames = new System.Windows.Forms.ComboBox();
            this.buttonAddANewPerson = new System.Windows.Forms.Button();
            this.labelErrorMessageComboboxHoneyType = new System.Windows.Forms.Label();
            this.labelErrorMessageComboboxPersonName = new System.Windows.Forms.Label();
            this.labelErrorMessageTextBoxAmount = new System.Windows.Forms.Label();
            this.labelErrorMessageTexBoxPrice = new System.Windows.Forms.Label();
            this.labelTextOfTheSum = new System.Windows.Forms.Label();
            this.labelSumOfTheSellingPrices = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_For_Sale
            // 
            this.dateTimePicker_For_Sale.Location = new System.Drawing.Point(110, 10);
            this.dateTimePicker_For_Sale.Name = "dateTimePicker_For_Sale";
            this.dateTimePicker_For_Sale.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker_For_Sale.TabIndex = 0;
            // 
            // comboBoxHoneyTypes
            // 
            this.comboBoxHoneyTypes.FormattingEnabled = true;
            this.comboBoxHoneyTypes.Location = new System.Drawing.Point(110, 48);
            this.comboBoxHoneyTypes.Name = "comboBoxHoneyTypes";
            this.comboBoxHoneyTypes.Size = new System.Drawing.Size(230, 21);
            this.comboBoxHoneyTypes.TabIndex = 1;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(110, 168);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(77, 20);
            this.textBoxAmount.TabIndex = 3;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // checkBoxPresent
            // 
            this.checkBoxPresent.AutoSize = true;
            this.checkBoxPresent.Location = new System.Drawing.Point(10, 129);
            this.checkBoxPresent.Name = "checkBoxPresent";
            this.checkBoxPresent.Size = new System.Drawing.Size(65, 17);
            this.checkBoxPresent.TabIndex = 4;
            this.checkBoxPresent.Text = "Ajándék";
            this.checkBoxPresent.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(110, 207);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(77, 20);
            this.textBoxPrice.TabIndex = 5;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // label_Sale_Date
            // 
            this.label_Sale_Date.AutoSize = true;
            this.label_Sale_Date.Location = new System.Drawing.Point(10, 13);
            this.label_Sale_Date.Name = "label_Sale_Date";
            this.label_Sale_Date.Size = new System.Drawing.Size(85, 13);
            this.label_Sale_Date.TabIndex = 6;
            this.label_Sale_Date.Text = "Eladás időpontja";
            // 
            // label_Honey_Type
            // 
            this.label_Honey_Type.AutoSize = true;
            this.label_Honey_Type.Location = new System.Drawing.Point(10, 51);
            this.label_Honey_Type.Name = "label_Honey_Type";
            this.label_Honey_Type.Size = new System.Drawing.Size(60, 13);
            this.label_Honey_Type.TabIndex = 7;
            this.label_Honey_Type.Text = "Méz típusa";
            // 
            // label_Customer_Name
            // 
            this.label_Customer_Name.AutoSize = true;
            this.label_Customer_Name.Location = new System.Drawing.Point(10, 90);
            this.label_Customer_Name.Name = "label_Customer_Name";
            this.label_Customer_Name.Size = new System.Drawing.Size(69, 13);
            this.label_Customer_Name.TabIndex = 8;
            this.label_Customer_Name.Text = "Vásárló neve";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(10, 170);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(93, 13);
            this.label_Amount.TabIndex = 9;
            this.label_Amount.Text = "Eladott mennyiség";
            // 
            // labelOneAmountPrice
            // 
            this.labelOneAmountPrice.AutoSize = true;
            this.labelOneAmountPrice.Location = new System.Drawing.Point(10, 210);
            this.labelOneAmountPrice.Name = "labelOneAmountPrice";
            this.labelOneAmountPrice.Size = new System.Drawing.Size(51, 13);
            this.labelOneAmountPrice.TabIndex = 10;
            this.labelOneAmountPrice.Text = "Egységár";
            // 
            // button_Sale_Data_Save
            // 
            this.button_Sale_Data_Save.Location = new System.Drawing.Point(265, 243);
            this.button_Sale_Data_Save.Name = "button_Sale_Data_Save";
            this.button_Sale_Data_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Sale_Data_Save.TabIndex = 11;
            this.button_Sale_Data_Save.Text = "Rögzítés";
            this.button_Sale_Data_Save.UseVisualStyleBackColor = true;
            this.button_Sale_Data_Save.Click += new System.EventHandler(this.buttonSaleDataSave_Click);
            // 
            // button_Back_To_Second_Menu
            // 
            this.button_Back_To_Second_Menu.Location = new System.Drawing.Point(10, 245);
            this.button_Back_To_Second_Menu.Name = "button_Back_To_Second_Menu";
            this.button_Back_To_Second_Menu.Size = new System.Drawing.Size(75, 23);
            this.button_Back_To_Second_Menu.TabIndex = 12;
            this.button_Back_To_Second_Menu.Text = "Vissza";
            this.button_Back_To_Second_Menu.UseVisualStyleBackColor = true;
            this.button_Back_To_Second_Menu.Click += new System.EventHandler(this.buttonBackToSecondMenu_Click);
            // 
            // comboBoxPersonNames
            // 
            this.comboBoxPersonNames.FormattingEnabled = true;
            this.comboBoxPersonNames.Location = new System.Drawing.Point(110, 87);
            this.comboBoxPersonNames.Name = "comboBoxPersonNames";
            this.comboBoxPersonNames.Size = new System.Drawing.Size(230, 21);
            this.comboBoxPersonNames.TabIndex = 13;
            // 
            // buttonAddANewPerson
            // 
            this.buttonAddANewPerson.Location = new System.Drawing.Point(110, 126);
            this.buttonAddANewPerson.Name = "buttonAddANewPerson";
            this.buttonAddANewPerson.Size = new System.Drawing.Size(230, 23);
            this.buttonAddANewPerson.TabIndex = 14;
            this.buttonAddANewPerson.Text = "Új vásárló felvétele";
            this.buttonAddANewPerson.UseVisualStyleBackColor = true;
            this.buttonAddANewPerson.Click += new System.EventHandler(this.buttonAddANewPerson_Click);
            // 
            // labelErrorMessageComboboxHoneyType
            // 
            this.labelErrorMessageComboboxHoneyType.AutoSize = true;
            this.labelErrorMessageComboboxHoneyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorMessageComboboxHoneyType.Location = new System.Drawing.Point(100, 70);
            this.labelErrorMessageComboboxHoneyType.Name = "labelErrorMessageComboboxHoneyType";
            this.labelErrorMessageComboboxHoneyType.Size = new System.Drawing.Size(0, 12);
            this.labelErrorMessageComboboxHoneyType.TabIndex = 16;
            // 
            // labelErrorMessageComboboxPersonName
            // 
            this.labelErrorMessageComboboxPersonName.AutoSize = true;
            this.labelErrorMessageComboboxPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorMessageComboboxPersonName.Location = new System.Drawing.Point(100, 109);
            this.labelErrorMessageComboboxPersonName.Name = "labelErrorMessageComboboxPersonName";
            this.labelErrorMessageComboboxPersonName.Size = new System.Drawing.Size(0, 12);
            this.labelErrorMessageComboboxPersonName.TabIndex = 17;
            // 
            // labelErrorMessageTextBoxAmount
            // 
            this.labelErrorMessageTextBoxAmount.AutoSize = true;
            this.labelErrorMessageTextBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorMessageTextBoxAmount.Location = new System.Drawing.Point(100, 189);
            this.labelErrorMessageTextBoxAmount.Name = "labelErrorMessageTextBoxAmount";
            this.labelErrorMessageTextBoxAmount.Size = new System.Drawing.Size(0, 12);
            this.labelErrorMessageTextBoxAmount.TabIndex = 18;
            // 
            // labelErrorMessageTexBoxPrice
            // 
            this.labelErrorMessageTexBoxPrice.AutoSize = true;
            this.labelErrorMessageTexBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorMessageTexBoxPrice.Location = new System.Drawing.Point(100, 228);
            this.labelErrorMessageTexBoxPrice.Name = "labelErrorMessageTexBoxPrice";
            this.labelErrorMessageTexBoxPrice.Size = new System.Drawing.Size(0, 12);
            this.labelErrorMessageTexBoxPrice.TabIndex = 19;
            // 
            // labelTextOfTheSum
            // 
            this.labelTextOfTheSum.AutoSize = true;
            this.labelTextOfTheSum.Location = new System.Drawing.Point(202, 210);
            this.labelTextOfTheSum.Name = "labelTextOfTheSum";
            this.labelTextOfTheSum.Size = new System.Drawing.Size(56, 13);
            this.labelTextOfTheSum.TabIndex = 20;
            this.labelTextOfTheSum.Text = "Összesen:";
            // 
            // labelSumOfTheSellingPrices
            // 
            this.labelSumOfTheSellingPrices.AutoSize = true;
            this.labelSumOfTheSellingPrices.Location = new System.Drawing.Point(258, 210);
            this.labelSumOfTheSellingPrices.Name = "labelSumOfTheSellingPrices";
            this.labelSumOfTheSellingPrices.Size = new System.Drawing.Size(0, 13);
            this.labelSumOfTheSellingPrices.TabIndex = 21;
            // 
            // SaleInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 278);
            this.Controls.Add(this.labelSumOfTheSellingPrices);
            this.Controls.Add(this.labelTextOfTheSum);
            this.Controls.Add(this.labelErrorMessageTexBoxPrice);
            this.Controls.Add(this.labelErrorMessageTextBoxAmount);
            this.Controls.Add(this.labelErrorMessageComboboxPersonName);
            this.Controls.Add(this.labelErrorMessageComboboxHoneyType);
            this.Controls.Add(this.buttonAddANewPerson);
            this.Controls.Add(this.comboBoxPersonNames);
            this.Controls.Add(this.button_Back_To_Second_Menu);
            this.Controls.Add(this.button_Sale_Data_Save);
            this.Controls.Add(this.labelOneAmountPrice);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label_Customer_Name);
            this.Controls.Add(this.label_Honey_Type);
            this.Controls.Add(this.label_Sale_Date);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.checkBoxPresent);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.comboBoxHoneyTypes);
            this.Controls.Add(this.dateTimePicker_For_Sale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SaleInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eladás";
            this.Load += new System.EventHandler(this.SaleInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_For_Sale;
        private System.Windows.Forms.ComboBox comboBoxHoneyTypes;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.CheckBox checkBoxPresent;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label_Sale_Date;
        private System.Windows.Forms.Label label_Honey_Type;
        private System.Windows.Forms.Label label_Customer_Name;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label labelOneAmountPrice;
        private System.Windows.Forms.Button button_Sale_Data_Save;
        private System.Windows.Forms.Button button_Back_To_Second_Menu;
        private System.Windows.Forms.ComboBox comboBoxPersonNames;
        private System.Windows.Forms.Button buttonAddANewPerson;
        private System.Windows.Forms.Label labelErrorMessageComboboxHoneyType;
        private System.Windows.Forms.Label labelErrorMessageComboboxPersonName;
        private System.Windows.Forms.Label labelErrorMessageTextBoxAmount;
        private System.Windows.Forms.Label labelErrorMessageTexBoxPrice;
        private System.Windows.Forms.Label labelTextOfTheSum;
        private System.Windows.Forms.Label labelSumOfTheSellingPrices;
    }
}