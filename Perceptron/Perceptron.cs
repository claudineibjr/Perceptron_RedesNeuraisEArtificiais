
namespace Perceptron{
    class Perceptron{

        double[] pesos;

        public Perceptron(int _NumEntradas){
            pesos = new double[_NumEntradas + 1];
            pesos[0] = 0.3;
            pesos[1] = -0.5;
            pesos[2] = 0.2;
            //TODO: Criar pesos aleatórios entre -1 e 1
        }

        public double somatorio(int [] entradas){
            double _somatorio = 0;

            for (int i = 0; i < pesos.Length; i++){
                _somatorio += pesos[i] * (i == 0 ? 1 : entradas[i-1] );
            }

            return _somatorio;
        }

        public int Y(int[] entradas){
            if (somatorio(entradas) >= 0)
                return 1;
            else
                return 0;
        }

        public void treinar(int [,] padroes, int [] dj, float taxaDeAprendizado){
            bool temErro = false;

            //w(t+1) = wi(t) + n *e*xi(t)

            //TODO: Atualizar pesos

            for (int i = 0; i < pesos.Length; i++){
                
                //double _pesoAuxiliar = 

            }

            while (temErro){

            }
        }
    }
}
