namespace ChapooApplication.UI
{
    partial class WaiterMenu
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
            this.button_NewOrder = new System.Windows.Forms.Button();
            this.button_ChangeOrder = new System.Windows.Forms.Button();
            this.button_OrderStatus = new System.Windows.Forms.Button();
            this.button_Checkout = new System.Windows.Forms.Button();
            this.button_tables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_LogOut
            // 
            this.button_LogOut.Location = new System.Drawing.Point(0, 0);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(167, 34);
            this.button_LogOut.TabIndex = 0;
            this.button_LogOut.Text = "Log Out";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_NewOrder
            // 
            this.button_NewOrder.Location = new System.Drawing.Point(43, 53);
            this.button_NewOrder.Name = "button_NewOrder";
            this.button_NewOrder.Size = new System.Drawing.Size(240, 55);
            this.button_NewOrder.TabIndex = 1;
            this.button_NewOrder.Text = "New Order";
            this.button_NewOrder.UseVisualStyleBackColor = true;
            this.button_NewOrder.Click += new System.EventHandler(this.button_NewOrder_Click);
            // 
            // button_ChangeOrder
            // 
            this.button_ChangeOrder.Location = new System.Drawing.Point(43, 130);
            this.button_ChangeOrder.Name = "button_ChangeOrder";
            this.button_ChangeOrder.Size = new System.Drawing.Size(240, 55);
            this.button_ChangeOrder.TabIndex = 2;
            this.button_ChangeOrder.Text = "Change Order";
            this.button_ChangeOrder.UseVisualStyleBackColor = true;
            this.button_ChangeOrder.Click += new System.EventHandler(this.button_ChangeOrder_Click);
            // 
            // button_OrderStatus
            // 
            this.button_OrderStatus.Location = new System.Drawing.Point(43, 206);
            this.button_OrderStatus.Name = "button_OrderStatus";
            this.button_OrderStatus.Size = new System.Drawing.Size(240, 55);
            this.button_OrderStatus.TabIndex = 3;
            this.button_OrderStatus.Text = "Order Status";
            this.button_OrderStatus.UseVisualStyleBackColor = true;
            this.button_OrderStatus.Click += new System.EventHandler(this.button_OrderStatus_Click);
            // 
            // button_Checkout
            // 
            this.button_Checkout.Location = new System.Drawing.Point(43, 279);
            this.button_Checkout.Name = "button_Checkout";
            this.button_Checkout.Size = new System.Drawing.Size(240, 55);
            this.button_Checkout.TabIndex = 4;
            this.button_Checkout.Text = "Checkout";
            this.button_Checkout.UseVisualStyleBackColor = true;
            this.button_Checkout.Click += new System.EventHandler(this.button_Checkout_Click);
            // 
            // button_tables
            // 
            this.button_tables.Location = new System.Drawing.Point(43, 354);
            this.button_tables.Name = "button_tables";
            this.button_tables.Size = new System.Drawing.Size(240, 55);
            this.button_tables.TabIndex = 5;
            this.button_tables.Text = "Tables";
            this.button_tables.UseVisualStyleBackColor = true;
            this.button_tables.Click += new System.EventHandler(this.button_tables_Click);
            // 
            // WaiterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 446);
            this.Controls.Add(this.button_tables);
            this.Controls.Add(this.button_Checkout);
            this.Controls.Add(this.button_OrderStatus);
            this.Controls.Add(this.button_ChangeOrder);
            this.Controls.Add(this.button_NewOrder);
            this.Controls.Add(this.button_LogOut);
            this.Name = "WaiterMenu";
            this.Text = "WaiterMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Button button_NewOrder;
        private System.Windows.Forms.Button button_ChangeOrder;
        private System.Windows.Forms.Button button_OrderStatus;
        private System.Windows.Forms.Button button_Checkout;
        private System.Windows.Forms.Button button_tables;
    }
}