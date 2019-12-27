package com.calculator;

public class Addition implements  Operation {

    @Override
    public double calculateResult(double left, double right) {
        return left + right;
    }
}
