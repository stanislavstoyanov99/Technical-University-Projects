public class MyThread extends Thread {
    private String mName;
    private long mTimeInterval;

    public MyThread(String aName, long aTimeInterval) {
        mName = aName;
        mTimeInterval = aTimeInterval;
    }

    public void run() {
        try {
            while(!isInterrupted()) {
                System.out.println(mName);
                sleep(mTimeInterval);
            }
        }
        catch (InterruptedException intEx) {
            // Current thread interrupted by another thread
        }
    }
}
