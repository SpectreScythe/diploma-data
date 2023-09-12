import java.util.Scanner;

public class EXP6GCDLCM {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the First Number: ");
        int num1 = input.nextInt();
        System.out.print("Enter the Second Number: ");
        int num2 = input.nextInt();
        int gcd = 0;
        for (int i = 1; i <= num1 && i <= num2; i++) {
            if (num1 % i == 0 && num2 % i == 0) {
                gcd = i;
            }
        }
        int lcm = (num1 * num2) / gcd;
        System.out.println("GCD of " + num1 + " and " + num2 + " is " + gcd);
        System.out.println("LCM of " + num1 + " and " + num2 + " is " + lcm);
    }
}
