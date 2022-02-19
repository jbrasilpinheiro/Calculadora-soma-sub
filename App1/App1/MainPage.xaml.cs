using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {

        int resultado = 0;
        int instance = 0;

        public MainPage()
        {
            InitializeComponent();
            Value.Text = resultado.ToString();
        }

        private void Button_Clicked_Soma(object sender, EventArgs e)
        {
            if (Value.Text != "")
            {
                if (instance == 2)
                {
                    resultado -= Int32.Parse(Value.Text);
                    Conta.Text = resultado.ToString() + " + ";
                    Value.Text = "";
                }
                else
                {
                    resultado += Int32.Parse(Value.Text);
                    Conta.Text = resultado.ToString() + " + ";
                    Value.Text = "";
                }
                instance = 1;
            }
        }

        private void Button_Clicked_Sub(object sender, EventArgs e)
        {
            if (Value.Text != "")
            {
                if (instance == 1 || instance == 0 || instance == 3)
                {
                    resultado += Int32.Parse(Value.Text);
                    Conta.Text = resultado.ToString() + " - ";
                    Value.Text = "";
                }
                else
                {
                    resultado -= Int32.Parse(Value.Text);
                    Conta.Text = resultado.ToString() + " - ";
                    Value.Text = "";
                }
            
                instance = 2;
            }
        }

        private void Button_Clicked_Equal(object sender, EventArgs e)
        {
            if (Value.Text != "")
            {
                if (instance == 1)
                {
                    resultado += Int32.Parse(Value.Text);
                    Conta.Text = "Resultado: " + resultado.ToString();
                    Value.Text = resultado.ToString();
                }
                else if (instance == 2)
                {
                    resultado -= Int32.Parse(Value.Text);
                    Conta.Text = "Resultado: " + resultado.ToString();
                    Value.Text = resultado.ToString();
                }
                else
                {
                    resultado = 0;
                    Value.Text = resultado.ToString();
                }
                if (instance != 0)
                {
                    instance = 3;
                    resultado = 0;
                }   
            }
        }
    }
}
