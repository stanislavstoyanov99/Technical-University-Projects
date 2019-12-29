package models;

import contracts.HasTail;

public class Lemur extends Primate implements HasTail {
    public int age = 10;

    @Override
    public boolean isTailStriped() {
        return false;
    }
}
