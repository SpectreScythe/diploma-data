import java.awt.*;
import java.applet.*;

public class EXP29Nigga extends Applet {
    public void paint(Graphics g) {
        g.setColor(new Color(255, 222, 173));
        g.fillOval(80, 100, 250, 250);
        g.setColor(Color.black);
        g.fillOval(150, 175, 25, 25);
        g.fillOval(225, 175, 25, 25);
        g.setColor(Color.red);
        g.drawArc(150, 225, 100, 50, 180, 180);
    }
}