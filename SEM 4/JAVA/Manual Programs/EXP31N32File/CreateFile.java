import java.io.FileWriter;
import java.io.IOException;

public class CreateFile {
    public static void main(String[] args) {
        String fileName = "AssalamualaikumHabibi.txt";
        String[] data = {"Yo Habibi is here", "This Habibi Code"};

        try (FileWriter writer = new FileWriter(fileName)) {
            for (String line : data) {
                writer.write(line + "\n");
            }
            System.out.println("Data has been written to " + fileName);
        } catch (IOException e) {
            System.err.println("Error writing to " + fileName + ": " + e.getMessage());
        }
    }
}
