import java.util.*;
public class EXP9DFToInt
{
    static void DoubleAndFloatToInt()
    {
        double dVal;

        float fVal;

        int iVal;

        Scanner userEnteredValue = new Scanner(System.in);

        System.out.println();

        System.out.print("Enter an integer : ");

        iVal = userEnteredValue.nextInt();

        dVal = iVal;

        fVal = iVal;

        System.out.println();

        System.out.println("Integer Value ---> " + iVal);

        System.out.println("Float Value ---> " + fVal);

        System.out.println("Double Value ---> " + dVal);
    }
    public static void main(String args[])
    {
        DoubleAndFloatToInt();
    }
}
