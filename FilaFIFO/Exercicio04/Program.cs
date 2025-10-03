namespace Exercicio04
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

    public class Exercicio04
    {
        public static void Executar()
        {
            Fila f1 = new Fila(); f1.Inserir(1); f1.Inserir(2);
            Fila f2 = new Fila(); f2.Inserir(10);

            if (f1.Quantidade() == f2.Quantidade())
                Console.WriteLine("As filas têm a mesma quantidade.");
            else if (f1.Quantidade() > f2.Quantidade())
                Console.WriteLine("Fila 1 tem mais elementos.");
            else
                Console.WriteLine("Fila 2 tem mais elementos.");
        }
    }
}