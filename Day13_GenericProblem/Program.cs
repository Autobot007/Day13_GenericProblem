namespace Day13_GenericProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            FindMax obj1 = new FindMax();
            while (check)
            {
                Console.WriteLine("Select option :\n" + "1)Find Integer Maximum Number\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int result = obj1.FindMaxInteger(4, 3, 2);
                        Console.WriteLine(result);
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Maximum Number is :"+result);
                        break;
                    default:
                        check = !check;
                        break;

                }
            }
        }
    }
}