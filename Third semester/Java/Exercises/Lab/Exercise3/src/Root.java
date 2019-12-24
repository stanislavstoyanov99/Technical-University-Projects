import java.util.Scanner;

public class Root {
    public float CalculateRoot() {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter a number to calculate root: ");
        double numberToCalculateRoot = sc.nextDouble();

        System.out.print("Enter a root number: ");
        double inputroot = sc.nextDouble();

        System.out.print("Enter n: ");
        int m = sc.nextInt();

        System.out.print("Enter m: ");
        int n = sc.nextInt();

        float result = m * (float)Math.pow(n, 2);
        // double result = Math.pow(numberToCalculateRoot, inputroot);

        return result;
    }
}
