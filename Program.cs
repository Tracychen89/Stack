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
            StackClass myStack = new StackClass(19);
           // use while loop to show users some information about the stack and some choices for them to choose
            while (true)
            {
                // clear the console
                Console.Clear();
                Console.WriteLine("\nStack MENU(size - - {0})", myStack.StackSizeSet);
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
        // declare isEmpty as bool data type
        Boolean isEmpty();
        // declare a method Push and it has one parameter without output
        void Push(Object element);
        // declare a method Pop and it has output
        object Pop();
        // delcare a method Peek and it has output 
        Object Peek();
        // delcare a method Display and it has no output
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
            // initialize StackSizeSet as 10
            StackSizeSet = 10;
            // assign item as a object array can hold 10 element 
            item = new Object[StackSizeSet];
            // assign -1 to top
            top = -1;
        }

        // creat constructor StackClass takes int capacity as argument. Default construtor is invoked when new operator is used.
        public StackClass(int capacity)
        {
            // assign capacity to StackSizeSet
            StackSizeSet = capacity;
            // assign item as a object array can hold the amount of element which equal to value of StackSizeSet 
            item = new Object[StackSizeSet];
            // assign -1 to top
            top = -1;
        }
        // creat a public method named isEmpty and return bool data taype output.

        public bool isEmpty()
        {
            // use if statement  to decide isEmpty to be 0 or 1
            if (top == -1) return true;

            return false;
        }
        // creat  a public method named Push and takes object element as argument. no output.
        public void Push(object element)
        {
            // use if statement to decide whether stack if full or not 
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }
            else 
            {
                // ++x operator is prefix increment: return x value after updating the storage location with x + 1 
                // assign element to item[]
                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            
            
            }
        }
        // creat a method named Pop and output is object data type
        public object Pop()
        {
            // if isEmpty is 1 then excuate code in {}
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                    return "No elements";
            }
            // if isEmpty is 0 then excuate code in {}
            else
            {
                // x-- operator is postfix decrement: return x value and update the storage location with x - 1
                return item[top--];
            }
        }
        // creat a method named Peek and output is object data type
       
        public object Peek()
        {
            // if isEmpty is 1 then excuate code in {}
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            // if isEmpty is 0 then return item[]
            else
            {
                return item[top];
            }

        }
        // creat a method named Display  and no output.
        public void Display()
        {
            // use for loop to console array item
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }

    
    
    
    
    }



}


