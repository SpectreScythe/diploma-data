import java.io.*;

public class CopyFile {

    public static void main(String[] args) {
        String inputFile = "whereShouldIGo.txt";
        String outputFile = "getOverHere.txt";

        try {
            FileInputStream inputStream = new FileInputStream(inputFile);
            FileOutputStream outputStream = new FileOutputStream(outputFile);

            int data;
            while ((data = inputStream.read()) != -1) {
                outputStream.write(data);
            }

            inputStream.close();
            outputStream.close();

            System.out.println("File copied successfully.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
