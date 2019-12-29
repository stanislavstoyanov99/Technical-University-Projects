package models;

public class Capybara extends Rodent {
    public static void main(String[] args) {
        Rodent rodent = new Rodent();
        Capybara capybara = (Capybara)rodent; // Throws ClassCastException at runtime

        /* Solution
        if (rodent instanceof Capybara) {
            Capybara capybara = (Capybara)rodent;
        }
         */
    }
}
