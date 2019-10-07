import java.text.DecimalFormat;
import java.util.Scanner;

public class CurrencyConverter {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("#.00");

        System.out.println("Which currency do you want to convert?");
        System.out.println("1: Pound to BGN \t2: Euro to BGN \t3: Dollar to BGN");
        int code = sc.nextInt();

        System.out.println("How much money do you want to convert?");
        double inputSum = sc.nextDouble();

        double resultSum = ConvertInputSum(code, inputSum, df);
    }

    public static double ConvertInputSum(int code, double inputSum, DecimalFormat df) {
        double resultSum = 0;

        switch (code) {
            case 1:
                resultSum = inputSum * 2.53405;
                System.out.println("Your " + inputSum + " pound is: " + df.format(resultSum) + " BGN");
                break;
            case 2:
                resultSum = inputSum / 1.95583;
                System.out.println("Your " + inputSum + " euro is: " + df.format(resultSum) + " BGN");
                break;
            case 3:
                resultSum = inputSum * 1.79549;
                System.out.println("Your " + inputSum + " dollars is: " + df.format(resultSum) + " BGN");
                break;
            default:
                System.out.println("Invalid choice for currency.");
        }

        return resultSum;
    }
}