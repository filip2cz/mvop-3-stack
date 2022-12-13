using System;
using System.Collections.Generic;

namespace _3.stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stack1 = new Stack();

            bool exit = false;

            Console.WriteLine("Commands: push; pop; peek; isempty; printstack; exit; quit; help");

            int helpInfo = 0;
            int easteregg = 0;

            while (exit == false)
            {
                Console.Write("> ");
                string input;
                input = Console.ReadLine();
                string cmd = input.Split(" ")[0];
                if (input == "quit")
                {
                    exit = true;
                }
                else if (input == "exit")
                {
                    exit = true;
                }
                else if (cmd == "push")
                {
                    if (input.IndexOf(" ") == -1)
                    {
                        Console.Write("Input one char: ");
                        char h = Console.ReadLine()[0];
                        stack1.Push(h);
                    }
                    else
                    {
                        var ch = input.Split(" ")[1][0];
                        stack1.Push(ch);
                    }
                    helpInfo = 0;
                }
                else if (input == "pop")
                {
                    bool isempty = stack1.IsEmpty();
                    if (isempty == false)
                    {
                        char x = stack1.Pop();
                        Console.WriteLine(x);
                    }
                    else
                    {
                        Console.WriteLine("error: stack is empty");
                    }
                    helpInfo = 0;
                }
                else if (input == "peek")
                {
                    bool isempty = stack1.IsEmpty();
                    if (isempty == false)
                    {
                        char x = stack1.Peek();
                        Console.WriteLine(x);
                    }
                    else
                    {
                        Console.WriteLine("error: stack is empty");
                    }
                    helpInfo = 0;
                }
                else if (input == "isempty")
                {
                    bool x = stack1.IsEmpty();
                    Console.WriteLine(x);
                    helpInfo = 0;
                }
                else if (input == "printstack")
                {
                    stack1.PrintStack();
                    helpInfo = 0;
                }
                else if (input == "help")
                {
                    Console.WriteLine("Commands: push; pop; peek; isempty; printstack; exit; quit; help");
                    Console.WriteLine("push [x] -> save character to stack");
                    Console.WriteLine("pop -> print last character from stack and delete that character from stack");
                    Console.WriteLine("peek -> print last character from stack (do not delete it like pop)");
                    Console.WriteLine("isempty -> check if stack is empty");
                    Console.WriteLine("printstack -> write all characters in stack");
                    helpInfo = 0;
                }
                else if (input == "")
                {
                    helpInfo++;
                    if (helpInfo == 3)
                    {
                        Console.WriteLine("You should write some command btw. Use help if you don't know.");
                        helpInfo = 0;
                        easteregg++;
                        easteregg++;
                        easteregg++;
                    }
                    if (easteregg == 42)
                    {
                        Console.WriteLine("Are you racist to characters?");
                        easteregg--;
                        easteregg--;
                        easteregg--;
                    }
                }
                else
                {
                    Console.WriteLine("Command not found, use help for help.");
                }

            }
        }
    }
    class Stack
    {
        //List<char> chars = new List<char>();
        //public void Push(char ch)
        //{
        //    chars.Add(ch);
        //}
        //public char Pop()
        //{
        //    char tmp = chars[chars.Count - 1];
        //    chars.RemoveAt(chars.Count - 1);
        //    return tmp;
        //}
        //public char Peek()
        //{
        //    char tmp = chars[chars.Count - 1];
        //    return tmp;
        //}
        //public bool IsEmpty()
        //{
        //    if (chars.Count == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public void PrintStack()
        //{
        //    foreach (char i in chars)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        char[] chars = new char[0];
        public void Push(char ch)
        {
            int tmp1 = chars.Length;
            tmp1++;
            Array.Resize(ref chars, tmp1);
            int tmp2 = chars.Length - 1;
            chars[tmp2] = ch;
        }
        public char Pop()
        {
            int tmp2 = chars.Length - 1;
            char tmp = chars[tmp2];
            Array.Resize(ref chars, tmp2);
            return tmp;
        }
        public char Peek()
        {
            int tmp2 = chars.Length - 1;
            char tmp = chars[tmp2];
            return tmp;
        }
        public bool IsEmpty()
        {
            if (chars.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PrintStack()
        {
            int i = 0;
            while (i < chars.Length)
            {
                Console.WriteLine(chars[i]);
                i++;
            }
        }
    }
}
