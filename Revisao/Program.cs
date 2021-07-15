using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            Aluno[] alunos = new Aluno[5];
            var index = 0;

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        // Inserir novo aluno
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Informe a nota do aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;                            
                        }
                        else{
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        
                        alunos[index] = aluno;
                        index++;
                        
                        break;
                    case "2":
                        // Listar alunos
                        foreach (var item in alunos)
                        {
                            if (!string.IsNullOrEmpty(item.Nome))
                            {
                                Console.WriteLine($"ALUNO: {item.Nome} - NOTA: {item.Nota}");                                
                            }
                        }              
                        break;
                    case "3":
                        // Calcular média geral
                        decimal notaTotal = 0;
                        var numDeAlunos = 0;
                        decimal mediaGeral = 0;
                        for (var i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal += alunos[i].Nota;
                                numDeAlunos++;
                            }
                        }
                        mediaGeral = notaTotal / numDeAlunos;
                        Console.WriteLine($"MEDIA GERAL: {mediaGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\nInforme a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();            
            return opcaoUsuario;
        }
    }
}
