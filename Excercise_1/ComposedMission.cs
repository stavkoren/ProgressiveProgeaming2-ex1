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
        /// <summary>
        /// ComposedMission - constructor
        /// </summary>
        /// <param name="missionName"></param>
        public ComposedMission(string missionName)
        {
            functions = new Queue<func>();
            Name = missionName;
            Type = "Composed";
        }
        public event EventHandler<double> OnCalculate;
        /// <summary>
        /// Add -add new mission to queue
        /// </summary>
        /// <param name="mission"></param>
        /// <returns></returns>
        public ComposedMission Add(func mission)
        {
            functions.Enqueue(mission);
            return this;
        }
        /// <summary>
        /// Calculate - calvulate value by its missions
        /// </summary>
        /// <param name="value"></param>
        /// <returns>result (type: double)</returns>
        public double Calculate(double value)
        {
            foreach (var func in functions)
            {
                value = func(value);
            }
            //invoke event if not empty
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
