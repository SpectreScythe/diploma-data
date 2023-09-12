public class ThreadTransfer {
    public static void main(String[] args) throws InterruptedException {
        threadX x = new threadX();
        threadY y = new threadY();
        x.start();
        System.out.println("Sleeping Thread X for 500ms...");
        y.start();
    }
}
class threadX extends Thread implements Runnable{
    public void run() {
        for (int i = 0 ; i <= 100 ; i++) {
            System.out.println("Ascending Order" +i);
        }
        try {
            Thread.sleep(500);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        System.out.println("Exiting Thread X");
    }
}
class threadY extends Thread implements Runnable{
    public void run() {
        for (int i = 0 ; i <= 100 ; i++) {
            System.out.println("Ascending Order" +i);
        }
        System.out.println("Exiting Thread Y");
    }
}
