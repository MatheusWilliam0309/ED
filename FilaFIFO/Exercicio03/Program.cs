namespace Exercicio03
{
    class No
    {
        public int Valor;
        public No Proximo;
        public No(int valor) { Valor = valor; }
    }

    class FilaReversa
    {
        private No inicio;

        public void Inserir(int valor)
        {
            No novo = new No(valor);
            novo.Proximo = inicio;
            inicio = novo;
        }

        public int Remover()
        {
            if (inicio == null) throw new Exception("Fila vazia!");
            if (inicio.Proximo == null)
            {
                int val = inicio.Valor;
                inicio = null;
                return val;
            }
            No aux = inicio;
            while (aux.Proximo.Proximo != null)
                aux = aux.Proximo;

            int valor = aux.Proximo.Valor;
            aux.Proximo = null;
            return valor;
        }

        public void Mostrar()
        {
            No aux = inicio;
            while (aux != null)
            {
                Console.Write(aux.Valor + " ");
                aux = aux.Proximo;
            }
            Console.WriteLine();
        }
    }

    public class Exercicio03
    {
        public static void Executar()
        {
            FilaReversa fila = new FilaReversa();
            fila.Inserir(1);
            fila.Inserir(2);
            fila.Inserir(3);
            fila.Mostrar();
            Console.WriteLine("Removido: " + fila.Remover());
            fila.Mostrar();
        }
    }
}