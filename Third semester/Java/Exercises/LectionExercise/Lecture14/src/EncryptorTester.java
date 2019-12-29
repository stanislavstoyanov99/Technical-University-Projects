import java.io.IOException;
import java.util.Scanner;

/**
 * A program to test the Caesar cipher encryptor.
 */
public class EncryptorTester {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);

        try {
            System.out.print("Input file: ");
            String inFile = in.next();
            System.out.print("Output file: ");
            String outFile = in.next();
            System.out.print("Encryption key: ");
            int key = in.nextInt();
            Encryptor encryptor = new Encryptor(key);
            encryptor.encryptFile(inFile, outFile);
        }
        catch (IOException exception) {
            System.out.println("Error processing file: " + exception.getMessage());
        }
    }
}
