import java.util.*;
public class EXP5numTri {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter number of rows:");
        int op = sc.nextInt();

        for(int i = 1 ; i<=op ; i++){
            for(int j = 0 ; j<i ; j++ ){
                System.out.print(i);
            }
            System.out.println(" ");
        }
    }
}
