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
}
