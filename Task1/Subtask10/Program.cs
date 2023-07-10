using System;

class Programm{

    class BaseClass 
    {
        protected string Name;

        public BaseClass(string name) 
        {
            Name = name;
        }
    }

    class DerivedClass: BaseClass 
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description):base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter):this(name, description){
            Counter = counter; 
        }
    }   
    public static void Main(){
        BaseClass bc = new BaseClass("WHO_I_AM");
        DerivedClass dc1 = new DerivedClass("WHO_I_AM", "I_AM_GROOT");
        DerivedClass dc2 = new DerivedClass("WHO_I_AM", "I_AM_GROOT", 2);
        Console.ReadKey();
    }
}