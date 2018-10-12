using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contracts;

namespace BinanceView
{
    public partial class PortfolioForm : Form, IBinanceViewer
    {
        private readonly DataTable _portfolioBalances;
        public Dictionary<string, decimal> PortfolioBalances
        {
            set
            {
                this._portfolioBalances.Columns.Add("Currency", typeof(string));
                this._portfolioBalances.Columns.Add("Balance", typeof(decimal));

                foreach (var currency in value)
                {
                    this._portfolioBalances.Rows.Add(currency.Key, currency.Value);
                }
            }
        }

        public PortfolioForm()
        {
            InitializeComponent();
            this._portfolioBalances = new DataTable();
            var presenter = new Presenter(this);
            this.DataGrid_BalanceInVariousCurrencies.DataSource = this._portfolioBalances;
        }
    }
}
