package com.employees;

public class Lawyer extends Employee {
    public Lawyer(int years) {
        super(years); // Call Employee constructor
    }

    @Override
    // overrides getVacationForm from Employee class
    public String getVacationForm() {
        return "pink";
    }

    @Override
    // overrides getVacationDays from Employee class
    public int getVacationDays() {
        return super.getVacationDays() + 5; // 3 weeks vacation
    }

    @Override
    public double getSalary() {
        return super.getSalary() + 5000 * getYears();
    }

    public void sue() {
        System.out.println("I'll see you in court!");
    }
}
