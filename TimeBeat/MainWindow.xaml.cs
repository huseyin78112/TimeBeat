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

namespace TimeBeat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int secs = 0;
        DispatcherTimer dt = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dt.Tick += Dt_Tick;
            dt.Interval = TimeSpan.FromSeconds(1);
        }

        private void Dt_Tick(object? sender, EventArgs e)
        {
            secs++;
            Timer.Text = string.Format("{0:00}:{1:00}:{2:00}", secs / 3600, secs / 60 % 60, secs % 60);
        }

        private void StartStop_Click(object sender, RoutedEventArgs e)
        {
            dt.IsEnabled = !dt.IsEnabled;
            if (!dt.IsEnabled)
            {
                secs = 0;
            }
            Timer.Text = "00:00:00";
        }
    }
}