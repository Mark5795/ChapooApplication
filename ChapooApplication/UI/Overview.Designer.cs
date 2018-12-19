namespace ChapooApplication.UI
{
    partial class Overview
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
            this.button_LogOut = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_OrderReady = new System.Windows.Forms.Button();
            this.label_Overview = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button_LogOut
            // 
            this.button_LogOut.Location = new System.Drawing.Point(0, -1);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(144, 41);
            this.button_LogOut.TabIndex = 0;
            this.button_LogOut.Text = "Log Out";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(656, -1);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(144, 41);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_OrderReady
            // 
            this.button_OrderReady.Location = new System.Drawing.Point(0, 402);
            this.button_OrderReady.Name = "button_OrderReady";
            this.button_OrderReady.Size = new System.Drawing.Size(800, 48);
            this.button_OrderReady.TabIndex = 2;
            this.button_OrderReady.Text = "Order Ready";
            this.button_OrderReady.UseVisualStyleBackColor = true;
            this.button_OrderReady.Click += new System.EventHandler(this.button_OrderReady_Click);
            // 
            // label_Overview
            // 
            this.label_Overview.AutoSize = true;
            this.label_Overview.Location = new System.Drawing.Point(367, 13);
            this.label_Overview.Name = "label_Overview";
            this.label_Overview.Size = new System.Drawing.Size(0, 13);
            this.label_Overview.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 365);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_Overview);
            this.Controls.Add(this.button_OrderReady);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_LogOut);
            this.Name = "Overview";
            this.Text = "BarOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_OrderReady;
        private System.Windows.Forms.Label label_Overview;
        private System.Windows.Forms.ListView listView1;
    }
}