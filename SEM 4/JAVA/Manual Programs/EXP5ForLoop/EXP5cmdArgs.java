import java.util.Scanner;

public class EXP5cmdArgs {
    public static void main(String[] args) {
        System.out.println("Printing CommandLine Arguments : ");
        for (int i = 1; i < args.length; i++) {
            System.out.println("Args[" + i + "] = " + args[i]);
        }
    }
}