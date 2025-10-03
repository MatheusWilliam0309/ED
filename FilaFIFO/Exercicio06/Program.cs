namespace Exercicio06
{
    class No { public int Valor; public No Proximo; public No(int v) { Valor = v; } }
    class Fila
    {
        private No inicio, fim;
        public void Inserir(int v)
        {
            No novo = new No(v);
            if (fim == null) inicio = fim = novo;
            else { fim.Proximo = novo; fim = novo; }
        }

        public void RemoverNegativos()
        {
            while (inicio != null && inicio.Valor < 0)
                inicio = inicio.Proximo;

            No aux = inicio;
            while (aux != null && aux.Proximo != null)
            {
                if (aux.Proximo.Valor < 0)
                    aux.Proximo = aux.Proximo.Proximo;
                else
                    aux = aux.Proximo;
            }
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

    public class Exercicio06
    {
        public static void Executar()
        {
            Fila fila = new Fila();
            fila.Inserir(5); fila.Inserir(-2); fila.Inserir(8); fila.Inserir(-7); fila.Inserir(12);
            Console.WriteLine("Antes:");
            fila.Mostrar();
            fila.RemoverNegativos();
            Console.WriteLine("Depois:");
            fila.Mostrar();
        }
    }
}