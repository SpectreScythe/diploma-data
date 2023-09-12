import java.util.*;
import java.lang.*;

class EXP4ArithmeticMenu
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter operator:");
        char op = sc.next().charAt(0);

        System.out.print("Enter operand 1:");
        int x = sc.nextInt();

        System.out.print("Enter operand 2:");
        int y = sc.nextInt();

        switch (op) {
            case '+' -> System.out.print("Operand 1 + Operand 2 = " + (x + y));
            case '-' -> System.out.print("Operand 1 - Operand 2 = " + (x - y));
            case '/' -> System.out.print("Operand 1 / Operand 2 = " + (x / y));
            case '*' -> System.out.print("Operand 1 * Operand 2 = " + (x * y));
            default -> System.out.print("Invalid operator...");
        }
    }
}
