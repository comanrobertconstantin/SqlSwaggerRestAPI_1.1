using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        private async void btnGetStudent_Click(object sender, RoutedEventArgs e)
        {
            string student = "";

            int id = Convert.ToInt32(txtStudentID.Text);

            HttpClient client = new HttpClient();

            string url = $"https://localhost:44394/api/Operations?idStudent={idStudent}";
            
            HttpResponseMessage responseStudent = await client.GetAsync(url);

            string contentStudent = await responseStudent.Content.ReadAsStringAsync();

            student = JsonConvert.DeserializeObject<string>(contentStudent);

            Dispatcher.Invoke(() => txtViewStudent.Text = student);
        }
    }
}
