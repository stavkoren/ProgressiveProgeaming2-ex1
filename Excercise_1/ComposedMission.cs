using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private Queue<func> functions;

        public string Name { get; }
        public string Type { get; }
        public ComposedMission(string missionName)
        {
            functions = new Queue<func>();
            Name = missionName;
            Type = "Composed";
        }
        public event EventHandler<double> OnCalculate;

        public ComposedMission Add(func mission)
        {
            functions.Enqueue(mission);
            return this;
        }

        public double Calculate(double value)
        {
            foreach (var func in functions)
            {
                value = func(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
