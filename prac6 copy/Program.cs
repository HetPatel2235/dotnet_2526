using System;

class Program
{
    static int precedence(char ch)
    {
        if(ch == '*' || ch == '/')
        {
            return 2;
    
        }
        else if(ch == '+' || ch == '-')
        {
            return 1;
        }
        return 0;
        
    }
    static string infixtopostfix(string infix)
    {
        string postfix = "";
        Stack<char>stack = new Stack<char>();
        for(int i = 0; i < infix.Length; i++)
        {
            if(char.IsLetterOrDigit(infix[i]))
                postfix+=infix[i];
            else
            {
                while (stack.Count() > 0 && precedence(infix[i]) < precedence(stack.Peek()))
                {
                    postfix+=stack.Pop();
                }
                stack.Push(infix[i]);
            }           
        }
        while(stack.Count() > 0)
        {
            postfix+=stack.Pop();
        }
        return postfix;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Infix expression:");

        string infix = Console.ReadLine();

        Console.WriteLine("Postfix expression:"+ infixtopostfix(infix));
        
    }
}