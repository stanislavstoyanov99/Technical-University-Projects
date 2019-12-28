package bank;

public class ClientThread extends Thread {
    private double amount;
    private Account account;

    ClientThread(Account account, double amount) {
        this.account = account;
        this.amount = amount;
    }

    @Override
    public void run() {
        account.setAmount(amount);
    }
}
