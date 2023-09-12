public class EXP61To50 {
    public static void main(String args[])
    {
        System.out.println("Displaying 1 to 50...");
        int i=1;
        while (i<=50){
            System.out.print(i + "\t");
            if(i%10 == 0 ){
                System.out.println();
            }
            i++;
        }
    }
}
