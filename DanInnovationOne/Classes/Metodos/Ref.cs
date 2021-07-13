namespace DanInnovationOne.Metodos
{
    public class Ref
    {
        // O modificador ref indica que o parametro será passado como referencia. Serve para modificar a variavel externamente, pois sem ela, o que é alterado dentro do método não afeta o valor original ao sair do método. Com o ref nós estamos passando um valor de referencia e o que sair dali irá alterar este valor de referencia que foi passado no parametro, por exemplo.
        
        static void Inverter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        }
    }
}