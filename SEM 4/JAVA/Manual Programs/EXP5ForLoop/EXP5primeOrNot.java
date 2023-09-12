import java.util.Scanner;

public class EXP5primeOrNot
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter Number : ");
        int num = sc.nextInt();
        int count = 0;
        for (int i = 2; i <= num; i++)
        {
            if (num%i == 0) {
                count++;
            }
        }
        if (count == 1) {
            System.out.println(num + " is Prime");
        }
        else {
            System.out.println(num + " is not Prime");
        }
    }
}