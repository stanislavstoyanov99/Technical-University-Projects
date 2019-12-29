import javax.sound.midi.SysexMessage;
import java.io.*;
import java.net.*;

public class ReadURL {
    public static void main(String[] args) {
        try {
            URL url = new URL("https://tu-sofia.bg");
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(url.openStream()));

            String line;
            while((line = bufferedReader.readLine()) != null){
                System.out.println(line);
            }

            bufferedReader.close();
        } catch (MalformedURLException me) {
            System.out.println("MalformedURLException: " + me.getMessage());
        } catch (IOException ioe) {
            System.out.println("IOException: " + ioe.getMessage());
        }
    }
}
