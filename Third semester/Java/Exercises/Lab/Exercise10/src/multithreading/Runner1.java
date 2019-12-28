package multithreading;

public class Runner1 implements Runnable {
    @Override
    public void run() {
        for (int number = 0; number <= 100; number++) {
            System.out.println("Runner1: " + number);

            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                System.out.println(e.getMessage());
            }
        }
    }
}
