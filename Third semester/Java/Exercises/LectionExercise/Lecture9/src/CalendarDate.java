public class CalendarDate implements Comparable<CalendarDate> {
    private int month;
    private int day;

    public CalendarDate(int month, int day) {
        this.month = month;
        this.day = day;
    }

    public int getMonth() {
        return this.month;
    }

    public int getDay() {
        return this.day;
    }

    // Compares two dates by month and then by day.
    @Override
    public int compareTo(CalendarDate other) {
        if (month != other.month) {
            return month - other.month;
        }
        else {
            return day - other.day;
        }
    }

    public String toString() {
        return this.month + "/" + day;
    }
}
