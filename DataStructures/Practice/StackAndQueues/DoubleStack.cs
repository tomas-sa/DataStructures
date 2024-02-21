using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Practice.StackAndQueues
{
    public class DoubleStack
    {
        private int MaxSize {  get; set; }
        public string[] Values {  get; set; }
        public int Top1 {  get; set; }
        public int Top2 { get; set; }


        public DoubleStack(int maxSize) 
        {
            this.MaxSize = maxSize;
            this.Values = new string[maxSize];
            Top1 = -1;
            Top2 = maxSize;
        }
        public void Push1(string value)
        {
            if (isFull())
            {
                Console.WriteLine("no hay espacio");
            }
            else
            {
                Top1++;
                Values[Top1] = value;
            }
        }
        public void Push2(string value)
        {
            if (isFull())
            {
                Console.WriteLine("no hay espacio");
            }
            else
            {
                Top2--;
                Values[Top2] = value;
            }
        }
        public string Pop1()
        {
            if (Top1 == -1)
            {
                return "Stack1 is empty";
            }
            else
            {
                int oldTop = Top1;
                Top1 --;
                return Values[oldTop];
            }
        }
        public string Pop2()
        {
            if (Top2 == MaxSize)
            {
                return "Stack2 is empty";
            }
            else
            {
                int oldTop = Top2;
                Top2++;
                return Values[oldTop];
            }
        }
        public string Peek1()
        {
            if (Top1 == -1)
            {
                return "Stack1 is empty";
            }
            else
            {
                return Values[Top1];
            }
        }
        public string Peek2()
        {
            if (Top2 == MaxSize)
            {
                return "Stack2 is empty";
            }
            else
            {
                return Values[Top2];
            }
        }
        public bool isFull()
        {
            return (Top1 + 1) >= Top2;
        }
    }
}
