using System.Runtime.CompilerServices;

public class Lista {

    //Atributos
    public No inicio; //cabeça
    public No fim; //cauda

    //Construtor
    public Lista() {
        this.inicio = null;
        this.fim = null;
    }

    //Métodos
    public Boolean estaVazia() {
        return this.inicio == null;
    }

    public void inserirInicio(int valor) {
        No novoNo = new No(valor);

        if (this.estaVazia()) { //LISTA VAZIA!
            this.inicio = novoNo;
            this.fim = novoNo;
        } else { //LISTA NÃO ESTÁ VAZIA!
            novoNo.prox = this.inicio; //Novo no aponta para o inicio da lista
            this.inicio = novoNo; //O inicio da lista passa a ser o novo no
        }
    }

    public void inserirFinal(int valor) {
        No novoNo = new No(valor);

        if (this.estaVazia()) { //LISTA VAZIA!
            this.inicio = novoNo;
            this.fim = novoNo;
        } else { //LISTA NÃO ESTÁ VAZIA!
            this.fim.prox = novoNo; //O fim atual aponta para o novo no
            this.fim = novoNo; //O fim da lista passa a ser o novo no
        }
    }

    public int removerInicio() {
        if (this.estaVazia()) {
            throw new Exception("Erro! A lista está vazia e não é possível remover elementos.");
        }

        int valorRemovido = this.inicio.valor;

        // Se a lista possui apenas um elemento
        if (this.inicio == this.fim) {
            this.inicio = null;
            this.fim = null;
        } else {
            // Se a lista possui mais de um elemento
            this.inicio = this.inicio.prox;
        }
        return valorRemovido;
    }

    public int removerFim() {
        if (this.estaVazia()) {
            throw new Exception("Erro! A lista está vazia e não é possível remover elementos.");
        }

        int valorRemovido = this.fim.valor;

        // Se a lista possui apenas um elemento
        if (this.inicio == this.fim) {
            this.inicio = null;
            this.fim = null;
        } else {
            // Se a lista possui mais de um elemento, é preciso encontrar o penúltimo
            No noAux = this.inicio;
            while (noAux.prox != this.fim) {
                noAux = noAux.prox;
            }
            // O penúltimo agora é o fim e não aponta para mais ninguém
            this.fim = noAux;
            this.fim.prox = null;
        }
        return valorRemovido;
    }

    public Boolean remover(int valor) {
        No noAnterior, noAtual;
        noAnterior = noAtual = null;

        Boolean verif = this.consulta(valor, ref noAtual, ref noAnterior);

        if (verif == true) { //Encontrou então remove!
            if (noAtual == this.inicio) { //Remover inicio
                this.inicio = noAtual.prox;
                // Se a lista ficou vazia, o fim também deve ser nulo
                if (this.inicio == null) {
                    this.fim = null;
                }
            } else if (noAtual == this.fim) { //Remover fim
                this.fim = noAnterior;
                noAnterior.prox = null;
            } else { //Remover no meio (entre dois nos)
                noAnterior.prox = noAtual.prox;
            }
            noAtual = null; // Libera o nó para o garbage collector
            return (true); //Retorna TRUE se removeu
        }
        return (false); //Retorna FALSE se não removeu
    }

    public Boolean consulta(int valor, ref No noAtual, ref No noAnterior) { //BUSCA ELEMENTO NA LISTA 
        noAtual = this.inicio; //Copia da lista
        noAnterior = null;
        while (noAtual != null) { //Percorrer lista
            if (noAtual.valor == valor) {
                return (true);
            }
            noAnterior = noAtual; //Copia do atual
            noAtual = noAtual.prox;
        }
        return (false);
    }

    public void imprimir() { //percorrer a lista...
        if (this.estaVazia()) {
            Console.WriteLine("\n -> A lista está vazia!");
            return;
        }

        No noAux = this.inicio; //Copia do inicio da lista

        Console.Write("\nElementos da lista: INÍCIO -> ");

        while (noAux != null) {
            Console.Write(noAux.valor + " -> ");
            noAux = noAux.prox;
        }
        Console.WriteLine("FIM");
    }
}