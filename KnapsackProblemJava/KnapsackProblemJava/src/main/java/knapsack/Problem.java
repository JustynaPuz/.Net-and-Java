package knapsack;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.HashMap;
import java.util.List;
import java.util.Random;

public class Problem {
    private final int numberOfItemTypes;
    private final int seed;
    private final int upperBound;
    private final int lowerBound;
    private final List<Item> items;

    public Problem(int numberOfItemTypes, int seed, int upperBound, int lowerBound) {
        this.numberOfItemTypes = numberOfItemTypes;
        this.seed = seed;
        this.upperBound = upperBound;
        this.lowerBound = lowerBound;
        items = new ArrayList<Item>();
        generateProblem();
    }
    public Problem(List<Item> items) {
        this.numberOfItemTypes = 0;
        this.seed = 0;
        this.upperBound = 0;
        this.lowerBound = 0;
        this.items = items;
    }

    public List<Item> getItems() {
        return items;
    }

    private void generateProblem() {
        Random random = new Random(seed);

        for(int i =0; i < numberOfItemTypes; i++) {
            items.add(new Item(random.nextInt(upperBound - lowerBound) + lowerBound, random.nextInt(upperBound - lowerBound) + lowerBound, i));
        }
    }
    public Result solve(int capacity) {

        List<Item> sortedItems = items.stream().sorted(Comparator.comparing(Item::getValueToWeightRatio).reversed()).toList();
        int totalWeight =0;
        int totalValue =0;
        int index=0;
        HashMap<Item, Integer> itemsIn = new HashMap<>();

        int numberOfItem = 0;
        while(totalWeight != capacity && index < (sortedItems.size())) {
            if(totalWeight + sortedItems.get(index).getWeight() <= capacity ) {
                totalWeight += sortedItems.get(index).getWeight();
                totalValue += sortedItems.get(index).getValue();
                numberOfItem++;
            }else {
                if(numberOfItem > 0) {
                    itemsIn.put(sortedItems.get(index), numberOfItem);
                }
                numberOfItem=0;
                index++;
            }
        }
        if(numberOfItem > 0) {
            itemsIn.put(sortedItems.get(index), numberOfItem);
        }
        return new Result(itemsIn, totalValue, totalWeight);

    }

    public String itemsToString() {
        StringBuilder output = new StringBuilder();
        for(Item item : items) {
            output.append(item.toString());
            output.append("\n");
        }
        return output.toString();
    }
}
