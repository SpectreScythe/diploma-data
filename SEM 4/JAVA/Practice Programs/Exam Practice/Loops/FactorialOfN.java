//public class FactorialOfN {
//    public static void main(String[] args) {
//        FactorialN(7);
//    }
//    static void FactorialN(int n) {
//        int fact = 1;
//        for (int i = 1; i <= n; i++) {
//            fact = fact * i;
//        }
//        System.out.println("Factorial of " + 7 + " : " + fact);
//    }
//}

public class FactorialOfN {
    public static int factorial(int n) {
        if (n == 0) {
            return 1;
        } else {
            return n * factorial(n - 1);
        }
    }

    public static void main(String[] args) {
        int number = 7;
        int result = factorial(number);
        System.out.println("The factorial of " + number + " is " + result);
    }
}
