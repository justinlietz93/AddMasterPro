namespace AddMaster;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Title = "Add Master Pro";
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtFirstNum.Text = string.Empty;
        txtSecondNum.Text = string.Empty;
        lblDisplay.Text = string.Empty;
    }

    private void Add_OnClicked(object sender, EventArgs e)
    {
        double dblFirst, dblSecond;
        Double.TryParse(txtFirstNum.Text, out dblFirst);
        Double.TryParse(txtSecondNum.Text, out dblSecond);

        lblDisplay.Text = (dblFirst + dblSecond).ToString();
    }
}