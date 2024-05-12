using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set up the timer
            DispatcherTimer PollingTimer = new DispatcherTimer();
            PollingTimer.Interval = TimeSpan.FromSeconds(1); // Fire every 1 second
            PollingTimer.Tick += Timer_Tick;
            PollingTimer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            float[] temperatures = GenerateVoltages();
            // Bind the array to the ListBox
            temperatureListBox.ItemsSource = temperatures;

        }

        private static float[] GenerateVoltages()
        {
            // Create the array of random float values
            float[] temperatures = new float[36];
            Random random = new Random();
            for (int i = 0; i < temperatures.Length; i++)
            {
                float randomValue = (float)(random.NextDouble() * (231.00 - 229.00) + 229.00);
                temperatures[i] = randomValue;
            }

            return temperatures;
        }
    }

}