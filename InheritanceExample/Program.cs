// See https://aka.ms/new-console-template for more information

using System.Dynamic;

class Program
{
    public static void SetPersonFirstName(Person person, string firstName)
    {
        person.SetFirstName(firstName);
    }
    public static void Main(string[] args)
    {
        Person Bob = new ("Bob", "Billy", 37);

        Console.WriteLine(Bob.GetPersonInfo());

        Doctor doctorBob = new Doctor("Bob", "Budge", 37, "Hack Saw");
        Console.WriteLine(doctorBob.GetDoctorInformation());
        Console.WriteLine(doctorBob.GetPersonInfo());

        Police policeDoug = new Police("Doug", "Denver", 40, "Taser");
        Console.WriteLine(policeDoug.GetPoliceInformation());
        Console.WriteLine(policeDoug.GetPersonInfo());

        SetPersonFirstName(policeDoug, "Doug the second");
        Console.WriteLine(policeDoug.GetPoliceInformation);
        Console.WriteLine(policeDoug.GetPersonInfo);

        SetPersonFirstName(Bob, "Bobby");
        Console.WriteLine(Bob.GetPersonInfo);

        List<Person> people = new List<Person>();
        people.Add(Bob);
        people.Add(doctorBob);
        people.Add(policeDoug);

        foreach (Person person in people)
        {
            Console.WriteLine(person.GetPersonInfo());
        }
    }
}