import java.util.*;

public class EXP6CountNum {
    public static void main(String args[]) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Enter number of integers you will enter:");
        int nOfNum = sc.nextInt();

        int[] userEntered = new int[50];
        int numOfZ = 0, numOfPI = 0, numOfNI = 0;

        System.out.println();

        for (int i = 0; i < nOfNum; i++) {

            System.out.print("Enter " + (i + 1) + " Position number here -->");
            userEntered[i] = sc.nextInt();

            System.out.println();

        }

        for (int j = 0; j < nOfNum; j++) {
            if (userEntered[j] == 0) {
                numOfZ++;
            } else if (userEntered[j] > 0) {
                numOfPI++;
            } else if (userEntered[j] < 0) {
                numOfNI++;
            }
        }

        System.out.println("Total number of positive integers entered = " + numOfPI);
        System.out.println("Total number of negative integers entered = " + numOfNI);
        System.out.println("Total number of zeroes entered = " + numOfZ);
    }
}
