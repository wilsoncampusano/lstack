using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lstack
{
    public class MStack
    {
        private int[] _elements;
        private readonly int _capacity;

        private int _size;

        private MStack(int capacity)
        {
            if (capacity < 0)
            {
                throw new LessThanZeroCapacity();
            }
            _capacity = capacity;
            _elements = new int[_capacity];
        }

        public static MStack create(int capacity)
        {
            return new MStack(capacity);
        }

        public void Push(int element)
        {
            _elements[_size++] = element;
        }

        public int Pop()
        {
            return _elements[--_size];
        }

        public int getCapacity()
        {
            return _capacity;
        }

        public bool IsEmpty()
        {
            return true;
        }

        public int Size()
        {
            return _size;
        }
    }

    public class LessThanZeroCapacity : Exception
    {
    }
}
