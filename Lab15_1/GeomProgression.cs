using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_1
{
    public class GeomProgression : ISeries
    {
        private int FirstValue;
        private int CurrentValue = 1;
        private int Step;
        private int Start;
                
        public GeomProgression(int firstValue, int step)
        {
            FirstValue = firstValue;
            Step = step;
        }

        public GeomProgression(int firstValue, int step, int start)
        {
            Step = step;
            Start = start;
            FirstValue = firstValue;
            CurrentValue = start;
        }

        public int getNext() => FirstValue * (int)Math.Pow(Step, (double)(CurrentValue++ - 1));

        public void reset() => CurrentValue = Start;

        public void setStart(int x)
        {
            CurrentValue = x;
            Start = x;
        }
    }
}
