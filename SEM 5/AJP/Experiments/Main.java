import javax.swing.*;
import java.awt.*;

public class Main {
    JProgressBar myProgressBar;
    JLabel JL;

    public Main() {
        JFrame frame = new JFrame("My Progress Bar");
        frame.setBackground(Color.DARK_GRAY);
        frame.setForeground(Color.WHITE);

        Panel P = new Panel();

        JL = new JLabel("0%");
        myProgressBar = new JProgressBar(1, 500);
        myProgressBar.setSize(200,200);

        P.setLayout(new FlowLayout(1));

        P.add(new JLabel("Progress Bar"));
        P.add(myProgressBar);
        P.add(JL);

        P.setSize(100,100);

        frame.add(P);

        frame.setSize(400, 300);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);

        loadProgressBar();
    }

    public void loadProgressBar() {
        for (int i = 1; i <= 500; i+=5) {
            myProgressBar.setValue(i);
            JL.setText(i + "%");
            try {
                Thread.sleep(100);
            } catch (Exception ignored) {
            }
        }
    }

    public static void main(String[] args) {
        new Main();
    }
}
