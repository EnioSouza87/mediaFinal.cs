using System;

namespace notas_do_trimestre
{
    class Program
    {
        static void Main(string[] args)
        {

            string aluno;
            double nota1;
            double nota2;
            double nota3;
            double mediafinal;

            Console.WriteLine("Digite o nome do aluno");
            aluno = Convert.ToString(Console.ReadLine());

            Console.WriteLine("digite a nota da primeira prova: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a nota da terceira prova: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            mediafinal = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine(aluno);
            Console.WriteLine("Média final é: " + mediafinal);

            if(mediafinal>8 & mediafinal < 10)
            {
                Console.WriteLine("Aprovado com média alta");
            }else if(mediafinal>6 & mediafinal < 8)
            {
                Console.WriteLine("Aprovado");
            }else if(mediafinal>4 & mediafinal < 6)
            {
                Console.WriteLine("recuperação");
            }
            else
            {
                Console.WriteLine("reprovado");
            }

            Console.Read();
        }
    }
}
