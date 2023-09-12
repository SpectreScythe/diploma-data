import java.io.*;

public class ReadFile {

    public static void main(String[] args) {
        String inputFile = "whereShouldIGo.txt";
        //String outputFile = "getOverHere.txt";

        try {
            FileReader fr = new FileReader (inputFile);
	   BufferedReader br = new BufferedReader(fr);
           // FileOutputStream outputStream = new FileOutputStream(outputFile);

            String data;
            while ((data = br.readLine()) != null) {
                int i = 0;
		if (i == 5)
		{
			System.out.println();		
		}
		System.out.print(data );
		i++;
		
            }

            fr.close();
br.close();
            //outputStream.close();

            System.out.println("\n\n\tFile copied successfully.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
