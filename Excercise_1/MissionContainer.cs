using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double func(double val);
    public class FunctionsContainer
    {
        private Dictionary<string, func> functions;
        public FunctionsContainer()
        {
            functions = new Dictionary<string, func>();
        }
        public func this[string key]
        {
            get
            {
                if (!functions.ContainsKey(key))
                {
                    //sign default function
                    functions[key] = var => var;
                }
                return functions[key];
            }
            set
            {
                functions[key] = value;
            }
        }
    }
}
