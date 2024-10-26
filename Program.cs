﻿using OOPArv;

//Timofey Suvorov, NET 2024

Console.WriteLine("Prensetation of a dog:\n");
Dog dog1 = new Dog("dog", 3, 35, "dry food and a lot of meat", "home", "Pitbull");
dog1.DisplayInfo();
dog1.MakeSound();
dog1.Hunt();
dog1.DoTrick();

Console.WriteLine("\nPresentation of a lion:\n");
Lion lion1 = new Lion("lion", 9, 175, "meat", "in the Safari", "the King of the Jungle");
lion1.DisplayInfo();
lion1.MakeSound();
lion1.Hunt();
lion1.TheKing();

Console.WriteLine("\nPresentation of a shark:\n");

Shark shark1 = new Shark("shark", 20, 800, "fishes", "Ocean", true);
shark1.DisplayInfo();
shark1.MakeSound();
shark1.Hunt();
Console.WriteLine(shark1.CantBreath());

Console.WriteLine("\nPresentation of a cute dog:\n");

ShihTzu sh = new ShihTzu("dog", 3, 6, "dry food", "home", "Shih-Tzu", "small");
sh.DisplayInfo();
sh.MakeSound();
sh.Hunt();
Console.WriteLine(sh.Sleep());

Console.WriteLine("\nPresentation of a crazy dog:\n");
JackRussel jr = new JackRussel("dog", 2, 5, "dry food", "home, sometimes in the forest", "Jack Russel", "small", true);
jr.DisplayInfo();
jr.MakeSound();
jr.Hunt();
Console.WriteLine(jr.OutdoorDog());





