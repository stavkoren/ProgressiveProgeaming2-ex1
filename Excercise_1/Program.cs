using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            FunctionsContainer funcList = new FunctionsContainer();     // Creating the mission conatiner

          //  var vall = funcList["Stam"];



            funcList["Double"] = val => val * 2;                    // Double the Value
            funcList["Triple"] = val => val * 3;                    // Triple the Value
            funcList["Square"] = val => val * val;                  // Square the Value
            funcList["Sqrt"] = val => Math.Sqrt(val);               // Taking the square root
            funcList["Plus2"] = val => val + 2;                    // Double the Value

            ComposedMission mission1 = new ComposedMission("mission1")
                .Add(funcList["Square"])
                .Add(funcList["Sqrt"]);

            ComposedMission mission2 = new ComposedMission("mission2")
                .Add(funcList["Triple"])
                .Add(funcList["Plus2"])
                .Add(funcList["Square"]);

            SingleMission mission3 = new SingleMission(funcList["Double"], "mission3");


            ComposedMission mission4 = new ComposedMission("mission4")
                .Add(funcList["Triple"])
                .Add(funcList["Stam"])              // Notice that this function does not exist and still it works
                .Add(funcList["Plus2"]);
          //  Console.Write("mission 4 with empth stam");
           // Console.Write(mission4.Calculate(2));
            

            funcList["Stam"] = val => val + 100;
            SingleMission mission5 = new SingleMission(funcList["Stam"], "mission5");

            var missionList = new List<IMission>() { mission1, mission2, mission3, mission4, mission5 };

            foreach(var mission in missionList)
            {
                Console.WriteLine(mission.Calculate(2));
            }

            Console.ReadKey();

        }
    }
}
