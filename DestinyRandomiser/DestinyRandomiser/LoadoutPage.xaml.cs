using Microsoft.Maui.Devices.Sensors;
namespace DestinyRandomiser;

public partial class LoadoutPage : ContentPage
{
    int count = 0;
    public LoadoutPage()
	{
		InitializeComponent();

        

    }


    public void ToggleAccelerometer()
    {
        if (Accelerometer.Default.IsSupported)
        {
            if (!Accelerometer.Default.IsMonitoring)
            {
                // Turn on accelerometer
                Accelerometer.Default.ReadingChanged += OnShakeDetected;
                Accelerometer.Default.Start(SensorSpeed.UI);
            }
            else
            {
                // Turn off accelerometer
                Accelerometer.Default.Stop();
                Accelerometer.Default.ReadingChanged -= OnShakeDetected;
            }
        }
    }
    private void OnShakeDetected(object sender, AccelerometerChangedEventArgs e)
    {


    }

    private void OnRandomiseButtonClicked(object sender, AccelerometerChangedEventArgs e)
    {

    }

    private void OnLoadClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            Kinetic.Text = $"Clicked {count} time";
        else
            Kinetic.Text = $"Clicked {count} times";
    }
    private void OnSettingsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SettingsPage());
    }


    private void OnSaveClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SavedLoadouts());
    }




}