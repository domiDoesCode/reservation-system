namespace cartellBarbershop.GUI.Reservation_Management
{
    partial class ReservationMenu
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
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.cidBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resNoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resDateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bidBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sidbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.findbox = new System.Windows.Forms.TextBox();
            this.findButton2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bidBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sidbox);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.cidBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.resNoBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.resDateBox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 451);
            this.panel1.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(259, 338);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(102, 46);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(140, 338);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 46);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer Id:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(20, 338);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(102, 46);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cidBox
            // 
            this.cidBox.Location = new System.Drawing.Point(140, 109);
            this.cidBox.Name = "cidBox";
            this.cidBox.Size = new System.Drawing.Size(202, 23);
            this.cidBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Reservation Date:";
            // 
            // resNoBox
            // 
            this.resNoBox.Location = new System.Drawing.Point(140, 20);
            this.resNoBox.Name = "resNoBox";
            this.resNoBox.Size = new System.Drawing.Size(202, 23);
            this.resNoBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reservation Number:";
            // 
            // resDateBox
            // 
            this.resDateBox.Location = new System.Drawing.Point(140, 65);
            this.resDateBox.Name = "resDateBox";
            this.resDateBox.Size = new System.Drawing.Size(202, 23);
            this.resDateBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Service Id:";
            // 
            // bidBox
            // 
            this.bidBox.Location = new System.Drawing.Point(140, 147);
            this.bidBox.Name = "bidBox";
            this.bidBox.Size = new System.Drawing.Size(202, 23);
            this.bidBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Barber Id:";
            // 
            // sidbox
            // 
            this.sidbox.Location = new System.Drawing.Point(140, 192);
            this.sidbox.Name = "sidbox";
            this.sidbox.Size = new System.Drawing.Size(202, 23);
            this.sidbox.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.findbox);
            this.panel2.Controls.Add(this.findButton2);
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Location = new System.Drawing.Point(391, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 180);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Reservation List:";
            // 
            // findbox
            // 
            this.findbox.Location = new System.Drawing.Point(150, 20);
            this.findbox.Name = "findbox";
            this.findbox.Size = new System.Drawing.Size(175, 23);
            this.findbox.TabIndex = 2;
            // 
            // findButton2
            // 
            this.findButton2.Location = new System.Drawing.Point(366, 16);
            this.findButton2.Name = "findButton2";
            this.findButton2.Size = new System.Drawing.Size(79, 29);
            this.findButton2.TabIndex = 1;
            this.findButton2.Text = "Find";
            this.findButton2.UseVisualStyleBackColor = true;
            this.findButton2.Click += new System.EventHandler(this.findButton2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(18, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(427, 106);
            this.dataGridView.TabIndex = 0;
            // 
            // ReservationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationMenu";
            this.Text = "ReservationMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox bidBox;
        private Label label6;
        private TextBox sidbox;
        private Button updateButton;
        private Button deleteButton;
        private Label label3;
        private Button createButton;
        private TextBox cidBox;
        private Label label2;
        private TextBox resNoBox;
        private Label label1;
        private TextBox resDateBox;
        private Panel panel2;
        private Label label4;
        public TextBox findbox;
        private Button findButton2;
        public DataGridView dataGridView;
    }
}