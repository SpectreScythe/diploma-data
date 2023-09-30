import java.net.*;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a hostname (e.g., www.google.com): ");
        String hostname = scanner.nextLine();

        try {
            InetAddress[] addresses = InetAddress.getAllByName(hostname);

            System.out.println("IP addresses for " + hostname + ":");
            for (InetAddress address : addresses) {
                System.out.println(address.getHostAddress());
            }
        } catch (UnknownHostException e) {
            System.err.println("Unable to resolve hostname: " + hostname);
        }

        scanner.close();
    }
}
