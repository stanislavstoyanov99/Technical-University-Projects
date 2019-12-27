package com.calculator;

import java.util.InputMismatchException;
import java.util.Scanner;

public class MainCalculator {
    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.println("Write two numbers on two lines and +, -, * or / sign");
        char operator = 0;
        double firstNumber = 0;
        double secondNumber = 0;

        try {
            System.out.print("First number: ");
            firstNumber = scanner.nextDouble();

            System.out.print("Second number: ");
            secondNumber = scanner.nextDouble();

            System.out.print("Sign: ");
            operator = scanner.next().charAt(0);
        } catch (InputMismatchException ime) {
            System.out.println("Invalid input.");
        } finally {
            if (operator != '+' & operator != '-' & operator != '*' & operator != '/') {
                throw new InputMismatchException();
            }

            Calculator calculator = new Calculator(firstNumber, secondNumber, operator);
            System.out.println(calculator.makeCalculation());
        }
    }
}
