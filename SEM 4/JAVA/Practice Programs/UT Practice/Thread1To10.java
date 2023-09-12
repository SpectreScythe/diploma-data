public class Thread1To10 {
    public static void main(String[] args) {
        ThreadX TX = new ThreadX();
        ThreadY TY = new ThreadY();
        TX.start();
        TY.start();
    }
}
class ThreadX extends Thread {
    public void run() {
        System.out.println("Entering Thread 1:");
        for (int i = 1; i <= 9; i += 2) {
            System.out.println("Odd Number :" + i);
        }
        System.out.println("Exiting Thread 1:");
    }
}

class ThreadY extends Thread {
    public void run() {
        System.out.println("Entering Thread 2:");
        for (int i = 0; i <= 10; i += 2) {
            System.out.println("Even Number :" + i);
        }
        System.out.println("Exiting Thread 1:");
    }
}
