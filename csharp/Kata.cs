using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
    public static long KiyoLCM(Object[][] a)
    {
        try
        {
            // Remove all even integers from each sub-array.
            Object[][] noEven = RemoveEven(a);

            // Sum the remaining odd integers of each sub-array. 
            long[] oddSums = SumOdd(noEven);

            // Find the Least common multiple of the arrays.
            return LCM(oddSums);
        }
        catch (Exception)
        {
            
            return 0;
        }
    }

    /// <summary>
    /// Remove all even integers from each sub-array.
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    private static Object[][] RemoveEven(Object[][] a)
    {

        return a.Select(objectList => 
            objectList.Where(obj => 
                {
                    string s = string.Format("{0}", obj);
                    int result = 0;
                    if(!Int32.TryParse(s, out result)){
                        // remove non-integers
                        return false;
                    }
                    return result % 2 == 1;
                }).ToArray()
        ).ToArray();
    }

    /// <summary>
    /// Sum the remaining odd integers of each sub-array. 
    /// </summary>
    /// <param name="odds"></param>
    /// <returns></returns>
    private static long[] SumOdd(Object[][] odds)
    {
        return odds.Select(oddList =>
            oddList.Sum(odd => Int64.Parse(string.Format("{0}", odd)))
        ).Distinct().ToArray();;
    }

    /// <summary>
    /// Calculate GCD of 2 number
    /// </summary>
    /// <param name="n1"></param>
    /// <param name="n2"></param>
    /// <returns></returns>
    private static long GCD(long n1, long n2)
    {
        return n2 == 0 ? n1 : GCD(n2, n1 % n2);
    }

    /// <summary>
    /// Find the Least common multiple of the arrays.
    /// </summary>
    /// <param name="oddSums"></param>
    /// <returns></returns>
    private static long LCM(long[] oddSums)
    {
        return oddSums.Aggregate((a, b) => 
            { 
                if (a % b == 0) 
                    return a;
                if (b % a == 0) 
                    return b;
                long gcd = GCD(a, b);
                return a * b / gcd; 
            });;
    }
}

