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

            float taxaDeAprendizado = 0.2f;

            p.treinar(padroes, dj, taxaDeAprendizado);

            int[] ent1 = { 0, 0 };
            int[] ent2 = { 0, 1 };
            int[] ent3 = { 1, 0 };
            int[] ent4 = { 1, 1 };
            Console.WriteLine("0, 0 = " + p.Y(ent1));
            Console.WriteLine("0, 1 = " + p.Y(ent2));
            Console.WriteLine("1, 0 = " + p.Y(ent3));
            Console.WriteLine("1, 1 = " + p.Y(ent4));
        }
    }
}