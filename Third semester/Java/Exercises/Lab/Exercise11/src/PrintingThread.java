public class PrintingThread extends Thread {
    ArrayConstruction arrConstr;

    public PrintingThread(ArrayConstruction arrConstr) {
        this.arrConstr = arrConstr;
    }

    @Override
    public void run() {
        arrConstr.print();
    }
}
