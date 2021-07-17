namespace DanInnovationOne.Metodos
{
    public class Out
    {
        // O modificador out serve para extrair o resultado ao final do método para uma variavel que foi criada no momento da declaração
        
        static void Dividir(int x, int y, out int resultado, out int resto) 
        {
            resultado = x / y;
            resto = x % y;
        }
        
        public static void Dividir() 
        {
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);	// Escreve "3 1"
        }
    }
}