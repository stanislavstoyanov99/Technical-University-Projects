import java.net.MalformedURLException;
import java.net.URL;

public class Test {
    public static void main(String[] args) throws MalformedURLException {
        // creates a URL with string representation
        URL firstUrl = new URL("https://photo-forum.net" + "/forum/list.php?f=1");

        // creates a URL with a protocol, host name and path
        URL secondUrl = new URL("https","photo-forum.net", "/bg/index.php?APP_ACTION=NEW_ALBUM");

        // create a URL with another URL and path
        URL thirdUrl = new URL("https://photo-forum.net");
        URL fourthUrl = new URL(thirdUrl, "/bg/index.php?APP_ACTION=NEW_ALBUM");

        // print the String representation of the URL
        System.out.println(firstUrl.toString());
        System.out.println(secondUrl.toString());
        System.out.println();
        System.out.println("Different components of the URL");

        // Retrieve the protocol for the URL
        System.out.println("Protocol firstUrl: " + firstUrl.getProtocol());

        // Retrieve the host name of the URL
        System.out.println("Hostname firstUrl: " + firstUrl.getHost());

        // Retrieve the path of URL
        System.out.println("Path fourthUrl: " + fourthUrl.getPath());

        // Retrieve the file name
        System.out.println("File firstUrl: " + firstUrl.getFile());
    }
}
