package com.calculator;

public class Multiplication implements Operation {

    @Override
    public double calculateResult(double left, double right) {
        return left * right;
    }
}
