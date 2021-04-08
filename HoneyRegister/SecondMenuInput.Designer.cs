namespace MéhészPróbálkozás1
{
    partial class SecondMenuInput
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
            this.button_Harwest_Input = new System.Windows.Forms.Button();
            this.button_Sale = new System.Windows.Forms.Button();
            this.button_Back_To_Main_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Harwest_Input
            // 
            this.button_Harwest_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Harwest_Input.Location = new System.Drawing.Point(66, 10);
            this.button_Harwest_Input.Name = "button_Harwest_Input";
            this.button_Harwest_Input.Size = new System.Drawing.Size(150, 25);
            this.button_Harwest_Input.TabIndex = 0;
            this.button_Harwest_Input.Text = "Pergetés";
            this.button_Harwest_Input.UseVisualStyleBackColor = true;
            this.button_Harwest_Input.Click += new System.EventHandler(this.buttonHarwestInput_Click);
            // 
            // button_Sale
            // 
            this.button_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Sale.Location = new System.Drawing.Point(66, 45);
            this.button_Sale.Name = "button_Sale";
            this.button_Sale.Size = new System.Drawing.Size(150, 25);
            this.button_Sale.TabIndex = 1;
            this.button_Sale.Text = "Eladás";
            this.button_Sale.UseVisualStyleBackColor = true;
            this.button_Sale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // button_Back_To_Main_Menu
            // 
            this.button_Back_To_Main_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Back_To_Main_Menu.Location = new System.Drawing.Point(66, 80);
            this.button_Back_To_Main_Menu.Name = "button_Back_To_Main_Menu";
            this.button_Back_To_Main_Menu.Size = new System.Drawing.Size(150, 25);
            this.button_Back_To_Main_Menu.TabIndex = 3;
            this.button_Back_To_Main_Menu.Text = "Vissza";
            this.button_Back_To_Main_Menu.UseVisualStyleBackColor = true;
            this.button_Back_To_Main_Menu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // SecondMenuInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.button_Back_To_Main_Menu);
            this.Controls.Add(this.button_Sale);
            this.Controls.Add(this.button_Harwest_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SecondMenuInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adatbevitel";
            this.Load += new System.EventHandler(this.SecondMenuInput_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Harwest_Input;
        private System.Windows.Forms.Button button_Sale;
        private System.Windows.Forms.Button button_Back_To_Main_Menu;
    }
}