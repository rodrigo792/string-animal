/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        // Leitura das três palavras
        string palavra1 = Console.ReadLine();
        string palavra2 = Console.ReadLine();
        string palavra3 = Console.ReadLine();

        // Variável para armazenar o nome do animal
        string animal = "";

        // Estrutura de decisão para identificar o animal
        if (palavra1 == "vertebrado")
        {
            if (palavra2 == "ave")
            {
                if (palavra3 == "carnivoro")
                {
                    animal = "aguia";
                }
                else if (palavra3 == "onivoro")
                {
                    animal = "pomba";
                }
            }
            else if (palavra2 == "mamifero")
            {
                if (palavra3 == "onivoro")
                {
                    animal = "homem";
                }
                else if (palavra3 == "herbivoro")
                {
                    animal = "vaca";
                }
            }
        }
        else if (palavra1 == "invertebrado")
        {
            if (palavra2 == "inseto")
            {
                if (palavra3 == "hematofago")
                {
                    animal = "pulga";
                }
                else if (palavra3 == "herbivoro")
                {
                    animal = "lagarta";
                }
            }
            else if (palavra2 == "anelideo")
            {
                if (palavra3 == "hematofago")
                {
                    animal = "sanguessuga";
                }
                else if (palavra3 == "onivoro")
                {
                    animal = "minhoca";
                }
            }
        }

        // Exibe o nome do animal em letras maiúsculas
        Console.WriteLine(animal.ToUpper());
    }
}
