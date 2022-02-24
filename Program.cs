using System;

string[] input = File.ReadAllLines("./pog.txt");

for (int i = 0; i < input.Length; i++)
{
    Console.WriteLine(input[i].Split(';'));  
}