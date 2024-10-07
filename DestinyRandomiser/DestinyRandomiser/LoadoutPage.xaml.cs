using Microsoft.Maui.Devices.Sensors;
namespace DestinyRandomiser;

public partial class LoadoutPage : ContentPage
{
    int count = 0;
    public LoadoutPage()
	{
		InitializeComponent();

        //Accelerometer.ReadingChanged += LoadoutShake; DO NOT USE XAMARIN - its old
        //Accelerometer.ReadingChanged += OnShakeDetected;
        

    }



    //event EventHandler? ShakeDetected;
    //void LoadoutShake(object sender, AccelerometerChangedEventArgs args)
    /*private void OnCounterClicked(object sender, EventArgs e)
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
    }*/
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

       /* count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);*/
    }

    private void OnRandomiseButtonClicked(object sender, AccelerometerChangedEventArgs e)
    {

        /* count++;

         if (count == 1)
             CounterBtn.Text = $"Clicked {count} time";
         else
             CounterBtn.Text = $"Clicked {count} times";

         SemanticScreenReader.Announce(CounterBtn.Text);*/
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