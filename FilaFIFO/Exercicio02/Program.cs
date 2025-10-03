namespace Exercicio02
{
    class Cliente
    {
        public string Nome;
        public int Idade;
        public double ValorPagoIngresso;
        public bool PagouMeia;
        public Cliente(string nome, int idade, double valor, bool meia)
        {
            Nome = nome;
            Idade = idade;
            ValorPagoIngresso = valor;
            PagouMeia = meia;
        }
    }

    class No
    {
        public Cliente Dado;
        public No Proximo;
        public No(Cliente dado) { Dado = dado; }
    }

    class Fila
    {
        private No inicio, fim;

        public void Inserir(Cliente c)
        {
            No novo = new No(c);
            if (fim == null) inicio = fim = novo;
            else { fim.Proximo = novo; fim = novo; }
        }

        public Cliente Remover()
        {
            if (inicio == null) throw new Exception("Fila vazia!");
            Cliente c = inicio.Dado;
            inicio = inicio.Proximo;
            if (inicio == null) fim = null;
            return c;
        }

        public bool Buscar(string nome)
        {
            No aux = inicio;
            while (aux != null)
            {
                if (aux.Dado.Nome == nome) return true;
                aux = aux.Proximo;
            }
            return false;
        }

        public void Percorrer()
        {
            No aux = inicio;
            while (aux != null)
            {
                Console.WriteLine("Nome: " + aux.Dado.Nome + 
                                  " Idade: " + aux.Dado.Idade +
                                  " Valor: " + aux.Dado.ValorPagoIngresso +
                                  " Meia: " + aux.Dado.PagouMeia);
                aux = aux.Proximo;
            }
        }
    }

    public class Exercicio02
    {
        public static void Executar()
        {
            Fila fila = new Fila();
            fila.Inserir(new Cliente("Ana", 22, 15, true));
            fila.Inserir(new Cliente("João", 30, 30, false));
            fila.Percorrer();
            Console.WriteLine("Busca João: " + fila.Buscar("João"));
            Console.WriteLine("Removido: " + fila.Remover().Nome);
            fila.Percorrer();
        }
    }
}