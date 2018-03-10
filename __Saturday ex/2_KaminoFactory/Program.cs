using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        string[] bestDna = null;
        int bestLenght = -1;
        int startIndex = -1;
        int bestDnaSum = 0;
        int bestSampleIndex = 0;

        int currentSampleIndex = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Clone them!")
            {
                break;
            }

            string[] currDNA = input.Split('!').Where(x => x != "").ToArray();
            int currLenght = 0;
            int currBestLenght = 0;
            int currEndIndex = 0;

            for (int a = 0; a < currDNA.Length; a++)
            {
                if (currDNA[a] == "1")
                {
                    currLenght++;
                    if (currLenght > currBestLenght)
                    {
                        currEndIndex = a;
                        currBestLenght = currLenght;
                    }
                }
                else
                {
                    currLenght = 0;
                }
            } // Get current sequence

            int currStartIndex = currEndIndex - currBestLenght + 1;

            bool isCurrDNABetter = false;
            int currentDnaSum = currDNA.Select(int.Parse).Sum();

            if (currBestLenght > bestLenght)
            {
                isCurrDNABetter = true;
            }            //  Is current sequrnce better
            else if (currBestLenght == bestLenght)
            {
                if (currStartIndex < startIndex)
                {
                    isCurrDNABetter = true;
                }
                else if (currStartIndex == startIndex)
                {
                    if (currentDnaSum > bestDnaSum)
                    {
                        isCurrDNABetter = true;
                    }
                }
            }      //

            currentSampleIndex++;

            if (isCurrDNABetter)
            {
                bestDna = currDNA;
                bestLenght = currBestLenght;
                startIndex = currStartIndex;
                bestDnaSum = currentDnaSum;
                bestSampleIndex = currentSampleIndex;
            }   // Is current sequence the best
        }

        Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
        Console.WriteLine(string.Join(" ", bestDna));
    }
}