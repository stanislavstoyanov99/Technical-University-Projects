package com.shapes;

import com.shapes.contracts.IShape;

import java.util.ArrayList;

public class ShapeMaker {
    public static IShape makeShape(String type, ArrayList<Object> parameters){
        if (type.toLowerCase().equals("circle")) {
            return new Circle((double)parameters.get(0));
        }
        else if (type.toLowerCase().equals("rectangle")) {
            return new Rectangle((double)parameters.get(0), (double)parameters.get(1));
        }
        else if (type.toLowerCase().equals("triangle")) {
            return new Triangle((double)parameters.get(0), (double)parameters.get(1), (double)parameters.get(2));
        }
        else {
            throw new IllegalArgumentException("Type could not be found.");
        }
    }
}
