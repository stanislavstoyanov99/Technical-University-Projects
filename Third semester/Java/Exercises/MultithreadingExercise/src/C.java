public class C extends Thread{
    @Override
    public void run() {
        System.out.println("Thread C started");

        for (int k = 1; k <= 5; k++) {
            System.out.println("\t From ThreadC: k = " + k);

            /*try {
                Thread.sleep(5);
                System.out.println("Exit from C");
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            */
        }

        System.out.println("Exit from C");
    }
}
