import java.io.*;

public class CopyContentToFile {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        File file = new File("output.txt");
        FileWriter writer = new FileWriter(file);
        while (true) {
            System.out.println("Enter some text (type TerminateProgram to stop):");
            String line = reader.readLine();
            if (line.equals("TerminateProgram")) {
                break;
            }
            writer.write(line);
        }
        writer.close();
        System.out.println("Data written to File");
    }
}
