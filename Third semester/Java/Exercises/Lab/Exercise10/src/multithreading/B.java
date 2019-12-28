package multithreading;

public class B extends Thread {
    @Override
    public void run() {
        System.out.println("Thread B started");

        for (int j = 1; j <= 5; j++) {
            System.out.println("\t From ThreadB: j = " + j);

            /*try {
                Thread.sleep(5);
                System.out.println("Exit from B");
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
             */
        }

        System.out.println("Exit from B");
    }
}
