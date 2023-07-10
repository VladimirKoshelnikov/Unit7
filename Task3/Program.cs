using System;
using System.IO;

class AbstractClass{
    //Абстрактный класс — это класс, экземпляр которого не может быть инициализирован. Абстрактный класс служит только базовым классом для других классов.

    class Subtask1{
        abstract class AbstractClass 
        {
            public string Name;
        }

        abstract class Person{
            public string Name;
            // В абстрактном классе нельзя
            public Person(string name){
                Name = name;
            }

            public void DisplayName(){
                Console.WriteLine(Name);
            }
        }

        class Employee: Person{
            public bool IsOnShift;

            public Employee(string name, bool isOnShift): base (name){
                IsOnShift = isOnShift;
            }
        }

        class Guest: Person{
            public DateTime ArrivalDate;

            public Guest(string name, DateTime arrivalDate):base(name){
                ArrivalDate = arrivalDate;
            }
        }
        public Subtask1(){

        }
    }
    class Subtask2{
        // Абстрактные методы
        abstract class NewAbstractClass{
            // В абстрактном методе могут быть объявлены абстрактные классы
            public abstract void Display();
        }

        abstract class FourLeggedAnimal{
            public abstract void Describe();
            // при объявлении абстрактного метода нельзя объявлять его тело. Иначе компилятор выдает ошибку
            // используется, когда известно, что метод необходим для каждого дочернего класса, но в каждом должен быть индивидуальным
        }

        class Dog:FourLeggedAnimal{
            public override void Describe(){
                Console.WriteLine("Это собака");
            }
        }
        
        class Cat:FourLeggedAnimal{
            public override void Describe(){
                Console.WriteLine("Это кошка");
            }
        }

        public Subtask2(){
            Dog animal1 = new Dog();
            Cat animal2 = new Cat();
            animal1.Describe();
            animal2.Describe();
        }
    }
    class Subtask3{
        abstract class ComputerPart{
            public abstract void Work();
        } 
        class Processor: ComputerPart{
            public override void Work() {}
        }
        class MotherBoard: ComputerPart{
            public override void Work() {}
        }
        class GraphicCard: ComputerPart{
            public override void Work() {}
        }
    }
    class Subtask4{
        abstract class FourLeggedAnimal{
            public abstract string Name
            {
                get;
                set;
            }
        }
        class Dog:FourLeggedAnimal{
            // В клвссе Dog используется полное определение свойства Name
            private string name;
            public override string Name{
                get { return name; }
                set { name = value; }
            }
        }

        class Cat:FourLeggedAnimal{
            // В клвссе Cat используется автоматическое определение свойства Name
            public override string Name{
                get;
                set;
            }
        }
    }

    static void Main(){
        Subtask2 st2 = new Subtask2();
        Console.ReadKey();
    }

}
