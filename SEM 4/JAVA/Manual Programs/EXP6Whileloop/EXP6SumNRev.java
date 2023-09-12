import java.util.Scanner;

public class EXP6SumNRev
{
    public static void main(String[] args)
    {

        Scanner userEnteredInt = new Scanner(System.in);
        System.out.print("Enter Number: ");

        int num, rem;
        int rev = 0, sum = 0;
        num = userEnteredInt.nextInt();

        do {
            rem = num % 10;
            rev = rev * 10 + rem;
            sum = sum + rem;
            num = num / 10;
        }

        while (num > 0);

        System.out.println("Reverse of given number: "
                + rev);

        System.out.println("Sum of digits of given number: "
                + sum);

    }
}
