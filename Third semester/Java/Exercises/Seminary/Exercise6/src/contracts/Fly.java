package contracts;

public interface Fly {
    int getWingSpan() throws Exception;
    static final int MAX_SPEED = 100;

    default void land() {
        System.out.println("Animal is landing");
    }

    static double calculateSpeed(float distance, double time) {
        return distance / time;
    }
}
