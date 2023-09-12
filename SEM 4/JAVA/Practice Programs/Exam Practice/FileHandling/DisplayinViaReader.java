import java.io.FileReader;
import java.io.IOException;

public class DisplayinViaReader {
    public static void main(String[] args) throws IOException {
        try {
            FileReader FR = new FileReader("NotepadA.txt");
            int ch;
            while ((ch = FR.read()) != -1) {
                System.out.print((char) ch);
            }
            FR.close();
        }
        catch (Exception e) {
            System.out.println("File not found");
        }
    }
}
