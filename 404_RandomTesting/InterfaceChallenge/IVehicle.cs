using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404_RandomTesting.InterfaceChallenge
{
    public interface IVehicle
    {
        string Make { get;}
        string Model {get;}
        string Color {get;}
        bool IsEngineOn { get; }
        bool StartVehicle();
        bool TurnOff();
        string Drive();
    }
}
