using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cur
{
    public partial class MemeStock : Form
    {
        public MemeStock()
        {
            InitializeComponent();
        }

        private bool _started;

        private void UpdateForm()
        {
            label2.Text = Math.Round(Player.Rubles, 3).ToString();
            label3.Text = Math.Round(Player.Dollars, 3).ToString();
            label5.Text = Math.Round(Player.GetProfit(), 3).ToString();

            if (Player.Dollars >= 100)
            {
                btSell100.Visible = true;
                btSell10.Visible = true;
                btSell1.Visible = true;
            }
            else if (Player.Dollars >= 10)
            {
                btSell100.Visible = false;
                btSell10.Visible = true;
                btSell1.Visible = true;
            }
            else if (Player.Dollars >= 1)
            {
                btSell100.Visible = false;
                btSell10.Visible = false;
                btSell1.Visible = true;
            }
            else
            {
                btSell100.Visible = false;
                btSell10.Visible = false;
                btSell1.Visible = false;
            }

            if (Player.Rubles >= Stock.TransferRUB(100))
            {
                btBuy100.Visible = true;
                btBuy10.Visible = true;
                btBuy1.Visible = true;
            }
            else if (Player.Rubles >= Stock.TransferRUB(10))
            {
                btBuy100.Visible = false;
                btBuy10.Visible = true;
                btBuy1.Visible = true;
            }
            else if (Player.Rubles >= Stock.TransferRUB(1))
            {
                btBuy100.Visible = false;
                btBuy10.Visible = false;
                btBuy1.Visible = true;
            }
            else
            {
                btBuy100.Visible = false;
                btBuy10.Visible = false;
                btBuy1.Visible = false;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (!_started)
            {
                _started = true;
                Stock.InitStock((double) edRate.Value);
                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.AddXY(0, Stock.Rate);
                edRate.Enabled = false;
                label1.Enabled = false;
            }

            Stock.StepStock();
            UpdateForm();

            chart1.Series[0].Points.AddXY(Stock.Days, Stock.Rate);
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 15;
            if (Stock.Days <= 15) return;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.LineColor = Color.Aquamarine;
            chart1.ChartAreas[0].AxisX.ScrollBar.Axis.ScaleView.Position = Stock.Days - 15;
        }

        private void btBuy1_Click(object sender, EventArgs e)
        {
            Player.BuyUSD(1);
            UpdateForm();
        }

        private void btBuy10_Click(object sender, EventArgs e)
        {
            Player.BuyUSD(10);
            UpdateForm();
        }

        private void btBuy100_Click(object sender, EventArgs e)
        {
            Player.BuyUSD(100);
            UpdateForm();
        }

        private void btSell1_Click(object sender, EventArgs e)
        {
            Player.SellUSD(1);
            UpdateForm();
        }

        private void btSell10_Click(object sender, EventArgs e)
        {
            Player.SellUSD(10);
            UpdateForm();
        }

        private void btSell100_Click(object sender, EventArgs e)
        {
            Player.SellUSD(100);
            UpdateForm();
        }
    }

    public static class Stock
    {
        public static double Rate;
        public static int Days;
        private const double K = 0.02;
        private static readonly Random Random = new Random();

        public static void InitStock(double initRate)
        {
            Rate = initRate;
        }

        public static void StepStock()
        {
            Days++;
            Rate *= (1 + K * (Random.NextDouble() - 0.5));
        }

        public static double TransferRUB(double dollars)
        {
            return dollars * Rate;
        }
    }

    public static class Player
    {
        private const double StartBalance = 1000;
        public static double Dollars;
        public static double Rubles = StartBalance;

        public static void BuyUSD(int quantity)
        {
            var broker = Stock.TransferRUB(quantity) + Stock.TransferRUB(quantity) * 0.003;
            if (broker > Rubles) return;
            Rubles -= broker;
            Dollars += quantity;
        }

        public static void SellUSD(int quantity)
        {
            var broker = Stock.TransferRUB(quantity) - Stock.TransferRUB(quantity) * 0.003;
            if (Dollars < quantity) return;
            Dollars -= quantity;
            Rubles += broker;
        }

        public static double GetProfit()
        {
            return Rubles - StartBalance;
        }
    }
}