public class A extends Thread {
    @Override
    public void run() {
        System.out.println("Thread A started");

        for (int i = 1; i <= 5; i++) {
            System.out.println("\t From ThreadA: i = " + i);

            /*try {
                Thread.sleep(5);
                System.out.println("Exit from A");
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
             */
        }

        System.out.println("Exit from A");
    }
}
