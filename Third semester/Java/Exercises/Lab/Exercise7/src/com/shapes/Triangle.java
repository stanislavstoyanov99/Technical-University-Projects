package com.shapes;

public class Triangle extends Shape {
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    @Override
    public double calculateArea() {
        double perimeter = calculatePerimeter() / 2;
        double area = Math.sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
        return area;
    }

    @Override
    public double calculatePerimeter() {
        return a + b + c;
    }
}
