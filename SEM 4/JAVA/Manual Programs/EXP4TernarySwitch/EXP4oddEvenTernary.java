import java.util.*;
public class EXP4oddEvenTernary
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the no " );
        int a = sc.nextInt();
        String statement = (a%2 == 0 )? " it is even '" : " it is odd" ;
        System.out.println(statement);
    }

}
