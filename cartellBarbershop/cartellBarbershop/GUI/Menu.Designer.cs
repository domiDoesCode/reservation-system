namespace cartellBarbershop
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionButton = new System.Windows.Forms.Button();
            this.customerMenu = new System.Windows.Forms.Button();
            this.reservationMenuButton = new System.Windows.Forms.Button();
            this.barberMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(12, 12);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(64, 24);
            this.connectionButton.TabIndex = 0;
            this.connectionButton.Text = "Connect";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // customerMenu
            // 
            this.customerMenu.Location = new System.Drawing.Point(36, 75);
            this.customerMenu.Name = "customerMenu";
            this.customerMenu.Size = new System.Drawing.Size(146, 55);
            this.customerMenu.TabIndex = 12;
            this.customerMenu.Text = "Customer Menu";
            this.customerMenu.UseVisualStyleBackColor = true;
            this.customerMenu.Click += new System.EventHandler(this.customerMenu_Click);
            // 
            // reservationMenuButton
            // 
            this.reservationMenuButton.Location = new System.Drawing.Point(36, 145);
            this.reservationMenuButton.Name = "reservationMenuButton";
            this.reservationMenuButton.Size = new System.Drawing.Size(146, 55);
            this.reservationMenuButton.TabIndex = 13;
            this.reservationMenuButton.Text = "Reservation Menu";
            this.reservationMenuButton.UseVisualStyleBackColor = true;
            this.reservationMenuButton.Click += new System.EventHandler(this.reservationMenuButton_Click);
            // 
            // barberMenuButton
            // 
            this.barberMenuButton.Location = new System.Drawing.Point(36, 217);
            this.barberMenuButton.Name = "barberMenuButton";
            this.barberMenuButton.Size = new System.Drawing.Size(146, 55);
            this.barberMenuButton.TabIndex = 14;
            this.barberMenuButton.Text = "Barber Menu";
            this.barberMenuButton.UseVisualStyleBackColor = true;
            this.barberMenuButton.Click += new System.EventHandler(this.barberMenuButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 361);
            this.Controls.Add(this.barberMenuButton);
            this.Controls.Add(this.reservationMenuButton);
            this.Controls.Add(this.customerMenu);
            this.Controls.Add(this.connectionButton);
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button connectionButton;
        private Button customerMenu;
        private Button reservationMenuButton;
        private Button barberMenuButton;
    }
}