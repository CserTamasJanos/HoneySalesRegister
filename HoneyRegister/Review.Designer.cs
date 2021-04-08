namespace MéhészPróbálkozás1
{
    partial class Review
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
            this.labelFirstText = new System.Windows.Forms.Label();
            this.labelSecondText = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTheDataIsOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstText
            // 
            this.labelFirstText.AutoSize = true;
            this.labelFirstText.Location = new System.Drawing.Point(127, 10);
            this.labelFirstText.Name = "labelFirstText";
            this.labelFirstText.Size = new System.Drawing.Size(120, 13);
            this.labelFirstText.TabIndex = 0;
            this.labelFirstText.Text = "Minden adat megfelelő?";
            // 
            // labelSecondText
            // 
            this.labelSecondText.AutoSize = true;
            this.labelSecondText.Location = new System.Drawing.Point(70, 33);
            this.labelSecondText.Name = "labelSecondText";
            this.labelSecondText.Size = new System.Drawing.Size(248, 13);
            this.labelSecondText.TabIndex = 1;
            this.labelSecondText.Text = "Ha javítani szeretne akkor nyomjon Vissza gombot!";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 56);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Vissza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTheDataIsOK
            // 
            this.buttonTheDataIsOK.Location = new System.Drawing.Point(297, 56);
            this.buttonTheDataIsOK.Name = "buttonTheDataIsOK";
            this.buttonTheDataIsOK.Size = new System.Drawing.Size(75, 23);
            this.buttonTheDataIsOK.TabIndex = 3;
            this.buttonTheDataIsOK.Text = "Megfelelő";
            this.buttonTheDataIsOK.UseVisualStyleBackColor = true;
            this.buttonTheDataIsOK.Click += new System.EventHandler(this.buttonTheDataIsOK_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 91);
            this.Controls.Add(this.buttonTheDataIsOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSecondText);
            this.Controls.Add(this.labelFirstText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Review";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adatellenőrzés";
            this.Load += new System.EventHandler(this.Review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstText;
        private System.Windows.Forms.Label labelSecondText;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTheDataIsOK;
    }
}