using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StepManager StepMan;

        private void SetupStepManager()
        {
            StepMan = new StepManager()
            .AddStep(lblStep1)
            .AddStep(lblStep2)
            .AddStep(lblStep3)
            .AddStep(lblStep4)
            .AddStep(lblStep5);
        }

        public MainWindow()
        {
            InitializeComponent();
            SetupStepManager();
        }

        private void DoubleClickStep1(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(1);
        }

        private void DoubleClickStep2(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(2);
        }

        private void DoubleClickStep3(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(3);
        }

        private void DoubleClickStep4(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(4);
        }

        private void DoubleClickStep5(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(5);
        }



        
    }
}
