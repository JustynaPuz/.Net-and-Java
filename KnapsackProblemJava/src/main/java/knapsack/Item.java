package knapsack;

public class Item {
    private final int value;
    private final int weight;
    private final int id;
    private final float valueToWeightRatio;

    public Item(int value, int weight, int id) {
        this.value = value;
        this.weight = weight;
        this.id = id;
        if(weight > 0 ) {
            valueToWeightRatio = (float)value /(float)weight;
        }else {
            throw new ArithmeticException("Cannot divide by zero");
        }
    }
    public int getValue() {
        return value;
    }
    public int getWeight() {
        return weight;
    }

    public int getId() {
        return id;
    }

    public float getValueToWeightRatio() {
        return valueToWeightRatio;
    }

    @Override
    public String toString() {
        return "Item: " +
                "id = " + id +
                ",value = " + value +
                ", weight = " + weight
                ;
    }
}
