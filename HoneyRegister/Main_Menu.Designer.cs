namespace MéhészPróbálkozás1
{
    partial class MainMenu
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
            this.button_Data_Input = new System.Windows.Forms.Button();
            this.button_Data_Output = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Data_Input
            // 
            this.button_Data_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Data_Input.Location = new System.Drawing.Point(41, 10);
            this.button_Data_Input.Name = "button_Data_Input";
            this.button_Data_Input.Size = new System.Drawing.Size(200, 30);
            this.button_Data_Input.TabIndex = 1;
            this.button_Data_Input.Text = "Adatbevitel";
            this.button_Data_Input.UseVisualStyleBackColor = true;
            this.button_Data_Input.Click += new System.EventHandler(this.buttonDataInput_Click);
            // 
            // button_Data_Output
            // 
            this.button_Data_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Data_Output.Location = new System.Drawing.Point(41, 50);
            this.button_Data_Output.Name = "button_Data_Output";
            this.button_Data_Output.Size = new System.Drawing.Size(200, 30);
            this.button_Data_Output.TabIndex = 2;
            this.button_Data_Output.Text = "Korábbi adatok";
            this.button_Data_Output.UseVisualStyleBackColor = true;
            this.button_Data_Output.Click += new System.EventHandler(this.button_Data_Output_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Close.Location = new System.Drawing.Point(41, 90);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(200, 30);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "Kilépés";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Data_Output);
            this.Controls.Add(this.button_Data_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Data_Input;
        private System.Windows.Forms.Button button_Data_Output;
        private System.Windows.Forms.Button button_Close;
    }
}

