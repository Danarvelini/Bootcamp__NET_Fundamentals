using System;

namespace DanInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int teste = 0;
            while(teste <= 100){
                if(teste % 2 == 0){
                    Console.WriteLine(teste);
                }
                teste++;
            }
        }
    }
}
