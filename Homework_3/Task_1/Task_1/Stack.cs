namespace Generic
{
    public class StackClass<T>
    {
        // Create stack to manipulate with it
        Stack<T> stack = new Stack<T>();

        // Add element to the stack
        public void AddElem(T value)
        {
            stack.Push(value);  // Add value to the stack
            Console.WriteLine($"The value [ {value} ] was added to stack.");
        }

        // Get top element and delete it
        public T PopElem()
        {
            if (EqualsNull()) return default(T); // True
            return stack.Pop();                  // False
        }

        // Get top element but not delete it
        public T PeekElem()
        {
            if (EqualsNull()) return default(T); // True
            return stack.Peek();                 // False
        }

        public void PrintStack()
        {
            Console.Write("Elements in Stack: [");

            for (int i = stack.Count(); 0 < i; i--)
            {
                Console.Write($" {stack.Pop()} ");
            }



            Console.WriteLine("]\n\n");
        }
        // Determine is the stack Equals null
        private bool EqualsNull()
        {
            return stack.Equals(null);
        }
    }
}
