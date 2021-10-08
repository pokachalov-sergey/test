using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().TrimEnd().Split(' ');
        StringBuilder cond = new StringBuilder(inputs[0]);

        for (int i = 1; i < inputs.Length; i += 2)
            cond.Replace(inputs[i], inputs[i + 1] == "True" ? "1" : "0");

        cond.Replace("!1", "0");
        cond.Replace("!0", "1");

        cond.Replace("1&0", "0");
        cond.Replace("0&1", "0");
        cond.Replace("1&1", "1");
        cond.Replace("0&0", "0");

        cond.Replace("1|0", "1");
        cond.Replace("0|1", "1");
        cond.Replace("1|1", "1");
        cond.Replace("0|0", "0");

        cond.Replace("1!=0", "1");
        cond.Replace("0!=1", "1");
        cond.Replace("1!=1", "0");
        cond.Replace("0!=0", "0");

        cond.Replace("1=0", "0");
        cond.Replace("0=1", "0");
        cond.Replace("1=1", "1");
        cond.Replace("0=0", "1");

        Console.WriteLine(cond.ToString().Trim() == "1" ? "True" : "False");
    }
}



