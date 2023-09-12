import java.util.*;
public class EXP4GreatestOfThreeTernary {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the first no ");
        int n1 = sc.nextInt();
        System.out.println("Enter the second no ");
        int n2 = sc.nextInt();
        String state = ( n1 > n2 ? n1 + "  is greatest " : n2 + "  is greatest");
        System.out.println(state);
    }

}
