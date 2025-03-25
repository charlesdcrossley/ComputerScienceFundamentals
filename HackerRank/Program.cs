using HackerRank.InterviewPrep.OneWeek;

List<int> test = new List<int> { -4, 3, -9, 0, 4, 1 };
DayOne.PlusMinus(test);

var expectedOutput = new StringWriter();
expectedOutput.WriteLine("0.500000");
expectedOutput.WriteLine("0.333333");
expectedOutput.WriteLine("0.166667");

Console.WriteLine(expectedOutput);
Console.ReadLine();