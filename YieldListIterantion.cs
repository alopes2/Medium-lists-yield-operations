namespace ListsIteration;

public static class YieldListIteration
{
    public static IEnumerable<int> GetDoubledNumbers(List<int> list)
    {
        foreach (var i in list)
        {
            Console.Write("*");
            yield return i * 2;
        }
    }

    public static IEnumerable<int> GetDoubledNumbersIfMoreThanThreshhold(List<int> list, int threshhold)
    {
        list.Sort();

        foreach (var i in list)
        {
            if (i >= threshhold)
            {
                Console.Write("Break");
                yield break;
            }

            yield return i * 2;
        }
        Console.Write(" End Method");
    }

    public static IEnumerable<int> GetDoubleNumbersWithExceptionHappening(List<int> list, int threshhold)
    {
        list.Sort();

        foreach (var i in list)
        {
            var number = 0;
            try
            {
                if (i >= threshhold)
                {
                    throw new Exception("Exception happened.");
                }

                number = DoubleNumber(i);
            }
            catch (Exception)
            {
                number = -1;
            }

            yield return number;
        }
    }
    
    public static async IAsyncEnumerable<int> GetDoubledNumbersAsync(List<int> list)
    {
        foreach (var i in list)
        {
            await Task.Delay(1000);
            yield return i * 2;
        }
    }

    private static int DoubleNumber(int i) => i * 2;
}