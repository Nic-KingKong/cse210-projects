
class Program 
{
    static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Roberts", 30, 180);
        Console.WriteLine(myPerson.GetPersonInfo());

        Police myPoliceman = new Police("Gun", "Robert", "Bob", 40, 150);
        Console.WriteLine(myPoliceman.GetPoliceInfo());
    }
}