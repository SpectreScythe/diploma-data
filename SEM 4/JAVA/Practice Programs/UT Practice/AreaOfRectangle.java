import java.util.*;

class RectangleOperations
{
    Scanner userEnteredVal = new Scanner(System.in);
    long breadth;
    long length;

    long areaOfRect;

    void GetValues()
    {
        System.out.print("Enter breadth of rectangle : ");
        breadth = userEnteredVal.nextInt();

        System.out.println();

        System.out.print("Enter length of rectangle : ");
        length = userEnteredVal.nextInt();
    }

    void Display()
    {
        areaOfRect = length * breadth;

        System.out.println();

        System.out.println("Area of Rectangle = " + areaOfRect);
    }

    void Rectangle()
    {
        GetValues();
        Display();
    }
}
public class AreaOfRectangle
{
    public static void main(String[] args)
    {
        RectangleOperations R = new RectangleOperations();
        R.Rectangle();
    }
}
