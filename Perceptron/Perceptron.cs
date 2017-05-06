
using System;
using System.Windows.Forms;

namespace Perceptron{
    class Perceptron{

        double[] pesos;

        public Perceptron(int _NumEntradas, int _NumPadroes){

            Random random = new Random();

            pesos = new double[_NumEntradas + 1];
            pesos[0] = random.NextDouble() * (random.Next(0, 1) == 0 ? -1 : 1);
            pesos[1] = random.NextDouble() * (random.Next(0, 1) == 0 ? -1 : 1);
            pesos[2] = random.NextDouble() * (random.Next(0, 1) == 0 ? -1 : 1);
            //TODO: Criar pesos aleatórios entre -1 e 1
        }

        public string exibePesos()
        {
            string meuTexto = "";

            for (int iCount = 0; iCount < pesos.Length; iCount++)
            {
                meuTexto += "w" + iCount + " = " + pesos[iCount] + "\n";
            }

            return meuTexto;
        }

        public string exibeMatriz(int [,] padroes, int [] yDesejado, int [] y, int [] erro)
        {
            int numLinhas = padroes.Length / padroes.Rank;
            int numColunas = padroes.Rank;

            string tabela = "";

            for (int linha = -1; linha < numLinhas; linha++)
            {
                if (linha == -1)
                {
                    for (int coluna_aux = 0; coluna_aux < numColunas; coluna_aux++)
                    {
                        tabela += "x" + (coluna_aux + 1) + "\t";
                    }
                    tabela += "yd\t" + "y\t" + "e";
                }
                else
                {
                    for (int coluna = 0; coluna < numColunas + 3; coluna++)
                    {
                        if (coluna >= numColunas)
                        {
                            if (coluna == numColunas)
                            {
                                tabela += yDesejado[linha] + "\t";
                            }
                            if (coluna == numColunas + 1)
                            {
                                tabela += y[linha] + "\t";
                            }
                            if (coluna == numColunas + 2)
                            {
                                tabela += erro[linha] + "\t";
                            }
                        }
                        else
                        {
                            tabela += padroes[linha, coluna] + "\t";
                        }
                    }
                }
                tabela += "\n";
            }

            return tabela;
        }

        public void treinar(int [,] padroes, int [] yDesejado, double taxaDeAprendizado, string tituloTreinamento){
            Console.Write("\n\n\n==================================================\n" + tituloTreinamento +"\n==================================================\n");

            bool temErro = true;
            int numIteracoes = 0;

            int numLinhas = padroes.Length / padroes.Rank;
            int numColunas = padroes.Rank;

            int[] y = new int[numLinhas];
            int[] erro = new int[numLinhas];
            double[] somatorio = new double[numLinhas];

            // Enquanto há erro, executa o algoritmo
            while (temErro){

                temErro = false;

                numIteracoes++;

                if (numIteracoes == 1)
                    Console.Write("\n=========================\nPesos iniciais:\n" + exibePesos());

                // Percorre todas as linhas do AND
                for (int linha = 0; linha < numLinhas; linha++)
                {
                    somatorio[linha] = 0;

                    // Percorre todas as colunas de x0 até xN de uma linha
                    for (int coluna = 0; coluna <= numColunas; coluna++)
                    {
                        somatorio[linha] += pesos[coluna] * (coluna == 0 ? 1 : padroes[linha, coluna - 1]);
                    }

                    // Atualiza o valor de Y
                    y[linha] = (somatorio[linha] >= 0 ? 1 : 0);

                    // Atualiza a incidência de erro
                    erro[linha] = yDesejado[linha] - y[linha];
                    if (erro[linha] != 0)
                    {
                        temErro = true;

                        // Atualizando os pesos
                        for (int iCount = 0; iCount < pesos.Length; iCount++)
                        {
                            pesos[iCount] = pesos[iCount] + taxaDeAprendizado * erro[linha] * (iCount == 0 ? 1 : padroes[linha, iCount - 1]);
                        }

                    }

                }

                //Atualiza os pesos
                if (temErro)
                {
                    //w(t + 1) = wi(t) + taxaDeAprendizado * erro * xi(t)
                }

            }

            Console.Write("\n=========================\nSem erro com " + numIteracoes + " iterações\n\nTabela:\n" + exibeMatriz(padroes, yDesejado, y, erro) + "\n\nPesos:\n" + exibePesos());
            

        }
    }
}
