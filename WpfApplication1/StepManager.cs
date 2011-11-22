using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
    internal class StepManager
    {
        private IList<Label> Steps { get; set; }

        public int CurrentStep
        {
            public get;
            private set;
        }

        public int Max
        {
            get
            {
                return Steps.Count;
            }
        }

        public StepManager(IEnumerable<Label> steps)
        {
            Steps = steps.ToList();
        }

        public StepManager()
        {
            Steps = new List<Label>();
        }

        public StepManager AddStep(Label step)
        {
            if (step != null)
                Steps.Add(step);

            return this;
        }

        public void ChangeStep(int stepNum)
        {
            bool stepNumIsInvalid = stepNum > Max || stepNum < 1;
            if (stepNumIsInvalid)
                return;

            CurrentStep = stepNum;

            int stepIndex = stepNum - 1;
            var lblCurrentStep = Steps[stepIndex];
            lblCurrentStep.FontWeight = FontWeights.ExtraBold;

            Steps.Where(step => step != lblCurrentStep).ToList().ForEach(step => step.FontWeight = FontWeights.Normal);
        }

        public void AdvanceStep()
        {
            if (CurrentStep >= Max)
                return;

            ChangeStep(CurrentStep + 1);
        }

        public void RetreatStep()
        {
            if (CurrentStep <= 1)
                return;

            ChangeStep(CurrentStep - 1);
        }
    }
}
