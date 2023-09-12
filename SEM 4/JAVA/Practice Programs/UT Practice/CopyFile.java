import java.io.*;

public class CopyFile {

    public static void main(String[] args) {
        // name of input and output files
        String inputFile = "input.txt";
        String outputFile = "output.txt";

        try {
            // create input and output stream objects
            FileInputStream inputStream = new FileInputStream(inputFile);
            FileOutputStream outputStream = new FileOutputStream(outputFile);

            // read input file contents byte by byte and write to output file
            int data;
            while ((data = inputStream.read()) != -1) {
                outputStream.write(data);
                int j = 0;
                while (j < 43) {
                    System.out.print(data+"\t");
                    j++;
                }
                System.out.println();
            }

            // close input and output streams
            inputStream.close();
            outputStream.close();

            System.out.println("File copied successfully.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
