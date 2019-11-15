public class Point {
    private  int x;
    private  int y;

    public Point() {

    }

    public Point(int x, int y) {
        setLocationX(x, y);
    }

    public void setLocationX(int newX, int newY) {
        if (newX < 0 || newY < 0) {
            throw new IllegalArgumentException(Exceptions.InvalidInputNumbers);
        }

        this.x = newX;
        this.y = newY;
    }

    public int getX() {
        return this.x;
    }

    public int getY() {
        return this.y;
    }

    public void translate(int dx, int dy) {
        if (this.x + dx < 0 || this.y + dy < 0) {
            throw new IllegalArgumentException(Exceptions.InvalidInputNumbers);
        }
        this.x += dx;
        this.y += dy;
    }

    public static double distanceFromOrigin(Point firstPoint, Point secondPoint) {
        double result = Math.sqrt(Math.pow(secondPoint.x - firstPoint.x, 2) +
                Math.pow(secondPoint.y - firstPoint.y, 2));
        return result;
    }

    public double distance(Point point) {
        double differenceBetweenPoints = distanceFromOrigin(point, this);
        return differenceBetweenPoints;
    }
}
