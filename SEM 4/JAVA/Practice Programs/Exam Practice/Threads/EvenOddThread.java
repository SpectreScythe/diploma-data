public class EvenOddThread {
    public static void main(String[] args) {
        Even E = new Even();
        Odd O = new Odd();
        E.start();
        O.start();
    }
}
class Even extends Thread {
    public void run() {
        try {
            for (int i = 0 ; i <= 50 ; i+=2) {
                System.out.print(i + "\t");
            }
            sleep(500);
        }
        catch (Exception e) {
            System.out.println("Even Thread Interrupted");
        }
    }
}

class Odd extends Thread {
    public void run() {
        try {
            for (int i = 1 ; i <= 50 ; i+=2) {
                System.out.print(i + "\t");
            }
            sleep(500);
        }
        catch (Exception e) {
            System.out.println("Odd Thread Interrupted");
        }
    }
}
