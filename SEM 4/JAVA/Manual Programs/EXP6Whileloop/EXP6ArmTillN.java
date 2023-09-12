import java.util.*;
class EXP6ArmTillN
{
    public static void main(String[] arg)
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the limit: ");
        int n = input.nextInt();
        int i=1,arm;
        int j=1;
        System.out.println("Armstrong numbers between " + 1 + " to " + n);
        while(i<n)
        {
            arm=armstrongOrNot(i);
            if(arm==i)
            {
                System.out.println("Armstrong [" +j+"] --> " + i);
                ++j;
            }
            i++;
        }
    }
    static int armstrongOrNot(int num)
    {
        int xnum,a=0;
        while(num!=0)
        {
            xnum=num%10;
            a=a+(xnum*xnum*xnum);
            num/=10 ;
        }
        return a;
    }
}
