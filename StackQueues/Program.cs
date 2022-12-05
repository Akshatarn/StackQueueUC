using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Queue Program");
            Console.WriteLine("Please select as per the below given options :\n" +
                "Press 1: Creating custom stack using LinkedList.\n "+
                "Press 2: Using Peek and Pop in stack.\n"+
                "Press 3: Using Enque in Queue.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LinkedListStack stackObject = new LinkedListStack();
                    stackObject.Push(70);
                    stackObject.Push(30);
                    stackObject.Push(56);
                    stackObject.Display();
                    break;
                case 2:
                    LinkedListStack stackObject1 = new LinkedListStack();
                    stackObject1.Push(70);
                    stackObject1.Push(30);
                    stackObject1.Push(56);
                    stackObject1.Display();
                    Console.WriteLine("Is list is empty? " + stackObject1.isEmpty());
                    stackObject1.Display();
                    break;
                case 3:
                    LinkedListQueue queueObject = new LinkedListQueue();
                    queueObject.Enque(70);
                    queueObject.Enque(30);
                    queueObject.Enque(56);
                    queueObject.Display();
                    break;
                default:
                    break;
            }
        }
    }
}
