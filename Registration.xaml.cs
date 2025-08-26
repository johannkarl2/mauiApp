namespace MauiApp3;

public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}

    private void mySlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        long value = (long)Math.Round(e.NewValue);
        lblnumber.Text = "09" + value.ToString("N0");

        // Sync stepper if needed
        if ((long)myStepper.Value != value)
        {
            myStepper.Value = value;
        }
    }

    private void myStepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        long value = (long)e.NewValue;
        lblnumber.Text = "09" + value.ToString("N0");

        // Sync slider if needed
        if ((long)mySlider.Value != value)
        {
            mySlider.Value = value;
        }
    }
}