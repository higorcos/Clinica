using System;
using System.Globalization;


namespace Services{
    class Pay{

         //ATRIBUTES
         public int Months { get; set;}
         public double Cost {get; set;}
        //CONSTRUCTOR
         public Pay()
         {
         }
          public Pay(int months,double cost){
             Cost = cost;
             Months = months;

         }
         public Pay(double cost){
             Cost = cost;
             Months = 3;

         }
        //PROPERTIES
        //METHODS
        public double InstallmentResult(){
            double number = Cost/Months;
            System.Console.WriteLine("O valor {0} em {1} vezes ficará {2} ",Cost,Months,number.ToString("f2"));
            return number;
        }
        
    }
}
