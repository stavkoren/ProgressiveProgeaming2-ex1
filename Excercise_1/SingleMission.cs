using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private func func;

        public string Name { get; }

        public string Type { get; }

        private const string type = "Single";
        /// <summary>
        /// SingleMission - constructor
        /// </summary>
        /// <param name="mission"></param>
        /// <param name="missionName"></param>
        public SingleMission(func mission, string missionName)
        {
            Name = missionName;
            Type = type;
            func = mission;
        }
        public event EventHandler<double> OnCalculate;
        /// <summary>
        /// Calculate - calvulate value by its mission
        /// </summary>
        /// <param name="value"></param>
        /// <returns>result (type: double)</returns>
        public double Calculate(double value)
        {
            double result= func(value);
            //invoke event if not empty
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
