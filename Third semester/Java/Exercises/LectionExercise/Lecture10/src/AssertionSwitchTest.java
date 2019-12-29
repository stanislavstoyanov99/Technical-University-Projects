// Assertion (JDK 1.4)
// Can be used for verifying:
public class AssertionSwitchTest {
    public static void main(String[] args) {
        char operator = '%'; // assumed either '+', '-', '*', '/' only
        int operand1 = 5, operand2 = 6, result = 0;

        switch (operator) {
            case '+': result = operand1 + operand2;
                break;
            case '-': result = operand1 - operand2;
                break;
            case '*': result = operand1 * operand2;
                break;
            case '/': result = operand1 / operand2;
                break;
            default: assert  false : "Unknown operator: " + operator; // not plausible here
        }

        System.out.println(operand1 + " " + operator + " " + operand2 + " = " + result);

        int number = -5; // assumed number is not negative

        // This assert also serves as documentation
        assert (number >= 0) : "number is negative: " + number;

        // do something
        System.out.println("The number is " + number);
    }
}
