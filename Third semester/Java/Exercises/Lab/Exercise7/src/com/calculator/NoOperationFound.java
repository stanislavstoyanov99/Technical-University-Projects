package com.calculator;

import java.util.InputMismatchException;

public class NoOperationFound implements Operation {

    @Override
    public double calculateResult(double left, double right) {
        throw new InputMismatchException("Invalid operator sign.");
    }
}
