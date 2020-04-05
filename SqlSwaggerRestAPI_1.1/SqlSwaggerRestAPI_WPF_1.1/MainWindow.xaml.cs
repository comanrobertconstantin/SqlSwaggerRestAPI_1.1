using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SqlSwaggerRestAPI_WPF_1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetStudent_Click(object sender, RoutedEventArgs e)
        {
            //double risArea = 0;

            //double raggio = Convert.ToDouble(txtRadius.Text);

            //HttpClient client = new HttpClient();

            //string urlArea = $"https://localhost:44327/api/Operations/GetArea?raggio={raggio}";

            //HttpResponseMessage responseArea = await client.GetAsync(urlArea);

            //string contentArea = await responseArea.Content.ReadAsStringAsync();

            //risArea = JsonConvert.DeserializeObject<double>(contentArea);

            //Dispatcher.Invoke(() => lblArea.Content = risArea);
        }
    }
}
