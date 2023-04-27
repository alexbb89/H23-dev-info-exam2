using System;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var liste = new List<int>();
            if(moyenne == -1)
            {
                console.WriteLine("données invalides");
            }
            else
            {
                var moyenne = OperationsMathematiques.CalculerMoyenne(liste);
                Console.WriteLine(moyenne);
            }
            
        }
    }
}