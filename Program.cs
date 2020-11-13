using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            string situacao = "";

            Console.WriteLine("media: " + media);

            if(media >  7) {
                situacao = "aprovado";
            }
            else{
                situacao = "reprovado";
            }

            Console.WriteLine(situacao);
            
        }
    }
}
