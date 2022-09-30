namespace MegaDesk_Brunst
{
    partial class DisplayQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnHomeQuoteButton
            // 
            this.returnHomeQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.returnHomeQuoteButton.Location = new System.Drawing.Point(12, 12);
            this.returnHomeQuoteButton.Name = "returnHomeQuoteButton";
            this.returnHomeQuoteButton.Size = new System.Drawing.Size(159, 45);
            this.returnHomeQuoteButton.TabIndex = 1;
            this.returnHomeQuoteButton.Text = "Main Menu";
            this.returnHomeQuoteButton.UseVisualStyleBackColor = true;
            this.returnHomeQuoteButton.Click += new System.EventHandler(this.returnHomeQuoteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Quote Submitted";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnHomeQuoteButton);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnHomeQuoteButton;
        private System.Windows.Forms.Label label1;
    }
}