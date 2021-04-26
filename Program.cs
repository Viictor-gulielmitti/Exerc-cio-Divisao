using System;

namespace Exerc_cio_Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
         double Numerador, Denominador, resultado; 

         
           
        Console.WriteLine("digite um Numerador");
        Numerador = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("digite um Denominador");
        Denominador = Convert.ToDouble(Console.ReadLine()); 

        resultado = Numerador / Denominador;


         if ( Denominador == 0){
        Console.WriteLine("impossivel dividir por zero"); 
         }
         else {
        Console.WriteLine ($" { Numerador } dividido por { Denominador } é { resultado }");
        }

        
        

        





        


        }
    }
}
