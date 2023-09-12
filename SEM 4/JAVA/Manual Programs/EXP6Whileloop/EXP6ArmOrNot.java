import java.util.*;
public class EXP6ArmOrNot
{
    public static void main(String args[])
    {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter an integer to check if it is an armstrong number:");

        int num = sc.nextInt(); 
        int sum = 0 , r;
        int temp = num;

        while(temp>0){
            r = temp % 10;
            sum = sum + (r*r*r);
            temp = temp / 10;
        }

        if(sum == num){
            System.out.println("The entered number : " + num + " is an armstrong number");
        }
        else{
            System.out.println("The entered number : " + num + " is not an armstrong number");
        }
    }
}
