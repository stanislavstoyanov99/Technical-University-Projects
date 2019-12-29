import java.util.ArrayList;
import java.util.Collections;

public class StartUp {
    public static void main(String[] args) {
        ArrayList<Integer> list = new ArrayList<Integer>();
        list.add(13);
        list.add(47);
        list.add(15);
        list.add(9);
        int sum = 0;

        for(int n : list) {
            sum += n;
        }

        System.out.println("list = " + list);
        System.out.println("sum = " + sum);

        ArrayList<String> words = new ArrayList<String>();
        words.add("four");
        words.add("score");
        words.add("and");
        words.add("seven");
        words.add("years");
        words.add("ago");

        // show list before and after sorting
        System.out.println("before sort, words = " + words);
        Collections.sort(words);
        System.out.println("after sort, words = " + words);

        CalendarDate calendarDate = new CalendarDate(6, 30);
        System.out.println(calendarDate.compareTo(new CalendarDate(5, 15)));
    }
}
