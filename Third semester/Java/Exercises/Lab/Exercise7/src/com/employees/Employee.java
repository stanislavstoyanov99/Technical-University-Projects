package com.employees;

// A class to represent employees in general (20-page manual).
public class Employee {
    private  int years;

    public Employee(int years) {
        this.years = years;
    }

    public int getYears() {
        return this.years;
    }

    public int getHours() {
        return 40; // works 40 hours / week
    }

    public double getSalary() {
        return 40000.0; // $40,000.00 / year
    }

    public int getVacationDays() {
        return 10 + getSeniorityBonus(); // 2 weeks's paid vacation
    }

    // vacation days given for each year in the company
    public int getSeniorityBonus() {
        return 2 * years;
    }

    public String getVacationForm() {
        return "yellow"; // use the yellow form
    }
}
