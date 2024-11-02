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

namespace Task_9
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

        static String[] SplitText(string text)
        {
            String[] listText = text.Split();
            return listText;
;
        }
        static String[] Reverse(string text)
        {
            String[] arrText = text.Split();
            Array.Reverse(arrText);

            return arrText;
        }
        static void WriteText(string text)
        {
            Console.WriteLine(text);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String[] spText = SplitText(task1.Text);
            listBox1.ItemsSource = spText;
        }

        private void prMouseDown(object sender, MouseButtonEventArgs e)
        {
            task1.Text = "";
            task1.FontStyle = FontStyles.Normal;
            task1.Opacity = 1;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            String[] spText = Reverse(task2.Text);
            listBox2.ItemsSource = spText;
        }

        private void prMouseDown2(object sender, MouseButtonEventArgs e)
        {
            task2.Text = "";
            task2.FontStyle = FontStyles.Normal;
            task2.Opacity = 1;
        }
    }
}