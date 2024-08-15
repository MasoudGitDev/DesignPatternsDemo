using Shared.Services;
using Strategy.Example_2.Abstractions;

namespace Strategy.Example_2.SortMethods;
internal class BubbleSort : ISortStrategy {
    public int[] Sort(int[] numbers) {
        Console.WriteLine(string.Join(", " , numbers));
        int temp;
        for(int x = 0 ; x <= numbers.Length - 2 ; x++) {
            for(int y = 0 ; y <= numbers.Length - 2 ; y++) {
                if(numbers[y] > numbers[y + 1]) {
                    temp = numbers[y + 1];
                    numbers[y + 1] = numbers[y];
                    numbers[y] = temp;
                }
            }
        }
        Logger.Log("Bubble sort : " + string.Join(',' , numbers));
        return numbers;
    }
}
