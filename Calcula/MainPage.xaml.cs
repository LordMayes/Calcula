using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calcula
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            pkOper.Items.Add("Sumar");
            pkOper.Items.Add("Restar");
            pkOper.Items.Add("Multiplicar");
            pkOper.Items.Add("Dividir");
        }

        private void pkOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            String op = pkOper.SelectedItem.ToString();
            int n1 = Int32.Parse(txtN1.Text);
            int n2 = Int32.Parse(txtN2.Text);
            double res = 0;

            if (op == "Sumar")
                res = n1 + n2;
            else if (op == "Restar")
                res = n1 - n2;
            else if (op == "Multiplicar")
                res = n1 * n2;
            else
                res = n1 / n2;


            lblRes.Text = res + "";
        }
    }
}
