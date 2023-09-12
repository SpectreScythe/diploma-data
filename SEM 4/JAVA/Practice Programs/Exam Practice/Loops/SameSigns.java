import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class SameSigns {
    public static void main(String[] args) throws IOException {

        checkSign();

    }

    static void checkSign() throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        System.out.println("---Program to check if sign of two numbers are same or not---");

        System.out.println("\nEnter number A : ");
        int n1 = Integer.parseInt(br.readLine());

        System.out.println("\nEnter number B : ");
        int n2 = Integer.parseInt(br.readLine());

        if ((n1 > 0 && n2 > 0) || (n1 < 0 && n2 < 0)) {

            System.out.println("True");

        }

        else {

            System.out.println("False");

        }

    }
}
