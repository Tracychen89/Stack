using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        // entrance of the class
        static void Main(string[] args)
        {
            // creat a StackClass object named myStack
            StackClass myStack = new StackClass();
           // use while loop to show users some information about the stack and some choices for them to choose
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
            //int choice accept value from user
                int choice =
                    Convert.ToInt32(Console.ReadLine());
                // using switch statement to deal with different choice. The expression in switch should be integral or enumerated type
                switch (choice)
                {
                    case 1:
                        // use Push method in StackClass class
                        myStack.Push(Console.ReadLine());
                        break;
                        // use Peek method in StackClass class
                    case 2:
                        Console.WriteLine("Top element is: {0}", myStack.Peek());
                        break;
                        // use Pop method in StackClass class
                    case 3:
                        Console.WriteLine("Element removed: {0}", myStack.Pop());
                        break;
                        // use Display method in StackClass class
                    case 4:
                        myStack.Display();
                        break;
                        // use Environment.Exit method to terminate process 
                    case 5:
                        System.Environment.Exit(0);
                        break;


                }
                Console.ReadKey();

            }

        }
    }

    // creat a interface 
    interface StackADT
    {
        Boolean isEmpty();
        void Push(Object element);
        object Pop();
        Object Peek();
        void Display();
    }
    // creat a derived class StackClass based on base class StackADT
    class StackClass : StackADT
    {
        // I don't understand get and set accessor.
        private int StackSize;
        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }

        }
        // defining a int data type named top 
        public int top;
        // defining a object array named item
        Object[] item;
        // default constructor StackClass as it takes no parameter. 
        //Default constructor is invoked whenever an object is instantiated by new opertor and no argument provide to new. 
        public StackClass()
        {
            StackSizeSet = 10;
            item = new Object[StackSizeSet];
            top = -1;
        }

        // creat constructor StackClass takes int capacity as argument. Default construtor is invoked when new operator is used.
        public StackClass(int capacity)
        {
            StackSizeSet = capacity;
            item = new Object[StackSizeSet];
            top = -1;
        }
        // creat a public method named isEmpty and return bool data taype output.

        public bool isEmpty()
        {
            if (top == -1) return true;

            return false;
        }
        // creat  a public method named Push and takes object element as argument. no output.
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
        // creat a method named Pop and output is object data type
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
        // creat a method named Peek and output is object data type

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
        // creat a method named Display  and no output.
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }

    
    
    
    
    }



}


