import javax.swing.*;
import java.awt.*;

public class BarChart extends JFrame {

    private int[] percentages;

    public BarChart(int[] percentages) {
        super("Student Passing Percentage Chart");

        this.percentages = percentages;

        setSize(600, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setVisible(true);
    }

    //public void paint(Graphics g) {
      //  super.paint(g);

        // set up the chart axes
       // g.drawLine(100, 300, 500, 300); // x-axis
        //g.drawLine(100, 50, 100, 300); // y-axis
       // g.drawString("Year", 510, 310);
       // g.drawString("Passing Percentage", 60, 40);

        // plot the data as bars
      //  int x = 150;
      //  int y = 300;
      //  int barWidth = 50;
      //  int barSpacing = 10;
      //  for (int i = 0; i < percentages.length; i++) {
      //      int barHeight = percentages[i] * 2;
      //      g.setColor(Color.blue);
      //      g.fillRect(x, y - barHeight, barWidth, barHeight);
       //     g.setColor(Color.black);
       //     g.drawString(Integer.toString(i+1), x + (barWidth/2), y + 15);
        //    x += barWidth + barSpacing;
       // }
   //}

    public static void main(String[] args) {
        int[] percentages = {75, 80, 85, 90, 95};
        BarChart chart = new BarChart(percentages);
    }
}
