public class ThreeThreadsPriorities {
    public static void main(String[] args) {
        Thread threadX = new Thread(new PrintNumbers(1, 10), "Thread 1");
        Thread threadY = new Thread(new PrintNumbers(11, 20), "Thread 2");
        Thread threadZ = new Thread(new PrintNumbers(21, 30), "Thread 3");

        threadX.setPriority(Thread.MIN_PRIORITY);
        threadY.setPriority(Thread.NORM_PRIORITY);
        threadZ.setPriority(Thread.MAX_PRIORITY);

        threadX.start();
        threadY.start();
        threadZ.start();
    }

    static class PrintNumbers implements Runnable {
        private final int start;
        private final int end;

        public PrintNumbers(int start, int end) {
            this.start = start;
            this.end = end;
        }

        public void run() {
            for (int i = start; i <= end; i++) {
		System.out.print(Thread.currentThread().getName() + ": " + i + "\t");                
		if (i == 3 || i == 6 || i == 19 || i == 20 || i == 25) {
                    System.out.println();
                }
            }
        }
    }
}