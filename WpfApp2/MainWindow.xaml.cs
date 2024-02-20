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
using WpfApp2.Views;

namespace WpfApp2
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginPage? lp;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lp = new LoginPage();
            ramka.Content = lp;
            lp.btnLogin.Click += BtnLogin_Click;

            Nav nn = new Nav();
            ramkaNaNav.Content = nn;
            //nn.btnLogin.Click += BtnLogin_Click;
            nn.btn1.Click += BtnALogin_Click;
            nn.btn2.Click += BtnALogin_Click;
            nn.btn3.Click += BtnALogin_Click;
            nn.btn4.Click += BtnALogin_Click;
            nn.btn5.Click += BtnALogin_Click;
        }





        private void BtnALogin_Click(object sender, RoutedEventArgs e) {
            switch (((Button)sender).Name)
            {
                case "btn2":
                    ramka.Content = new Page1();
                    break;
                case "btn1":
                    lp = new LoginPage();
                    ramka.Content = lp;
                    lp.btnLogin.Click += BtnLogin_Click;
                    break;
                default:
                    break;
            }

        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            ramka.Content = new AfterLogin();
        }
    }
}
