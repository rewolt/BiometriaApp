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
using BioMApp.ViewAction;

namespace BioMApp.Views
{
    /// <summary>
    /// Interaction logic for BeforeTestPage.xaml
    /// </summary>
    public partial class BeforeTestPage : Page
    {
        public BeforeTestPage()
        {
            InitializeComponent();
        }

        private void BtnConfirm_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows.OfType<MainWindow>().FirstOrDefault().frame.Content = StudyPageViewAction.InitialStudyPage();

        }
    }
}
