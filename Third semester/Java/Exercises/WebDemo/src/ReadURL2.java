import java.io.*;
import java.net.*;
import java.nio.charset.*;

public class ReadURL2 {
    public static void main(String[] args) {
        try {
            URL url = new URL("https://tu-sofia.bg/");
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(url.openStream(), Charset.forName("UTF-8")));

            String line;
            while ((line = bufferedReader.readLine()) != null) {
                System.out.println(line);
            }

            bufferedReader.close();
        } catch (MalformedURLException e) {
            System.out.println(e.getMessage());
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}
