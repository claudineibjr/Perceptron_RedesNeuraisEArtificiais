using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Cria um Perceptron com 2 entradas e 4 padrões
            Perceptron p = new Perceptron(2, 4);

            // Treinamento AND
            int[,] padroes = {  {0, 0},
                                {0, 1},
                                {1, 0},
                                {1, 1}};

            int[] yDesejado_AND = { 0,
                                    0,
                                    0,
                                    1};

            double taxaDeAprendizado = 0.2;

            p.treinar(padroes, yDesejado_AND, taxaDeAprendizado, "Treinamento AND");

            // Treinamento OR
            int[] yDesejado_OR = {  0,
                                    1,
                                    1,
                                    1};

            p.treinar(padroes, yDesejado_OR, taxaDeAprendizado, "Treinamento OR");

            // Treinamento A ou T
            /*int[,] padroes_A_T = {  {   1, 1, 1, 1, 1,
                                        1, 0, 0, 0, 1,
                                        1, 1, 1, 1, 1,
                                        1, 0, 0, 0, 1,
                                        1, 0, 0, 0, 1},

                                    {   1, 1, 1, 1, 1,
                                        0, 0, 1, 0, 0,
                                        0, 0, 1, 0, 0,
                                        0, 0, 1, 0, 0,
                                        0, 0, 1, 0, 0 }};

            int[] yDesejado_A_T = { 0,
                                    1 };

            p.treinar(padroes_A_T, yDesejado_A_T, taxaDeAprendizado, "Treinamento T ou A");*/

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}
