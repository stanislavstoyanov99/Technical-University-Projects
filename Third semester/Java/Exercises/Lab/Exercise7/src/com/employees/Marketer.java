package com.employees;

// A class to represent marketers.
public class Marketer extends Employee {
    public Marketer(int years) {
        super(years);
    }

    public void advertise() {
        System.out.println("Act now while suppliers last!");
    }

    @Override
    public double getSalary() {
        return super.getSalary() + 10000.0; // $50,000.00 / years
    }
}
