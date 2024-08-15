using Shared.Services;
using Strategy.Example_1;
using Strategy.Example_2;
using Strategy.Example_2.SortMethods;

Console.WriteLine("Hello, World! " + Environment.NewLine);

// Example 1
// new MathProgramExecution().Execute();


// Example 2 
int[] numbers = [0,5,6,2,3,4,1];

var bubbleStrategy = new BubbleSort();
var binaryStrategy = new BinarySort();

var useStrategy = new SortStrategyContext(bubbleStrategy);
useStrategy.Sort(numbers);

useStrategy.SetStrategy(binaryStrategy);
useStrategy.Sort(numbers);

