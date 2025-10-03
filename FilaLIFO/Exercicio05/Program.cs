namespace Exercicio05
{
    public class No { public char valor; public No prox; public No(char v) { valor = v; } }
    public class Pilha {
        private No topo;
        public void Push(char c) { No n = new No(c); n.prox = topo; topo = n; }
        public char Pop() { if (topo == null) throw new Exception("Vazia"); char c = topo.valor; topo = topo.prox; return c; }
        public bool Vazia() => topo == null;
    }

    public class Exercicio05 {
        public static void Executar() {
            Pilha p = new Pilha(); string palavra = "EUAMOPROGRAMAR";
            foreach (char c in palavra) p.Push(c);

            while (!p.Vazia()) Console.Write(p.Pop() + " ");
        }
    }
}