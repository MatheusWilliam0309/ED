namespace Exercicio02
{
    public class No { public int valor; public No prox; public No(int v) { valor = v; } }

    public class Pilha {
        private No topo;
        public void Push(int v) { No n = new No(v); n.prox = topo; topo = n; }
        public int Contar() {
            int qtd = 0; No aux = topo;
            while (aux != null) { qtd++; aux = aux.prox; }
            return qtd;
        }
    }

    public class Exercicio02 {
        public static void Executar() {
            Pilha p = new Pilha(); p.Push(1); p.Push(2); p.Push(3);
            Console.WriteLine("Quantidade de elementos: " + p.Contar());
        }
    }
}