using System;

namespace FilaFIFO{

    class Program{
        static void Main(string[] args){

            Pilha pilha = new();

            //Inserção
            pilha.push(12);
            pilha.push(7);
            pilha.push(10);
            
            //Percurso = Impressão
            pilha.imprimir();

            //Consulta
            No noAtual = null;
            No noAnterior = null;
            pilha.consulta(7, ref noAtual, ref noAnterior);

            //Remoção
            pilha.pop();
            pilha.pop();
            pilha.pop();
            pilha.imprimir();
        }
    }
}