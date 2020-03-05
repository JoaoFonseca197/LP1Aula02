using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variavéis 
            string altura,raio;
            float alturaF, raioF,v,surfA;
            const float pi  = 3.1415926f;
            //1. pedir as variáveis ao utilizador
            Console.WriteLine("Insira uma altura: ");
            altura = Console.ReadLine();
            Console.WriteLine("Insira um raio: ");
            raio = Console.ReadLine();
            //2.Converter o input para numeros
            alturaF = float.Parse(altura);
            raioF = float.Parse(raio);
            //3.fazer Contas
            v = pi * raioF * raioF * alturaF;
            surfA = 2 * pi * raioF * (raioF+alturaF);
            //4.Mostrar a solução ao utilizador
            Console.WriteLine($"Volume = {v,8:f2}");
            Console.WriteLine($"AreaSup = {surfA,8:f2}");

        }
    }
}
