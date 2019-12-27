package com.calculator;

import java.util.Map;
import java.util.HashMap;

public class Calculator {
    private char operation;
    private double firstOperand;
    private double secondOperand;

    private Map<Character, Operation> operationMap = new HashMap<>();

    public Calculator(double firstOperand, double secondOperand, char operation) {
        this.firstOperand = firstOperand;
        this.secondOperand = secondOperand;
        this.operation = operation;

        operationMap.put('+', new Addition());
        operationMap.put('-', new Subtraction());
        operationMap.put('*', new Multiplication());
        operationMap.put('/', new Division());
    }

    public String makeCalculation() {
        Operation operationMapValue = operationMap.getOrDefault(operation, new NoOperationFound());

        double result = operationMapValue.calculateResult(firstOperand, secondOperand);
        return "Result: " + result;
    }
}
