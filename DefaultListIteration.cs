namespace ListsIteration;

public static class DefaultListIteration
{
    public static List<int> GetDoubledNumbers(List<int> list)
    {
        var result = new List<int>();

        foreach(var i in list)
        {
            result.Add(i * 2);
        }

        return result;
    }

    public static List<int> GetDoubledNumbersIfMoreThanThreshhold(List<int> list, int threshhold)
    {
        var result = new List<int>();
        list.Sort();

        foreach(var i in list)
        {
            if (i >= threshhold)
            {
                break;
            }
            
            result.Add(i * 2);
        }

        return result;
    }
}