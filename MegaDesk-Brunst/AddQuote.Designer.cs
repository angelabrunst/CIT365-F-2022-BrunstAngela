namespace MegaDesk_Brunst
{
    partial class AddQuote
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
            this.returnHomeQuoteButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.rushDaysInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.DepthInput = new System.Windows.Forms.TextBox();
            this.NumOfDrawersInput = new System.Windows.Forms.TextBox();
            this.SurfaceMaterialsSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // returnHomeQuoteButton
            // 
            this.returnHomeQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.returnHomeQuoteButton.Location = new System.Drawing.Point(12, 9);
            this.returnHomeQuoteButton.Name = "returnHomeQuoteButton";
            this.returnHomeQuoteButton.Size = new System.Drawing.Size(159, 45);
            this.returnHomeQuoteButton.TabIndex = 0;
            this.returnHomeQuoteButton.Text = "Main Menu";
            this.returnHomeQuoteButton.UseVisualStyleBackColor = true;
            this.returnHomeQuoteButton.Click += new System.EventHandler(this.returnHomeQuoteButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(81, 131);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(132, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Customer Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Quote";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rush Order Days:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desk Width: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desk Depth: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of Drawers: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Surface Materials: ";
            // 
            // submitBtn
            // 
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submitBtn.Location = new System.Drawing.Point(299, 435);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(159, 45);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "&Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(255, 131);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(419, 26);
            this.customerNameInput.TabIndex = 9;
            // 
            // rushDaysInput
            // 
            this.rushDaysInput.Location = new System.Drawing.Point(255, 179);
            this.rushDaysInput.Name = "rushDaysInput";
            this.rushDaysInput.Size = new System.Drawing.Size(419, 26);
            this.rushDaysInput.TabIndex = 10;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(255, 228);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(419, 26);
            this.widthInput.TabIndex = 11;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.WidthInput_Validating);
            // 
            // DepthInput
            // 
            this.DepthInput.Location = new System.Drawing.Point(255, 275);
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(419, 26);
            this.DepthInput.TabIndex = 12;
            this.DepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthInput_KeyPress);
            // 
            // NumOfDrawersInput
            // 
            this.NumOfDrawersInput.Location = new System.Drawing.Point(255, 324);
            this.NumOfDrawersInput.Name = "NumOfDrawersInput";
            this.NumOfDrawersInput.Size = new System.Drawing.Size(419, 26);
            this.NumOfDrawersInput.TabIndex = 13;
            // 
            // SurfaceMaterialsSelect
            // 
            this.SurfaceMaterialsSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SurfaceMaterialsSelect.FormattingEnabled = true;
            this.SurfaceMaterialsSelect.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.SurfaceMaterialsSelect.Location = new System.Drawing.Point(255, 372);
            this.SurfaceMaterialsSelect.Name = "SurfaceMaterialsSelect";
            this.SurfaceMaterialsSelect.Size = new System.Drawing.Size(419, 28);
            this.SurfaceMaterialsSelect.TabIndex = 14;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.SurfaceMaterialsSelect);
            this.Controls.Add(this.NumOfDrawersInput);
            this.Controls.Add(this.DepthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.rushDaysInput);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.returnHomeQuoteButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnHomeQuoteButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.TextBox rushDaysInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox DepthInput;
        private System.Windows.Forms.TextBox NumOfDrawersInput;
        private System.Windows.Forms.ComboBox SurfaceMaterialsSelect;
    }
}