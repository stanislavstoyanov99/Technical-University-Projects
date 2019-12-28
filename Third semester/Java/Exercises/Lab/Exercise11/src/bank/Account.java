package bank;

public class Account {
    private double currentAmount = 0;

    public synchronized void setAmount(double amount) {
        this.currentAmount += amount;
    }

    double getAmount() {
        return currentAmount;
    }
}
