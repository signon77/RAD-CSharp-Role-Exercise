namespace RAD_CSharp_Role_Exercise
{
    partial class frmGetPaymentsPerPortfolio
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
            this.comboBoxPortfolios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGetPayments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPortfolios
            // 
            this.comboBoxPortfolios.FormattingEnabled = true;
            this.comboBoxPortfolios.Location = new System.Drawing.Point(91, 47);
            this.comboBoxPortfolios.Name = "comboBoxPortfolios";
            this.comboBoxPortfolios.Size = new System.Drawing.Size(153, 21);
            this.comboBoxPortfolios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Portfolios";
            // 
            // cmdGetPayments
            // 
            this.cmdGetPayments.Location = new System.Drawing.Point(91, 123);
            this.cmdGetPayments.Name = "cmdGetPayments";
            this.cmdGetPayments.Size = new System.Drawing.Size(137, 23);
            this.cmdGetPayments.TabIndex = 2;
            this.cmdGetPayments.Text = "Get Payments";
            this.cmdGetPayments.UseVisualStyleBackColor = true;
            this.cmdGetPayments.Click += new System.EventHandler(this.cmdGetPayments_Click);
            // 
            // frmGetPaymentsPerPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 258);
            this.Controls.Add(this.cmdGetPayments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPortfolios);
            this.Name = "frmGetPaymentsPerPortfolio";
            this.Text = "Get Payments Per Portfolio";
            this.Load += new System.EventHandler(this.frmGetPaymentsPerPortfolio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPortfolios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGetPayments;
    }
}

