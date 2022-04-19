using ListsIteration;

var numbers = new List<int>
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    10
};

Console.WriteLine("Default List");
var defaultList = DefaultListIteration.GetDoubledNumbers(numbers);

PrintNumbers(defaultList);

Console.WriteLine("Default With Threshhold List");
var thresholdedList = DefaultListIteration.GetDoubledNumbersIfMoreThanThreshhold(numbers, 5);

PrintNumbers(thresholdedList);

Console.WriteLine("Yield List");
var yieldList = YieldListIteration.GetDoubledNumbers(numbers);

PrintNumbers(yieldList);

Console.WriteLine("Yield Break List");
var yieldBreak = YieldListIteration.GetDoubledNumbersIfMoreThanThreshhold(numbers, 5);

PrintNumbers(yieldBreak);

Console.WriteLine("Yield With Exception List");
var exceptionYieldList = YieldListIteration.GetDoubleNumbersWithExceptionHappening(numbers, 5);

PrintNumbers(exceptionYieldList);

Console.WriteLine("Yield Async List");
var asyncYieldList = YieldListIteration.GetDoubledNumbersAsync(numbers);

await PrintNumbersAsync(asyncYieldList);

void PrintNumbers(IEnumerable<int> list)
{
    Console.WriteLine();
    
    foreach(var i in list)
    {
        Console.Write(i + ", ");
    }
}

async Task PrintNumbersAsync(IAsyncEnumerable<int> list)
{
    Console.WriteLine();
    
    await foreach(var i in list)
    {
        Console.Write(i + ", ");
    }
}