namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Stack with integers
            StackClass<int> intStack = new StackClass<int>();

            // Message about intStack
            Console.WriteLine("\n\tIntger Stack:\n");

            // Add elements to stack
            intStack.AddElem(1);
            intStack.AddElem(2);
            intStack.AddElem(3);
            intStack.AddElem(4);
            intStack.AddElem(5);

            Console.WriteLine($"\nPop element: {intStack.PopElem()}"); // Print 5

            Console.WriteLine($"\nPeek element: {intStack.PeekElem()}\n"); // Print 4

            intStack.PrintStack(); // Print stack [ 1, 2, 3, 4 ]


            // Stack with strings
            StackClass<string> stringStack = new StackClass<string>();

            // Message about stringStack
            Console.WriteLine("\n\n\tString Stack:\n");

            // Add element to Stack
            stringStack.AddElem("Jura");
            stringStack.AddElem("Andrew");
            stringStack.AddElem("John");
            stringStack.AddElem("Dimon");
            stringStack.AddElem("Maks");

            Console.WriteLine($"\nPop element: {stringStack.PopElem()}");

            Console.WriteLine($"\nPeek element: {stringStack.PeekElem()}\n");

            stringStack.PrintStack();
        }
    }
}