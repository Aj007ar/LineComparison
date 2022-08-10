namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************WELCOME TO LINE COMPARISON**************");
            Console.WriteLine("1.UC1 Length Calculation");

            Console.WriteLine("Enter number for execution");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    Console.WriteLine("**************Calculation Length**************");

                    UC1LentghCal uC1 = new UC1LentghCal();
                    uC1.LineLength();
                    break;
            }

        }
    }
}