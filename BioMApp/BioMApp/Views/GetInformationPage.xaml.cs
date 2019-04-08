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

namespace BioMApp.Views
{
    /// <summary>
    /// Interaction logic for GetInformationPage.xaml
    /// </summary>
    public partial class GetInformationPage : Page
    {
        public GetInformationPage()
        {
            InitializeComponent();
        }

        private void BtnConfirm_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows.OfType<MainWindow>().FirstOrDefault().frame.Content = new BeforeTestPage();

        }
    }
}
