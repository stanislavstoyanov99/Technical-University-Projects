package com.employees;

// A class to represent legal secretaries.
public class LegalSecretary extends Secretary {
    public LegalSecretary(int years) {
        super(years);
    }

    public void fileLegalBriefs() {
        System.out.println("I could file all day!");
    }

    @Override
    public double getSalary() {
        double baseSalary = super.getSalary();
        return baseSalary + 5000.0; // $45,000.00 / year
    }
}
