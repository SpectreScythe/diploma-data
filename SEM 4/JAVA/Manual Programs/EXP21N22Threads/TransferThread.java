public class TransferThread {
    public static void main(String[] args) {
        Thread threadX = new Thread(new PrintNumbers1(), "ThreadX");
        Thread threadY = new Thread(new PrintNumbers2(), "ThreadY");

        threadX.start();
        threadY.start();
    }

    static class PrintNumbers1 implements Runnable {
        public void run() {
            try{
	
	for (int i = 1; i <= 10; i++) {
		  System.out.println("After Delay of 500 milliseconds....");
             
		System.out.println(Thread.currentThread().getName() + ": " + i);
			Thread.sleep(500);
            	}
	}
	catch (InterruptedException e) {
            e.printStackTrace();
        	}
        }
    }

    static class PrintNumbers2 implements Runnable {
        public void run() {
            //Thread.sleep(500);
System.out.println("Before Delay of 500 milliseconds....");
            for (int i = 10; i >= 1; i--) {

                System.out.println(Thread.currentThread().getName() + ": " + i);
            }
        }
    }
}
