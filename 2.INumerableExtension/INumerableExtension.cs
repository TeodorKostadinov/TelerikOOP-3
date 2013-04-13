using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class INumerableExtension
{
    public static T Sum<T>(this IEnumerable<T> additiveFirst) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        T sum = default(T);
        foreach (var item in additiveFirst)
        {
            sum = (dynamic)sum + item;
        }
        return sum;
    }
}
//Test
class Test
{
    static void Main()
    {
        int[] a = new int[]{5,3,5};

        int c = a.Sum();
        Console.WriteLine(c);
    }
}

