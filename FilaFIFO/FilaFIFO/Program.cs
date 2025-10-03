using System;

namespace Aula{

    class Program{
        static void Main(string[] args){

            Fila filinha = new Fila();
            Console.WriteLine(filinha.estaVazia());
            
            filinha.enfileirar(34);
            filinha.enfileirar(15342);
            filinha.enfileirar(29);

            filinha.percurso();

            filinha.desenfileirar();
            filinha.percurso();
            filinha.RemoverDesenfilar();
        }
    }
}
