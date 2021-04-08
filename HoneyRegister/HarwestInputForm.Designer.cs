namespace MéhészPróbálkozás1
{
    partial class HarwestInputForm
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
            this.dateTimePickerHarwestDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxHoneyTypes = new System.Windows.Forms.ComboBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label_for_DateTimePicker = new System.Windows.Forms.Label();
            this.label_For_ComboBox = new System.Windows.Forms.Label();
            this.label_For_Location = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.button_Save_Harwest_Data = new System.Windows.Forms.Button();
            this.button_Back_To_The_Second_Menu = new System.Windows.Forms.Button();
            this.labelErrorMessageHoneyType = new System.Windows.Forms.Label();
            this.labelErrorMessageLocation = new System.Windows.Forms.Label();
            this.labelErrorMessageHoneyHarwestAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerHarwestDate
            // 
            this.dateTimePickerHarwestDate.Location = new System.Drawing.Point(120, 10);
            this.dateTimePickerHarwestDate.Name = "dateTimePickerHarwestDate";
            this.dateTimePickerHarwestDate.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerHarwestDate.TabIndex = 1;
            // 
            // comboBoxHoneyTypes
            // 
            this.comboBoxHoneyTypes.FormattingEnabled = true;
            this.comboBoxHoneyTypes.ItemHeight = 13;
            this.comboBoxHoneyTypes.Location = new System.Drawing.Point(120, 48);
            this.comboBoxHoneyTypes.Name = "comboBoxHoneyTypes";
            this.comboBoxHoneyTypes.Size = new System.Drawing.Size(210, 21);
            this.comboBoxHoneyTypes.TabIndex = 2;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(120, 87);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(210, 20);
            this.textBoxLocation.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(120, 125);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(210, 20);
            this.textBoxAmount.TabIndex = 4;
            // 
            // label_for_DateTimePicker
            // 
            this.label_for_DateTimePicker.AutoSize = true;
            this.label_for_DateTimePicker.Location = new System.Drawing.Point(10, 13);
            this.label_for_DateTimePicker.Name = "label_for_DateTimePicker";
            this.label_for_DateTimePicker.Size = new System.Drawing.Size(95, 13);
            this.label_for_DateTimePicker.TabIndex = 5;
            this.label_for_DateTimePicker.Text = "Pergetés időpontja";
            // 
            // label_For_ComboBox
            // 
            this.label_For_ComboBox.AutoSize = true;
            this.label_For_ComboBox.Location = new System.Drawing.Point(10, 51);
            this.label_For_ComboBox.Name = "label_For_ComboBox";
            this.label_For_ComboBox.Size = new System.Drawing.Size(103, 13);
            this.label_For_ComboBox.TabIndex = 6;
            this.label_For_ComboBox.Text = "Pergetett méz fajtája";
            // 
            // label_For_Location
            // 
            this.label_For_Location.AutoSize = true;
            this.label_For_Location.Location = new System.Drawing.Point(10, 89);
            this.label_For_Location.Name = "label_For_Location";
            this.label_For_Location.Size = new System.Drawing.Size(97, 13);
            this.label_For_Location.TabIndex = 7;
            this.label_For_Location.Text = "Pergetés helyszíne";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(10, 127);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(108, 13);
            this.label_Amount.TabIndex = 8;
            this.label_Amount.Text = "Pergetés mennyisége";
            // 
            // button_Save_Harwest_Data
            // 
            this.button_Save_Harwest_Data.Location = new System.Drawing.Point(255, 167);
            this.button_Save_Harwest_Data.Name = "button_Save_Harwest_Data";
            this.button_Save_Harwest_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Save_Harwest_Data.TabIndex = 9;
            this.button_Save_Harwest_Data.Text = "Rögzítés";
            this.button_Save_Harwest_Data.UseVisualStyleBackColor = true;
            this.button_Save_Harwest_Data.Click += new System.EventHandler(this.buttonSaveHarwestData_Click);
            // 
            // button_Back_To_The_Second_Menu
            // 
            this.button_Back_To_The_Second_Menu.Location = new System.Drawing.Point(10, 167);
            this.button_Back_To_The_Second_Menu.Name = "button_Back_To_The_Second_Menu";
            this.button_Back_To_The_Second_Menu.Size = new System.Drawing.Size(75, 23);
            this.button_Back_To_The_Second_Menu.TabIndex = 10;
            this.button_Back_To_The_Second_Menu.Text = "Vissza";
            this.button_Back_To_The_Second_Menu.UseVisualStyleBackColor = true;
            this.button_Back_To_The_Second_Menu.Click += new System.EventHandler(this.buttonBackToTheSecondMenu_Click);
            // 
            // labelErrorMessageHoneyType
            // 
            this.labelErrorMessageHoneyType.AutoSize = true;
            this.labelErrorMessageHoneyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorMessageHoneyType.Location = new System.Drawing.Point(115, 69);
            this.labelErrorMessageHoneyType.Name = "labelErrorMessageHoneyType";
            this.labelErrorMessageHoneyType.Size = new System.Drawing.Size(0, 12);
            this.labelErrorMessageHoneyType.TabIndex = 11;
            // 
            // labelErrorMessageLocation
            // 
            this.labelErrorMessageLocation.AutoSize = true;
            this.labelErrorMessageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorMessageLocation.Location = new System.Drawing.Point(115, 107);
            this.labelErrorMessageLocation.Name = "labelErrorMessageLocation";
            this.labelErrorMessageLocation.Size = new System.Drawing.Size(0, 12);
            this.labelErrorMessageLocation.TabIndex = 12;
            // 
            // labelErrorMessageHoneyHarwestAmount
            // 
            this.labelErrorMessageHoneyHarwestAmount.AutoSize = true;
            this.labelErrorMessageHoneyHarwestAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorMessageHoneyHarwestAmount.Location = new System.Drawing.Point(115, 145);
            this.labelErrorMessageHoneyHarwestAmount.Name = "labelErrorMessageHoneyHarwestAmount";
            this.labelErrorMessageHoneyHarwestAmount.Size = new System.Drawing.Size(0, 12);
            this.labelErrorMessageHoneyHarwestAmount.TabIndex = 13;
            // 
            // HarwestInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 201);
            this.Controls.Add(this.labelErrorMessageHoneyHarwestAmount);
            this.Controls.Add(this.labelErrorMessageLocation);
            this.Controls.Add(this.labelErrorMessageHoneyType);
            this.Controls.Add(this.button_Back_To_The_Second_Menu);
            this.Controls.Add(this.button_Save_Harwest_Data);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label_For_Location);
            this.Controls.Add(this.label_For_ComboBox);
            this.Controls.Add(this.label_for_DateTimePicker);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.comboBoxHoneyTypes);
            this.Controls.Add(this.dateTimePickerHarwestDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HarwestInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pergetés adatbevitel";
            this.Load += new System.EventHandler(this.HarwestInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerHarwestDate;
        private System.Windows.Forms.ComboBox comboBoxHoneyTypes;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label_for_DateTimePicker;
        private System.Windows.Forms.Label label_For_ComboBox;
        private System.Windows.Forms.Label label_For_Location;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Button button_Save_Harwest_Data;
        private System.Windows.Forms.Button button_Back_To_The_Second_Menu;
        private System.Windows.Forms.Label labelErrorMessageHoneyType;
        private System.Windows.Forms.Label labelErrorMessageLocation;
        private System.Windows.Forms.Label labelErrorMessageHoneyHarwestAmount;
    }
}