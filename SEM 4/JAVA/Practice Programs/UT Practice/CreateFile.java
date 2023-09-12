import java.io.FileWriter;
import java.io.IOException;

public class CreateFile {
    public static void main(String[] args) {
        String fileName = "op.txt";
        String[] data = {"Hello, World!", "This is a test file."};

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
