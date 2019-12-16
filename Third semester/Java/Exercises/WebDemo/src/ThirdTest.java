import java.io.IOException;
import java.net.MalformedURLException;
import java.io.*;
import java.net.*;

public class ThirdTest {
    public static void main(String[] args) throws MalformedURLException, IOException {
        byte buffer[] = new byte[1024];
        int length;

        URL url = new URL("https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Domestic-pigeon.jpg/1024px-Domestic-pigeon.jpg");
        InputStream inputStream = url.openStream();
        FileOutputStream fileOutputStream = new FileOutputStream("picture2.jpg");
        System.out.println("starting ...");
        while((length = inputStream.read(buffer)) != -1) {
            fileOutputStream.write(buffer, 0, length);
        }

        fileOutputStream.close();
        inputStream.close();
        System.out.println("created");
    }
}
