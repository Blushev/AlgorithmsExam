using AlgorithmsExam.Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        MyStack<string> stack = new MyStack<string>(4);
        stack.Push("Kate");
        stack.Push("Sam");
        stack.Push("Alice");
        stack.Push("Tom");


        stack.ShowStack(stack);
    }
}