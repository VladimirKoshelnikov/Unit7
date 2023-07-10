using System;
using System.IO;


static class StringExtentions{
    public static char GetLastChar(this string source){
        return source[source.Length - 1];
    }
}

static class IntExtentions{
    public static int GetPositive(this int source){
        if (source < 0){
            return source*(-1);
        }
        return source;
    }
    public static int GetNegative(this int source){
      if (source > 0){
            return source*(-1);
        }
        return source;  
    }
}


static class StaticKeyWord{

    class Subtask1{
        
        class ClassWithStaticField{
            public static int maxValue = 300;
            public int Value;

            public ClassWithStaticField(int newValue){
                if (newValue > maxValue){
                    Value = maxValue;
                }
                else {
                    Value = newValue;
                }

                Console.WriteLine($"Величина Value = {Value}");
            }
         
        }
        
        // Статическое поле класса позволяет использовать его значение не создавая новый элемент класса
        
        public Subtask1(){
            ClassWithStaticField c1 = new ClassWithStaticField(150);
            ClassWithStaticField c2 = new ClassWithStaticField(5000);
            Console.WriteLine($"Максимальная величина для класса ClassWithStaticField = {ClassWithStaticField.maxValue}");
            
        }
    }
    class Subtask2{
        
        class Counter{

            private static int increasingCounter = 0;
            public static int IncreasingCounter { 
                get{
                    return increasingCounter;
                } 
                set{
                    if (value > increasingCounter){
                        increasingCounter++;
                    }
                } 
            }
        }      
        

        public Subtask2(){
            Counter.IncreasingCounter++;
            Counter.IncreasingCounter++;
            Counter.IncreasingCounter++;
            Counter.IncreasingCounter++;
            Counter.IncreasingCounter++;

            Console.WriteLine(Counter.IncreasingCounter);

            //Таким образом, переменные и свойства, которые хранят состояние, общее для всех объектов класса, следует определять как статические.
        }
    }
    class Subtask3{
        
        class Helper{
            public static void Swap(ref int num1, ref int num2){
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
        }      
        

        public Subtask3(){
            int num1 = 52;
            int num2 = 5;
            Helper.Swap(ref num1, ref num2);

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            //Таким образом, переменные и свойства, которые хранят состояние, общее для всех объектов класса, следует определять как статические.
        }    
    }
    class Subtask4{
        class Car{
            static int MinPrice = 100000;
            static int MaxPrice;

            // Такой конструктор будет вызван один раз за все выполнение кода
            static Car(){
                MaxPrice = 1000000;
            }
        }
    }
    class Subtask5{
        static class Car{
            static int MinPrice = 100000;
            static int MaxPrice;

            // Статические классы часто используют для расположения в них каких-либо однородных операций, 
            // например, класс с вспомогательными функциями для работы с файлами, или функции для работы 
            // с математическими операциями (как пример: класс System.Math).

            // Это будет полезно в паттернах программирования

            static Car(){
                MaxPrice = 1000000;
            }
        }
    }
    class Subtask6{
        /*
        Методы расширения (extension methods) позволяют добавлять новые методы в уже существующие типы
        без создания нового производного класса. Расширения выносятзя за тело класса вызывающего выполнение программы
        Применение методов расширения очень удобно, но при этом надо помнить, что метод расширения никогда не будет вызван,
         если он имеет ту же сигнатуру, что и метод, изначально определенный в типе.
        Синтаксис:
        [модификатор доступа] static <тип возвращаемого значения> <название метода>(
        this <тип параметра 1> <название параметра 1>,
        [<тип параметра 2> <название параметра 2>, ...]
        )*/


        public Subtask6(){
            string testString = "Hello";
            Console.WriteLine(testString.GetLastChar());    // o
            Console.WriteLine("testString".GetLastChar());  // g
        }
    }
    class Subtask7{
        
        public Subtask7(){
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0 
            }
        }
    static void Main(){
        //Subtask1 st1 = new Subtask1();
        //Subtask2 st2 = new Subtask2();
        //Subtask3 st3 = new Subtask3();
        //Subtask6 st6 = new Subtask6();
        Subtask7 st7 = new Subtask7();
        Console.ReadKey();
    }
}