using System;

namespace generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            // Requirements:
            // Create a generic class named Range<T> where T represents the type of values.
            // Implement a constructor that takes the minimum and maximum values to define the range.
            // Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            // Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            // Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

            var intRange = new Range<int>(10, 20);
            Console.WriteLine(intRange); // Range: [10 - 20]
            Console.WriteLine("Is 15 in range? " + intRange.Contains(15)); // True
            Console.WriteLine("Length: " + intRange.Length()); // 10

            var doubleRange = new Range<double>(1.5, 3.2);
            Console.WriteLine(doubleRange); // Range: [1.5 - 3.2]
            Console.WriteLine("Is 2.1 in range? " + doubleRange.Contains(2.1)); // True
            Console.WriteLine("Length: " + doubleRange.Length()); // 1.7


            #endregion
        }
}
}
