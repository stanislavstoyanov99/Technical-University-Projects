package models;

import contracts.LivesInOcean;

public class Dolphin implements LivesInOcean {
    @Override
    public void makeSound() {
        System.out.println("whistle");
    }
}
