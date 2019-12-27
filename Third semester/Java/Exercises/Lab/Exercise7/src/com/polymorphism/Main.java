package com.polymorphism;

public class Main {
    public static void main(String[] args) {
        Foo[] pity = {new Baz(), new Bar(), new Mumble(), new Foo()};
        for (int i = 0; i < pity.length; i++) {
            System.out.println(pity[i]);
            pity[i].method1();
            pity[i].method2();
            System.out.println();
        }

        Ham[] food = {new Spam(), new Yam(), new Ham(), new Lamb()};
        for (int i = 0; i < food.length; i++) {
            System.out.println(food[i]);
            food[i].a();
            food[i].b();
            System.out.println();
        }
    }
}
