
//Pass by value 
int increase(int value)
{
	value++;
}
//pass by reference
int increasewithref(ref int value){
	value++;
}
//Abstraction hide the complexity of the program with interface and abstract 
public interface IShape {
	void Draw();
}
public class Circle:IShape {
	public void Draw(){
		console.WriteLine("draw a circle");
	}
}
//Encapsulation grouping medthods and data to one single unit. AChive through classes, access modifiers and properties
public class Employee
{
   private string name;
   private int age;
   //constructor
	Employee(){
		name = "Null";
		age = 0;
	}
	Employee(string name, int age){
		this.name = name;
		this.age =age;
	}
   public string Name
   {
      get { return name; }
      set { name = value; }
   }

   public int Age
   {
      get { return age; }
      set { age = value; }
   }

   public void DisplayInfo()
   {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Age: " + age);
   }
}
//inheritance child class have parent method without rewrite those method.
public class Animal{
	public void Eat(){
		Console.WriteLine("Eat");
	}
}
public class Dog(): Animal{
	public void Bark(){
		Console.WriteLine("Bark");
	}
}

//Polymorphism
	//Parent class can have many childrens class 
 //overloading 
 public class Animal{
	 public int add (int x){
		x = x + 1;
		return x;
	 }
	 public double add (double x, double y){
		 return x + y;
	 }
 }

 //overridine
 public class Book{
	public virtual void  Author(){
		 console.WriteLine("JK Rowling");
	 }
 }
 public class MafiaBook : Book {
	public override void  Author(){
		console.WriteLine("Mario Puzo");

	}
 }
 //abstract 
 public abstract class Shape
{
    public abstract double GetArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double GetArea()
    {
        return Width * Height;
    }
}
//virtual 
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("I am an animal.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

int x = 45;
object obj = x; //boxing
int y = (int)obj//unboxing

StringBuilder sb = new StringBuilder();
StringBuilder sb = new StringBuilder();
sb.Append("John");
sb.Append(" ");
sb.Append("Doe");
string fullName = sb.ToString();

//IEnumerable is an interface that provides a way to iterate over a collection of objects
IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}
//Genertic mean general form, do not to specify type an object ->help for reusability 
public interface IRepository<T> {
	{
		public void Add (T entity);
		public void GetAll (T entity);
		public void Update (T entity);
		public void DeleteById (int id);
		
	}
}
//try catch 
try{
} catch (Exception ex) {

}
finally{

}
public class AgeException : Exception
	{
		public overdride  string "Out of range for age"
	}
//extension medthod are method that added to base class with out fixng the base class code
// must have static and this in the implementation
public static class extendsionmed{
	public static bool GeraterthanValue(this int num,int value){
		if num < value{
		return false;
		}
		return true;
	}
}
int i = 10;

bool result = i.IsGreaterThan(100); 

public interface
  public class Program{
	static void main(){
		//overload
		Animal ani = new Animal();
		var result1 = Animal.add(2); // 3
		var result2 = Animal.add(2.0,2.5); // 4.5
		console.WriteLine(result1);
		//override
		Book bk = new Book();
		MafiaBook mb = new MafiaBook();
		var result3 = bk.Author();//Jk
		var result4 = bk.Author();//Mario 
		//upcasting
		Animal ani2 = mb;
		ani2.Author();// Mario
	} 
 }

