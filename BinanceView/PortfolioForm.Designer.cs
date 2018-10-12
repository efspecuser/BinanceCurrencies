namespace BinanceView
{
    partial class PortfolioForm
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
            this.components = new System.ComponentModel.Container();
            this.DataGrid_BalanceInVariousCurrencies = new System.Windows.Forms.DataGridView();
            this.portfolioFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_BalanceInVariousCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_BalanceInVariousCurrencies
            // 
            this.DataGrid_BalanceInVariousCurrencies.AllowUserToAddRows = false;
            this.DataGrid_BalanceInVariousCurrencies.AllowUserToDeleteRows = false;
            this.DataGrid_BalanceInVariousCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_BalanceInVariousCurrencies.Location = new System.Drawing.Point(12, 12);
            this.DataGrid_BalanceInVariousCurrencies.Name = "DataGrid_BalanceInVariousCurrencies";
            this.DataGrid_BalanceInVariousCurrencies.ReadOnly = true;
            this.DataGrid_BalanceInVariousCurrencies.Size = new System.Drawing.Size(253, 208);
            this.DataGrid_BalanceInVariousCurrencies.TabIndex = 0;
            // 
            // portfolioFormBindingSource
            // 
            this.portfolioFormBindingSource.DataSource = typeof(BinanceView.PortfolioForm);
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 231);
            this.Controls.Add(this.DataGrid_BalanceInVariousCurrencies);
            this.Name = "PortfolioForm";
            this.Text = "Portfolio currencies";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_BalanceInVariousCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_BalanceInVariousCurrencies;
        private System.Windows.Forms.BindingSource portfolioFormBindingSource;
    }
}

