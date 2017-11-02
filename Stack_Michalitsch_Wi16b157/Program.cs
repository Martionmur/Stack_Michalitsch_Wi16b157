using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Michalitsch_Wi16b157
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> MyStack = new Stack<String>();
            MyStack.Push(Console.ReadLine());
            MyStack.Push(Console.ReadLine());
            MyStack.Push(Console.ReadLine());

            Console.WriteLine(MyStack.peek());
            MyStack.Pop();
            Console.WriteLine(MyStack.peek());
            MyStack.Pop();
            Console.WriteLine(MyStack.peek());
            MyStack.Pop();
            Console.ReadKey();
            Console.WriteLine(MyStack.peek());
            MyStack.Pop();
            Console.ReadKey();




        }
    }
}
