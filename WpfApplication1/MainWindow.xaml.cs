using System.Windows;
using FynbusProject;

namespace GUI
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

        private void button_Clear_Click(object sender, RoutedEventArgs e)
        {
            textBox_BasicData.Text = string.Empty;
            textBox_OfferData.Text = string.Empty;
            textBox_Routes.Text = string.Empty;
            bool dataCleared = CSVImport.Instance.ClearData();

            if(dataCleared)
            {
                MessageBox.Show("Data and interface cleared sucessfuly!");
            }
            else
            {
                MessageBox.Show("Oops! Something went wrong clearing the data, please try again");
            }
        }
    }
}
