package knapsack;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

import java.util.Arrays;
import java.util.List;
import org.junit.jupiter.api.Test;

class ProblemTest {

    @Test
    void TestAtLeastOneElement() {
        Problem problem = new Problem(1, 1, 10,1);
        Result result = problem.solve(30);
        assertFalse(result.itemsIn().isEmpty());
    }

    @Test
    void TestNoElement() {
        Problem problem = new Problem(1, 1, 50,10);
        Result result = problem.solve(8);
        assertEquals(result.itemsIn().size(), 0);

    }
    @Test
    void TestValueWeightUpperBound() {
        int upperBound = 10;
        int lowerBound =1;
        Problem problem = new Problem(10, 89, upperBound,lowerBound);
        assertTrue(problem.getItems().stream().allMatch(item -> item.getWeight() <= upperBound && item.getValue() <= upperBound));
    }
    @Test
    void TestValueWeightLowerBound() {
        int upperBound = 10;
        int lowerBound =1;
        Problem problem = new Problem(10, 89, upperBound,lowerBound);
        assertTrue(problem.getItems().stream().allMatch(item -> item.getWeight() >= lowerBound && item.getValue() >= lowerBound));
    }

    @Test
    void TestCorrectnessOfTheResult() {
        List<Item> items = Arrays.asList(new Item(10,5,0), new Item(5,2,1));
        Problem problem = new Problem(items);
        Result result = problem.solve(21);
        assertEquals(result.totalValue(), 50);
        assertEquals(result.totalWeight(), 20);

    }
}