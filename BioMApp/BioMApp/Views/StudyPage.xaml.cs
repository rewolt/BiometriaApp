using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using BioMApp.ViewAction;

namespace BioMApp.Views
{
    /// <summary>
    /// Interaction logic for StudyPage.xaml
    /// </summary>
    public partial class StudyPage : Page
    {
        public StudyPage()
        {
            InitializeComponent();
            LoadPageTime();
            Progres();
        }
        
        Stopwatch sw = new Stopwatch();

        void LoadPageTime()
        {
            sw.Start();
        }

        void Progres()
        {
            SynchronizationContext context = SynchronizationContext.Current;

            Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int n = 0; n < 1000; n++)
                        {
                            Thread.Sleep(5);
                            context?.Post(new SendOrPostCallback((o) =>
                            {

                                ProgressBar.Value = n;
                            }), null);

                            if(n.Equals(999))
                            {

                                this.Dispatcher.Invoke(() =>
                                {
                                    sw.Stop();
                                    StudyPageViewAction.ChangeStudyPage(sw.Elapsed, 1);
                                });
                               
                            }
                        };


                    }
                ));
            backgroundThread.Start();
        }

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            int answer = 1;
            sw.Stop();
            StudyPageViewAction.ChangeStudyPage(sw.Elapsed, answer);
        }

        private void Btn2_OnClick(object sender, RoutedEventArgs e)
        {
            int answer = 2;
            sw.Stop();
            StudyPageViewAction.ChangeStudyPage(sw.Elapsed, answer);
        }

        private void Btn3_OnClick(object sender, RoutedEventArgs e)
        {
            int answer = 3;
            sw.Stop();
            StudyPageViewAction.ChangeStudyPage(sw.Elapsed, answer);
        }

        private void Btn4_OnClick(object sender, RoutedEventArgs e)
        {
            int answer = 4;
            sw.Stop();
            StudyPageViewAction.ChangeStudyPage(sw.Elapsed, answer);
        }

    }
}
