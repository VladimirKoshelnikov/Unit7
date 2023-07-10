using System;

class Programm{

    class MyObject
    {
	private string name;
	private string owner;
	private int length;
	private int count;

	public MyObject(string name, string ownerName, int objLength, int count)
	{
		this.name = name;
        owner = ownerName;
        length = objLength;
        this.count = count;
	}
    }
    public static void Main(){
        Console.ReadKey();
    }
}