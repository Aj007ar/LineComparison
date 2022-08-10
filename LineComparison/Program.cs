namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************WELCOME TO LINE COMPARISON**************");
            Console.WriteLine("1.UC1 Length Calculation");
            Console.WriteLine("2.UC2 check line equality");
            Console.WriteLine("3.UC3 Compare Lines"); 

            Console.WriteLine("\nEnter number for execution");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    Console.WriteLine("**************Calculation Length**************");

                    UC1LentghCal uC1 = new UC1LentghCal();
                    uC1.LineLength();
                    break;
                case 2:
                    Console.WriteLine("**************Line Equality**************");

                    UC2LineEquality equality = new UC2LineEquality();
                    equality.EqualLines();
                    break;
                case 3:
                    Console.WriteLine("**************Compare Lines**************");

                    UC3LineCompare uC3 = new UC3LineCompare();
                    uC3.EqualLines();
                    break;
            }

        }
    }
}