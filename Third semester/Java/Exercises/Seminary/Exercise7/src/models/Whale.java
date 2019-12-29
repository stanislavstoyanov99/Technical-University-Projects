package models;

import contracts.LivesInOcean;

public class Whale implements LivesInOcean {
    @Override
    public void makeSound() {
        System.out.println("sing");
    }
}
