import java.io.FileInputStream;
import java.io.FileNotFoundException;

public class DisplayinfFromAFile {
    public static void main(String[] args) throws FileNotFoundException {
        try {
            FileInputStream FR = new FileInputStream("NotepadA.txt");
            int data;
            while ((data = FR.read()) != -1) {
                System.out.print((char) data);
            }
            FR.close();
        }
        catch (Exception e) {
            System.out.println("File not found");
        }
    }
}
