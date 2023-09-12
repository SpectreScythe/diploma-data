import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class CharacteristicsOfAFile {
    public static void main(String[] args) throws IOException {
        try {
            int nWhiteSpace = 0;
            int nLines = 0;
            String l = "";

            FileReader FR = new FileReader("NotepadA.txt");
            int data;

            while ((data = FR.read()) != -1) {
                System.out.print((char) data);
            }

            BufferedReader BR = new BufferedReader(new FileReader("NotepadA.txt"));

            while ((l = BR.readLine()) != null) {
                nLines++;
                String[] words = l.split(" ");
                nWhiteSpace = nWhiteSpace + words.length;
            }
            FR.close();
            System.out.println("Number of Lines : " + nLines);
            System.out.println("Number of Words : " + nWhiteSpace);
        } catch (Exception e) {
            System.out.println("File not found");
        }
    }
}
