import java.util.Scanner;

public class EXP6PalindromeNum
{
    public static void main(String args[])
    {
        Scanner sc = new Scanner(System.in);

        int r,sum=0,temp;

        System.out.print("Enter an integer to check if its a palindrome number:");
        int n=sc.nextInt();

        temp=n;
        while(n>0)
        {
            r=n%10;
            sum=(sum*10)+r;
            n=n/10;
        }
        if(temp==sum)
        {
            System.out.println("The Entered number " + temp + " is a Palindrome Number ");
        }
        else
        {
            System.out.println("The Entered number " + temp + " is not a palindrome Number");
        }
    }
}
