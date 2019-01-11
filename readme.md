# MontyHallSimulation

This program simulates the Monty Hall Problem.
You provide a number of games you'd like to simulate and the app will simulate that number of games and then output the number of games that would have been won by swapping and the number that would have been won by not swapping.

Simply provide the number of cycles as an argument, eg:  
`MontyHallSimulation.exe 100000`

This simulation uses cryptographically safe random numbers, and so simulating more than a few thousand can take a little while. The following is output from 10,000,000 cycles:
```
Simulating 10000000 times
Staying Won: 3335715
Swapping Won: 6664285
```

I only created this to further demonstrate that Monty Hall isn't a purely theoretical argument, but the correct answer is demonstrably so.

Thanks!
