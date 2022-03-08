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
            this.createButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.findBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(12, 12);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(100, 50);
            this.connectionButton.TabIndex = 0;
            this.connectionButton.Text = "Connect";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(423, 367);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(102, 46);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(97, 239);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(202, 23);
            this.nameBox.TabIndex = 2;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(97, 280);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(202, 23);
            this.surnameBox.TabIndex = 3;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(97, 318);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(202, 23);
            this.phoneBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(423, 26);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(83, 27);
            this.findButton.TabIndex = 8;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findBox
            // 
            this.findBox.Location = new System.Drawing.Point(281, 26);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(121, 23);
            this.findBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.connectionButton);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button connectionButton;
        private Button createButton;
        private TextBox nameBox;
        private TextBox surnameBox;
        private TextBox phoneBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button findButton;
        private TextBox findBox;
        private Label label4;
    }
}