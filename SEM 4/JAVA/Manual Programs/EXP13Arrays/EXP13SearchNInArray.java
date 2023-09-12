import java.io.*;
public class EXP13SearchNInArray
{
    static void SearchingInArray() throws Exception
    {
        InputStreamReader r=new InputStreamReader(System.in);
        BufferedReader br=new BufferedReader(r);

        System.out.print("Enter the size of the array: ");
        int n = Integer.parseInt(br.readLine());
        int[] a = new int[n];

        for (int i = 0 ; i < a.length ; i++)
        {
            System.out.print("Enter value for position [" + (i+1) + "] : ");
            a[i] = Integer.parseInt(br.readLine());
            //br.readLine();
        }

        System.out.print("Enter element to be searched: ");
        int ToBeSearched = Integer.parseInt(br.readLine());
        //br.readLine();

        int flag = 0;

        for (int j : a) {
            if (j == ToBeSearched) {
                flag++;
            } else {
                continue;
            }
        }

        if (flag != 0)
        {
            System.out.println("Element exists...");
        }
        else
        {
            System.out.println("Element does not exist...");
        }
    }
    public static void main(String[] args) throws Exception
    {
        SearchingInArray();
    }
}
