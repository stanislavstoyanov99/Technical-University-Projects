import java.util.Arrays;

public class SortingThread extends Thread {
    private ArrayConstruction arrConstr;

    public SortingThread(ArrayConstruction arrConstr) {
        this.arrConstr = arrConstr;
    }

    @Override
    public void run() {
        synchronized (this) {
            Arrays.sort(arrConstr.array);
        }
    }
}
