using System;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cria um Perceptron com 2 entradas
            Perceptron p = new Perceptron(2);

            int[,] padroes = {  {0, 0},
                                {0, 1 },
                                {1, 0 },
                                {1, 1 }
                            };

            int[] dj = {
                            0,
                            0,
                            0,
                            1
                        };

            double taxaDeAprendizado = 0.2;

            p.treinar(padroes, dj, taxaDeAprendizado);
        }
    }
}