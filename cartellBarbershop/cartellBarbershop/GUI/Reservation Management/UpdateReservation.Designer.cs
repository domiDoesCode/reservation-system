namespace cartellBarbershop.GUI.Reservation_Management
{
    partial class UpdateReservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newSIDBox = new System.Windows.Forms.TextBox();
            this.newBIDBox = new System.Windows.Forms.TextBox();
            this.newResDateBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.findBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newSIDBox);
            this.panel1.Controls.Add(this.newBIDBox);
            this.panel1.Controls.Add(this.newResDateBox);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Location = new System.Drawing.Point(1, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 256);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter new service id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter new barber id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter new new reservation date:";
            // 
            // newSIDBox
            // 
            this.newSIDBox.Location = new System.Drawing.Point(10, 169);
            this.newSIDBox.Name = "newSIDBox";
            this.newSIDBox.Size = new System.Drawing.Size(199, 23);
            this.newSIDBox.TabIndex = 3;
            // 
            // newBIDBox
            // 
            this.newBIDBox.Location = new System.Drawing.Point(10, 108);
            this.newBIDBox.Name = "newBIDBox";
            this.newBIDBox.Size = new System.Drawing.Size(199, 23);
            this.newBIDBox.TabIndex = 2;
            // 
            // newResDateBox
            // 
            this.newResDateBox.Location = new System.Drawing.Point(10, 55);
            this.newResDateBox.Name = "newResDateBox";
            this.newResDateBox.Size = new System.Drawing.Size(199, 23);
            this.newResDateBox.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(299, 220);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(299, 42);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findBox
            // 
            this.findBox.Location = new System.Drawing.Point(12, 42);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(199, 23);
            this.findBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the reservation number of the reservation you want to update:";
            // 
            // UpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.findBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateReservation";
            this.Text = "UpdateReservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox newSIDBox;
        private TextBox newBIDBox;
        private TextBox newResDateBox;
        private Button updateButton;
        private Button findButton;
        private TextBox findBox;
        private Label label1;
    }
}