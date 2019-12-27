package com.shapes;

import com.shapes.contracts.IShape;

public abstract class Shape implements IShape {
    @Override
    public abstract double calculateArea();

    @Override
    public abstract double calculatePerimeter();

    @Override
    public void printAreaAndPerimeter() {
        System.out.println("Type: " + this.getClass().getSimpleName() + "\nArea: " + calculateArea() + "\nPerimeter: " + calculatePerimeter());
    }
}
