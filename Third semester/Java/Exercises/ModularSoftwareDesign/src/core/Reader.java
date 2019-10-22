package core;

import contracts.IReader;

import java.util.Scanner;

public class Reader implements IReader {
    private Scanner scanner;

    @Override
    public String readLine() {

        this.scanner = new Scanner(System.in);
        return scanner.nextLine();
    }
}
