namespace Exercicio03
{
    public class No { public int valor; public No prox; public No(int v) { valor = v; } }
    public class Pilha {
        private No topo;
        public void Push(int v) { No n = new No(v); n.prox = topo; topo = n; }
        public int ContarImpares() {
            int qtd = 0; No aux = topo;
            while (aux != null) { if (aux.valor % 2 != 0) qtd++; aux = aux.prox; }
            return qtd;
        }
    }

    public class Exercicio03 {
        public static void Executar() {
            Pilha p = new Pilha(); p.Push(2); p.Push(5); p.Push(7); p.Push(10);
            Console.WriteLine("Ímpares: " + p.ContarImpares());
        }
    }
}