package com.linesegment;

import java.awt.*;
import javax.swing.*;
import java.awt.geom.Line2D;

public class LineSegment {
    private Point p;
    private Point t;

    public LineSegment(Point x, Point y) {
        this.p = x;
        this.t = y;
    }

    public LineSegment() {
        this(new Point(0,0), new Point(0, 0));
    }

    public double computeSlope() {
        return (t.getY() - p.getY()) / (t.getX() - p.getX());
    }

    public void draw() {
        JFrame frame = new JFrame();

        frame.setSize(500, 500);
        frame.setTitle("LineSegment visualization");
        frame.setVisible(true);

        JPanel panel = new JPanel() {
            public void paint(Graphics graphics) {
                var graphics2D = (Graphics2D)graphics;

                Shape line = new Line2D.Double(p.getX(), p.getY(), t.getX(), t.getY());

                graphics2D.draw(line);
            }
        };

        frame.getContentPane().add(panel);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    @Override
    public String toString() {
        return "X: [" + this.p.getX() + ", " + this.p.getY() + "]" + " Y: [" + this.t.getX() + ", " + this.t.getY() + "]";
    }

    @Override
    public boolean equals(Object obj) {
        if (obj instanceof LineSegment) {
            LineSegment other = (LineSegment) obj;
            return this.p.getX() == other.p.getX() &&
                    this.p.getY() == other.p.getY() &&
                    this.t.getX() == other.t.getX() &&
                    this.t.getY() == other.t.getY();
        }
        else {
            return false;
        }
    }

    public boolean doesPointIntersectLine(Point point){
        double slope = computeSlope();

        if(point.getY() - this.p.getY() == slope * (point.getX() - this.p.getX())) {
            return true;
        }
        else {
            return false;
        }
    }
}
