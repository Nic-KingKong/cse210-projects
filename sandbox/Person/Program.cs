
class Program 
{
    static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Roberts", 30, 180);
        Console.WriteLine(myPerson.GetPersonInfo());

        Police myPoliceman = new Police("Gun", "Robert", "Bob", 40, 150);
        Console.WriteLine(myPoliceman.GetPoliceInfo());

        Doctor myDoctor = new Doctor("MD", "Alice", "Smith", 45, 160);
        Console.WriteLine(myDoctor.GetDoctorInfo());

        myPerson.ChangeWeight(10);
        Console.WriteLine(myPerson.GetPersonInfo());
        myDoctor.ChangeWeight(-10);
        Console.WriteLine(myDoctor.GetDoctorInfo());
        myPoliceman.ChangeWeight(15);
        Console.WriteLine(myPoliceman.GetPoliceInfo());
    }
}