import java.applet.*;
import java.awt.*;
public class Main extends Applet {
    int[] percentage = {75, 80, 85, 90, 95};
    String[] years = {"2017", "2018", "2019", "2020", "2021"};
    Color[] colors = {Color.red, Color.green, Color.blue, Color.yellow, Color.orange};
    public void paint(Graphics g) {
        g.setFont(new Font("Arial", Font.PLAIN, 12));
        int maxPercentage = 95;
        int width = 800;
        int height = 300;
        int barWidth = width / percentage.length;
        g.setColor(Color.black);
        g.drawString("Passing Percentage in Last 5 Years", 50, 20);
        for (int i = 0; i < percentage.length; i++) {
            g.setColor(colors[i]);
            int barHeight = (int)((double)percentage[i] / maxPercentage * (height - 50));
            g.fillRect(i * barWidth + 50, height - barHeight - 30, barWidth - 20, barHeight);
            g.setColor(Color.black);
            g.drawString(years[i], i * barWidth + 50, height - 10);
            g.drawString(Integer.toString(percentage[i]) + "%", i * barWidth + 50, height - barHeight - 35);
        }
    }
}
