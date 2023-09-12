import java.util.Scanner;
public class EXP3SameSign
    {
        public static void main(String args[])
        {
            Scanner sc = new Scanner(System.in);
            System.out.println("Enter the first no: ");
            int n1 = sc.nextInt();
            System.out.println("Enter the second no: ");
            int n2= sc.nextInt();

            if (n1 > 0 && n2 > 0 || n1<0 && n2<0)
            {
                System.out.println("The signs are same...");
            }
            else if (n1 > 0 || n1 < 0  &&  n2 > 0 || n2 < 0)
            {
                System.out.println("The signs aren't same...");
            }
            else
            {
                System.out.println("Either of the no is zero");
            }
        }
    }

