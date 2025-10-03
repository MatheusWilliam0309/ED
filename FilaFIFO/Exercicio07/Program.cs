namespace Exercicio07
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

        public void Concatenar(Fila outra)
        {
            if (outra.inicio == null) return;
            if (fim == null) { inicio = outra.inicio; fim = outra.fim; }
            else { fim.Proximo = outra.inicio; fim = outra.fim; }
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

    public class Exercicio07
    {
        public static void Executar()
        {
            Fila f1 = new Fila(); f1.Inserir(1); f1.Inserir(2);
            Fila f2 = new Fila(); f2.Inserir(3); f2.Inserir(4);
            f1.Concatenar(f2);
            Console.WriteLine("Fila concatenada:");
            f1.Mostrar();
        }
    }
}