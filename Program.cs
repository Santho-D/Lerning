using System;

Random CoinFlip = new Random();
int Coin = CoinFlip.Next(0, 2);


Console.WriteLine ($"You've got: " + (Coin == 0 ? "Heads" : "Tails"));
