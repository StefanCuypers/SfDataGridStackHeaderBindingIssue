using System.Collections.ObjectModel;
using System.Windows;

namespace DataGridHeaderTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void RefreshDataNoDelay()
        {
            CurrentMachine = new();
            CurrentMachine.VerzekeringsPolissen.Add(new("Polis1", 25m, 5m));
            CurrentMachine.VerzekeringsPolissen.Add(new("Polis2", 16m, 10m));
            CurrentMachine.VerzekeringsPolissen.Add(new("Polis3", 450m, 12m));
            CurrentMachine.VerzekeringsPolissen.Add(new("Polis4", 35m, 9m));
        }
        private async void RefreshData()
        {
            CurrentMachine = new();
            await Task.Delay(200);
            CurrentMachine.VerzekeringsPolissen.Add(new("Polis1", 25m, 5m));
            CurrentMachine.VerzekeringsPolissen.Add(new("Polis2", 16m, 10m));
            CurrentMachine.VerzekeringsPolissen.Add(new("Polis3", 450m, 12m));
            CurrentMachine.VerzekeringsPolissen.Add(new("Polis4", 35m, 9m));
        }

        /// <summary>
        /// Current machine we're viewing/editing.
        /// </summary>
        public MachineGegevensInfoVM? CurrentMachine
        {
            get => (MachineGegevensInfoVM?)GetValue(CurrentMachineProperty);
            private set => SetValue(CurrentMachinePropertyKey, value);
        }

        /// <summary>
        /// The CurrentMachine property key
        /// </summary>
        private static readonly DependencyPropertyKey CurrentMachinePropertyKey
                    = DependencyProperty.RegisterReadOnly(
                        nameof(CurrentMachine),
                        typeof(MachineGegevensInfoVM), typeof(MainWindow),
                        new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// The CurrentMachine property
        /// </summary>
        public static readonly DependencyProperty CurrentMachineProperty = CurrentMachinePropertyKey.DependencyProperty;

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void RefreshNoDelay_Click(object sender, RoutedEventArgs e)
        {
            RefreshDataNoDelay();
        }
    }
}