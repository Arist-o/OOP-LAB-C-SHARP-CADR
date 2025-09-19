namespace Lab1_Csharp_07._09;

public partial class FindWorkerForm : Form
{
    private TextBox txtNameSearch;
    private Button btnReturn;
    private Form1 mainForm;

    public FindWorkerForm(Form1 parentForm)
    {
        mainForm = parentForm;
        InitializeComponent();
        InitializeControls();
    }
    private void InitializeControls()
    {
        txtNameSearch = new TextBox
        {
            Location = new Point(20, 20),
            Size = new Size(200, 20),
            PlaceholderText = "Введіть ім'я для пошуку"
        };

        btnReturn = new Button
        {
            Text = "Повернутися",
            Location = new Point(20, 50),
            Size = new Size(100, 30)
        };

        btnReturn.Click += BtnReturn_Click;

        this.Controls.Add(txtNameSearch);
        this.Controls.Add(btnReturn);

        this.Size = new Size(260, 120);
        this.Text = "Пошук працівника";
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.CenterToScreen();
    }

    private void BtnReturn_Click(object sender, EventArgs e)
    {
        string searchName = txtNameSearch.Text.Trim();
        if (!string.IsNullOrEmpty(searchName))
        {
            var filteredWorkers = mainForm.ListFromFile
                .Where(w => w.Name.ToLower().Contains(searchName.ToLower()))
                .ToList();
            mainForm.UpdateDataGridView(mainForm.DATA2, filteredWorkers);
        }
        this.Close();
    }
}