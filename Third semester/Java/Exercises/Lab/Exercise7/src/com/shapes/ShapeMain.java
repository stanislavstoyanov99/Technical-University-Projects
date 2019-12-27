package com.shapes;

import com.shapes.contracts.IShape;

import java.util.ArrayList;
import java.util.Scanner;

public class ShapeMain {
    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        ArrayList<IShape> shapes = new ArrayList<IShape>();

        System.out.print("Enter shape: ");
        String shapeType = scanner.next();

        ArrayList<Object> parameters = new ArrayList<Object>();
        System.out.print("Enter shape parameters: ");

        switch (shapeType) {
            case "circle":
                double radius = scanner.nextDouble();
                parameters.add(radius);
                break;
            case "triangle":
                double a = scanner.nextDouble();
                double b = scanner.nextDouble();
                double c = scanner.nextDouble();
                parameters.add(a);
                parameters.add(b);
                parameters.add(c);
                break;
            case "rectangle":
                double width = scanner.nextDouble();
                double height = scanner.nextDouble();
                parameters.add(width);
                parameters.add(height);
                break;
            default:
                System.out.println("Type could not be found.");
                return;
        }

        shapes.add(ShapeMaker.makeShape(shapeType, parameters));

        printAll(shapes);
    }

    public static void printAll(ArrayList<IShape> shapes) {
        for (int i = 0; i < shapes.size(); i++) {
            shapes.get(i).printAreaAndPerimeter();
        }
    }
}
