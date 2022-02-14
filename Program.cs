using System;
using System.Globalization;
using Services; //objeto Exames

namespace Clinica
{
    class Program
    {
        static void Main(string[] args)
        {

            Exams x = new Exams();
            x.Name = "Glicemia";
            x.Tipo = "Sangue";
            x.Cost = 23;
            
            x.InstallmentMonths();

            Exams y = new Exams("Toxicológico", "Sangue", 90);

            y.InstallmentMonths(); //parcelemento mínimo
            y.InstallmentMonths(9); //parcelametno informado
            System.Console.WriteLine(y.ToString());
            y.Tipo = "Urina";
            y.Cost = 64.59;
            System.Console.WriteLine(y.ToString());



        }
    }
}
