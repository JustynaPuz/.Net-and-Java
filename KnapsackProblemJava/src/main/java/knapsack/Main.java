package knapsack;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("Give number of items:");
        int numberOfItems = Integer.parseInt(scanner.nextLine());
        System.out.println("Give seed:");
        int seed = Integer.parseInt(scanner.nextLine());
        System.out.println("Give knapsack capacity:");
        int capacity  = Integer.parseInt(scanner.nextLine());

        Problem problem = new Problem(numberOfItems, seed, 10,1);
        Result result = problem.solve(capacity);
        System.out.println(result.toString());
    }

}
