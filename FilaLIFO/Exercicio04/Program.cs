namespace Exercicio04
{
    public class No { public int valor; public No prox; public No(int v) { valor = v; } }

    public class Pilha {
        private No topo;
        public void Push(int v) { No n = new No(v); n.prox = topo; topo = n; }
        public int Pop() { if (topo == null) throw new Exception("Vazia"); int v = topo.valor; topo = topo.prox; return v; }
        public bool Vazia() => topo == null;
    }

    public class Exercicio04 {
        public static void Executar() {
            Pilha pilha1 = new Pilha(); int[] valores = {1, -2, 7, -15, 51, -23};
            foreach (int v in valores) pilha1.Push(v);

            Pilha positivos = new Pilha();
            Pilha negativos = new Pilha();

            while (!pilha1.Vazia()) {
                int v = pilha1.Pop();
                if (v >= 0) positivos.Push(v);
                else negativos.Push(v);
            }

            Console.WriteLine("Positivos e Negativos separados!");
        }
    }
}