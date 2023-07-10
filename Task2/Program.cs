using System;
using System.IO;

class PolyMorph{

    class Subtask1{
        class Car{
            public int Milleage {get; set;}

            public Car(){
                Milleage = 0;
            }
        
            // Свойство virtual обозначает, что метод может переопределен в классе наследнике
            public virtual void Move() {
                Console.WriteLine("Вызван метод из класса Car");
                Milleage++;
            }
        }
    
        enum FuelType{
            Gas = 0,
            Electricity
        }

        class HybridCar: Car{
            private FuelType FuelType;
            private double Gas;
            public double Electricity;

            public HybridCar() 
            {
                Electricity = 50;
                Gas = 50;
            }
            public override void Move()
            {
                Console.WriteLine("Вызван метод из класса HybridCar");
                Milleage++;

                switch (FuelType){
                    case FuelType.Gas:
                    Gas -= 0.5;
                    break;
                    case FuelType.Electricity:
                    Electricity -= 0.5;
                    break;
                }
            }
            public void ChangeFuelType(FuelType type){
                FuelType = type;
            }
        }
    
        public Subtask1(){
            Car car = new Car();
            HybridCar hybridCar = new HybridCar();
            car.Move();
            hybridCar.Move();
            // Приведение к базовому классу и вызов функции Move
            // так как петод был перезаписан выполнится метод HybridCar
            ((Car)hybridCar).Move();
        }
    } 
    class Subtask2{

        class BaseClass{
            public virtual void Display(){
                Console.WriteLine("Метод класс BaseClass");
            }
        }

        class DerivedClass: BaseClass{
            public override void Display(){
                Console.WriteLine("Метод класса DerivedClass");
            }
        }

        public Subtask2(){
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            bc.Display();
            dc.Display();
        }
    } 
    class Subtask3{
        // Переопределение свойства Age
        class Citizen{
            public virtual double Age{
                get;
                set;
            }

            public void SayYourAge(){
                Console.WriteLine("Мне {0} лет", Age);
            }
        }

        class CivilServant: Citizen
        {
            private double age;
            // Свойство private не передается наследнику
            public override double Age{
                get
                {
                    return age;
                }
                set
                {
                    if (value < 18){
                        Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                    }
                    else{
                        age = value;
                    }
                }
            }    
        }

        class President: CivilServant
        {
            private double age;
            public override double Age{
                get
                {
                    return age;
                }
                set
                {
                    if (value < 35){
                        Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                    }
                    else{
                        age = value;
                    }
                }
            }    
        }
        public Subtask3(){
        
        }
    }
    class Subtask4{
        class BaseClass{
            public virtual void Method(){
                // base logic
            }
        }

        class InheritedClass:BaseClass{
            public override void Method(){
                base.Method();
                // added method
            }
        }
        // при необходимости дополнить метод из базового класса его можно вызвать с помощью ключевого слова base
        public Subtask4(){

        }
    }
    class Subtask5{
        class BaseClass{
            public virtual void Method(){

            }
        }
        class InheritedClass:BaseClass{
            public override sealed void Method()
            {
                // Ключевое слово sealed запрещает изменение метода в дальнейших наследованных классов
            }
        }
        public Subtask5(){

        }
    }
    class Subtask6{
        class A{
            public virtual void Display(){
                Console.Write("A");
            }
        }
        class B:A{
            public new void Display(){
                Console.Write("B");    
            }
        }
        class C:A{
            public override void Display(){
                Console.Write("C");  
            } 
        }
        class D:B{
            public new void Display(){
                Console.Write("D");    
            }
        }
        class E:C{
            public new void Display(){
                Console.Write("E");    
            }
        }
        public Subtask6(){
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
            // Выводится DCBA
        }
    }    
    class Subtask7{
        string Greeting(string name, string second_name){
            return $"Hello, {second_name} {name}!";
        }

