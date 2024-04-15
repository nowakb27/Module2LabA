namespace Module2LabA;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(HeightEntry.Text) || string.IsNullOrWhiteSpace(WeightEntry.Text))
        {
            ResultLabel.Text = "Please enter both height and weight.";
            return;
        }

        if (!double.TryParse(HeightEntry.Text, out double height) || !double.TryParse(WeightEntry.Text, out double weight))
        {
            ResultLabel.Text = "Please enter your height and weight.";
            return;
        }
        
        height *= 0.3048; 
        weight *= 0.453592; 

        double bmi = CalculateBMI(height, weight);
        ResultLabel.Text = $"Your BMI is: {bmi:F2}";
    }

    private double CalculateBMI(double height, double weight)
    {
        return weight / (height * height);
    }
}
