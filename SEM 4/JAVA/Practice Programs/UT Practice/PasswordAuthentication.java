import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class PasswordAuthentication {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String password = "yobich";
        String userEnteredPassword = br.readLine();

        try {
            authenticate(userEnteredPassword);
            System.out.println("Login Successful");
        }
        catch (AuthencticationFailureException e) {
            System.out.println(e.getMessage());
        }
    }
    public static void authenticate(String pass) throws AuthencticationFailureException {
        if(!pass.equals("yobich")) {
            throw new AuthencticationFailureException("Login Failed");
        }
    }
}

class AuthencticationFailureException extends Exception{
    AuthencticationFailureException(String msg) {
        super(msg);
    }
}
