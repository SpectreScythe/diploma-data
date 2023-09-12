import java.util.Scanner;

public class EXP5Fibonacci {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter Range : ");
        int range = sc.nextInt();
        int f1 = 0;
        int f2 = 1;
        int f3;
        System.out.print("Fibonacci Series : " + f1 + " " + f2);
        for (int i = 2; i <= range; i++) {
            f3 = f1 + f2;
            System.out.print(" " + f3);
            f1 = f2;
            f2 = f3;
        }
    }
}