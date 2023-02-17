// See https://aka.ms/new-console-template for more information


using HackerRankProblemSolving;

//SampleTestRunner.ClimbingLeaderBoardTest();
//SampleTestRunner.SequenceEquationTest();

Product productA = new Product("ProductA");
Product productB = new Product("ProductB");
Product productC = new Product("ProductC");

productB = productA;
productC = productA;


productB.Name = " New B value";
Console.WriteLine(productA.ToString());
productC.Name = "New C value";
Console.WriteLine(productA.ToString());
Console.WriteLine(productB.ToString());



