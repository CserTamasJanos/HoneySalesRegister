namespace MéhészPróbálkozás1
{
    partial class NewPersonWindow
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
            this.buttonSaveNewPersonName = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelTextBoxFirstnameError = new System.Windows.Forms.Label();
            this.labelTextBoxSecondNameError = new System.Windows.Forms.Label();
            this.textBoxPersonLocation = new System.Windows.Forms.TextBox();
            this.labelPersonLocation = new System.Windows.Forms.Label();
            this.labelTextBoxLocationError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveNewPersonName
            // 
            this.buttonSaveNewPersonName.Location = new System.Drawing.Point(255, 124);
            this.buttonSaveNewPersonName.Name = "buttonSaveNewPersonName";
            this.buttonSaveNewPersonName.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveNewPersonName.TabIndex = 0;
            this.buttonSaveNewPersonName.Text = "Rögzít";
            this.buttonSaveNewPersonName.UseVisualStyleBackColor = true;
            this.buttonSaveNewPersonName.Click += new System.EventHandler(this.buttonSaveNewPersonName_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 124);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(90, 10);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(240, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(90, 48);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(240, 20);
            this.textBoxSecondName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(10, 13);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "Családnév";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(10, 51);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(60, 13);
            this.labelSecondName.TabIndex = 5;
            this.labelSecondName.Text = "Keresztnév";
            // 
            // labelTextBoxFirstnameError
            // 
            this.labelTextBoxFirstnameError.AutoSize = true;
            this.labelTextBoxFirstnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTextBoxFirstnameError.Location = new System.Drawing.Point(80, 31);
            this.labelTextBoxFirstnameError.Name = "labelTextBoxFirstnameError";
            this.labelTextBoxFirstnameError.Size = new System.Drawing.Size(0, 12);
            this.labelTextBoxFirstnameError.TabIndex = 6;
            // 
            // labelTextBoxSecondNameError
            // 
            this.labelTextBoxSecondNameError.AutoSize = true;
            this.labelTextBoxSecondNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTextBoxSecondNameError.Location = new System.Drawing.Point(80, 69);
            this.labelTextBoxSecondNameError.Name = "labelTextBoxSecondNameError";
            this.labelTextBoxSecondNameError.Size = new System.Drawing.Size(0, 12);
            this.labelTextBoxSecondNameError.TabIndex = 7;
            // 
            // textBoxPersonLocation
            // 
            this.textBoxPersonLocation.Location = new System.Drawing.Point(90, 86);
            this.textBoxPersonLocation.Name = "textBoxPersonLocation";
            this.textBoxPersonLocation.Size = new System.Drawing.Size(240, 20);
            this.textBoxPersonLocation.TabIndex = 8;
            // 
            // labelPersonLocation
            // 
            this.labelPersonLocation.AutoSize = true;
            this.labelPersonLocation.Location = new System.Drawing.Point(20, 89);
            this.labelPersonLocation.Name = "labelPersonLocation";
            this.labelPersonLocation.Size = new System.Drawing.Size(26, 13);
            this.labelPersonLocation.TabIndex = 9;
            this.labelPersonLocation.Text = "Cím";
            // 
            // labelTextBoxLocationError
            // 
            this.labelTextBoxLocationError.AutoSize = true;
            this.labelTextBoxLocationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTextBoxLocationError.Location = new System.Drawing.Point(80, 107);
            this.labelTextBoxLocationError.Name = "labelTextBoxLocationError";
            this.labelTextBoxLocationError.Size = new System.Drawing.Size(0, 12);
            this.labelTextBoxLocationError.TabIndex = 10;
            // 
            // NewPersonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.labelTextBoxLocationError);
            this.Controls.Add(this.labelPersonLocation);
            this.Controls.Add(this.textBoxPersonLocation);
            this.Controls.Add(this.labelTextBoxSecondNameError);
            this.Controls.Add(this.labelTextBoxFirstnameError);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveNewPersonName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(130, 300);
            this.MaximizeBox = false;
            this.Name = "NewPersonWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Új ügyfél";
            this.Load += new System.EventHandler(this.NewPersonWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveNewPersonName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelTextBoxFirstnameError;
        private System.Windows.Forms.Label labelTextBoxSecondNameError;
        private System.Windows.Forms.TextBox textBoxPersonLocation;
        private System.Windows.Forms.Label labelPersonLocation;
        private System.Windows.Forms.Label labelTextBoxLocationError;
    }
}