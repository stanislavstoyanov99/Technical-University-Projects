import java.util.Scanner;
import palindrome.Palindrome;

public class StartUp {
    public static void main(String[] args) {
        Palindrome palindrome = new Palindrome();

        var input = new Scanner(System.in);

        System.out.print("Enter word to check whether is palindrome: ");
        var firstSolution = palindrome.isPalindrome(input.nextLine().toCharArray());

        System.out.print("Enter word to check whether is palindrome: ");
        var secondSolution = palindrome.isPalindrome(input.nextLine());

        System.out.print("Enter word to check whether is palindrome: ");
        var thirdSolution = palindrome.isPalindromeRecursive(input.nextLine());

        System.out.print("Enter word to check whether is palindrome: ");
        var mySolution = palindrome.isPalindromeMySolution(input.nextLine());

        System.out.println(firstSolution);
        System.out.println(secondSolution);
        System.out.println(thirdSolution);

        System.out.print(mySolution);
    }
}
