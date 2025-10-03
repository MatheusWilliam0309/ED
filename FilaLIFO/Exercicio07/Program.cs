namespace Exercicio07
{
    public class No { public int valor; public No prox; public No(int v) { valor = v; } }
    public class Pilha {
        private No topo;
        public void Push(int v) { No n = new No(v); n.prox = topo; topo = n; }
        public int Pop() { if (topo == null) throw new Exception("Vazia"); int v = topo.valor; topo = topo.prox; return v; }
        public bool Vazia() => topo == null;
    }

    public class Exercicio07 {
        public static void Executar() {
            Pilha p1 = new Pilha(); int[] valores = {12, 5, 7, 10};
            foreach (int v in valores) p1.Push(v);

            Pilha aux = new Pilha();
            Pilha p2 = new Pilha();

            // inverter duas vezes para manter ordem
            while (!p1.Vazia()) aux.Push(p1.Pop());
            while (!aux.Vazia()) p2.Push(aux.Pop());

            Console.WriteLine("Elementos transferidos mantendo ordem!");
        }
    }
}