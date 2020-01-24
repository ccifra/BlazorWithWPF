using BlazorUI;
using BlazorUI.Data;
using System.Windows;

namespace WPFHostApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CounterService _counterService;

        public MainWindow()
        {
            InitializeComponent();
            _counterService = new CounterService();
            _counterText.DataContext = _counterService;
            var counterServiceCookie = CookieManager.Instance.CookieObject(_counterService);
            _browser.Address = "http://localhost:5000/counter/" + counterServiceCookie.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _counterService.Count += 1;
        }
    }
}
