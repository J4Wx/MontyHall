using System;

namespace MontyHallSimulation {
    class Simulation {
        int numberOfCycles;
        int stayWins;
        int swapWins;

        public Simulation(int cycles) {
            numberOfCycles = cycles;
        }

        public void run() {
            Console.WriteLine("Simulating " + numberOfCycles + " times");

            for (int i = 0; i < numberOfCycles; i++) {
                runCycle();
            }

            Console.WriteLine("Staying Won: " + stayWins);
            Console.WriteLine("Swapping Won: " + swapWins);
        }

        public void runCycle() {
            bool stayWin = runGame();
            if (stayWin) {
                stayWins++;
            } else {
                swapWins++;
            }
        }

        public bool runGame() {
            Game game = new Game();
            bool result = game.play();
            game = null;
            return result;
        }
    }
}
