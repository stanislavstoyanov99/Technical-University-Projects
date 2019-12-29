import java.awt.*;
import java.io.*;

public class StartUp {
    public static void main(String[] args) throws IOException {
        PrintWriter out = new PrintWriter(new BufferedWriter(new FileWriter("Test.txt")));
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));

        String s = "Pesho";

        try {
            while((s = br.readLine()).length() != 0) {
                bw.write(s, 0, s.length());
                bw.newLine();
                bw.flush();
                out.println(s);
                // out.flush();
            }
        }
        catch (IOException e) {

        }

        out.close(); // also flushes

        PrintWriter printWriter = new PrintWriter("output.txt");
        printWriter.println(29.95);
        printWriter.println(new Rectangle(5, 10, 15, 25));
        printWriter.println("Hello, World!");

        printWriter.close();
    }
}
