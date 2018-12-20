namespace ChapooApplication.UI
{
    partial class DrinksChoosen
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
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(159, 0);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(165, 49);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 446);
            this.Controls.Add(this.button_Back);
            this.Name = "Drinks";
            this.Text = "Drinks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
    }
}