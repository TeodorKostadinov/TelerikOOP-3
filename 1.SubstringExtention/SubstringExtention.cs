using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class SubstringExtention
{
    public static StringBuilder Substring(this StringBuilder sb, int index, int length)
    {
        StringBuilder rezult = new StringBuilder();
        for (int i = index; i < index + length; i++)
        {
            rezult.Append(sb[i]);
        }
        return rezult;
    }
}

class Test
{
    static void Main()
    {
        StringBuilder aSb = new StringBuilder();
        for (int i = 0; i < 50; i++)
        {
            aSb.Append(i.ToString());
        }

        StringBuilder newSBdr=aSb.Substring(5, 7);
        Console.WriteLine(newSBdr.ToString());
    }
}


