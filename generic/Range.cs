using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Start { get; }
        public T End { get; }
        public Range(T start, T end)
        {
            if (start.CompareTo(end) > 0)
            {
                throw new ArgumentException("Start must be less than or equal to End.");
            }
            Start = start;
            End = end;
        }
        public bool Contains(T value)
        {
            return value.CompareTo(Start) >= 0 && value.CompareTo(End) <= 0;
        }
        public T Length()
        {
            dynamic start = Start;
            dynamic end = End;
            return end - start; // Assuming T supports subtraction
        }
        public override string ToString()
        {
            return $"Range: [{Start} - {End}]";
        }
    }
    
}

