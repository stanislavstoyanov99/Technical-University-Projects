package core;

import contracts.IManagerController;
import contracts.IReader;

import java.util.HashMap;
import java.util.Set;

public class ManagerController implements IManagerController {
    private HashMap<Integer, Integer> accounts;
    private Set<Integer> accts;
    private final double rate = 0.01;
    private int nextacct = 0;
    private int current = -1;
    private int initialBalance = 0;
    private boolean result;
    private IReader reader;

    public ManagerController(IReader reader, HashMap<Integer, Integer> accounts){
        this.reader = reader;
        this.accounts = accounts;
    }

    @Override
    public void quit() {
        System.out.println("Goodbye!");
    }

    @Override
    public void newAccount() {
        current = nextacct++;
        accounts.put(current, this.initialBalance);
        System.out.println("Your new account number is " + current);
    }

    @Override
    public void select() {
        System.out.print("Enter account#: ");
        current = Integer.parseInt(this.reader.readLine());

        this.result = ValidateData(accounts, current);

        if (this.result == true) {
            return;
        }

        int balance = accounts.get(current);
        System.out.printf("The balance of account %d is %d%n", current, balance);
    }

    @Override
    public void deposit() {
        System.out.print("Enter deposit amount: ");
        int amount = Integer.parseInt(this.reader.readLine());

        this.result = ValidateData(accounts, current);

        if (this.result == true) {
            return;
        }

        int balance = accounts.get(current);
        accounts.put(current, balance + amount);
    }

    @Override
    public void authorizeLoan() {
        System.out.print("Enter loan amount: ");
        int loanAmount = Integer.parseInt(this.reader.readLine());

        this.result = ValidateData(accounts, current);

        if (this.result == true) {
            return;
        }

        int balance = accounts.get(current);
        String resultMessage = "";

        if (balance >= loanAmount / 2) {
            resultMessage = "Your loan is approved.";
        }
        else {
            resultMessage = "Your loan is denied";
        }

        System.out.println(resultMessage);
    }

    @Override
    public void showAll() {
        this.accts = accounts.keySet();
        System.out.printf("The bank has %d accounts", this.accts.size());

        for (int i : this.accts) {
            System.out.printf("\n\tBank account %d: balance = %d%n", i, accounts.get(i));
        }
    }

    @Override
    public void addInterest() {
        this.accts = accounts.keySet();
        for (int i : accts) {
            int balance = accounts.get(i);
            int newBalance = (int) (balance * (1 + rate));
            accounts.put(i, newBalance);
        }
    }

    private boolean ValidateData(HashMap<Integer, Integer> accounts, int current) {
        boolean isFinished = false;

        if (!accounts.containsKey(current)) {
            System.out.println("The account number is invalid.");
            isFinished = true;
        }

        return  isFinished;
    }
}
