import java.io.IOException;
import java.io.OutputStreamWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Date;

// Simple TCP Server
public class DataServer {
    public static void main(String[] args) throws IOException {
        ServerSocket serverSocket = new ServerSocket(2002);

        while (true) {
            Socket socket = serverSocket.accept();
            OutputStreamWriter out = new OutputStreamWriter(socket.getOutputStream());
            out.write(new Date() + "\n");
            out.close();
            socket.close();
        }
    }
}
