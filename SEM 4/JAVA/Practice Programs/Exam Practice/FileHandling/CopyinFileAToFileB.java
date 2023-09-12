import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;

public class CopyinFileAToFileB {
    public static void main(String[] args) throws FileNotFoundException {
        try {
            FileInputStream FIS = new FileInputStream("NotepadA.txt");
            FileOutputStream FOS = new FileOutputStream("NotepadB.txt");

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
