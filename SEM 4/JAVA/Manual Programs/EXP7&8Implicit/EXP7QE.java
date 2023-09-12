import java.util.*;

class EXP7QE {

    public static void main(String args[]) {

        int delta;

        double r1 = 0, r2 = 0;

        int a, b, c;

        Scanner sc = new Scanner(System.in);

        System.out.print("Enter value for first coeffiecent :");

        a = sc.nextInt();

        System.out.println();

        System.out.print("Enter value for second coeffiecent :");

        b = sc.nextInt();

        System.out.println();

        System.out.print("Enter value for third coeffiecent :");

        c = sc.nextInt();

        System.out.println();

        delta = ((b * b) - 4 * a * c);

        if (delta < 0) {

            System.out.println("The roots are not real and imaginary...");

            r1 = (-b + Math.sqrt(delta)) / (2 * a);

            r2 = (-b - Math.sqrt(delta)) / (2 * a);

        } else if (delta > 0) {

            System.out.println("The roots are real and unequal...");

            r1 = (-b + Math.sqrt(delta)) / (2 * a);

            r2 = (-b - Math.sqrt(delta)) / (2 * a);

        } else if (delta == 0) {

            System.out.println("The roots are real and equal...");

            r1 = (-b + Math.sqrt(delta)) / (2 * a);

            r2 = (-b - Math.sqrt(delta)) / (2 * a);

        }

        System.out.println("Root 1 = " + r1);

        System.out.println("Root 2 = " + r2);

    }

}