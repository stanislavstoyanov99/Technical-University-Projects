public class StartUp {
    private  static int counter = 0;

    public static synchronized void increment() {
        ++counter;
    }

    public static void process() {
        Thread firstThread = new Thread((new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < 100; i++) {
                    increment();
                }
            }
        }));

        Thread secondThread = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < 100; i++) {
                    increment();
                }
            }
        });

        firstThread.start();
        secondThread.start();

        try {
            firstThread.join();
            secondThread.join();
        } catch (InterruptedException e) {
            System.out.println(e.getMessage());
        }
    }

    public static void main(String[] args) {
        //process();

        /*Thread firstThread = new Thread(new Runner1());
        Thread secondThread = new Thread((new Runner2()));

        firstThread.start();
        secondThread.start();

        System.out.println("Finished the tasks ...");
         */

        /*new A().start();
        new B().start();
        new C().start();
         */

        A threadA = new A();
        B threadB = new B();
        C threadC = new C();

        threadA.setPriority(Thread.MIN_PRIORITY); // min_priority => 1
        threadB.setPriority(threadA.getPriority() + 1); // priority => 2
        threadC.setPriority(Thread.MAX_PRIORITY); // priority => 10

        System.out.println("Started Thread A");
        threadA.start();
        System.out.println("Started Thread B");
        threadB.start();
        System.out.println("Started Thread C");
        threadC.start();

        System.out.println("End of main thread.");
    }
}
