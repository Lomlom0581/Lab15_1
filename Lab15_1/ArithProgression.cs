using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_1
{
    public class ArithProgression : ISeries
    {
        private int CurrentValue;
        private int FirstValue;
        private int Step;
        private int Start;
                
        public ArithProgression(int firstValue, int step)
        {
            Step = step;
            FirstValue = firstValue;
        }
                
        public int getNext() =>
                FirstValue + (CurrentValue++ - 1) * Step;

        public void reset() => CurrentValue = Start;

        public void setStart(int x)
        {
            CurrentValue = x;
            Start = x;
        }
    }
}
