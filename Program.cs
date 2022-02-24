using System;
new Splits().RealSplit();
class Splits
{
    public void RealSplit()
    {
        string[] input = File.ReadAllLines("./pog.txt");
        for (int i = 0; i < input.Length; i++)
        {
            string[] Gotit = input[i].Split(';');
            string left = Gotit[0];
            string right = Gotit[1];
            Console.WriteLine(left + right);
            Console.WriteLine(right + left);//bam prohodil sem to
        }
    }
}