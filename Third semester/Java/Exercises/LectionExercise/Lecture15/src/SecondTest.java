import java.io.*;
import java.net.*;

public class SecondTest {
    public static void main(String args[]) {
        int abyte;

        try {
            URL url = new URL("https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Marsh_fritillary_%28Euphydryas_aurinia%29_female_underside.jpg/1024px-Marsh_fritillary_%28Euphydryas_aurinia%29_female_underside.jpg");
            InputStream inputStream = url.openStream();
            FileOutputStream fileOutputStream = new FileOutputStream("picture.jpg");
            System.out.println("starting ...");

            while((abyte = inputStream.read()) != -1) {
                fileOutputStream.write(abyte);
            }

            inputStream.close();
            fileOutputStream.close();
            System.out.println("created");
        }
        catch (MalformedURLException me) {
            System.out.println("MalformedURLException: " + me.getMessage());
        }
        catch (IOException ioe) {
            System.out.println("IOException: " + ioe.getMessage());
        }
    }
}
