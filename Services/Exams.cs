using System;
using System.Globalization;
using Services;


namespace Services
{
    class Exams
    {

        //ATRIBUTES
        private string _name;
        private double _cost;
        public string Tipo { get; set; }

        //CONSTRUCTOR
        public Exams()
        {
        }
        public Exams(string name, string tipo, double cost)
        {
            _name = name;
            Tipo = tipo;
            _cost = cost;
        }
        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 1 && value != null)
                {
                    _name = value;
                }
            }
        }
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value > 0)
                {
                    _cost = value;

                }
            }
        }
        //METHODS
        public double InstallmentMonths(int months=0)
        {
            if(months == 0){ // Parcelamento mínimo (regra de "negócio" ____constructor do objeto) 
            Pay x = new Pay(_cost);
            return x.InstallmentResult();

            }else{ // Quando o parcelamento for indicado
            Pay x = new Pay(months, _cost);
            return x.InstallmentResult();
            }

        }
        public override string ToString()
        {
            return "Exame de "+ Tipo +",("+ _name +") no valor de "+_cost.ToString("f2")+ "$ reais.";
        }
    }
}