        /*
        void Greeting(string name, string second_name){
            Console.WriteLine($"Hello, {second_name} {name}!");
        }

        string Greeting(string person1, string person2){
            return $"Hello, {person1} and {person2}!";
        }
        Не будут работать так как сигнатура метода такая же как и в предыдущем методе.
        Greeting(string, string)
        */
        public Subtask7(){
            Greeting("Vladimir", "Koshelnikov");
        }


        
    }
    class Subtask8{
        class Vector{
            public double X;
            public double Y;

            public Vector(double x, double y){
                X = x;
                Y = y;
            }
            // перегрузка оператора 
            // Модификатор static обозначает, что для использования этого свойства/функции/оператора не обязательно создавать экземпляр класса
            // ключевое слово оператор показывает, что мы хотим перегрузить оператор "+"
            public static Vector operator + (Vector a, Vector b){
                return new Vector(a.X + b.X, a.Y + b.Y); 
            }
                
        }
            
        public Subtask8(){
            Vector a = new Vector (10, 5);
            Vector b = new Vector (10, 5);
            Vector c = a + b;
            Console.WriteLine($"Вектор 1 имеет координаты ({a.X}, {a.Y})");
            Console.WriteLine($"Вектор 2 имеет координаты ({b.X}, {b.Y})");
            Console.WriteLine($"Сумма векторов имеет координаты ({c.X}, {c.Y})");

        }
    }
    class Subtask9{
        class Obj{
            public int Value;

            public static Obj operator + (Obj o1, Obj o2){
            return new Obj{
                Value = o1.Value + o2.Value
                };  
            }

            public static Obj operator - (Obj o1, Obj o2){
                return new Obj{
                    Value = o1.Value - o2.Value
                };
            }

        }
        
        public Subtask9(){

        }
    }
    class Subtask10{
        class Book{
            public string Name;
            public string Author; 
        }

        class BookCollection{

            // Закрытое поля хранящее книги в виде массива
            private Book[] collection;

            public BookCollection(Book[] collection){
                this.collection = collection;
            }
            // индекс по массиву из объектов класса Book
            // Индексатор - это величина в квадратных скобках 
            // То есть возвращается значение Book из коллекции, а index - это нумерация
            // Настройка геттеров и сеттеров настраивает поведение массива, а не индекса
            public Book this[int index]{
                get{
                    if (index >= 0 && index < collection.Length){
                        return collection[index];
                    }
                    else {
                        return null;
                    }
                }
                private set{
                    if (index >= 0 && index < collection.Length){
                        collection[index] = value;
                    }

                }
            }
            // перегрузка индексатора
            // Благодаря этому можно полдьзоваться конструкцией collection["СТРОКА"]
            
            public Book this [string name]{
                get {
                    for (int i = 0; i < collection.Length; i++){
                        if (collection[i].Name == name){
                            return collection[i];
                        }
                    }
                    return null;
                }
            }


        }
        public Subtask10(){
            var array = new Book[] {
			    new Book { Name = "Мастер и Маргарита", Author = "М.А. Булгаков" },
			    new Book { Name = "Отцы и дети", Author = "И.С. Тургенев" },
		    };
		    BookCollection collection = new BookCollection(array);

		    Console.ReadKey();

		    Book book = collection[1];
		    book = collection[-1];
		    book = collection[4];

		    Console.ReadKey();

		    book = collection["Мастер и Маргарита"];

		    Console.ReadKey();
        }
    }
    class Subtask11{
        class IndexingClass 
        {
            private int[] array;

            public IndexingClass(int[] array) 
            {
                this.array = array;
            }

            public int this [int index]{
                get {
                    return array[index];
                }
                set{
                    array[index] = value;
                }
            }
        }
    }
    static void Main(){
        //Subtask1 st1 = new Subtask1();
        //Subtask2 st2 = new Subtask2();
        //Subtask3 st3 = new Subtask3();
        //Subtask6 st6 = new Subtask6();
        //Subtask8 st8 = new Subtask8();
        //Subtask10 st10 = new Subtask10();
        Console.ReadKey();
    }
}