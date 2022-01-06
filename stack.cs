class Stack
    {
        #region member variables
        private int top;
        private int[] data;
        #endregion

        public Stack(int maxSize)
        {
            top = -1;
            data = new int[maxSize];
        }

        public void Push(int num)
        {
            if (IsFull())
                throw new FullStackException();

            top += 1;
            data[top] = num;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new EmptyStackException();

            var topElem = data[top];
            top -= 1;

            return topElem;
        }

        public bool IsFull()
        {
            return top == data.Length-1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }

    class FullStackException : Exception
    {
        public FullStackException() { }
    }

    class EmptyStackException : Exception
    {
        public EmptyStackException() { }
    }

    class StackTest
    {
        static void Main(string[] args)
        {
            var stack = new Stack(4);
            stack.Push(3);
            stack.Push(6);
            stack.Push(8);
            stack.Pop();
            stack.Push(5);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            //stack.Pop();
            stack.Push(2);
            stack.Push(6);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
        }
    }
