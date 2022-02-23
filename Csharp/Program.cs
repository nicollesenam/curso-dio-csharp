using System;
using System.Collections.Generic;
using System.Text;
using Csharp;
using Interface;
using Enum;


namespace Csharp
{
    class Program
    {
      static void Main(string[] args) 
        { 
            Pessoa person = new Pessoa();

            person.Nome = "Giovanna";
            person.Idade =  19;
            person.Estado = "Rio de Janeiro";

            Pessoa person2 = new Pessoa();

            person.Nome = "Julia";
            person.Idade = 20;
            person.Estado = "Manaus";



           Animal animal = new Animal();
            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";


            var pessoa1 = (Pessoas) 0; //chamar a pessoa no indice 0
            //outra maneira de chamar o Enum
            Pessoas pessoa2 = Pessoas.João;


            Console.WriteLine(person2);

        }
    }

}