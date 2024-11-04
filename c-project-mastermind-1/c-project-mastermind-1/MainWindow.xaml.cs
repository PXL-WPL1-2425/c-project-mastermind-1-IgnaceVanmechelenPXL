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

namespace c_project_mastermind_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int randomIndex;
        private string randomColor;
        public MainWindow()
        {
            InitializeComponent();
            string randomColorOne = GenerateRandomColor();
            string randomColorTwo = GenerateRandomColor();
            string randomColorThree = GenerateRandomColor();
            string randomColorFour = GenerateRandomColor();
            string colorCode = randomColorOne + ", " + randomColorTwo + ", " + randomColorThree + ", " + randomColorFour;
            Title = "MasterMind - " + colorCode;
        }
        public string GenerateRandomColor()
        {
            string[] colors = { "rood", "geel", "oranje", "wit", "groen", "blauw" };
            Random rnd = new Random();
            randomIndex = rnd.Next(colors.Length);
            randomColor = colors[randomIndex];
            return randomColor;
        }
    }
}