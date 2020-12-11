using System;
using AulaPOO_PolimosrfismoSobreposicao.classes;

namespace AulaPOO_PolimosrfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();
            Console.WriteLine($"MegaMan = {jogador.Correr()}");
            Console.WriteLine($"MegaMan = {jogador.Pular()}");
            Console.WriteLine($"MegaMan = habilidade: {jogador.Buster}");

            Zero jogador2 = new Zero();
            Console.WriteLine($"Zero = {jogador2.Correr()}");
            Console.WriteLine($"Zero = {jogador2.Pular()}");
            Console.WriteLine($"Zero = habilidade: {jogador2.Sword}");
        }
    }
}
