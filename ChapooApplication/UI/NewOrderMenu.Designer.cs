namespace ChapooApplication.UI
{
    partial class NewOrderMenu
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.button_Drinks = new System.Windows.Forms.Button();
            this.button_Food = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_tablenrText = new System.Windows.Forms.Label();
            this.label_TableId = new System.Windows.Forms.Label();
            this.listView_OrderItems = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(159, 0);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(165, 49);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(0, 397);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(324, 49);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_Drinks
            // 
            this.button_Drinks.Location = new System.Drawing.Point(0, 67);
            this.button_Drinks.Name = "button_Drinks";
            this.button_Drinks.Size = new System.Drawing.Size(148, 49);
            this.button_Drinks.TabIndex = 2;
            this.button_Drinks.Text = "Drinks";
            this.button_Drinks.UseVisualStyleBackColor = true;
            this.button_Drinks.Click += new System.EventHandler(this.button_Drinks_Click);
            // 
            // button_Food
            // 
            this.button_Food.Location = new System.Drawing.Point(176, 67);
            this.button_Food.Name = "button_Food";
            this.button_Food.Size = new System.Drawing.Size(148, 49);
            this.button_Food.TabIndex = 3;
            this.button_Food.Text = "Food";
            this.button_Food.UseVisualStyleBackColor = true;
            this.button_Food.Click += new System.EventHandler(this.button_Food_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(0, 135);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(108, 49);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_min
            // 
            this.button_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_min.Location = new System.Drawing.Point(108, 135);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(108, 49);
            this.button_min.TabIndex = 5;
            this.button_min.Text = "-";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(216, 135);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(108, 49);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "x";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_tablenrText
            // 
            this.label_tablenrText.AutoSize = true;
            this.label_tablenrText.Location = new System.Drawing.Point(12, 18);
            this.label_tablenrText.Name = "label_tablenrText";
            this.label_tablenrText.Size = new System.Drawing.Size(46, 13);
            this.label_tablenrText.TabIndex = 7;
            this.label_tablenrText.Text = "Tablenr:";
            // 
            // label_TableId
            // 
            this.label_TableId.AutoSize = true;
            this.label_TableId.Location = new System.Drawing.Point(72, 18);
            this.label_TableId.Name = "label_TableId";
            this.label_TableId.Size = new System.Drawing.Size(51, 13);
            this.label_TableId.TabIndex = 8;
            this.label_TableId.Text = "No Table";
            this.label_TableId.Click += new System.EventHandler(this.label_TableId_Click);
            // 
            // listView_OrderItems
            // 
            this.listView_OrderItems.FullRowSelect = true;
            this.listView_OrderItems.Location = new System.Drawing.Point(1, 194);
            this.listView_OrderItems.Name = "listView_OrderItems";
            this.listView_OrderItems.Size = new System.Drawing.Size(322, 203);
            this.listView_OrderItems.TabIndex = 9;
            this.listView_OrderItems.UseCompatibleStateImageBehavior = false;
            this.listView_OrderItems.View = System.Windows.Forms.View.Details;
            // 
            // NewOrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 446);
            this.Controls.Add(this.listView_OrderItems);
            this.Controls.Add(this.label_TableId);
            this.Controls.Add(this.label_tablenrText);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_Food);
            this.Controls.Add(this.button_Drinks);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_back);
            this.Name = "NewOrderMenu";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_Drinks;
        private System.Windows.Forms.Button button_Food;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_tablenrText;
        private System.Windows.Forms.Label label_TableId;
        private System.Windows.Forms.ListView listView_OrderItems;
    }
}