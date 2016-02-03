using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackClass myStack = new StackClass();
            while (true)
            {
                // clear the console
                Console.Clear();
                Console.WriteLine("\nStack MENU(size - - 10)");
                Console.WriteLine("1. Add an element.");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4.Display stack element.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice =
                    Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        myStack.Push(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Top element is: {0}", myStack.Peek());
                        break;
                        
                    case 3:
                        Console.WriteLine("Element removed: {0}", myStack.Pop());
                        break;

                    case 4:
                        myStack.Display();
                        break;

                    case 5:
                        System.Environment.Exit(1);
                        break;


                }
                Console.ReadKey();

            }

        }
    }
    interface StackADT
    {
        Boolean isEmpty();
        void Push(Object element);
        object Pop();
        Object Peek();
        void Display();
    }

    class StackClass : StackADT
    {
        private int StackSize;

        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }

        }
        public int top;
        Object[] item;

        public StackClass()
        {
            StackSizeSet = 10;
            item = new Object[StackSizeSet];
            top = -1;
        }
        public StackClass(int capacity)
        {
            StackSizeSet = capacity;
            item = new Object[StackSizeSet];
            top = -1;
        }

        public bool isEmpty()
        {
            if (top == -1) return true;

            return false;
        }
        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }
            else 
            {
                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            
            
            }
        }
        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                    return "No elements";
            }
            else
            {
                return item[top--];
            }
        }

        public object Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top];
            }

        }
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }

    
    
    
    
    }



}


