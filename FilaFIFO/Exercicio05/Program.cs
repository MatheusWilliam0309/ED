namespace Exercicio05
{
    class No { public int Valor; public No Proximo; public No(int v) { Valor = v; } }
    class Fila
    {
        private No inicio, fim;
        private int qtd;
        public void Inserir(int v)
        {
            No novo = new No(v);
            if (fim == null) inicio = fim = novo;
            else { fim.Proximo = novo; fim = novo; }
            qtd++;
        }
        public int Quantidade() => qtd;
    }

    public class Exercicio05
    {
        public static void Executar()
        {
            Fila fila = new Fila();
            fila.Inserir(5); fila.Inserir(10); fila.Inserir(15);
            Console.WriteLine("Quantidade de elementos: " + fila.Quantidade());
        }
    }
}