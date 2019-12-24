package palindrome;

public class Palindrome {
    public static boolean isPalindrome(char[] word) {
        int i = 0;
        int j = word.length - 1;

        while (j > i) {
            if (word[i] != word[j]) {
                return false;
            }

            ++i;
            --j;
        }

        return true;
    }

    public static boolean isPalindrome(String str) {
        return str.equals(new StringBuilder(str).reverse().toString());
    }

    public static boolean isPalindromeRecursive(String str) {
        int length = str.length();

        if (length < 2) { // If the string only has 1 char or is empty
            return true;
        }
        else {
            // Check opposite ends of the string for equality
            if (str.charAt(0) != str.charAt(length - 1)) {
                return false;
            }
            else { // Function call for string with two ends snipped off
                return isPalindromeRecursive(str.substring(1, length - 1));
            }
        }
    }

    public static boolean isPalindromeMySolution(String str) {
        String text = str
                .replaceAll("\\s+", "")
                .toLowerCase(); // \\s+ -> matches one or many whitespaces

        int length = text.length();
        int forward = 0;
        int backward = length - 1;

        while (backward > forward) {
            char forwardChar = text.charAt(forward++);
            char backwardChar = text.charAt(backward--);

            if (forwardChar != backwardChar) {
                return false;
            }
        }

        return true;
    }
}
