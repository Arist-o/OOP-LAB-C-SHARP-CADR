using Lab1_Csharp_07._09.Classes;

namespace Lab1_Csharp_07._09;
using System.IO;
public partial class Form1 : Form
{
    private List<Worker> ListFromFile = new List<Worker>();
    public Form1()
    {
        InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
   
        MenuStrip menu = new MenuStrip();
        
        ToolStripMenuItem create = new ToolStripMenuItem("Створити");
        ToolStripMenuItem save = new ToolStripMenuItem("Зберегти");
        ToolStripMenuItem print = new ToolStripMenuItem("Вивести");

        menu.Items.Add(create);
        menu.Items.Add(save);
        menu.Items.Add(print);
        
        this.MainMenuStrip = menu;
        this.Controls.Add(menu);

        DATA1.Columns.Add("Name", "Ім`я");
        DATA1.Columns.Add("Gender", "Стать");
        DATA1.Columns.Add("Position", "Посада");
        DATA1.Columns.Add("Age", "Вік");
        DATA1.Columns.Add("Experience", "Досвід");
        
        DATA2.Columns.Add("Name", "Ім`я");
        DATA2.Columns.Add("Gender", "Стать");
        DATA2.Columns.Add("Position", "Посада");
        DATA2.Columns.Add("Age", "Вік");
        DATA2.Columns.Add("Experience", "Досвід");
        
        
        this.CenterToScreen();
    }
}