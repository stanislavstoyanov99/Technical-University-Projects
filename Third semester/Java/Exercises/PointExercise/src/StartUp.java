public class StartUp {
    public static void main(String[] args) {
        Point originPoint = new Point(0, 0);
        Point firstPoint = new Point(7, 2);
        Point secondPoint = new Point(4, 3);

        System.out.printf("p1 is (%d, %d)\n", firstPoint.getX(), firstPoint.getY());
        double distanceFromOrigin = Point.distanceFromOrigin(firstPoint, originPoint);
        System.out.printf("p1's distance from origin = %f\n", distanceFromOrigin);

        System.out.printf("p2 is (%d, %d)\n", secondPoint.getX(), secondPoint.getY());
        distanceFromOrigin = Point.distanceFromOrigin(secondPoint, originPoint);
        System.out.printf("p2's distance from origin = %f\n", distanceFromOrigin);

        System.out.printf("distance from p1 to p2 = %f\n", firstPoint.distance(secondPoint));

        secondPoint.translate(2, 4);
        System.out.printf("p2 is (%d, %d)\n", secondPoint.getX(), secondPoint.getY());
    }
}