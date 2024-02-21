using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Practice.StackAndQueues
{
    public class Stack
    {
        public int MaxSize {  get; set; }
        public string[] Values {  get; set; }
        public int Top {  get; set; }

        public Stack(int size)
        {
            this.MaxSize = size;
            this.Values = new string[size];
            this.Top = -1;
        }

        public void Push(string value)
        {
            if (!isFull())
            {
                Top++;
                Values[Top] = value;
            }
            else
            {
                Console.WriteLine("The stack is full");
            }
        }
        public string Pop()
        {
            if (!isEmpty())
            {
                int oldTop = Top;
                Top--;
                return Values[oldTop];
            }
            else
            {
                return "The Stack is empty";
            }
        }

        public string Peek()
        {
            if (Top == -1)
            {
                return "Stack vacio";
            }
            return Values[Top];
        }
        public bool isEmpty()
        {
            return (Top == -1);
        }
        public bool isFull()
        {
            return (Top == MaxSize - 1);
        }
    }
}
