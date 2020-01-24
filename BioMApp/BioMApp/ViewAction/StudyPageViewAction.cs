using BioMApp.Database;
using BioMApp.Models;
using BioMApp.SQL;
using BioMApp.Views;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace BioMApp.ViewAction
{
    public static class StudyPageViewAction
    {

        public static StudyPage InitialStudyPage()
        {
            StudyPage page = new StudyPage();

            Filament filament = FilamentOpp.GetRandomFilament();

            page.rec.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(filament.RectangleCollor.Trim());

            page.btn1.Background =
                (SolidColorBrush)new BrushConverter().ConvertFromString(filament.BtnBackColor1.Trim());
            page.btn1.Foreground =
                (SolidColorBrush)new BrushConverter().ConvertFromString(filament.BtnStringColor1.Trim());
            page.btn1.Content = filament.BtnString1.Trim();

            page.btn2.Background =
                (SolidColorBrush)new BrushConverter().ConvertFromString(filament.BtnBackColor2.Trim());
            page.btn2.Foreground =
                (SolidColorBrush)new BrushConverter().ConvertFromString(filament.BtnStringColor2.Trim());
            page.btn2.Content = filament.BtnString2.Trim();

            page.btn3.Background =
                (SolidColorBrush)new BrushConverter().ConvertFromString(filament.BtnBackColor3.Trim());
            page.btn3.Foreground =
                (SolidColorBrush)new BrushConverter().ConvertFromString(filament.BtnStringColor3.Trim());
            page.btn3.Content = filament.BtnString3.Trim();

            page.btn4.Background =
                (SolidColorBrush)new BrushConverter().ConvertFromString(filament.BtnBackColor4.Trim());
            page.btn4.Foreground =
                (SolidColorBrush)new BrushConverter().ConvertFromString(filament.BtnStringColor4.Trim());
            page.btn4.Content = filament.BtnString4.Trim();

            Instance.answer = filament.Answer;
            Instance.index = Instance.index + 1;


            return page;
        }


        public static void ChangeStudyPage(TimeSpan time, int answer)
        {
            if (Instance.index <= 10)
            {
                if (answer == Instance.answer)
                {
                    Instance.PosAnsS = Instance.PosAnsS + 1;
                }
                else
                {
                    Instance.NegAnsS = Instance.NegAnsS + 1;
                }


                Instance.timeIntervalSilence.Add(time);
                Application.Current.Windows.OfType<MainWindow>().FirstOrDefault().frame.Content = InitialStudyPage();
            }


            if (Instance.index > 10 && Instance.index <= 20)
            {
                if (answer == Instance.answer)
                {
                    Instance.PosAnsRM = Instance.PosAnsRM + 1;
                }
                else
                {
                    Instance.NegAnsRM = Instance.NegAnsRM + 1;
                }


                Instance.timeIntervalRelaxMusic.Add(time);
                Application.Current.Windows.OfType<MainWindow>().FirstOrDefault().frame.Content = InitialStudyPage();
            }


            if (Instance.index > 20 && Instance.index <= 30)
            {
                if (answer == Instance.answer)
                {
                    Instance.PosAnsHM = Instance.PosAnsHM + 1;
                }
                else
                {
                    Instance.NegAnsHM = Instance.NegAnsHM + 1;
                }


                Instance.timeIntervalHardMusic.Add(time);
                Application.Current.Windows.OfType<MainWindow>().FirstOrDefault().frame.Content = InitialStudyPage();
            }

            if (Instance.index == 31)
            {

            }








        }

    }
}
