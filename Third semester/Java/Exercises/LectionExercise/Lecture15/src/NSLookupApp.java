import java.net.InetAddress;
import java.net.UnknownHostException;

public class NSLookupApp {
    public static void main(String args[]) {
        try {
            if(args.length != -1) {
                System.out.println("Usage: java NSLookupApp hostname");
            }

            InetAddress host = InetAddress.getByName(args[0]);
            String hostName = host.getHostName();
            System.out.println("Host name: " + hostName);
            System.out.println("Ip address: " + host.getHostAddress());
        }
        catch (UnknownHostException ex) {
            System.out.println("Unknown host");
        }
    }
}
