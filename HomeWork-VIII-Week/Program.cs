using HomeWork_VIII_Week.TaskN1;
using HomeWork_VIII_Week.TaskN2;
using HomeWork_VIII_Week.TaskN3;

class Program
{
    static void Main(string[] args)
    {
        // 1) Virtual  და override  ბრძანებების გამოყენებით შექმენით Shape კლასი,
        // რომელიც იქნება მშობელი კლასი Area კლასის. თავის მხრივ Area კლასი უნდა იყოს მშობელი კლასი Calculate კლასის.
        // Shape კლასში შექმენით ერთი მეთოდი რომელიც გამოითვლის კვადრატის ფართობს.
        // გადაფარვა უნდა ხდებოდეს მხოლოდ  Calculate კლასში და ფართობთან  ერთად გამოითვალოს პერიმეტრი (გამოიყენეთ base).

        Calculate calc = new Calculate(2, 5);
        calc.CalculateArea();
        calc.Perimeter();

        Console.WriteLine("");

        //2) შექმენით ორი ინტერფეისი და ერთი კლასი,
        //ორივე ინტერფეისს უნდა ჰქონდეს განსხვავებული ტიპის მეთოდები და ორივეს იმპლემენტაცია უნდა ხდებოდეს კლასში.

        SomeClass obj = new SomeClass();
        obj.firstMethod();
        obj.secondMethod();

        Console.WriteLine("");

//        3) შექმენით აბსტრაქტული კლასი Animal, რომელსაც აქვს ტექსტის ტიპის Name თვისება და სამი მეთოდი SetName(სტრიქონის სახელი), GetName და Eat.Eat მეთოდი იქნება void ტიპის აბსტრაქტული მეთოდი.
//ასევე შექმენით Dog კლასი, რომელიც იქნება შვილი კლასი Animal კლასის და განახორციელებს Eat მეთოდს, რომელიც კონსოლზე დაბეჭდავს, რომ “ძაღლი ჭამს.”
//კონსოლიდან შეიყვანეთ ძაღლის სახელი და შექმენით ახალი Dog ტიპის ობიექტი პროგრამის Main-დან, 
//გადაეცით Dog ობიექტს სახელი და შემდეგ შეასრულეთ GetName და Eat მეთოდები.


        Console.WriteLine("Enter name");
        string name = Console.ReadLine();

        Dog dog = new Dog();
        Console.WriteLine($"The dog's name is {name}");
        dog.Eat();
    }
}
