import java.time.LocalDate;

public class StartUp {

    public static void main(String[] args) {
        MinutesAndSeconds minutesAndSeconds = new MinutesAndSeconds();
        String result = minutesAndSeconds.calculateMinutesAndSeconds();
        System.out.println(result);

        Root root = new Root();
        double rootResult = root.calculateRoot();
        System.out.println(rootResult);

        DayAfter10Days dayAfter10Days = new DayAfter10Days();
        LocalDate date = dayAfter10Days.calculateDayAfter10Days();
        System.out.println(date);
    }
}
