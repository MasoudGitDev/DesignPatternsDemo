using Strategy.Example_2.Abstractions;

namespace Strategy.Example_2;
internal class SortStrategyContext(ISortStrategy sortStrategy) {
    private ISortStrategy _sortStrategy = sortStrategy;
    public void SetStrategy(ISortStrategy strategy) {
        _sortStrategy = strategy;
    }

    public int[] Sort(int[] numbers) {
        return _sortStrategy.Sort(numbers);        
    }

}
