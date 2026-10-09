using System.Windows.Forms;
using System;
public class bhoomi : Form   //Class
{
    Button b;
    TextBox textBox;

    public bhoomi()
    {
        b=new Button();
        textBox=new TextBox();
        b.Text="Save";
        b.Click+=new EventHandler(this.save);    
        this.Controls.Add(b);
        this.Controls.Add(textBox);


    }
    public void save(Object o,EventArgs s)
    {
        MessageBox.Show("save");
    }
    public static void Main()
    {
       bhoomi b=new bhoomi();
       b.ShowDialog();
    }
}