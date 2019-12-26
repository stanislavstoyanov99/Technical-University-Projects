package com.circle;

import javax.swing.*;
import java.awt.*;
import java.awt.geom.Ellipse2D;

public class Circle {
    private Point center;
    private double radius;

    public Circle(double centerX, double centerY, double radius) {
        this.center = new Point();

        this.center.setLocation(centerX, centerY);
        this.radius = radius;
    }

    public Circle () {
        this(0, 0, 1);
    }

    public void draw() {
        JFrame frame = new JFrame();

        frame.setSize(500, 500);
        frame.setTitle("Circle visualization");
        frame.setVisible(true);

        JPanel panel = new JPanel() {
            public void paint(Graphics graphics) {
                var graphics2D = (Graphics2D)graphics;

                double x = center.getX() - radius;
                double y = center.getY() - radius;
                double width = radius * 2;
                double height = radius * 2;

                Shape circle = new Ellipse2D.Double(x, y, width, height);

                graphics2D.draw(circle);
            }
        };

        frame.getContentPane().add(panel);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    public boolean isInside(Point point) {
        double deltaX = point.getX() - this.center.getX();
        double deltaY = point.getY() - this.center.getY();

        double distanceSquared = deltaX * deltaX + deltaY * deltaY;

        double radiusSquared = this.radius * this.radius;

        if (distanceSquared == radiusSquared) { //distance == radius -> on circle
            return true;
        }
        else if (distanceSquared < radiusSquared) { //distance < radius -> in circle
            return true;
        }
        else { //out of circle
            return false;
        }
    }

    @Override
    public boolean equals(Object obj) {
        if (obj instanceof Circle) {
            Circle other = (Circle)obj;
            return this.center.getX() == other.center.getX() &&
                    this.center.getY() == other.center.getY() &&
                    this.radius == other.radius;
        }
        else {
            return false;
        }
    }

    @Override
    public String toString() {
        return "center: [" + this.center.getX() + ", " + this.center.getY() + "]" + "\nradius: " + this.radius;
    }
}
