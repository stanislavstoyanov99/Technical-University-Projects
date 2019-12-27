package com.calculator;

public class Subtraction implements Operation {

    @Override
    public double calculateResult(double left, double right) {
        return left - right;
    }
}
