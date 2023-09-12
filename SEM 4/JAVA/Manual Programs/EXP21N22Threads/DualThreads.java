public class DualThreads {
    public static void main(String[] args) {
        Thread threadX = new Thread(new PrintEvenNumbers(), "ThreadX");
        Thread threadY = new Thread(new PrintOddNumbers(), "ThreadY");

        threadX.start();
        threadY.start();
    }

    static class PrintEvenNumbers implements Runnable {
        public void run() {
            for (int i = 2; i <= 10; i += 2) {
                if(i == 5)	
			{
System.out.println();
			}
System.out.print(Thread.currentThread().getName() + ": " + i + "\t");
            }
        }
    }

    static class PrintOddNumbers implements Runnable {
        public void run() {
            for (int i = 1; i <= 9; i += 2) {
                if(i == 5)	
			{
System.out.println();
			}
System.out.print(Thread.currentThread().getName() + ": " + i + "\t");
            }
        }
    }
}
