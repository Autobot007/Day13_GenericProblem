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
                Console.WriteLine("Select option :\n" + "1)Find Integer Maximum Number\n"+"2)Find Float Maximum Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int result = obj1.FindMx(4, 3, 2);
                        Console.WriteLine(result);
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Maximum Number is :"+result);
                        break;
                    case 2:
                        float resultfloat = obj1.FindMx(4.3f, 3.8f, 2.8f);
                        Console.WriteLine(resultfloat);
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Maximum Number is :" + resultfloat);
                        break;                        
                    default:
                        check = !check;
                        break;

                }
            }
        }
    }
}