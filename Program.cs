using System;

namespace MontyHallSimulation {
    class Program {
        static void Main(string[] args) {
            Simulation sim = new Simulation(Int32.Parse(args[0]));
            sim.run();
        }
    }
}
