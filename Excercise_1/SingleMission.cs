using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private readonly string name;
        private readonly string type;
        private func func;

        public string Name
        {
            get
            {return name; }
        }

        public string Type
        {
            get
            { return type;  }
        }
        public SingleMission(func mission, string missionName)
        {
            name = missionName;
            type = "Single";
            func = mission;
        }
        public event EventHandler<double> OnCalculate;
        public double Calculate(double value)
        {
            return func(value);
        }
    }
}
