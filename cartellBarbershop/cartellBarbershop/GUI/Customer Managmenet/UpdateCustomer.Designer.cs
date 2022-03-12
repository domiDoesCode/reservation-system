namespace cartellBarbershop.GUI
{
    partial class UpdateCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.findBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPhoneBox = new System.Windows.Forms.TextBox();
            this.newLastNameBox = new System.Windows.Forms.TextBox();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the phone number of the customer you want to update:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // findBox
            // 
            this.findBox.Location = new System.Drawing.Point(12, 59);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(199, 23);
            this.findBox.TabIndex = 1;
            this.findBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(269, 59);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newPhoneBox);
            this.panel1.Controls.Add(this.newLastNameBox);
            this.panel1.Controls.Add(this.newNameBox);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Location = new System.Drawing.Point(1, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 246);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter new Phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter new Last name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter new First name:";
            // 
            // newPhoneBox
            // 
            this.newPhoneBox.Location = new System.Drawing.Point(10, 169);
            this.newPhoneBox.Name = "newPhoneBox";
            this.newPhoneBox.Size = new System.Drawing.Size(199, 23);
            this.newPhoneBox.TabIndex = 3;
            // 
            // newLastNameBox
            // 
            this.newLastNameBox.Location = new System.Drawing.Point(10, 108);
            this.newLastNameBox.Name = "newLastNameBox";
            this.newLastNameBox.Size = new System.Drawing.Size(199, 23);
            this.newLastNameBox.TabIndex = 2;
            // 
            // newNameBox
            // 
            this.newNameBox.Location = new System.Drawing.Point(10, 55);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(199, 23);
            this.newNameBox.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(267, 215);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.findBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCustomer";
            this.Text = "Update Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox findBox;
        private Button findButton;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox newPhoneBox;
        private TextBox newLastNameBox;
        private TextBox newNameBox;
        private Button updateButton;
    }
}