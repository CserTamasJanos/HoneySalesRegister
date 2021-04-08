namespace MéhészPróbálkozás1
{
    partial class SecondMenuDataVisualising
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
            this.buttonSellingData = new System.Windows.Forms.Button();
            this.buttonHarwestingData = new System.Windows.Forms.Button();
            this.buttonPresentData = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSellingData
            // 
            this.buttonSellingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSellingData.Location = new System.Drawing.Point(66, 10);
            this.buttonSellingData.Name = "buttonSellingData";
            this.buttonSellingData.Size = new System.Drawing.Size(150, 25);
            this.buttonSellingData.TabIndex = 0;
            this.buttonSellingData.Text = "Eladásadatok";
            this.buttonSellingData.UseVisualStyleBackColor = true;
            this.buttonSellingData.Click += new System.EventHandler(this.buttonSellingData_Click);
            // 
            // buttonHarwestingData
            // 
            this.buttonHarwestingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHarwestingData.Location = new System.Drawing.Point(66, 80);
            this.buttonHarwestingData.Name = "buttonHarwestingData";
            this.buttonHarwestingData.Size = new System.Drawing.Size(150, 25);
            this.buttonHarwestingData.TabIndex = 1;
            this.buttonHarwestingData.Text = "Pergetésadatok";
            this.buttonHarwestingData.UseVisualStyleBackColor = true;
            this.buttonHarwestingData.Click += new System.EventHandler(this.buttonHarwestingData_Click);
            // 
            // buttonPresentData
            // 
            this.buttonPresentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPresentData.Location = new System.Drawing.Point(66, 45);
            this.buttonPresentData.Name = "buttonPresentData";
            this.buttonPresentData.Size = new System.Drawing.Size(150, 25);
            this.buttonPresentData.TabIndex = 2;
            this.buttonPresentData.Text = "Ajándék";
            this.buttonPresentData.UseVisualStyleBackColor = true;
            this.buttonPresentData.Click += new System.EventHandler(this.buttonPresentData_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(66, 115);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 25);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SecondMenuDataVisualising
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPresentData);
            this.Controls.Add(this.buttonHarwestingData);
            this.Controls.Add(this.buttonSellingData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SecondMenuDataVisualising";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adatmegjelenítés";
            this.Load += new System.EventHandler(this.DataVisualising_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSellingData;
        private System.Windows.Forms.Button buttonHarwestingData;
        private System.Windows.Forms.Button buttonPresentData;
        private System.Windows.Forms.Button buttonCancel;
    }
}