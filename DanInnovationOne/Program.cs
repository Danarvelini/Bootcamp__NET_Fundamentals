using System;
using DanInnovationOne.Exemplos;
using DanInnovationOne.Herança;
using DanInnovationOne.Metodos;

namespace DanInnovationOne
{
    class Program
    {
        static void Main()
        {
            
        }
        
        public void AulaDePilha(){
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
        
        public void AulaDeHeranca(){
            Ponto p1 = new Ponto(10,20); //Criamos uma instancia da classe Ponto
            Ponto3D p2 = new Ponto3D(10,20,30); //Criamos uma instancia da classe Ponto3D
            
            Ponto3D.Calcular(); // Chamados através da classe pois o método é static e pertence à classe
        }
    }
}
