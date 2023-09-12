import java.util.Scanner;
class EXP1N2SimpleInterest{

    public static void main(String[] args)
    {
        Scanner sc  = new Scanner(System.in);
        System.out.println("Enter principle");
        int p = sc.nextInt();
        System.out.println("Enter the rate of interest");
        int r= sc.nextInt();
        System.out.println("Enter the no of years");
        int n = sc.nextInt();
        int si = (p*r*n)/100;
        System.out.println("Simple Interest is " + si);

    }
}
