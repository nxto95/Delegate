namespace Delegate;

/// <summary>
/// Delegate 
/// Func<nTypes params,output type> tack any number of params and return a type you specify,
/// Predicate<nTypes params> return bool result
/// Action<nTypes params> return void result
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        FilterNumbers([1, 2, 3, 4, 5, 6], (num) => num != 3);
    }

    static void FilterNumbers(int[] nums, Predicate<int> where)
    {
        foreach (int num in nums)
        {
            if (where(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}

