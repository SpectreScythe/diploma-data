import java.util.Scanner;
class EXP1N2Grade {
    public static void main(String[] args) {
        Scanner userEnteredScannedValue = new Scanner(System.in);
        System.out.println("Enter your name");
        String name = userEnteredScannedValue.nextLine();
        System.out.println("Enter your age");
        Integer age = userEnteredScannedValue.nextInt();
        System.out.println("Enter your grade");
        Character grade = userEnteredScannedValue.next().charAt(0);
        System.out.println("Enter your percentage");
        int per = userEnteredScannedValue.nextInt();
        System.out.println(name + " - 210451 ");
        System.out.println("Age is  " + age + " \n" + "Grade =  " + grade + "\n" + "percentage is  " + per);
    }
}
