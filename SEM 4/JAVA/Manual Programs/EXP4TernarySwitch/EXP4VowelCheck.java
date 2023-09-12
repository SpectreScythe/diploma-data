import java.util.*;
public class EXP4VowelCheck {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter any character");

        char ch = sc.next().charAt(0);

        switch (ch) {
            case 'A', 'a', 'O', 'o', 'I', 'i', 'U', 'u', 'E', 'e' -> System.out.println(ch + " is vowel");
            default -> System.out.println(ch + " is either a consonant, special character or a number.");
        }
    }
    }

