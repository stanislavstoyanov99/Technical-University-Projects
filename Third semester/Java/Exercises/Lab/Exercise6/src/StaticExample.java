public class StaticExample {
    int instanceVar;
    static int staticVar;

    public void instanceMethod() { // can access static & instance members
        instanceVar++;
        staticVar++;
        staticMethod();
    }

    public static void staticMethod() { // can access only static members
        staticVar++;
        //instanceVar++; compiler error
        //instanceMethod(); compiler error
        (new StaticExample()).instanceMethod(); // ok
    }

    public static void switchExample() {
        System.out.println("\nInside switchExample ...");

        final byte month2 = 2;
        byte month = 3;

        switch (month) {
            case 1: System.out.println("January");
            break;
            case month2: System.out.println("February");
            break;
            case 3: System.out.println("March");
            break;
            default: System.out.println("April");
        }
    }
}
