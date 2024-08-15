using Shared.Services;
using Strategy.Example_2.Abstractions;

namespace Strategy.Example_2.SortMethods;

internal class BinarySort : ISortStrategy {
    public int[] Sort(int[] numbers) {
        for(int i = 1 ; i < numbers.Length ; i++) {
            int key = numbers[i];
            int left = 0;
            int right = i;
            while(left < right) {
                int middle = (left + right) / 2;
                if(key < numbers[middle]) {
                    right = middle;
                }
                else {
                    left = middle + 1;
                }
            }
            for(int j = i ; j > left ; j--) {
                numbers[j] = numbers[j - 1];
            }
            numbers[left] = key;
        }
        Logger.Log("Binary sort : " + string.Join(',' , numbers));
        return numbers;
    }
}
