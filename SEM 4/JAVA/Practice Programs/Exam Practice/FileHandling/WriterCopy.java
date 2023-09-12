import java.io.*;

public class WriterCopy {
    public static void main(String[] args) throws FileNotFoundException {
        try {
            FileReader FIS = new FileReader("NotepadA.txt");
            FileWriter FOS = new FileWriter("NotepadB.txt");

            int data;

            while ((data = FIS.read()) != -1) {
                FOS.write(data);
            }
            FIS.close();
            FOS.close();
            System.out.println("File copied successfully");
        }
        catch (Exception e) {
            System.out.println("File not found");
        }
    }
}
