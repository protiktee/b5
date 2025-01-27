// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");


string input_1 = "1"; 
string input_2 = "2";

int sum = 0;
//not correct
sum = Convert.ToInt16(input_1 + input_2); 
Console.WriteLine(sum);
//correct
sum = Convert.ToInt16(input_1  )+ Convert.ToInt16( input_2); 
Console.WriteLine(sum);
string msg = "";
//try
//{
//    int i = Convert.ToInt16("");
//}
//catch (Exception ex)
//{
//    msg = ex.Message;
//}

string NamePrefix = "Mr ";
string Namesuffix = "Abc";
//Console.WriteLine(msg);

DateTime dateTime = DateTime.Now;   
Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
Console.WriteLine(dateTime.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(dateTime.ToString("dd/MM/yyyy HH:mm tt"));
//www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
/*
 dfdfd
 dfdfdfdfdfdfd
 */
//dfdfdfdfdf


string FromScreenDate = "27/01/2025";//01/27/2025
DateTime dateTime1 = Convert.ToDateTime("02/01/2025");
//DateTime.Now.ToString("dddd, dd MMMM yyyy")
Console.WriteLine(dateTime1.ToString("dddd, dd MMMM yyyy"));

Console.WriteLine("------------------------");
DateTime dateTime2 = DateTime.ParseExact("02/01/2025","dd/MM/yyyy",null);
Console.WriteLine(dateTime2.ToString("dddd, dd MMMM yyyy"));
Console.ReadLine();
