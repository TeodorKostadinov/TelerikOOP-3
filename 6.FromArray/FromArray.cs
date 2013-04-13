using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FromArray
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        for (int i = 0; i < 420; i++)
        {
            numList.Add(i);
        }
        //creating lists
        var lambdaList = numList.FindAll(x => (x % 7 == 0) && (x % 3 == 0));
        var linqList =
            from number in numList
            where number % 21 == 0
            select number;
        //printing
        Console.WriteLine("The numbers found with lambda exp");
        foreach (var num in lambdaList)
        {
            Console.Write("{0} ",num);
        }
        Console.WriteLine();
        Console.WriteLine("The numbers found with linq");
        foreach (var num in linqList)
        {
            Console.Write("{0} ", num);
        }
    }
}

