using Algorithms;
using Algorithms.AlgorithmAnalysis;
using System;


int[] integers = FileReader.ReadIntegersFromFile(@"AlgorithmAnalysis/SampleData/1Kints.txt").ToArray();
int count = 0;
TimeSpan time = ThreeSum.TimeAlgorithm(integers, ThreeSum.EqualZeroCountCubicComplexity, out count);

Console.WriteLine($"{count} number of triplets found to equal 0 \n" );
Console.WriteLine($"Tine taken to run was {time.ToString()}");
Console.ReadLine();
