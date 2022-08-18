using System.Collections;

namespace data_structure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack stackobj = new();
            stackobj.Push(10);
            stackobj.Push(20);
            stackobj.Push(30);
            stackobj.Push("Saif");
            foreach (var item in stackobj)
            {
                Console.WriteLine("|  "+item+"   |");
                Console.WriteLine("----------------");

            }

            Console.WriteLine("Top most element of stack:" + stackobj.Peek());
            stackobj.Pop();
            foreach(var item in stackobj)
            {
                Console.WriteLine("|  " + item + "   |");
                Console.WriteLine("----------------");
            }


        }
    }
}