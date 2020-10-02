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

namespace WpfComboBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> words;

        public MainWindow()
        {
            InitializeComponent();
            words = new List<string>() { "Hello", "World", "Green", "Table", "Day" };
            wordsComboBox.ItemsSource = words;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wordTextBox.Text != string.Empty)
            {
                words.Add(wordTextBox.Text);
                wordsComboBox.ItemsSource = new List<string>(words);
            }
        }
    }
}
