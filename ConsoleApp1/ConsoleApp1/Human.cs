using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Human:Stationary,IHobby // Religion//
    {
        public string Name { get; set; }
        public int age { get; set; }

        public MyTask myTasks { get; set; }
        public Human()
        {
            Name = "in constructor";
            myTasks = new MyTask();
            myTasks.TaskName = "Collection Stamp";
        }

        //public string hobbyname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
        public static string GetAge()
        {
            return "30";
        }
        public string getHobby()
        {
            return "";
        }
        public string GetEducation()
        {
            return "BSC";
        } 
        public string GetEducation(string educationType)
        {
            if (educationType == "UnderGrad")
            {
                return "BSC";
            }
            else if (educationType == "PostGrad")
            {
                return "MSC";
            }
            else
                return "";
        }
        public string GetEducation(string educationType,string ddfd)
        {
            if (educationType == "UnderGrad")
            {
                return "BSC";
            }
            else if (educationType == "PostGrad")
            {
                return "MSC";
            }
            else
                return "";
        }

        public override int StationaryCount()
        {
            return 20;
        }
    }
    public interface IHobby
    {
        //string hobbyname { get; set; }
        string getHobby();

    }
    public class Religion
    { 
        public string ReligionName { get; set; }
        public void GetReligion()
        { 
        
        }
    }

    public class MyTask 
    {
        public string TaskName { get; set; }
    }
    public class Animal
    {  
        public string GetSoundName(string animalname)
        {
            if (animalname == "Cat")
                return "Mew Mew";
            else if (animalname == "DOG")
            {
                string sound = "Bark Bark";
                return sound;
            }
            else
                return "Animal Name needed";

        }
    }


    partial class Passport
    { 
        public string PassName { get; set; }
    }
    partial class Passport
    { 
        public string PassNo { get; set; }
    }
    partial class Passport
    {
        public string passArea { get; set; }
    }
}
