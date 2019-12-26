import com.point.Point;

public class StartUp {
    public static void main(String[] args) {
        Point originPoint = new Point();
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

        long result = MyMath.multiply(5, 2000);
        System.out.println(result);

        User user = new User("wrong secret", "grrr");
        System.out.println(user.authenticate());

        // default behaviour -> System.out.println("p is " + firstPoint);

        System.out.println(firstPoint); // override of toString method
    }
}