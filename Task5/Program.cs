using System;
using System.IO;

class Generic{

    class Subtask1{
        class Order<T>
        {
	        public T Number;

	        public string Description;

	        // ... Другие поля
        }
        
        public Subtask1(){
            Order<int> order1 = new Order<int>();
            Order<string> order2 = new Order<string>();

            order1.Number = 7727;
            order2.Number = "SevenEleven";

        }
    }
    class Subtask2{
        class TElectricEngine{}
        class TGasEngine{}

        class Car<T>{
           public T Engine = default(T); // Поле типа Т принимает дефолтное значение
        }
    }
    class Subtask3{
        class Record<T1, T2>{
            public T1 Id;
            public T2 Value;
            private DateTime Date ;
            public Record(){
                Date = DateTime.Now;
            }
        }
        public Subtask3(){
            Record<int, string> rec1 = new Record<int, string>();
        }
    }   
    class Subtask4{
        public void Method<pupyrka>(pupyrka p1, pupyrka p2){
        // При объявление метода с обобщенными параметрами необходимо после его имени обозначить параметры в скобках        
        }

        public static void Return<T>(int number)
        {
        	Console.WriteLine(number);
            // Не могу представить, где это может потребоваться
        	// ... Логика работы с типом T
        }

        public static void Swap<T>(ref T x, ref T y) // 
	        {
		    T t = x;
		    x = y;
		    y = t;
	        }
        class Obj {
            public void Display<T>(T param)
	            {
	        	    Console.WriteLine(param.ToString());
	            }

        }
        
        public Subtask4(){
            Obj obj = new Obj();
	        obj.Display<int>(345);

	        int num1 = 4;
	        int num2 = 10;
	        Swap<int>(ref num1, ref num2);

	        Console.WriteLine("{0} {1}", num1, num2);

	        Console.ReadKey();    
        }
        
    }
    class Subtask5{
        abstract class CarPart{}
        abstract class Engine:CarPart{}
        class TElectricEngine: Engine{}
        class TGasEngine: Engine{}
        class Battery:CarPart{}
        class Differentia:CarPart{}
        class Wheel:CarPart{}
        
        abstract class Car<TEngine> where TEngine : Engine{
           public TEngine Engine; // Поле типа Т принимает дефолтное значение
           public abstract void ChangePart<TPart>(TPart newPart) where TPart:CarPart;
        }

        class ElectricCar:Car<TElectricEngine>{
           public override void ChangePart<TPart>(TPart newPart){}
        }
        
        class GasCar:Car<TGasEngine>{
           public override void ChangePart<TPart>(TPart newPart){}            
        }
        

        public Subtask5(){
            //Record<int, string> rec1 = new Record<int, string>();
        }
    }   

    class Subtask6{
        class Order<TDelivery> where TDelivery : Delivery
        {
	        public int Number;

	        public string Description;

            public TDelivery delivery;

            public void DisplayAddress()
            {
	            Console.WriteLine(delivery.Address);
            }

	    // ... Другие поля
        }  

        abstract class Delivery
        {
        	public string Address = "WWW.LENINGRAD.WWW.RU";

        }

        class HomeDelivery : Delivery { /* ... */ }

        class PickPointDelivery : Delivery { /* ... */ }

        class ShopDelivery : Delivery { /* ... */ }     
    }
    static void Main(){
        //Subtask4 st4 = new Subtask4();
        Subtask5 st5 = new Subtask5();
    }
}