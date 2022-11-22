// See https://aka.ms/new-console-template for more information
using static C5.Class1;
using static C5.testFolder.Class1;
using static C5.Calculator.calculatorFile;
using static C5.week2.SelectStatement;
using static C5.week4.callingAbstract;

//Console.WriteLine("Hello, World!");

////Creating object
//C5.Class1 class1 = new C5.Class1();
//C5.testFolder.Class1 classTest = new C5.testFolder.Class1();

////calling method using object.
//class1.greet();

////calling method from testfolder object.
//classTest.greet();

Console.WriteLine("hello world");

C5.week4.callingAbstract _callingAbstract = new C5.week4.callingAbstract();

_callingAbstract.Area(value: 5);

//Console.WriteLine("Pushing to github");

//C5.Calculator.calculatorFile.initialize();

//C5.week2.SelectStatement _selectStatement = new C5.week2.SelectStatement();

//C5.week2.SelectStatement.ifElse();




//Need to put this line to not stop the program automatically.
Console.ReadKey();