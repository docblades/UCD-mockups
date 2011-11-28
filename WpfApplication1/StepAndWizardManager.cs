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
    internal class StepAndWizardManager
    {
        private IList<WizardStep> StepsAndWizards { get; set; }
        private const int DEFAULTFONTSIZE = 12;
        private const int ACTIVEFONTSIZE = 16;

        public StepAndWizardManager()
        {
            CurrentStep = 1;
            StepsAndWizards = new List<WizardStep>();
        }

        public int MaxSteps
        {
            get 
            {
                return StepsAndWizards.Count;
            }
        }

        public int CurrentStep { get; set; }

        public StepAndWizardManager AddStep(WizardStep step)
        {
            StepsAndWizards.Add(step);
            return this;
        }

        public void ChangeStep(int stepNum)
        {
            CurrentStep = stepNum;
            int stepIndex = stepNum - 1;

            foreach (var item in StepsAndWizards.Where(step=>step.StepLabel != StepsAndWizards[stepIndex].StepLabel))
            {
                item.StepLabel.FontSize = DEFAULTFONTSIZE;
                item.StepLabel.FontWeight = FontWeights.Normal;
                item.WizardControl.Visibility = Visibility.Hidden;
            }

            var activeItem = StepsAndWizards[stepIndex];
            activeItem.StepLabel.FontSize = ACTIVEFONTSIZE;
            activeItem.StepLabel.FontWeight = FontWeights.Bold;
            activeItem.WizardControl.Visibility = Visibility.Visible;            
        }

        public void AdvanceStep()
        {
            if (CurrentStep >= MaxSteps)
                return;
            ChangeStep(CurrentStep + 1);
        }

        public void RetreateStep()
        {
            if (CurrentStep <= 1)
                return;
            ChangeStep(CurrentStep - 1);
        }
    }
}
