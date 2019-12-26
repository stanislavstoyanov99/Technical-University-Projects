package com.circle;

import java.awt.*;

public class MainCircle {
    public static void main(String[] args) {
        Circle firstCircle = new Circle(100, 100, 100);
        firstCircle.draw();
        System.out.println(firstCircle);

        Circle secondCircle = new Circle(300, 300, 50);
        System.out.println(secondCircle);

        System.out.println(firstCircle.equals(secondCircle));

        Point point = new Point();
        point.setLocation(100, 100);

        System.out.println(firstCircle.isInside(point));
        System.out.println(secondCircle.isInside(point));
    }
}
