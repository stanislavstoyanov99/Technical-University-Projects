import java.util.Scanner;

public class MinutesAndSeconds {
    public String CalculateMinutesAndSeconds() {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter an integer for seconds: ");
        int inputSeconds = sc.nextInt();

        int minutes = inputSeconds / 60;
        int seconds = inputSeconds % 60;

        String result = String.format("%s seconds is %s minutes and %s seconds", inputSeconds, minutes, seconds);
        return result;
    }
}
