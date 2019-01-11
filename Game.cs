using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MontyHallSimulation {
    class Game {
        private int prizeDoor;
        private int selectedDoor;
        private int otherDoor;

        private System.Security.Cryptography.RNGCryptoServiceProvider Rand;

        public Game() {
            Rand = new RNGCryptoServiceProvider();
        }

        public bool play() {
            List<int> doors = new List<int> { 1, 2, 3 };

            int winnerIndex = RandomInteger(0, doors.Count);
            prizeDoor = doors[winnerIndex];

            int selectedIndex = RandomInteger(0, doors.Count);
            selectedDoor = doors[selectedIndex];

            doors.RemoveAt(winnerIndex);
            if (winnerIndex != selectedIndex) {
                doors.RemoveAll(d => d == selectedDoor);
            }

            int otherDoorIndex = RandomInteger(0, doors.Count);
            otherDoor = doors[otherDoorIndex];

            if (otherDoor == prizeDoor || otherDoor == selectedDoor) {
                throw new Exception();
            }

            return (prizeDoor == selectedDoor);
        }

        // Return a random integer between a min and max value.
        private int RandomInteger(int min, int max) {
            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue) {
                // Get four random bytes.
                byte[] four_bytes = new byte[4];
                Rand.GetBytes(four_bytes);

                // Convert that into an uint.
                scale = BitConverter.ToUInt32(four_bytes, 0);
            }

            // Add min to the scaled difference between max and min.
            return (int)(min + (max - min) *
                (scale / (double)uint.MaxValue));
        }
    }
}
