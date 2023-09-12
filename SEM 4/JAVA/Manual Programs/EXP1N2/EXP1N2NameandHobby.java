import java.util.Scanner;
class EXP1N2NameandHobby{
    public static void main(String[] args)
    {
        Scanner userEnteredScan = new Scanner(System.in);

        System.out.println("Enter your name");
        String name = userEnteredScan.nextLine();
        System.out.println("Enter hobby of  " + name) ;
        String hobby = userEnteredScan.nextLine();
        System.out.println(name + " - 210451 \n" + "My hobby is -  " + hobby);
    }
}
