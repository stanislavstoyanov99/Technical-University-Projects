package com.employees;

public class Secretary extends  Employee {
    public Secretary(int years) {
        super(years);
    }

    @Override
    // // Secretaries don't get a bonus for their years of service.
    public int getSeniorityBonus() {
        return 0;
    }

    public void takeDictation(String text) {
        System.out.println("Taking dictation of text: " + text);
    }
}
