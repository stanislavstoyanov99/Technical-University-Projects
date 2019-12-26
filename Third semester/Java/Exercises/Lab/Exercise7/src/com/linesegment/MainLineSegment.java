package com.linesegment;

import java.awt.*;

public class MainLineSegment {
    public static void main(String[] args) {
        Point firstPoint = new Point();
        firstPoint.setLocation(0, 0);

        Point secondPoint = new Point();
        secondPoint.setLocation(50, 50);

        LineSegment lineSegment = new LineSegment(firstPoint, secondPoint);

        Point thirdPoint = new Point();
        thirdPoint.setLocation(0, 100);

        Point fourthPoint = new Point();
        fourthPoint.setLocation(35, 90);

        LineSegment secondLineSegment = new LineSegment(thirdPoint, fourthPoint);

        System.out.println(lineSegment);
        System.out.println(secondLineSegment);
        System.out.println(lineSegment.equals(secondLineSegment));

        System.out.println("First Line Segment Slope: " + lineSegment.computeSlope());
        System.out.println("Second Line Segment Slope: " + secondLineSegment.computeSlope());
        secondLineSegment.draw();

        Point fifthPoint = new Point(50, 50);

        System.out.println("[50, 50] is on the first line segment: " + lineSegment.doesPointIntersectLine(fifthPoint));
        System.out.println("[50, 50] is on the second line segment: " + secondLineSegment.doesPointIntersectLine(fifthPoint));
    }
}
