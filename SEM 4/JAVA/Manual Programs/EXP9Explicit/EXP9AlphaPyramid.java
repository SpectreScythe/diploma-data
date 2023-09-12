import java.util.*;
public class EXP9AlphaPyramid
{
    static void AlphaPyra()
    {
        char ch = 'A';
        Scanner sc = new Scanner(System.in);

        int noOfCol = sc.nextInt();

        for (int i = 1 ; i<=noOfCol ; i++)
        {
            for (int j = noOfCol-i ; j>=0 ; j--)
            {
                System.out.print(" ");
            }
            for (int k = 1 ; k<=i ; k++)
            {
                System.out.print(ch + " ");
                ch++;
            }
            System.out.println();
        }
    }

    public static void main(String[] args)
    {
        AlphaPyra();
    }
}
