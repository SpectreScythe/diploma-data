import java.io.*;
public class EXP13LarSmaArray
{
    static void LargestSmallestArray() throws Exception {
        InputStreamReader r = new InputStreamReader(System.in);
        BufferedReader br = new BufferedReader(r);

        System.out.print("Enter the size of the array: ");
        int n = Integer.parseInt(br.readLine());
        int[] a = new int[n];

        for (int i = 0; i < a.length; i++) {
            System.out.print("Enter value for position [" + (i + 1) + "] : ");
            a[i] = Integer.parseInt(br.readLine());
        }

        int largest = a[0];

        for (int i = 0 ; i < a.length-1 ; i++)
        {
            for (int j = i+1 ; j < a.length ; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }

        int smallest = a[0];

        for (int i = 1 ; i < a.length ; i++)
        {
            if (a[i] > largest)
            {
                largest = a[i];
            }
        }

        System.out.println("Smallest : " + smallest);
        System.out.println("Largest : " + largest);

    }
    public static void main(String[] args) throws Exception
    {
        LargestSmallestArray();
    }
}
