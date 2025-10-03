public class Pilha{

    public No topo;

    public Pilha(){
        this.topo = null;
    }

    public Boolean estaVazia(){

        if(this.topo == null){
            return(true);
        }
        return(false);
    }

    public void push(int Valor){
        
        //CRIAR NOVO NO
        No novoNo = new(Valor);

        if(this.estaVazia() == true){ //PILHA VAZIA!
            this.topo = novoNo;
        }
        else{
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    public No pop(){
        No aux = null;
        if(this.estaVazia() == true){
            return(aux);
        }
        else{ //Remoção do topo da pilha
            aux = this.topo;
            this.topo = this.topo.prox;
            return(aux);
        }
    }

    public Boolean consulta(int valor, ref No noAtual, ref No noAnterior){

        noAtual = this.topo;
        noAnterior = null;

        while(noAtual != null){
            
            if(noAtual.valor == valor){
                return(true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.prox;
        }
        return(false);
    }

    public void imprimir(){

        No noAux = this.topo;
        
        Console.WriteLine("Elementos: ");
        
        while(noAux != null){
            Console.WriteLine(noAux.valor + " -> ");
            noAux = noAux.prox;
        }
    }

}