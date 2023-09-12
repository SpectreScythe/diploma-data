import java.util.Scanner;

public class EXP3LogicalOperator
{
    public static void main(String[] args)
    {

        Scanner sc= new Scanner(System.in);
        System.out.print("Enter value for A: ");
        int a = sc.nextInt();

        System.out.print("\nEnter value for B: ");
        int b = sc.nextInt();
        System.out.print("\nEnter value for C: ");
        int c = sc.nextInt();

        if ((a > b) && (a>c)  )
            System.out.println(a + " is largest");
        else if ((b > a) && (b > c))
            System.out.println(b+ " is largest");
        else
            System.out.println(c+ " is largest");
    }
}
