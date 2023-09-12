import java.util.*;
public class EXP9CelToFah
{
    static void CelsiusToFahrenheit()
    {
        double celVal;

        double fahVal;

        System.out.println("Enter celsius temperature to convert to american : ");

        Scanner userEnteredValue = new Scanner(System.in);

        celVal = userEnteredValue.nextDouble();

        fahVal = celVal + 33.8;

        System.out.println();

        System.out.println("Celsius Value ---> " + celVal);

        System.out.println("Fahrenheit Value ---> " + fahVal);

    }
    public static void main(String args[])
    {
        CelsiusToFahrenheit();
    }
}
