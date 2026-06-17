abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        SetAge(age);
        SetWeight(weight);
    }

    public virtual string GetPersonInfo()
    {
        return $"Name: {_firstName} {_lastName}, age: {_age}, weight: {_weight}";
    }

    public void ChangeWeight(int weight)
    {
        SetWeight(_weight + weight);
    }
    
    public void SetAge(int age)
    {
        _age = age;
        if (_age < 0 || _age > 120)
        {
            _age = 0;
            Console.WriteLine("Invalid age.");
        }
    }

    public void SetWeight(int weight)
    {
        _weight = weight;
        if (_weight < 0 || _weight > 1000)
        {
            _weight = 0;
            Console.WriteLine("Invalid weight.");
        }
    }

    public abstract double GetSalary();
}