using System;


namespace CSharpRevisionOOPS
{
    public class StaticInstance
    {
        //static field
        public static float _discount;
        int _price;

        //static Constructor
        static StaticInstance()
        {
            _discount = .10F;
        }


        //static method
        public static void print()
        {
            Console.WriteLine("The discounted offered is :" + StaticInstance._discount);
             
        }

        public StaticInstance(int price)
        {
            this._price= price;
        }

        public float CalculateDiscount()
        {
            return this._price*StaticInstance._discount;
        }
    }

    public class Class1
    {
        public static void Main(string[] args)
        {
            StaticInstance s1 = new StaticInstance(500);
            StaticInstance.print();
            Console.WriteLine("The discounted price is " + s1.CalculateDiscount());

            StaticInstance s2 = new StaticInstance(1000);
            Console.WriteLine("The discounted price is "+ s2.CalculateDiscount());
        }
   
    }

}
