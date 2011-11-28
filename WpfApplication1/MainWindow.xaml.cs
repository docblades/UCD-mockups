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
        private StepAndWizardManager StepMan;

        private void SetupStepManager()
        {
            StepMan = new StepAndWizardManager()
            .AddStep(new WizardStep()
            {
                StepLabel = lblStep1,
                WizardControl = wizard11
            })
            .AddStep(new WizardStep()
            {
                StepLabel = lblStep2,
                WizardControl = wizard21
            })
            .AddStep(new WizardStep()
            {
                StepLabel = lblStep3,
                WizardControl = wizard31
            })
            .AddStep(new WizardStep()
            {
                StepLabel = lblStep4,
                WizardControl = wizard41
            })
            .AddStep(new WizardStep()
            {
                StepLabel = lblStep5,
                WizardControl = wizard51
            });
        }

        public MainWindow()
        {
            InitializeComponent();
            SetupStepManager();
        }

        private void DoubleClickStep1(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(1);
            ManageStepChange();
        }

        private void DoubleClickStep2(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(2);
            ManageStepChange();
        }

        private void DoubleClickStep3(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(3);
            ManageStepChange();
        }

        private void DoubleClickStep4(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(4);
            ManageStepChange();
        }

        private void DoubleClickStep5(object sender, MouseButtonEventArgs e)
        {
            StepMan.ChangeStep(5);
            ManageStepChange();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ManageStepChange()
        {
            if (StepMan.CurrentStep == StepMan.MaxSteps)
            {
                button1.IsEnabled = true;
                button2.IsEnabled = false;
            }
            else
            {
                button1.IsEnabled = false;
                button2.IsEnabled = true;
            }        

            if (StepMan.CurrentStep == 1)
                button3.IsEnabled = false;
            else
                button3.IsEnabled = true;            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            StepMan.AdvanceStep();
            ManageStepChange();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            StepMan.RetreateStep();
            ManageStepChange();
        }
        
    }
}
