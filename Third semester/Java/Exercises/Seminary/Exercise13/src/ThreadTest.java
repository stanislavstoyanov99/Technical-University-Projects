public class ThreadTest {
    public static void main(String[] args) {
        MyThread thread1 = new MyThread("thread 1", 1000);
        MyThread thread2 = new MyThread("thread 2", 2000);
        MyThread thread3 = new MyThread("thread 3", 1500);

        thread1.start();
        thread2.start();
        thread3.start();
    }
}
