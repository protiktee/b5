// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;

//Console.WriteLine("Hello, World!");


//string input_1 = "1"; 
//string input_2 = "2";

//int sum = 0;
////not correct
//sum = Convert.ToInt16(input_1 + input_2); 
//Console.WriteLine(sum);
////correct
//sum = Convert.ToInt16(input_1  )+ Convert.ToInt16( input_2); 
//Console.WriteLine(sum);
//string msg = "";
//try
//{
//    int i = Convert.ToInt16("");
//}
//catch (Exception ex)
//{
//    msg = ex.Message;
//}

//string NamePrefix = "Mr ";
//string Namesuffix = "Abc";
////Console.WriteLine(msg);

//DateTime dateTime = DateTime.Now;   
//Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
//Console.WriteLine(dateTime.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine(dateTime.ToString("dd/MM/yyyy HH:mm tt"));
//www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
/*
 dfdfd
 dfdfdfdfdfdfd
 */
//dfdfdfdfdf


//string FromScreenDate = "27/01/2025";//01/27/2025
//DateTime dateTime1 = Convert.ToDateTime("02/01/2025");
////DateTime.Now.ToString("dddd, dd MMMM yyyy")
//Console.WriteLine(dateTime1.ToString("dddd, dd MMMM yyyy"));

//Console.WriteLine("------------------------");
//DateTime dateTime2 = DateTime.ParseExact("02/01/2025","dd/MM/yyyy",null);
//Console.WriteLine(dateTime2.ToString("dddd, dd MMMM yyyy"));



//for (int i = 0; i < 6; i++)
//{
//    i++;
//    Console.WriteLine(i);
//    i = 6;
//}

//int i = 1;
//while (i > 0)
//{
//    i++;
//    Console.WriteLine(i);
//    if (i == 10)
//        i = 0;
//}

//string[] strArray = { "abc","xyz","pqr"};
//int[] sArray = { 1,2,3 };
//foreach (string item in strArray)
//{
//    Console.WriteLine(item);
//}

//List<Human> strings = new List<Human>();
//Human human = new Human();
//human.Name = "Rahim";
//strings.Add(human);

//human = new Human();
//human.Name = "Karim";
//strings.Add(human);

//human = new Human();
//human.Name = "ABC";
//strings.Add(human);
//foreach (Human item in strings)
//{
//    Console.WriteLine("Person name is:"+item.Name);
//    Console.WriteLine("-----------------------");
//}

// //  *
// // ***
// //*****

//Console.ReadLine();

//Human objHuman = new Human();
//objHuman.Name = "Protik";

//Console.WriteLine(objHuman.Name+" last Degree:"+objHuman.GetEducation());
//Console.ReadLine();

//Animal objAnimal = new Animal();
//string animalSound = objAnimal.GetSoundName(Console.ReadLine());
//Console.WriteLine(animalSound);
//Console.ReadLine();

//Human objHuman = new Human();
//Console.WriteLine("With No argument:"+objHuman.GetEducation("","")); 
//Console.WriteLine("With argument:" + objHuman.GetEducation("UnderGrad"));
//Console.ReadLine();

//Human objHuman = new Human();
//objHuman.Name = "protik";
//Console.WriteLine(objHuman.Name+" Hobby is:"+objHuman.getHobby()); 
//Console.ReadLine();

//Constructor
//Human objHuman = new Human("Called from UI"); 
//Console.WriteLine(objHuman.Name);
//Console.ReadLine();


//Human objHuman = new Human();
//Console.WriteLine(objHuman.Name);
//objHuman.getHobby();
//Console.WriteLine(objHuman.Name);
//Console.ReadLine();

//static function

Console.WriteLine(Human.GetAge());
Console.ReadLine();

//partial class
//Passport passport = new Passport();
//Console.ReadLine();

//Abstraction
Human human = new Human();
Console.WriteLine(human.StationaryCount());
Console.ReadLine();
;


