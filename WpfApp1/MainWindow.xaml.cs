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
using WpfApp1.Commands;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public RelayCommand SaveCommand { get; set; }


        public TextBox FullNameTxtBox
        {
            get { return (TextBox)GetValue(FullNameTxtBoxProperty); }
            set { SetValue(FullNameTxtBoxProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FullNameTxtBox.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FullNameTxtBoxProperty =
            DependencyProperty.Register("FullNameTxtBox", typeof(TextBox), typeof(MainWindow), new PropertyMetadata(0));



        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }


        private void SaveFunct(object obj)
        {
            MessageBox.Show("Congratulations");
        }

    }
}
