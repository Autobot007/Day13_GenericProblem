namespace Day13_GenericProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, };
            FindMax<int> generic = new FindMax<int>(array);





            //bool check = true;
            //FindMax<T> obj1 = new FindMax<T>();
            //while (check)
            //{
            //    Console.WriteLine("Select option :\n" + "1)Find Integer Maximum Number\n"+"2)Find Float Maximum Number\n"+"3)Find String Maximum Asci Value");
            //    int option = Convert.ToInt32(Console.ReadLine());
            //    switch (option)
            //    {
            //        case 1:
            //            int result = obj1.FindMx(4, 3, 2);
            //            Console.WriteLine(result);
            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Maximum Number is :"+result);
            //            break;
            //        case 2:
            //            float resultfloat = obj1.FindMx(4.3f, 3.8f, 2.8f);
            //            Console.WriteLine(resultfloat);

            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Maximum Number is :" + resultfloat);
            //            break;
            //        case 3:
            //            string resultstring = obj1.FindMx("Apple","Peach","Banana");
            //            Console.WriteLine(resultstring);
            //            Console.WriteLine("-------------------------------------");
            //            Console.WriteLine("Maximum Number is :" + resultstring);
            //            break;
            //        default:
            //            check = !check;
            //            break;

            //    }
            //}
        }
    }
}