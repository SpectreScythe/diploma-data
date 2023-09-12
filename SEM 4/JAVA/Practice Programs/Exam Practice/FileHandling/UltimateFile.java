import java.io.*;

public class UltimateFile {
    public static void main(String[] args) throws IOException {
        try {
            File F = new File("newFile.txt");
            System.out.println("A New File has been created.");

            BufferedReader BR = new BufferedReader(new InputStreamReader(System.in));
            System.out.print("\nEnter the content for the new text file:");
            String content = BR.readLine();

            FileWriter FW = new FileWriter("newFile.txt");
            FW.write(content);
            System.out.println("Content copied to the file.");

            FW.close();

            int nWords = 0;
            int nLines = 0;

            String l = "";

            BufferedReader fBR = new BufferedReader(new FileReader("newFile.txt"));

            while ((l = fBR.readLine()) != null) {
                nLines++;
                String[] words = l.split(" ");
                nWords += words.length;
            }
            System.out.println("Number of Words : " + nWords);
            System.out.println("Number of Lines : " + nLines);
        } catch (Exception e) {
            System.out.println("File Not Found...");
        }
    }
}
