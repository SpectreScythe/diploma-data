import java.sql.*;
public class exp18q2
{
    public static void main(String args[])
    {
        try
        {
            Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
            Connection con=DriverManager.getConnection("jdbc:odbc:exp13");
            Statement st=con.createStatement();

            ResultSet rs=st.executeQuery("Select * from Student where sper>70");

            System.out.println("Students - Above 75% ");
            System.out.println("Roll No  \tPercentage");
            while(rs.next())
            {
                System.out.println(rs.getInt(1)+"\t\t"+rs.getInt(3));
            }

            con.close();
        }
        catch(Exception e)
        {
            System.out.println(e.getMessage());
        }
    }
}
