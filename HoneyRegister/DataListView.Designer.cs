namespace MéhészPróbálkozás1
{
    partial class DataListView
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
            this.listViewBasic = new System.Windows.Forms.ListView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxNames = new System.Windows.Forms.ComboBox();
            this.labelNamesText = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxHoneyTypes = new System.Windows.Forms.ComboBox();
            this.labelHoneyTypes = new System.Windows.Forms.Label();
            this.labelAllAmountText = new System.Windows.Forms.Label();
            this.labelAllAmount = new System.Windows.Forms.Label();
            this.labelAllPriceText = new System.Windows.Forms.Label();
            this.labelAllPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewBasic
            // 
            this.listViewBasic.HideSelection = false;
            this.listViewBasic.Location = new System.Drawing.Point(12, 41);
            this.listViewBasic.Name = "listViewBasic";
            this.listViewBasic.Size = new System.Drawing.Size(614, 236);
            this.listViewBasic.TabIndex = 0;
            this.listViewBasic.UseCompatibleStateImageBehavior = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(551, 310);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "Lekérdezés";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(526, 10);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDate.TabIndex = 3;
            // 
            // comboBoxNames
            // 
            this.comboBoxNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNames.FormattingEnabled = true;
            this.comboBoxNames.Location = new System.Drawing.Point(110, 10);
            this.comboBoxNames.Name = "comboBoxNames";
            this.comboBoxNames.Size = new System.Drawing.Size(180, 21);
            this.comboBoxNames.TabIndex = 4;
            this.comboBoxNames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelNamesText
            // 
            this.labelNamesText.AutoSize = true;
            this.labelNamesText.Location = new System.Drawing.Point(12, 14);
            this.labelNamesText.Name = "labelNamesText";
            this.labelNamesText.Size = new System.Drawing.Size(92, 13);
            this.labelNamesText.TabIndex = 5;
            this.labelNamesText.Text = "Regisztrált nevek:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(476, 14);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Dátum:";
            // 
            // comboBoxHoneyTypes
            // 
            this.comboBoxHoneyTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHoneyTypes.FormattingEnabled = true;
            this.comboBoxHoneyTypes.Location = new System.Drawing.Point(366, 11);
            this.comboBoxHoneyTypes.Name = "comboBoxHoneyTypes";
            this.comboBoxHoneyTypes.Size = new System.Drawing.Size(100, 21);
            this.comboBoxHoneyTypes.TabIndex = 7;
            this.comboBoxHoneyTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxHoneyTypes_SelectedIndexChanged);
            // 
            // labelHoneyTypes
            // 
            this.labelHoneyTypes.AutoSize = true;
            this.labelHoneyTypes.Location = new System.Drawing.Point(300, 14);
            this.labelHoneyTypes.Name = "labelHoneyTypes";
            this.labelHoneyTypes.Size = new System.Drawing.Size(56, 13);
            this.labelHoneyTypes.TabIndex = 8;
            this.labelHoneyTypes.Text = "Mézfajták:";
            // 
            // labelAllAmountText
            // 
            this.labelAllAmountText.AutoSize = true;
            this.labelAllAmountText.Location = new System.Drawing.Point(12, 287);
            this.labelAllAmountText.Name = "labelAllAmountText";
            this.labelAllAmountText.Size = new System.Drawing.Size(211, 13);
            this.labelAllAmountText.TabIndex = 9;
            this.labelAllAmountText.Text = "A lekérdezéshez tartozó összes mennyiség:";
            // 
            // labelAllAmount
            // 
            this.labelAllAmount.AutoSize = true;
            this.labelAllAmount.Location = new System.Drawing.Point(224, 287);
            this.labelAllAmount.Name = "labelAllAmount";
            this.labelAllAmount.Size = new System.Drawing.Size(0, 13);
            this.labelAllAmount.TabIndex = 10;
            // 
            // labelAllPriceText
            // 
            this.labelAllPriceText.AutoSize = true;
            this.labelAllPriceText.Location = new System.Drawing.Point(300, 287);
            this.labelAllPriceText.Name = "labelAllPriceText";
            this.labelAllPriceText.Size = new System.Drawing.Size(170, 13);
            this.labelAllPriceText.TabIndex = 11;
            this.labelAllPriceText.Text = "A lekérdezéshaz tartozó összes ár:";
            // 
            // labelAllPrice
            // 
            this.labelAllPrice.AutoSize = true;
            this.labelAllPrice.Location = new System.Drawing.Point(471, 287);
            this.labelAllPrice.Name = "labelAllPrice";
            this.labelAllPrice.Size = new System.Drawing.Size(0, 13);
            this.labelAllPrice.TabIndex = 12;
            // 
            // DataListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 345);
            this.Controls.Add(this.labelAllPrice);
            this.Controls.Add(this.labelAllPriceText);
            this.Controls.Add(this.labelAllAmount);
            this.Controls.Add(this.labelAllAmountText);
            this.Controls.Add(this.labelHoneyTypes);
            this.Controls.Add(this.comboBoxHoneyTypes);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNamesText);
            this.Controls.Add(this.comboBoxNames);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listViewBasic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DataListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataListView";
            this.Load += new System.EventHandler(this.DataListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBasic;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.ComboBox comboBoxNames;
        private System.Windows.Forms.Label labelNamesText;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxHoneyTypes;
        private System.Windows.Forms.Label labelHoneyTypes;
        private System.Windows.Forms.Label labelAllAmountText;
        private System.Windows.Forms.Label labelAllAmount;
        private System.Windows.Forms.Label labelAllPriceText;
        private System.Windows.Forms.Label labelAllPrice;
    }
}