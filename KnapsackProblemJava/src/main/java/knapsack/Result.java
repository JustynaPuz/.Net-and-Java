package knapsack;

import java.util.HashMap;

public record Result(HashMap<Item, Integer> itemsIn, int totalValue, int totalWeight) {
    @Override
    public String toString() {
        StringBuilder output = new StringBuilder();
        for(Item item : itemsIn().keySet()) {
                output.append(item.toString()).append(" Quantity: ").append(itemsIn.get(item));
                output.append("\n");

        }
        output.append("TotalValue: ").append(totalValue).append(" TotalWeight: ")
                .append(totalWeight).append("\n");
        return output.toString();
    }

}
