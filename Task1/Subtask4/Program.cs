using System;

class Programm{

    class Employee{
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager : Employee{
        public string ProjectName;
    }

    class Developer : Employee{
        public string ProgrammingLanguage;
    }
    public static void Main(){
        
        ProjectManager pm = new ProjectManager();
        pm.Name = "Fufel";
        pm.Age = 15;
        pm.Salary = 15000;
        pm.ProjectName = "FufelProject";
        
        Developer dev = new Developer();
        dev.Name = "SuperFufel";
        dev.Age = 20;
        dev.Salary = 12000;
        dev.ProgrammingLanguage = "Python";
       
        Console.ReadKey();
    }
}