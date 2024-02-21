using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Practice.HashTableOpenAdressing
{
    public class HashTable
    {
        public int[] Values {  get; set; }
        private int MaxSize {  get; set; }
        

        public HashTable(int MaxSize) 
        {
            this.MaxSize = MaxSize;
            this.Values = new int[MaxSize];
        }

        public int Add(int value)
        {
            int modulo = value % this.MaxSize;

            while ((Values[modulo] != 0) && modulo < this.MaxSize)
            {
                modulo++;
            }
            if (modulo != this.MaxSize)
            {
                Values[modulo] = value;
                return modulo;
            }

            return -1;
        }

        public int Search(int value)
        {
            int modulo = value % this.MaxSize;

            while ((Values[modulo] != 0) && modulo < this.MaxSize && Values[modulo] != value)
            {
                modulo++;
            }
            if (modulo != this.MaxSize && Values[modulo] == value)
            {
                return modulo;
            }

            return -1;
        }

        public string Delete(int value)
        {
            int modulo = value % this.MaxSize;

            while (Values[modulo] != value  && modulo < this.MaxSize -1)
            {
                modulo++;
            }
            if (Values[modulo] == value)
            {
                Values[modulo] = -1;
                return "borrado con exito";
            }
            return "no encontrado";
        }

    }
}
