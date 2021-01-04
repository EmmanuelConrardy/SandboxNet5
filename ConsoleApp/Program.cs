//Top level statement
System.Console.WriteLine("Hello World!");

//Init only setter
var p = new Point { X = 1, Y = 2 };

//Record
var bob = new Person("Bob", "Kelso");

//ToString display : Person { FirstName = Bob, LastName = Kelso }
System.Console.WriteLine(bob);

//Use with to shallow copy your record into another.
var otherBob = bob with { LastName = "Dylan" };

//ToString display : Person { FirstName = Bob, LastName = Dylan }
System.Console.WriteLine(otherBob);

var sameBob = new Person("Bob", "Kelso");

//operator == != , display true
System.Console.WriteLine($"bob == sameBob : { bob == sameBob }");

//Operator not, display false
System.Console.WriteLine($"bob is not Person : { bob is not Person }");

//Pattern matching enhancement 
System.Console.WriteLine($"Age 18 : { ConvertAgeToLifeStage(18)}");
System.Console.WriteLine($"Age 10 : { ConvertAgeToLifeStage(10)}");
System.Console.WriteLine($"Age 1 : { ConvertAgeToLifeStage(1)}");
System.Console.WriteLine($"Age 0 : { ConvertAgeToLifeStage(0)}");
System.Console.WriteLine($"Age null : { ConvertAgeToLifeStage(null)}");


string ConvertAgeToLifeStage(int? age)
{
    return age switch
    {
        >= 18 => "Majeur",
        >= 10 and < 18 => " Adolescent",
        > 0 and < 10 => "Enfant",
        not null => "inconnue",
        _ => "erreur"
    };
}

System.Console.WriteLine($"Generation X 1978 : { GenerationXZ(1978)}");
System.Console.WriteLine($"Generation Y 1989 : { GenerationXZ(1989)}");
System.Console.WriteLine($"Generation Z 2000 : { GenerationXZ(2000)}");

bool GenerationXZ(int year) => year is (> 1963 and <= 1978) or (> 1996 and <= 2010);

//Fit and finish features
Doctor Kelso = new (new ("Bob", "Kelso"));

//Display : Doctor { HumanBehindIt = Person { FirstName = Bob, LastName = Kelso } }
System.Console.WriteLine(Kelso);

struct Point
{
    public int X { get; init; }
    public int Y { get; init; }
}

public record Person(string FirstName, string LastName);

public record Doctor (Person HumanBehindIt);
