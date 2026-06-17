
class Program 
{

    public static void DisplayPersonInfo(Person person)
    {
        if(person is Doctor doctor)
        {
            Console.WriteLine(doctor.GetPersonInfo());
        }
        else if (person is Police police)
        {
            Console.WriteLine(police.GetPersonInfo());
        }
        else
        {
            Console.WriteLine(person.GetPersonInfo());
        }
    }

    static void Main(string[] args)
    {
        //Person myPerson = new Person("Bob", "Roberts", 30, 180);
        //Console.WriteLine(myPerson.GetPersonInfo());

        Police myPoliceman = new Police("Gun", "Robert", "Bob", 40, 150);
        Console.WriteLine(myPoliceman.GetPersonInfo());

        Doctor myDoctor = new Doctor("MD", "Alice", "Smith", 45, 160);
        Console.WriteLine(myDoctor.GetPersonInfo());

        //myPerson.ChangeWeight(10);
        //Console.WriteLine(myPerson.GetPersonInfo());
        myDoctor.ChangeWeight(-10);
        Console.WriteLine(myDoctor.GetPersonInfo());
        myPoliceman.ChangeWeight(15);
        Console.WriteLine(myPoliceman.GetPersonInfo());

        List <Person> myPeople = new List<Person>();
        //myPeople.Add(myPerson);
        myPeople.Add(myPoliceman);
        myPeople.Add(myDoctor);

        foreach (Person person in myPeople)
        {
            DisplayPersonInfo(person);
        }
    }
}