using Algorithms;
using Algorithms.AlgorithmAnalysis;
using System;


int[] oneKintegers = FileReader.ReadIntegersFromFile(@"AlgorithmAnalysis/SampleData/1Kints.txt").ToArray();
int[] fourKintegers = FileReader.ReadIntegersFromFile(@"AlgorithmAnalysis/SampleData/4Kints.txt").ToArray();
int[] eightKintegers = FileReader.ReadIntegersFromFile(@"AlgorithmAnalysis/SampleData/8Kints.txt").ToArray();


int countOneK = 0;
int countFourK = 0;
int countEightK = 0;


TimeSpan oneKTimeSpan = ThreeSum.TimeAlgorithm(oneKintegers, ThreeSum.EqualZeroCountCubicComplexity, out countOneK);
TimeSpan fourKTimeSpan = ThreeSum.TimeAlgorithm(fourKintegers, ThreeSum.EqualZeroCountCubicComplexity, out countFourK);
TimeSpan eightKTimeSpan = ThreeSum.TimeAlgorithm(eightKintegers, ThreeSum.EqualZeroCountCubicComplexity, out countEightK);



Console.WriteLine($"1Kints");
Console.WriteLine($"{countOneK} number of triplets found to equal 0 \n" );
Console.WriteLine($"Time taken to run was {oneKTimeSpan.TotalMilliseconds.ToString()} Milliseconds");
Console.WriteLine($"-----------------------------------------------------------------");
Console.WriteLine($"4Kints");
Console.WriteLine($"{countFourK} number of triplets found to equal 0 \n");
Console.WriteLine($"Time taken to run was {fourKTimeSpan.TotalMilliseconds.ToString()} Milliseconds");
Console.WriteLine($"-----------------------------------------------------------------");
Console.WriteLine($"8Kints");
Console.WriteLine($"{countEightK} number of triplets found to equal 0 \n");
Console.WriteLine($"Time taken to run was {eightKTimeSpan.TotalMilliseconds.ToString()} Milliseconds");

Console.ReadLine();
