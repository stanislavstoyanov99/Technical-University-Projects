package com.employees;

public class EmployeeMain {
    public static void main(String[] args) {
        Lawyer lisa = new Lawyer(3);
        Secretary steve = new Secretary(2);

        printInfo(lisa);
        printInfo(steve);

        Employee[] employees = {new Lawyer(3), new Secretary(2), new Marketer(4), new LegalSecretary(1)};

        for(int i = 0; i < employees.length; i++) {
            System.out.println("salary = " + employees[i].getSalary());
            System.out.println("vacation days = " + employees[i].getVacationDays());
            System.out.println();
        }
    }

    public static void printInfo(Employee employee) {
        System.out.println("salary = " + employee.getSalary());
        System.out.println("days = " + employee.getVacationDays());
        System.out.println("form = " + employee.getVacationForm());
        System.out.println();
    }
}
