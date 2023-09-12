import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CountryAuthentication {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        System.out.print("Enter your damned country: ");
        String country = "India";
        String userEnteredPassword = br.readLine();

        try {
            authenticate(userEnteredPassword);
            System.out.println("No Signs of Intelligent Species");
        }
        catch (NotMatchException e) {
            System.out.println(e.getMessage());
        }
    }
    public static void authenticate(String pass) throws NotMatchException {
        if(!pass.equals("India")) {
            throw new NotMatchException("Illiteracy Signs found");
        }
    }
}

class NotMatchException extends Exception{
    NotMatchException(String msg) {
        super(msg);
    }
}
